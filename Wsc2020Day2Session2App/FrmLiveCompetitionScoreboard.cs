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
    public partial class FrmLiveCompetitionScoreboard : Form
    {
        Wsc2020Day2Session2DbContext context = new Wsc2020Day2Session2DbContext();
        BindingSource bs = new BindingSource();
        public FrmLiveCompetitionScoreboard()
        {
            InitializeComponent();
            var skillareas = context.Areas.ToList();
            cbskillarea.Items.AddRange(skillareas.Select(x => x.area1).ToArray());
            cbskillarea.SelectedIndex = 0;
            Timer timer = new Timer();


            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            getData();
        }

        public class displayScoreboard
        {
            public string Rank { get; set; }
            public string Competitor { get; set; }
            public int JudgingRoundsCompleted { get; set; }
            public decimal OverallScore { get; set; }
        }

        public void getData()
        {
            var areaId = context.Areas.Where(x => x.area1 == cbskillarea.SelectedItem.ToString()).Select(x => x.id).FirstOrDefault();
            var competitors = context.Users.Where(x => x.areaId == areaId).Select(x => x.id).ToList();
            var criteria = context.AreaCriterias.Where(x => x.areaId == areaId).ToList();
            var displayList = new List<displayScoreboard>();
            var datatable = new DataTable();
            

            datatable.Columns.Add("Rank");
            datatable.Columns.Add("Competitor");
            datatable.Columns.Add("Judging Rounds Completed");
            datatable.Columns.Add("OverallScore");

            foreach (var competitor in competitors)
            {
                var competitorName = context.Users.Where(x => x.id == competitor).Select(x => x.name).FirstOrDefault();
                var rounds = context.AreaCompetitions.Where(x => x.areaId == areaId).Select(x => x.round).ToList();
                var roundsCompleted = context.CompetitorSubmissions.Where(x => x.competitorId == competitor).Select(x => x.areaCompetitionId).Count();

                var scoreList = context.Scores.Where(x => x.CompetitorSubmission.competitorId == competitor).Select(x => x.score1).ToList();
                decimal totalScore = 0;
                if (scoreList.Count > 0)
                {
                    totalScore = scoreList.Sum();
                }

                var display = new displayScoreboard()
                {
                    Rank = "",
                    Competitor = competitorName,
                    JudgingRoundsCompleted = (int)roundsCompleted,
                    OverallScore = (decimal)totalScore
                };
                
                displayList.Add(display);
            }

            int i = 1;

            foreach (var display in displayList.OrderByDescending(x=>x.OverallScore).ThenByDescending(x=>x.JudgingRoundsCompleted))
            {
                datatable.Rows.Add(i, display.Competitor, $"{display.JudgingRoundsCompleted}/{criteria.Count}", display.OverallScore);
                i++;
            }
            bs.DataSource = datatable;
            dgvcompetitors.DataSource = bs;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvcompetitors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbskillarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            getData();

        }
    }
}
