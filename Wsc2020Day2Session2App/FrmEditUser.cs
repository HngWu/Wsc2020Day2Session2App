using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wsc2020Day2Session2App
{
    public partial class FrmEditUser : Form
    {
        Wsc2020Day2Session2DbContext context = new Wsc2020Day2Session2DbContext();
        public FrmEditUser()
        {
            InitializeComponent();
            var userTypes = context.UserTypes.ToList();
            cbusertype.Items.AddRange(userTypes.Select(x => x.userTypeName).ToArray());
            var areas = context.Areas.ToList();
            cbarea.Items.AddRange(areas.Select(x => x.area1).ToArray());

            var user = context.Users.Where(x => x.id == common.userId).FirstOrDefault();
            tbuserid.Text = user.id;
            tbname.Text = user.name;
            tbpassword.Text = user.password;
            cbusertype.SelectedItem = user.UserType.userTypeName;
            cbarea.SelectedItem = user.Area.area1;


        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbname.Text == "" || tbpassword.Text == "" || tbuserid.Text == "")
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }

                if (cbusertype.SelectedItem == null || cbarea.SelectedItem == null)
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
                context.Users.AddOrUpdate(newUser);
                context.SaveChanges();
                MessageBox.Show("User updated successfully");
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

        private void btnback_Click(object sender, EventArgs e)
        {
            FrmJudgementManagement frmCompetitorManagementScreen = new FrmJudgementManagement();
            frmCompetitorManagementScreen.Show();
            this.Hide();
        }
    }
}
