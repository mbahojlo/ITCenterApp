using ITCenterApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCenterApp
{
    public partial class MainApp : Form, IMainApp
    {
        IDatabaseManager _dbManager;
        int selectedIdHeader = -1;
        public MainApp(IDatabaseManager dbManager)
        {
            _dbManager = dbManager;
            InitializeComponent();
        }

        public DialogResult Run()
        {
            return this.ShowDialog();
        }

        private void tb_rowQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDecimal(sender, e);
        }

        private void tb_rowNetPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDecimal(sender, e);
        }

        private void tb_headerNetPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDecimal(sender, e);
        }

        private void tb_headerCustomerNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(sender, e);
        }

        private void btn_headerCreateUpdate_Click(object sender, EventArgs e)
        {
            Headers header = new Headers();

            header.Name = tb_headerName.Text;

            int customerNumber;
            int.TryParse(tb_headerCustomerNumber.Text, out customerNumber);
            header.CustomerNumber = customerNumber;

            header.CreatedDate = DateTime.Now;

            decimal netPrice;
            decimal.TryParse(tb_headerNetPrice.Text, out netPrice);
            header.NetPrice = netPrice;
            
            header.GrossPrice = netPrice * 1.23M ;
            if (selectedIdHeader != -1)
            {
                header.Id = selectedIdHeader;
                _dbManager.UpdateHeader(header);
            }
            else
            {
                _dbManager.CreateHeader(header);
            }
        
            PopulateHeders();
            ClearHeder();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            PopulateHeders();
        }

        private void btn_headerDelete_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you shure to delete record", "Deleting", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int Id = (int)dgv_headers.CurrentRow.Cells["Id"].Value;
                _dbManager.DeleteHeader(Id);
                PopulateHeders();
            }
        }

        private void btn_headerCancel_Click(object sender, EventArgs e)
        {
            ClearHeder();
        }

        private void btn_rowCreateUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btn_rowDelete_Click(object sender, EventArgs e)
        {

        }

        private void btn_rowCancel_Click(object sender, EventArgs e)
        {

        }

        private void ClearHeder()
        {
            tb_headerName.Text = "";
            tb_headerNetPrice.Text = "";
            tb_headerCustomerNumber.Text = "";
            btn_headerCreateUpdate.Text = "Create";
            selectedIdHeader = -1;
        }

        private void ClearRow()
        {
            tb_rowArticleName.Text = "";
            tb_rowNetPrice.Text = "";
            tb_rowQuantity.Text = "";
        }

        private void PopulateHeders()
        {
            try
            {
                dgv_headers.AutoGenerateColumns = false;
                dgv_headers.DataSource = _dbManager.GetHeaders();
            }
            catch (Exception)
            {
                MessageBox.Show("There is a DB connection problem.");
            }
            
        }

        private static void OnlyDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private static void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void dgv_headers_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_headers.CurrentRow.Index != -1) {
                selectedIdHeader = (int)dgv_headers.CurrentRow.Cells["Id"].Value;
                Headers header = _dbManager.GetHeaderById(selectedIdHeader);
                if (header!= null)
                {
                    tb_headerCustomerNumber.Text = header.CustomerNumber.ToString();
                    tb_headerName.Text = header.Name.ToString();
                    tb_headerNetPrice.Text = header.NetPrice.ToString();
                    btn_headerCreateUpdate.Text = "Update";
                }

            }
        }

        private void dgv_headers_SelectionChanged(object sender, EventArgs e)
        {
            int id = (int)dgv_headers.CurrentRow.Cells["Id"].Value;
            LoadRows(id);
        }

        private void LoadRows(int id)
        {
            try
            {
                dgv_rows.AutoGenerateColumns = false;
                dgv_rows.DataSource = _dbManager.GetRowsById(id);
            }
            catch (Exception)
            {
                MessageBox.Show("There is a DB connection problem.");
            }
}
    }
}
