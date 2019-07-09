using ITCenterApp.Database;
using Octokit;
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
        int selectedIdRow = -1;

        public MainApp(IDatabaseManager dbManager)
        {
            _dbManager = dbManager;
            InitializeComponent();
        }

        public DialogResult Run()
        {
            return this.ShowDialog();
        }

        #region Methods

        private void UpdateHederRow()
        {
            decimal netPriceTotal = 0M;
            decimal grossPriceTotal = 0M;
            foreach (DataGridViewRow row in dgv_rows.Rows)
            {
                netPriceTotal += (decimal)row.Cells["rowNetPrice"].Value * (decimal)row.Cells["quantity"].Value;
                grossPriceTotal += (decimal)row.Cells["rowGrossPrice"].Value * (decimal)row.Cells["quantity"].Value;
            }
          
            Headers header = (Headers)dgv_headers.CurrentRow.DataBoundItem;
            header.NetPrice = netPriceTotal;
            header.GrossPrice = grossPriceTotal;
            _dbManager.UpdateHeader(header);
            dgv_headers.Refresh();
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
            btn_rowCreateUpdate.Text = "Create";
            selectedIdRow = -1;
        }

        private void LoadHeders()
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

        private void HeaderCreateUpdate()
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

            header.GrossPrice = netPrice * 1.23M;
            if (selectedIdHeader != -1)
            {
                header.Id = selectedIdHeader;
                _dbManager.UpdateHeader(header);
            }
            else
            {
                _dbManager.CreateHeader(header);
            }

            LoadHeders();
            ClearHeder();
        }

        private void RowCreateUpdate()
        {
            Rows row = new Rows();

            row.ArticleName = tb_rowArticleName.Text;

            decimal quantity;
            decimal.TryParse(tb_rowQuantity.Text, out quantity);
            row.Quantity = quantity;

            decimal netPrice;
            decimal.TryParse(tb_rowNetPrice.Text, out netPrice);
            row.NetPrice = netPrice;

            row.GrossPrice = row.NetPrice * 1.23M;

            row.HeaderId = (int)dgv_headers.CurrentRow.Cells["Id"].Value;

            if (selectedIdRow != -1)
            {
                row.Id = selectedIdRow;
                _dbManager.UpdateRow(row);
            }
            else
            {
                _dbManager.CreateRow(row);
            }

            LoadRows(row.HeaderId);
            ClearRow();
            UpdateHederRow();
        }

        #endregion Methods

        #region Events

        private void dgv_rows_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_rows.CurrentRow.Index != -1)
            {
                selectedIdRow = (int)dgv_rows.CurrentRow.Cells["rowId"].Value;
                Rows row = _dbManager.GetRowById(selectedIdRow);
                if (row != null)
                {
                    tb_rowArticleName.Text = row.ArticleName;
                    tb_rowNetPrice.Text = row.NetPrice.ToString();
                    tb_rowQuantity.Text = row.Quantity.ToString();
                    btn_rowCreateUpdate.Text = "Update";
                }

            }
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
            HeaderCreateUpdate();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            LoadHeders();
        }

        private void btn_headerDelete_Click(object sender, EventArgs e)
        {
            if (dgv_headers.Rows.Count > 0)
            if (MessageBox.Show("Are you shure to delete record", "Deleting", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)dgv_headers.CurrentRow.Cells["Id"].Value;
                _dbManager.DeleteHeader(id);
                LoadHeders();
                ClearHeder();
            }
           
        }

        private void btn_rowDelete_Click(object sender, EventArgs e)
        {
            if (dgv_rows.Rows.Count > 0)
            if (MessageBox.Show("Are you shure to delete record", "Deleting", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int rowId = (int)dgv_rows.CurrentRow.Cells["rowId"].Value;
                int headerid = (int)dgv_headers.CurrentRow.Cells["Id"].Value;
                _dbManager.DeleteRow(rowId);
                LoadRows(headerid);
                ClearRow();
                UpdateHederRow();
             }
            
        }

        private void btn_rowCancel_Click(object sender, EventArgs e)
        {
            ClearRow();
        }

        private void btn_headerCancel_Click(object sender, EventArgs e)
        {
            ClearHeder();
        }

        private void dgv_headers_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_headers.CurrentRow.Index != -1)
            {
                selectedIdHeader = (int)dgv_headers.CurrentRow.Cells["Id"].Value;
                Headers header = _dbManager.GetHeaderById(selectedIdHeader);
                if (header != null)
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

        private void btn_rowCreateUpdate_Click(object sender, EventArgs e)
        {
            RowCreateUpdate();
        }

        private void btn_github_ClickAsync(object sender, EventArgs e)
        {
            var client = new GitHubClient(new ProductHeaderValue("ITCenterApp"));
            var repo = client.Repository.GetAllForUser("mbahojlo").GetAwaiter().GetResult().Where(repos => repos.Name == "ITCenterApp").FirstOrDefault();
            GitHubInfo ghi = new GitHubInfo(repo.CreatedAt,repo.Owner.Login,repo.StargazersCount);
            ghi.ShowDialog();
        }

        #endregion Events
    }
}
