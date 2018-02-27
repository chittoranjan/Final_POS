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
            LoadDataGridView();
        }

 

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void LoadDataGridView()
        {
            try
            {
                using (ManagerContext db = new ManagerContext())
                {

                    var stockitem = (from s in db.Stocks
                                     join i in db.Items on s.ItemId equals i.Id
                                     join sales in db.SalesItem on s.ItemId equals sales.ItemId
                                     where i.Code.StartsWith(txtSearch.Text)
                                     select new
                                     {
                                         i.Name,
                                         i.Code,
                                         Category = i.ItemCategory.Name,
                                         s.ItemId,
                                         s.ItemName,
                                         AvailbleQuantity = s.AvailableQuantity - sales.Quantity,
                                         s.AveragePrice
                                     }).ToList();
                    dgvStock.DataSource = stockitem;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (ManagerContext db = new ManagerContext())
                {

                    var stockitem = (from s in db.Stocks
                                     join i in db.Items on s.ItemId equals i.Id
                                     join sales in db.SalesItem on s.ItemId equals sales.ItemId
                                     where s.ItemId.ToString().StartsWith(txtSearch.Text) || s.ItemName.StartsWith(txtSearch.Text) || i.ItemCategory.Name.StartsWith(txtSearch.Text)
                                     select new
                                     {
                                         i.Name,
                                         i.Code,
                                         Category = i.ItemCategory.Name,
                                         s.ItemId,
                                         s.ItemName,
                                         AvailbleQuantity = s.AvailableQuantity - sales.Quantity,
                                         s.AveragePrice
                                     }).ToList();
                    dgvStock.DataSource = stockitem;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (ManagerContext db = new ManagerContext())
            {

                var stockitem = (from s in db.Stocks
                                 join i in db.Items on s.ItemId equals i.Id
                                 join sales in db.SalesItem on s.ItemId equals sales.ItemId
                                 where i.Code.StartsWith(txtSearch.Text)
                                 select new
                                 {
                                     i.Name,
                                     i.Code,
                                     Category = i.ItemCategory.Name,
                                     s.ItemId,
                                     s.ItemName,
                                     AvailbleQuantity=s.AvailableQuantity-sales.Quantity,
                                     s.AveragePrice
                                 }).ToList();
                dgvStock.DataSource = stockitem;
            }
        }
    }
}
