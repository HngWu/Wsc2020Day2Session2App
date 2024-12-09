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
    public partial class FrmAttemptSubmission : Form
    {
        Wsc2020Day2Session2DbContext context = new Wsc2020Day2Session2DbContext();
        public FrmAttemptSubmission()
        {
            InitializeComponent();
            var areaId = context.Users.Where(x => x.id == common.competitorId).Select(x => x.areaId).FirstOrDefault();
            var rounds = context.AreaCompetitions
                .Where(x => x.areaId == areaId)
                .ToList();
            cbrounds.Items.AddRange(rounds.Select(x => x.round).OrderBy(x=>x).ToArray());


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbrounds.SelectedIndex == null || string.IsNullOrEmpty(tbattempt.Text.ToString()))
                {
                   MessageBox.Show("Please fill all the fields");

                }
                else
                {
                    


                    var round = cbrounds.SelectedItem.ToString();
                    var areaId = context.Users.Where(x => x.id == common.competitorId).Select(x => x.areaId).FirstOrDefault();
                    var attempt = tbattempt.Text;
                    var areaCompetitionId = context.AreaCompetitions
                        .Where(x => x.areaId == areaId && x.round == round)
                        .Select(x => x.id)
                        .FirstOrDefault();

                    var checkSubmission = context.CompetitorSubmissions
                        .Where(x => x.competitorId == common.competitorId)
                        .Where(x => x.areaCompetitionId == areaCompetitionId)
                        .Any();


                    if (checkSubmission)
                    {
                        MessageBox.Show("You have already Submitted for this round");

                        tbattempt.Text = "";
                        cbrounds.Text = "";
                    }
                    else
                    {
                        var newSubmission = new CompetitorSubmission()
                        {
                            areaCompetitionId = areaCompetitionId,
                            competitorId = common.competitorId,
                            attempt = attempt,
                            marked = false
                        };

                        context.CompetitorSubmissions.Add(newSubmission);
                        context.SaveChanges();


                        MessageBox.Show("Submission successful");
                        tbattempt.Text = "";
                        cbrounds.Text = "";

                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Submission unsuccessful");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin(); 
            frmLogin.Show();
            this.Hide();
        }
    }
}
