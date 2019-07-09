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
    public partial class GitHubInfo : Form
    {
        public GitHubInfo(DateTimeOffset date, string userName, int repositoryRating)
        {
            InitializeComponent();
            tb_creationDate.Text = date.ToString();
            tb_rating.Text = repositoryRating.ToString();
            tb_username.Text = userName;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
