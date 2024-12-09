using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wsc2020Day2Session2App
{
    public partial class FrmCompetitorManagementScreen : Form
    {
        Wsc2020Day2Session2DbContext context = new Wsc2020Day2Session2DbContext();
        BindingSource bs = new BindingSource();
        public FrmCompetitorManagementScreen()
        {
            InitializeComponent();
            getdata();
            dgvcompetitor.AllowUserToOrderColumns = true;
            dgvcompetitor.AllowUserToResizeColumns = true;
            dgvcompetitor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            DataGridViewLinkColumn editLink = new DataGridViewLinkColumn();
            editLink.UseColumnTextForLinkValue = true;
            editLink.HeaderText = "Edit";
            editLink.DataPropertyName = "lnkColumn";
            editLink.Name = "Edit";
            editLink.LinkBehavior = LinkBehavior.SystemDefault;
            editLink.Text = "Edit";
            dgvcompetitor.Columns.Add(editLink);


            DataGridViewLinkColumn deleteLink = new DataGridViewLinkColumn();
            deleteLink.UseColumnTextForLinkValue = true;
            deleteLink.HeaderText = "Delete";
            deleteLink.Name = "Delete";
            deleteLink.DataPropertyName = "lnkColumn";
            deleteLink.LinkBehavior = LinkBehavior.SystemDefault;
            deleteLink.Text = "Delete";
            dgvcompetitor.Columns.Add(deleteLink);

         
        }

        public void getdata()
        {
            var competitor = context.Users
                .Where(x => x.userTypeId == 2)
                 .Select(x => new
                 {
                     x.id,
                     x.UserType.userTypeName,
                     x.areaId,
                     x.Area.area1,
                     x.name,
                     x.password,
                 })
                .ToList();
            bs.DataSource = competitor;
            dgvcompetitor.DataSource = bs;


        }
        private void dgvjudges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvcompetitor.Columns["Edit"].Index)
                {
                    var competitorId = dgvcompetitor.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    common.userId = competitorId;
                    FrmEditUser frmJudge = new FrmEditUser();
                    frmJudge.Show();
                    this.Hide();

                }
                else if (e.ColumnIndex == dgvcompetitor.Columns["Delete"].Index)
                {
                    var judgeId = dgvcompetitor.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    var judge = context.Users.Where(x => x.id == judgeId).FirstOrDefault();
                    context.Users.Remove(judge);
                    context.SaveChanges();
                    MessageBox.Show("Competitor Deleted Successfully");

                    getdata();
                }
                else if (e.ColumnIndex == dgvcompetitor.Columns["Report"].Index)
                {
                    var list = new List<List<string>>();


                    var competitorId = dgvcompetitor.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    var competitor = context.Users.Where(x => x.id == competitorId).FirstOrDefault();
                    var submissionId = common.submissionId;
                    var submissions = context.CompetitorSubmissions.Where(x => x.competitorId == competitorId).ToList();

                    var areaId = context.Users.Where(x => x.id == competitorId).Select(x => x.areaId).FirstOrDefault();
                    var criteria = context.AreaCriterias.Where(x => x.areaId == areaId).ToList();

                    var headers = new List<string> { "Area", "Round", "Participant Name" };

                    var rounds = context.AreaCompetitions.Where(x => x.areaId == areaId).ToList();

                    foreach(var criterion in criteria)
                    {
                        headers.Add(criterion.criteria);
                        headers.Add("Score");
                    }
                    list.Add(headers);
                    foreach (var round in rounds)
                    {
                        var data = new List<string> { competitor.Area.area1, round.round, competitor.name };


                        foreach (var criterion in criteria)
                        {
                            
                            var creteriaName = criterion.criteria;
                            var scoreForCriterion = context.Scores.Where(x => x.CompetitorSubmission.competitorId == competitorId && x.areaCompetitionId == round.id && x.areaCriteriaId == criterion.id).Select(x => x.score1).FirstOrDefault();
                            data.Add(creteriaName);
                            data.Add(scoreForCriterion.ToString());
                        }
                        list.Add(data);
                    }

                    

                    var filePath = $"ASC2020_Competition_Score_Report_{competitorId}.csv";
                    
                    CreateCsvFile(filePath, list);
                    OpenCsvFile(filePath);


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error occured due to misclick");
            }
          
        }


        static void CreateCsvFile(string filePath, List<List<string>> data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var row in data)
                    {
                        // Join each row's elements with commas and write to the file
                        writer.WriteLine(string.Join(",", row));
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex}");
            }
            

            Console.WriteLine($"CSV file created at {filePath}");
        }

        static void OpenCsvFile(string filePath)
        {
            try
            {
                // Open the CSV file with the default application
                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true // This opens the file with the default program
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while trying to open the CSV file: " + ex.Message);
            }
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            FrmCreateUser frmCreateUser = new FrmCreateUser();
            frmCreateUser.Show();
            this.Hide();
        }

        private void btnjudgementmanagement_Click(object sender, EventArgs e)
        {
            FrmJudgementManagement frmJudgementManagement = new FrmJudgementManagement();  
            frmJudgementManagement.Show();
            this.Hide();
        }

        private void btngeneratereport_Click(object sender, EventArgs e)
        {
            var list = new List<List<string>>();


            var competitorsParticipated = context.Scores.Select(x => x.competitorId).Distinct().ToList();

            var competitors = context.Users
                .Where(x => x.userTypeId == 2)
                .Where(x => competitorsParticipated.Contains(x.id))
                .OrderBy(x => x.Area.area1)
                .ToList();

            var areas = context.Areas.ToList();
            var addHeaders = true;

            foreach ( var area in areas )
            {
                foreach (var c in competitors)
                {
                    if (c.areaId != area.id)
                    {
                        continue;
                    }
                    else
                    {
                        decimal totalScore = 0;
                        var competitorId = c.id;
                        var competitor = context.Users.Where(x => x.id == competitorId).FirstOrDefault();
                        var submissionId = common.submissionId;
                        var submissions = context.CompetitorSubmissions.Where(x => x.competitorId == competitorId).ToList();

                        var areaId = context.Users.Where(x => x.id == competitorId).Select(x => x.areaId).FirstOrDefault();
                        var criteria = context.AreaCriterias.Where(x => x.areaId == areaId).ToList();

                        var headers = new List<string> { "Area", "Round", "Participant Name" };


                        var rounds = context.AreaCompetitions.Where(x => x.areaId == areaId).ToList();

                        if(addHeaders)
                        {
                            foreach (var criterion in criteria)
                            {
                                headers.Add(criterion.criteria);
                                headers.Add("Score");
                            }
                            headers.Add("Total Score");
                            list.Add(headers);
                            addHeaders = false;
                        }

                      
                        foreach (var round in rounds)
                        {
                            var checkrounds = context.Scores.Where(x => x.areaCompetitionId == round.id && x.competitorId == competitorId).Any();
                            
                            if (checkrounds)
                            {
                                var data = new List<string> { competitor.Area.area1, round.round, competitor.name };


                                foreach (var criterion in criteria)
                                {

                                    var creteriaName = criterion.criteria;
                                    var scoreForCriterion = context.Scores.Where(x => x.CompetitorSubmission.competitorId == competitorId && x.areaCompetitionId == round.id && x.areaCriteriaId == criterion.id).Select(x => x.score1).FirstOrDefault();
                                    data.Add(creteriaName);
                                    data.Add(scoreForCriterion.ToString());
                                    totalScore += scoreForCriterion;
                                }
                                data.Add(totalScore.ToString());
                                list.Add(data);
                                totalScore = 0;
                            }

                            
                        }
                    }


                  

                }
                addHeaders = true;
            }

            





            var filePath = $"ASC2020_Competition_Score_Report.csv";

            CreateCsvFile(filePath, list);
            OpenCsvFile(filePath);

        }
    }
}
