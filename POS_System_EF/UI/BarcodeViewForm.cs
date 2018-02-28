using POS_System_EF.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_EF.UI
{
    public partial class BarcodeViewForm : Form
    {
        public BarcodeViewForm()
        {
            InitializeComponent();
            ComboBoxData();
            
        }

        private void ComboBoxData()
        {
            ManagerContext db = new ManagerContext();
            var loadItem = db.Items.Where(i => i.IsDelete == false);

            cmbItem.DisplayMember = "CodeName";
            cmbItem.ValueMember = "Id";
            cmbItem.DataSource = loadItem.ToList();
            cmbItem.SelectedIndex = -1;
        }

        private void btnBarcodeMake_Click(object sender, EventArgs e)
        {
            string nameCode = cmbItem.Text;
            decimal salePrice = Convert.ToDecimal(txtSalePrice.Text);
            int qty = Convert.ToInt32(txtQuantity.Text);
            var item = nameCode + " - " + salePrice;
            if (item != null)
            {
                for (int i = 0; i <= qty; i++)
                {
                    Bitmap bitmap = new Bitmap(item.Length * 40, 70);
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        System.Drawing.Font font = new System.Drawing.Font("IDAHC39M Code 39 Barcode", 20);
                        PointF point = new PointF(2f, 2f);
                        SolidBrush black = new SolidBrush(Color.Black);
                        SolidBrush white = new SolidBrush(Color.White);
                        graphics.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                        graphics.DrawString("*" + item + "*" , font, black, point);
                    }
                    using (MemoryStream ms = new MemoryStream())
                    {
                        PictureBox pb = new PictureBox();
                        bitmap.Save(ms, ImageFormat.Png);
                        this.Controls.Add(pb);
                        pb.Image = bitmap;
                        pb.Padding=new Padding(10, 10, 10, 10);
                        
                    }

                }

            }
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int cmbId;
                if (cmbItem.SelectedValue != null && cmbItem.Text != "")
                {
                    bool isValidItemId = int.TryParse(cmbItem.SelectedValue.ToString(), out cmbId);
                    if (isValidItemId)
                    {
                        using (ManagerContext db = new ManagerContext())
                        {
                            var objItem = db.Items.FirstOrDefault(a => a.Id == cmbId);

                            if (objItem.Id > 0)
                            {
                                txtSalePrice.Text = objItem.SalePrice.ToString();

                            }
                            else
                            {
                                txtSalePrice.Clear();
                                MessageBox.Show("Not Found");
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

        private void BarcodeViewForm_Load(object sender, EventArgs e)
        {
            cmbItem.SelectedIndex = -1;
            txtSalePrice.Clear();
        }
    }
}