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
            ManagerContext db = new ManagerContext();
            var purchases = (from p in db.Purchases
                             join outlet in db.Outlets on p.OutletId equals outlet.Id
                             join emp in db.Employees on p.EmployeeId equals emp.Id
                             join s in db.Suppliers on p.SupplierId equals s.Id
                             
                             select new
                             {
                                 p.Id,
                                 p.InvoiceNo,
                                 p.PurchaseDate,
                                 Outlet = p.Outlet.Name,
                                 EmployeeName = p.Employee.Name,
                                 Supplier = p.Supplier.Name,
                                 ListOfProduct = p.ListOfPurchase,

                             }).ToList();
            dgvPurchaseReport.DataSource = purchases;
            dgvPurchaseReport.Columns["Id"].Visible = false;


            itemListView.View = View.Details;
            itemListView.GridLines = true;
            itemListView.FullRowSelect = true;

            //Add column header
            itemListView.Columns.Add("Product", 200);
            itemListView.Columns.Add("Quantity", 100);
            itemListView.Columns.Add("CostPrice", 100);
            itemListView.Columns.Add("TotalPrice", 100);


        }

        private void dgvPurchaseReport_DoubleClick(object sender, EventArgs e)
        {
            


            ManagerContext db = new ManagerContext();
           
            int selectedId = (int)dgvPurchaseReport.CurrentRow.Cells["Id"].Value;
            
           
            if(selectedId>0)
            {
                txtInvoiceNo.Text = dgvPurchaseReport.CurrentRow.Cells["InvoiceNo"].Value.ToString();
                purchaseDate.Text = dgvPurchaseReport.CurrentRow.Cells["PurchaseDate"].Value.ToString();
                outletName.Text = dgvPurchaseReport.CurrentRow.Cells["Outlet"].Value.ToString();
                lblemployeeName.Text = dgvPurchaseReport.CurrentRow.Cells["EmployeeName"].Value.ToString();
                lblsupplierName.Text = dgvPurchaseReport.CurrentRow.Cells["Supplier"].Value.ToString();
            

            List<TempPurchase> purchases = db.TempPurchases.Where(c => c.PurchaseId == selectedId).ToList();
                string[] itms = new string[4];
                ListViewItem lItem;
                itemListView.Items.Clear();
                foreach (var o in purchases)
                {
                   
                    itms[0] = o.Name;
                    itms[1] = o.Quantity.ToString();
                    itms[2] = o.CostPrice.ToString();
                    itms[3] = o.TotalPrice.ToString();
                    lItem = new ListViewItem(itms);
                    itemListView.Items.Add(lItem);
                    btnPdf.Visible = true;
                }
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if(sfd.ShowDialog()==DialogResult.OK)
                {
                    
                    Document pdfDocument = new Document(iTextSharp.text.PageSize.A4,20,20,42,35);
                    PdfWriter pdfwriter = PdfWriter.GetInstance(pdfDocument, new FileStream(sfd.FileName, FileMode.Create));
                    pdfDocument.Open();
                    pdfDocument.NewPage();
                    pdfDocument.Add(new Paragraph("This is paragraph"));

                    pdfDocument.Close();
                    
                }
            }
        }

        private void itemListView_DoubleClick(object sender, EventArgs e)
        {
            var item = itemListView.SelectedItems[0].Text;
            var item1 = itemListView.SelectedItems[0].SubItems[2].Text;
            var qty = itemListView.SelectedItems[0].SubItems[1].Text;
            var item2 = item +" "+item1;
            if (item != null)
            {
                for(int i=0; i<=qty.Length; i++)
                {
                    Bitmap bitmap = new Bitmap(item2.Length * 40, 150);
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        System.Drawing.Font font = new System.Drawing.Font("IDAutomationHC39M", 20);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ManagerContext db;
            if(txtSearchBox.Text!=null)
            {
                db = new ManagerContext();
                var searchResult = (from p in db.Purchases
                                    where p.Employee.Name.StartsWith(txtSearchBox.Text)
                                    select new
                                    {
                                        p.Id,
                                        p.InvoiceNo,
                                        p.PurchaseDate,
                                        Outlet = p.Outlet.Name,
                                        EmployeeName=p.Employee.Name,
                                        Supplier = p.Supplier.Name
                                        

                                    }).ToList();
                dgvPurchaseReport.DataSource = searchResult;
                dgvPurchaseReport.Columns["Id"].Visible = false;
            }
        }
    }
}
