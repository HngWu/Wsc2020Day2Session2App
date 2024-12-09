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
    public partial class FrmJudgingPortal : Form
    {
        Wsc2020Day2Session2DbContext context = new Wsc2020Day2Session2DbContext();
        BindingSource bs = new BindingSource();
        string areaId;
        public FrmJudgingPortal()
        {
            InitializeComponent();

            areaId = context.Users.Where(x => x.id == common.judgeId).Select(x => x.areaId).FirstOrDefault();
            lbskillarea.Text = context.Areas.Where(x => x.id == areaId).Select(x => x.area1).FirstOrDefault();
            var rounds = context.AreaCompetitions
                .Where(x => x.areaId == areaId)
                .ToList();
            cbrounds.Items.AddRange(rounds.Select(x => x.round).OrderBy(x => x).ToArray());
            cbrounds.SelectedIndex = 1;

            var round = cbrounds.SelectedItem.ToString();

            getdata(round);

            



        }

        public void getdata(string round)
        {
            var areaCompetitionId = context.AreaCompetitions
                .Where(x => x.areaId == areaId && x.round == round)
                .FirstOrDefault().id;
            var competitors = context.CompetitorSubmissions.Where(x => x.areaCompetitionId == areaCompetitionId).Select(x => x.competitorId).ToList();

            var datatable = new DataTable();

            datatable.Columns.Add("SubmissionId");
            datatable.Columns.Add("Competitor");
            datatable.Columns.Add("Submission");
            datatable.Columns.Add("Score");
            datatable.Columns.Add("Action");

            foreach (var competitor in competitors)
            {
                try
                {
                    var competitorName = context.Users.Where(x => x.id == competitor).Select(x => x.name).FirstOrDefault();
                    var submission = context.CompetitorSubmissions
                        .Where(x => x.areaCompetitionId == areaCompetitionId && x.competitorId == competitor)
                        .FirstOrDefault();
                    var scores = context.Scores
                        .Where(x => x.CompetitionSubmissionId == submission.id && x.competitorId == competitor)
                        .Select(x => x.score1)
                        .ToList();
                    var submissionId = submission.id;
                    if (scores.Count == 0)
                    {
                        datatable.Rows.Add(submissionId,competitorName, submission.attempt, "-", "Score");
                    }
                    else
                    {
                        datatable.Rows.Add(submissionId,competitorName, submission.attempt, scores.Sum().ToString(), "Edit");

                    }
                }
                catch (Exception)
                {

                    throw;
                }
               

            }
            bs.DataSource = datatable;
            dgvsubmissions.DataSource = bs;

            if (dgvsubmissions.Columns["Action"] is DataGridViewTextBoxColumn)
            {
                // Remove the existing "Action" text column and replace it with a link column
                dgvsubmissions.Columns.Remove("Action");

                // Create a new DataGridViewLinkColumn for the Action column
                DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn
                {
                    HeaderText = "Action",
                    DataPropertyName = "Action",  // Bind to the Action column in the DataTable
                    Name = "Action",
                    UseColumnTextForLinkValue = false
                };

                dgvsubmissions.Columns.Add(linkColumn);
            }



            //foreach (DataGridViewRow row in dgvsubmissions.Rows)
            //{
            //    if (row != null && row.Cells["Score"].Value != null)
            //    {
            //        var scoreString = row.Cells["Score"].Value.ToString();
            //        // If score is "-", set action to "Score"; otherwise, set it to "Edit"
            //        row.Cells["Action"].Value = scoreString == "-" ? "Edit" : "Edit";
            //    }
            //}


        }

        private void dgvjudges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.ColumnIndex == dgvsubmissions.Columns["Action"].Index)
                {

                    var linkText = dgvsubmissions.Rows[e.RowIndex].Cells["Action"].Value.ToString();

                    if (linkText == "Score")
                    {

                        var submissionId = dgvsubmissions.Rows[e.RowIndex].Cells["SubmissionId"].Value.ToString();
                        common.submissionId = int.Parse(submissionId);

                        var frmScore = new FrmScore();
                        frmScore.Show();
                        this.Hide();
                    }
                    else if (linkText == "Edit")
                    {
                        var submissionId = dgvsubmissions.Rows[e.RowIndex].Cells["SubmissionId"].Value.ToString();
                        common.submissionId = int.Parse(submissionId);


                        FrmEditScore frmEditScore = new FrmEditScore(); 
                        frmEditScore.Show();
                        this.Hide();
                    }



                }
            }
            catch (Exception)
            {

                throw;
            }

          
        }

        private void FrmJudgingPortal_Load(object sender, EventArgs e)
        {

        }

        private void cbrounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            var round = cbrounds.SelectedItem.ToString();
            getdata(round);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbskillarea_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
