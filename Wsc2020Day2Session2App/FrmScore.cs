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
    public partial class FrmScore : Form
    {
        Wsc2020Day2Session2DbContext context = new Wsc2020Day2Session2DbContext();
        BindingSource bs = new BindingSource();
        string competitorId;
        int noOfCriteria;
        string areaId;
        public FrmScore()
        {
            InitializeComponent();

            
        

            var submissionId = common.submissionId;
            var submission = context.CompetitorSubmissions.Where(x => x.id == submissionId).FirstOrDefault();
            competitorId = submission.competitorId;
            areaId = context.Users.Where(x => x.id == competitorId).Select(x => x.areaId).FirstOrDefault();

            var criteria = context.AreaCriterias.Where(x => x.areaId == submission.AreaCompetition.areaId).ToList();
            noOfCriteria = criteria.Count;
            var datatable = new DataTable();
            datatable.Columns.Add("Criteria");
            datatable.Columns.Add("Max Score");
            datatable.Columns.Add("Score");

            foreach (var criterion in criteria)
            {
                datatable.Rows.Add(criterion.criteria, criterion.maximumMarks);
            }
            bs.DataSource = datatable;  
            dgvsubmissions.DataSource = bs;
        }

        private void FrmScore_Load(object sender, EventArgs e)
        {
            int u = 2; // Specify the number of columns to make readonly

            for (int i = 0; i < u; i++)
            {
                dgvsubmissions.Columns[i].ReadOnly = true;
            }

        }

        private void dgvsubmissions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make the first u columns in dgvsubmissions readonly
            
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                foreach(DataGridViewRow row in dgvsubmissions.Rows)
                {
                    if(i < noOfCriteria)
                    {
                        var criteria = row.Cells["Criteria"].Value.ToString();
                        var maxScore = row.Cells["Max Score"].Value.ToString();
                        var score = row.Cells["Score"].Value.ToString();
                        var submissionId = common.submissionId;
                        var areaCriteriaId = context.AreaCriterias.Where(x => x.criteria == criteria && x.areaId == areaId).Select(x => x.id).FirstOrDefault();
                        var areaCompetitionId = context.CompetitorSubmissions.Where(x => x.id == submissionId).Select(x => x.areaCompetitionId).FirstOrDefault();
                        if (score == "")
                        {
                            MessageBox.Show("Please fill all the fields");
                            return;
                        }

                        if (Decimal.TryParse(score, out Decimal n) == false)
                        {
                            MessageBox.Show("Score must be a number");
                            return;
                        }

                        if (Decimal.Parse(score) > Decimal.Parse(maxScore))
                        {
                            MessageBox.Show("Score cannot be greater than maximum score");
                            return;
                        }

                        var submissionScore = new Score()
                        {
                            competitorId = competitorId,
                            areaCriteriaId = areaCriteriaId,
                            areaCompetitionId = areaCompetitionId,
                            CompetitionSubmissionId = submissionId,
                            score1 = Decimal.Parse(score)
                        };

                        context.Scores.Add(submissionScore);
                        context.SaveChanges();
                        i++;
                    }
                 
                }
                MessageBox.Show("Scores submitted successfully");
                FrmJudgingPortal frmJudgingPortal = new FrmJudgingPortal();
                frmJudgingPortal.Show();
                this.Hide();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
