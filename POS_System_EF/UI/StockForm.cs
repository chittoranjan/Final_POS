using POS_System_EF.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System_EF.UI
{
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
            ComboBoxData();
            LoadDataGridView();
        }

        private void ComboBoxData()
        {
            using (ManagerContext db = new ManagerContext())
            {
                var outlet = db.Outlets.ToList();
                cmbOutlet.DisplayMember = "Name";
                cmbOutlet.ValueMember = "Id";
                cmbOutlet.DataSource = outlet;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void cmbOutlet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadDataGridView()
        {

            ManagerContext db = new ManagerContext();
            var stock = (from s in db.Stocks
                         join i in db.Items on s.ItemId equals i.Id
                         join sales in db.SalesItem on s.ItemId equals sales.ItemId
                         join p in db.TempPurchases on s.ItemId equals p.ItemId
                         select new
                         {
                             s.Id,
                             s.AvailableQuantity,
                             s.ItemId,
                             ItemName =i.Name,
                             i.SalePrice,
                             SalesQty=sales.Quantity,
                             PurchaseQuantity=p.Quantity,
                             CurrentQuantity=p.Quantity - sales.Quantity
                         }).ToList();
            dgvStock.DataSource = stock;
        }
    }
}
