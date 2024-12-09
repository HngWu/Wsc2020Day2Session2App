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
    public partial class FrmLogin : Form
    {
        Wsc2020Day2Session2DbContext context  = new Wsc2020Day2Session2DbContext();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var userId = tbuserid.Text.ToString();
                var password = tbpassword.Text.ToString();

                var user = context.Users.Where(u => u.id == userId && u.password == password).FirstOrDefault();
                if (user != null)
                {
                    MessageBox.Show("Login Success");
                    this.Hide();


                    if(user.userTypeId == 3)
                    {
                        common.judgeId = user.id;
                        FrmJudgingPortal frmJudgingPortal = new FrmJudgingPortal();
                        frmJudgingPortal.Show();
                    }
                    else if(user.userTypeId == 2)
                    {
                        common.competitorId = user.id;
                        FrmAttemptSubmission frmMain = new FrmAttemptSubmission();
                        frmMain.Show();
                    }
                    else if(user.userTypeId == 1)
                    {
                        FrmJudgementManagement frmMain = new FrmJudgementManagement();
                        frmMain.Show();
                    }
                    else
                    {

                    }

                    
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbuserid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
