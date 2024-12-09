using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wsc2020Day2Session2App
{
    public partial class FrmJudgementManagement : Form
    {
        Wsc2020Day2Session2DbContext context = new Wsc2020Day2Session2DbContext();
        BindingSource bs = new BindingSource();
        public FrmJudgementManagement()
        {
            InitializeComponent();
            getdata();

            DataGridViewLinkColumn editLink = new DataGridViewLinkColumn();
            editLink.UseColumnTextForLinkValue = true;
            editLink.HeaderText = "Edit";
            editLink.DataPropertyName = "lnkColumn";
            editLink.LinkBehavior = LinkBehavior.SystemDefault;
            editLink.Text = "Edit";
            editLink.Name = "Edit";

            dgvjudges.Columns.Add(editLink);


            DataGridViewLinkColumn deleteLink = new DataGridViewLinkColumn();
            deleteLink.UseColumnTextForLinkValue = true;
            deleteLink.HeaderText = "Delete";
            deleteLink.DataPropertyName = "lnkColumn";
            deleteLink.LinkBehavior = LinkBehavior.SystemDefault;
            deleteLink.Text = "Delete";
            deleteLink.Name = "Delete";

            dgvjudges.Columns.Add(deleteLink);

        }


        public void getdata()
        {
            var judges = context.Users
                .Where(x=>x.userTypeId == 3)
                .Select(x=> new
                {
                    x.id,
                    x.UserType.userTypeName,
                    x.areaId,
                    x.Area.area1,
                    x.name,
                    x.password,
                })
                .ToList();
            bs.DataSource = judges;
            dgvjudges.DataSource = bs;


        }

        private void dgvjudges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvjudges.Columns["Edit"].Index)
                {
                    var judgeId = dgvjudges.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    common.userId = judgeId;
                    FrmEditUser frmJudge = new FrmEditUser();
                    frmJudge.Show();
                    this.Hide();
                }
                else if (e.ColumnIndex == dgvjudges.Columns["Delete"].Index)
                {
                    var judgeId = dgvjudges.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    var judge = context.Users.Where(x => x.id == judgeId).FirstOrDefault();
                    context.Users.Remove(judge);
                    context.SaveChanges();
                    MessageBox.Show("Judge Deleted Successfully");
                    getdata();
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            FrmCreateUser frmCreateUser = new FrmCreateUser();
            frmCreateUser.Show();
            this.Hide();
        }

        private void btncompetitormanagement_Click(object sender, EventArgs e)
        {
            FrmCompetitorManagementScreen frmCompetitorManagementScreen = new FrmCompetitorManagementScreen();
            frmCompetitorManagementScreen.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
