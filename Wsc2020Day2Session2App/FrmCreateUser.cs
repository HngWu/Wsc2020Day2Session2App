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
    public partial class FrmCreateUser : Form
    {
        Wsc2020Day2Session2DbContext context = new Wsc2020Day2Session2DbContext();
        public FrmCreateUser()
        {
            InitializeComponent();

            var userTypes = context.UserTypes.ToList();
            cbusertype.Items.AddRange(userTypes.Select(x=>x.userTypeName).ToArray());
            var areas = context.Areas.ToList();
            cbarea.Items.AddRange(areas.Select(x => x.area1).ToArray());
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            try
            {
                if(tbname.Text == "" || tbpassword.Text == "" || tbuserid.Text == "")
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }

                if (cbusertype.SelectedItem == null || cbarea.SelectedItem== null)
                {
                    MessageBox.Show("Please select user type");
                    return;
                }

                var userTypeId = context.UserTypes.Where(x => x.userTypeName == cbusertype.SelectedItem.ToString()).FirstOrDefault().id;
                var areaId = context.Areas.Where(x => x.area1 == cbarea.SelectedItem.ToString()).FirstOrDefault().id;
                var newUser = new User()
                {
                    id = tbuserid.Text.ToString(),
                    name = tbname.Text.ToString(),
                    password = tbpassword.Text.ToString(),
                    userTypeId = userTypeId,
                    areaId = areaId
                };
                context.Users.Add(newUser);
                context.SaveChanges();
                MessageBox.Show("User created successfully");
                if (common.userType == 3)
                {
                    FrmJudgementManagement frmMain = new FrmJudgementManagement();
                    frmMain.Show();
                }
                else if (common.userType == 2)
                {
                    FrmCompetitorManagementScreen frmMain = new FrmCompetitorManagementScreen();
                    frmMain.Show();
                }
                else
                {
                    FrmJudgementManagement frmMain = new FrmJudgementManagement();
                    frmMain.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbuserid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbusertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbarea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FrmJudgementManagement frmCompetitorManagementScreen = new FrmJudgementManagement();
            frmCompetitorManagementScreen.Show();
            this.Hide();
        }
    }
}
