using POS_System_EF.EntityModels;
using POS_System_EF.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing;

namespace POS_System_EF.UI
{
    public partial class PurchaseReportForm : Form
    {
        public PurchaseReportForm()
        {
            InitializeComponent();
        }

        private void PurchaseReportForm_Load(object sender, EventArgs e)
        {
            LoadDataGridView();

        }

        private void dgvPurchaseReport_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                using (ManagerContext db = new ManagerContext())
                {
                    int selectedId = (int)dgvPurchaseReport.CurrentRow.Cells["Id"].Value;
                    
                    if (selectedId > 0)
                    {
                        txtInvoiceNo.Text = dgvPurchaseReport.CurrentRow.Cells["InvoiceNo"].Value.ToString();
                        purchaseDate.Text = dgvPurchaseReport.CurrentRow.Cells["PurchaseDate"].Value.ToString();
                        outletName.Text = dgvPurchaseReport.CurrentRow.Cells["Outlet"].Value.ToString();
                        lblemployeeName.Text = dgvPurchaseReport.CurrentRow.Cells["EmployeeName"].Value.ToString();
                        lblsupplierName.Text = dgvPurchaseReport.CurrentRow.Cells["Supplier"].Value.ToString();


                        //List<TempPurchase> purchases = db.TempPurchases.Include(o=>o.Item).Where(c => c.PurchaseId == selectedId).ToList();
                        var purchases = (from tp in db.TempPurchases
                                                        join itm in db.Items on tp.ItemId equals itm.Id
                                                        where tp.PurchaseId == selectedId
                                                        select new
                                                        {
                                                            itm.Name,
                                                            tp.Quantity,
                                                            tp.CostPrice,
                                                            tp.TotalPrice
                                                        }).ToList();





                        string[] itms = new string[4];
                        ListViewItem lItem;
                        itemListView.Items.Clear();
                        foreach (var o in purchases)
                        {

                            itms[0] = o.Name.ToString();
                            itms[1] = o.Quantity.ToString();
                            itms[2] = o.CostPrice.ToString();
                            itms[3] = o.TotalPrice.ToString();
                            lItem = new ListViewItem(itms);
                            itemListView.Items.Add(lItem);
                            btnPdf.Visible = true;
                        }
                    }
                }

            }
            catch(Exception ex)
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
                            if (dgvPurchaseReport.CurrentRow != null)
                            {
                                int selectedId = (int)dgvPurchaseReport.CurrentRow.Cells[0].Value;
                                if (selectedId > 0)
                                {
                                    string invoiceNo = dgvPurchaseReport.CurrentRow.Cells["InvoiceNo"].Value.ToString();
                                    string i = "Invoice No: " + invoiceNo;
                                    string supplier = dgvPurchaseReport.CurrentRow.Cells["Supplier"].Value.ToString();
                                    string s = "Supplier Name: " + supplier;
                                    string outletName = dgvPurchaseReport.CurrentRow.Cells["Outlet"].Value.ToString();
                                    string o = "Outlet Name: " + outletName;
                                    string employeeName = dgvPurchaseReport.CurrentRow.Cells["EmployeeName"].Value.ToString();
                                    string emp = "Employee Name: " + employeeName;
                                    string purchaseDate = dgvPurchaseReport.CurrentRow.Cells["PurchaseDate"].Value.ToString();
                                    string pDate = "Purchase Date: " + purchaseDate;
                                    Document pdfDocument = new Document(iTextSharp.text.PageSize.A4, 20, 20, 42, 35);
                                    PdfWriter pdfwriter = PdfWriter.GetInstance(pdfDocument, new FileStream(sfd.FileName, FileMode.Create));
                                    pdfDocument.Open();
                                    pdfDocument.NewPage();
                                    pdfDocument.AddAuthor("POS");
                                    pdfDocument.AddCreator("LanguageIntegratedDevelopmentTeam");
                                    pdfDocument.AddSubject("PurchaseReport");
                                    Paragraph heading = new Paragraph("Purchase Details");
                                    heading.Alignment = Element.ALIGN_CENTER;
                                    heading.SpacingAfter = 18f;
                                    pdfDocument.Add(heading);

                                    Paragraph invoice = new Paragraph(i);
                                    invoice.Alignment = Element.ALIGN_CENTER;
                                    invoice.SpacingAfter = 18f;
                                    pdfDocument.Add(invoice);

                                    Paragraph supp = new Paragraph(s);
                                    supp.Alignment = Element.ALIGN_CENTER;
                                    supp.SpacingAfter = 18f;
                                    pdfDocument.Add(supp);

                                    Paragraph para = new Paragraph(o);
                                    para.Alignment = Element.ALIGN_CENTER;
                                    para.SpacingAfter = 18f;
                                    pdfDocument.Add(para);
                                    Paragraph para2 = new Paragraph(emp);
                                    para2.Alignment = Element.ALIGN_CENTER;
                                    para2.SpacingAfter = 18f;
                                    pdfDocument.Add(para2);
                                    Paragraph para3 = new Paragraph(pDate);
                                    para3.Alignment = Element.ALIGN_CENTER;
                                    para3.SpacingAfter = 18f;
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

        private void itemListView_DoubleClick(object sender, EventArgs e)
        {
            var item = itemListView.SelectedItems[0].Text;
            var itemcostprice = itemListView.SelectedItems[0].SubItems[2].Text;
            var qty = itemListView.SelectedItems[0].SubItems[1].Text;
            var item2 = item +" "+itemcostprice;
            if (item != null)
            {
                for(int i=0; i<=qty.Length; i++)
                {
                    Bitmap bitmap = new Bitmap(item2.Length * 40, 150);
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        System.Drawing.Font font = new System.Drawing.Font("IDAHC39M Code 39 Barcode", 20);
                        PointF point = new PointF(2f, 2f);
                        SolidBrush black = new SolidBrush(Color.Black);
                        SolidBrush white = new SolidBrush(Color.White);
                        graphics.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                        graphics.DrawString("*" + item2 + "*", font, black, point);
                    }

                    using (MemoryStream ms = new MemoryStream())
                    {
                        bitmap.Save(ms, ImageFormat.Png);
                        barcodePictureBox.Visible = true;
                        barcodePictureBox.Image = bitmap;
                        barcodePictureBox2.Visible = true;
                        barcodePictureBox2.Image = bitmap;
                        barcodePictureBox3.Visible = true;
                        barcodePictureBox3.Image = bitmap;
                    }
                }
                
            }
        }

        

        private void dgvPurchaseReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPurchaseReport.CurrentCell.ColumnIndex.Equals(7))
            {
                if(dgvPurchaseReport.CurrentCell!=null && dgvPurchaseReport.CurrentCell.Value!=null)
                {
                    if (dgvPurchaseReport.CurrentRow != null)
                    {
                        int id = (int)dgvPurchaseReport.CurrentRow.Cells[0].Value;
                    
                        using (ManagerContext db = new ManagerContext())
                        {
                            var purchaseId = db.Purchases.FirstOrDefault(c => c.Id == id); ;
                            if(purchaseId!=null)
                            {
                                purchaseId.IsDelete = true;
                                int count = db.SaveChanges();
                                if (count > 0)
                                {
                                    MessageBox.Show("Successfully Deleted");
                                }
                                else
                                {
                                    MessageBox.Show("Operation Failed");
                                }
                            }
                       
                        }
                    }
                }
            }
        }
        private void LoadDataGridView()
        {

            ManagerContext db = new ManagerContext();
            var purchases = (from p in db.Purchases.Where(a => a.IsDelete == false)
                             join outlet in db.Outlets on p.OutletId equals outlet.Id
                             join emp in db.Employees on p.EmployeeId equals emp.Id
                             join s in db.CustomerAndSuppliers on p.SupplierId equals s.Id
                             where s.Type != "Customr"

                             select new
                             {
                                 p.Id,
                                 p.InvoiceNo,
                                 p.PurchaseDate,
                                 Outlet = p.Outlet.Name,
                                 EmployeeName = p.Employee.Name,
                                 Supplier = p.Supplier.Name,
                                 ListOfProduct = p.ListOfPurchase,
                                 p.TotalAmount

                             }).ToList();

            dgvPurchaseReport.DataSource = purchases;
            var dataGridViewColumn = dgvPurchaseReport.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Name = "btnDelete";
            btn.Text = "Delete";
            btn.UseColumnTextForButtonValue = true;
            dgvPurchaseReport.Columns.Add(btn);


            itemListView.View = View.Details;
            itemListView.GridLines = true;
            itemListView.FullRowSelect = true;

            //Add column header
            itemListView.Columns.Add("Product", 200);
            itemListView.Columns.Add("Quantity", 100);
            itemListView.Columns.Add("CostPrice", 100);
            itemListView.Columns.Add("TotalPrice", 100);
        }

        private void txtSearchAny_TextChanged(object sender, EventArgs e)
        {

            ManagerContext db = new ManagerContext();
            var purchases = (from p in db.Purchases.Where(a => a.IsDelete == false)
                             join outlet in db.Outlets on p.OutletId equals outlet.Id
                             join emp in db.Employees on p.EmployeeId equals emp.Id
                             join s in db.CustomerAndSuppliers on p.SupplierId equals s.Id
                             where p.InvoiceNo.ToString().StartsWith(txtSearchAny.Text) && p.IsDelete == false || p.Outlet.Name.StartsWith(txtSearchAny.Text) && p.IsDelete == false
                             || p.Employee.Name.StartsWith(txtSearchAny.Text) && p.IsDelete == false || p.Supplier.Name.StartsWith(txtSearchAny.Text) && p.IsDelete == false

                             select new
                             {
                                 p.Id,
                                 p.InvoiceNo,
                                 p.PurchaseDate,
                                 Outlet = p.Outlet.Name,
                                 EmployeeName = p.Employee.Name,
                                 Supplier = p.Supplier.Name,
                                 ListOfProduct = p.ListOfPurchase,
                                 p.TotalAmount

                             }).ToList();

            dgvPurchaseReport.DataSource = purchases;
            var dataGridViewColumn = dgvPurchaseReport.Columns["Id"];
            if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
        }
        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            ManagerContext db;
            if (txtSearchBox.Text != null)
            {
                db = new ManagerContext();
                var searchResult = (from p in db.Purchases
                                    where p.InvoiceNo.ToString().StartsWith(txtSearchBox.Text) && p.IsDelete == false
                                    select new
                                    {
                                        p.Id,
                                        p.InvoiceNo,
                                        p.PurchaseDate,
                                        Outlet = p.Outlet.Name,
                                        EmployeeName = p.Employee.Name,
                                        Supplier = p.Supplier.Name


                                    }).ToList();
                dgvPurchaseReport.DataSource = searchResult;
                var dataGridViewColumn = dgvPurchaseReport.Columns["Id"];
                if (dataGridViewColumn != null) dataGridViewColumn.Visible = false;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearchAny.Clear();
            txtSearchBox.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        
    }
}
