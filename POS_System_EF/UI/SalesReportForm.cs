using POS_System_EF.EntityModels;
using POS_System_EF.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace POS_System_EF.UI
{
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                ManagerContext db = new ManagerContext();
                var salesList = (from s in db.Sales
                                 join o in db.Outlets on s.OutletId equals o.Id
                                 join emp in db.Employees on s.EmployeeId equals emp.Id
                                 join cus in db.CustomerAndSuppliers on s.CustomerId equals cus.Id
                                 select new
                                 {
                                     s.Id,
                                     Invoice = s.InvoiceNo,
                                     Employee = s.Employee.Name,
                                     Outlet = s.Outlet.Name,
                                     Customer = s.Customer.Name,
                                     Contact = s.Customer.ContactNo,
                                     Vat = s.Vat,
                                     Discount = s.Discount,
                                     TotalAmount = s.TotalAmount,
                                     LineTotal = s.SubTotal,
                                     Date = s.SalesDate,
                                 }).ToList();
                dgvSalesList.DataSource = salesList;
                var dataGridViewColumn = dgvSalesList.Columns["Id"];
                if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;


                itemListView.View = View.Details;
                itemListView.GridLines = true;
                itemListView.FullRowSelect = true;

                //Add column header
                itemListView.Columns.Add("Product Name", 110);
                itemListView.Columns.Add("Quantity", 100);
                itemListView.Columns.Add("CostPrice", 100);
                itemListView.Columns.Add("TotalPrice", 100);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        private void dgvSalesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSalesList.CurrentRow != null)
                {
                    int selectedId = (int)dgvSalesList.CurrentRow.Cells["Id"].Value;
                    if (dgvSalesList.SelectedRows.Count > 0)
                    {
                        lblInvoice.Visible = true;
                        lblOutlet.Visible = true;
                        lblCustomerName.Visible = true;
                        lblContact.Visible = true;
                        txtInvoiceNo.Visible = true;
                        txtOutletName.Visible = true;
                        txtCustomerName.Visible = true;
                        txtContactNo.Visible = true;
                        txtInvoiceNo.Text = dgvSalesList.CurrentRow.Cells["Invoice"].Value.ToString();
                        txtOutletName.Text = dgvSalesList.CurrentRow.Cells["Outlet"].Value.ToString();
                        txtCustomerName.Text = dgvSalesList.CurrentRow.Cells["Customer"].Value.ToString();
                        txtContactNo.Text = dgvSalesList.CurrentRow.Cells["Contact"].Value.ToString();
                        lblLineTotal.Text = dgvSalesList.CurrentRow.Cells["LineTotal"].Value.ToString();
                        lblDiscount.Text = dgvSalesList.CurrentRow.Cells["Discount"].Value.ToString();
                        lblVat.Text = dgvSalesList.CurrentRow.Cells["Vat"].Value.ToString();
                        lblTotal.Text = dgvSalesList.CurrentRow.Cells["TotalAmount"].Value.ToString();

                        using (ManagerContext db = new ManagerContext())
                        {
                            var sales = (from s in db.SalesItem
                                             join itm in db.Items on s.SaleId equals itm.Id
                                             where s.SaleId == selectedId
                                             select new
                                             {
                                                 itm.Name,
                                                 s.Quantity,
                                                 s.SalePrice,
                                                 s.LineTotal
                                             }).ToList();
                            string[] item = new string[4];
                            ListViewItem itms;
                            itemListView.Items.Clear();
                            foreach (var i in sales)
                            {
                                item[0] = i.Name.ToString();
                                item[1] = i.Quantity.ToString();
                                item[2] = i.SalePrice.ToString();
                                item[3] = i.LineTotal.ToString();
                                itms = new ListViewItem(item);
                                itemListView.Items.Add(itms);
                            }
                            btnPdf.Visible = true;
                            btnPdf.Enabled = true;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (ManagerContext db = new ManagerContext())
                        {
                            if (dgvSalesList.CurrentRow != null)
                            {
                                int selectedId = (int)dgvSalesList.CurrentRow.Cells[0].Value;
                                if (selectedId > 0)
                                {
                                    string invoiceNo = dgvSalesList.CurrentRow.Cells["Invoice"].Value.ToString();
                                    string i = "Invoice No: " + invoiceNo;
                                    string outletName = dgvSalesList.CurrentRow.Cells["Outlet"].Value.ToString();
                                    string o = "Outlet Name: " + outletName;
                                    string customerName = dgvSalesList.CurrentRow.Cells["Customer"].Value.ToString();
                                    string c = "Customer :" + customerName;
                                    string employeeName = dgvSalesList.CurrentRow.Cells["Employee"].Value.ToString();
                                    string emp = "Employee Name: " + employeeName;
                                    string salesDate = dgvSalesList.CurrentRow.Cells["Date"].Value.ToString();
                                    string sDate = "Sales Date: " + salesDate;
                                    string total = dgvSalesList.CurrentRow.Cells["TotalAmount"].Value.ToString();
                                    Document pdfDocument = new Document(iTextSharp.text.PageSize.A4, 20, 20, 42, 35);
                                    PdfWriter pdfwriter = PdfWriter.GetInstance(pdfDocument, new FileStream(sfd.FileName, FileMode.Create));


                                    pdfDocument.Open();
                                    pdfDocument.NewPage();
                                    pdfDocument.AddAuthor("POS");
                                    pdfDocument.AddCreator("LanguageIntegratedDevelopmentTeam");
                                    pdfDocument.AddSubject("SalesReport");
                                    Paragraph heading = new Paragraph("Purchase Details");
                                    heading.Alignment = Element.ALIGN_CENTER;
                                    heading.SpacingAfter = 18f;
                                    pdfDocument.Add(heading);

                                    Paragraph invoice = new Paragraph(i);
                                    invoice.Alignment = Element.ALIGN_CENTER;
                                    invoice.SpacingAfter = 18f;
                                    pdfDocument.Add(invoice);

                                    Paragraph outlet = new Paragraph(o);
                                    outlet.Alignment = Element.ALIGN_CENTER;
                                    outlet.SpacingAfter = 4f;
                                    pdfDocument.Add(outlet);

                                    Paragraph customer = new Paragraph(c);
                                    customer.Alignment = Element.ALIGN_CENTER;
                                    customer.SpacingAfter = 5F;
                                    pdfDocument.Add(customer);

                                    Paragraph para2 = new Paragraph(emp);
                                    para2.Alignment = Element.ALIGN_CENTER;
                                    para2.SpacingAfter = 5F;
                                    pdfDocument.Add(para2);
                                    Paragraph para3 = new Paragraph(sDate);
                                    para3.Alignment = Element.ALIGN_CENTER;
                                    para3.SpacingAfter = 35F;
                                    pdfDocument.Add(para3);


                                    PdfPTable table = new PdfPTable(4);

                                    table.SpacingAfter = 30f;

                                    PdfPCell cell = new PdfPCell(new Phrase("Product Details"));

                                    cell.Colspan = 4;
                                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    table.AddCell(cell);
                                    table.AddCell("Name");

                                    table.AddCell("Quantity");

                                    table.AddCell("Cost Price");

                                    table.AddCell("Total Price");


                                    foreach (ListViewItem item in itemListView.Items)
                                    {
                                        foreach (var itm in item.SubItems)
                                        {
                                            table.AddCell(((ListViewItem.ListViewSubItem)itm).Text);
                                        }
                                    }
                                    pdfDocument.Add(table);
                                    pdfDocument.Close();
                                    MessageBox.Show("Your PDF File Has Been Ready....!");
                                }
                            }
                        }

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchAny_TextChanged(object sender, EventArgs e)
        {
            ManagerContext db = new ManagerContext();
            var purchases = (from p in db.Sales.Where(a => a.IsDelete == false)
                             join outlet in db.Outlets on p.OutletId equals outlet.Id
                             join emp in db.Employees on p.EmployeeId equals emp.Id
                             join s in db.CustomerAndSuppliers on p.CustomerId equals s.Id
                             where p.InvoiceNo.ToString().StartsWith(txtSearchAny.Text) && p.IsDelete == false || p.Outlet.Name.StartsWith(txtSearchAny.Text) && p.IsDelete == false
                             || p.Employee.Name.StartsWith(txtSearchAny.Text) && p.IsDelete == false || p.Customer.Name.StartsWith(txtSearchAny.Text) && p.IsDelete == false

                             select new
                             {
                                 p.Id,
                                 p.InvoiceNo,
                                 p.SalesDate,
                                 Outlet = p.Outlet.Name,
                                 EmployeeName = p.Employee.Name,
                                 Supplier = p.Customer.Name,
                                 ListOfProduct = p.listOfItem,
                                 p.TotalAmount

                             }).ToList();

            dgvSalesList.DataSource = purchases;
            var dataGridViewColumn = dgvSalesList.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
        }
    }
        
 }
