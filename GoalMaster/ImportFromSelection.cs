using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoalMaster
{
    public partial class ImportFromSelection : Form
    {
        private GoalsData goalData;
        private List<Goal> allGoals;
        private List<Goal> selectedGoals;
        public ImportFromSelection(GoalsData gData)
        {
            InitializeComponent();
            goalData = gData;
        }
        private void ImportFromSelection_Load(object sender, EventArgs e)
        {
            listGoals();
        }
        private void listGoals()
        {
            allGoals = goalData.listOfGoals;
            foreach (Goal currentGoal in allGoals)
            {
                string goalText = getGoalText(currentGoal);
                lbGoals.Items.Add(goalText);
            }
        }

        private string getGoalText(Goal goal)
        {
            if (goal.Summary != "(Optional)")
                return goal.Summary;
            else if (goal.Fiction != "")
                return goal.Fiction;
            else if (goal.Text != "")
                return goal.Text;
            else return "Goal " + goal.Number + " (no text set)";
        }

        private void lbGoals_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection sel = lbGoals.SelectedIndices;
            selectedGoals = new List<Goal>();
            foreach (int i in sel)
            {
                selectedGoals.Add(allGoals[i]);
            }
        }

        public List<Goal> SelectedGoals
        {
            get
            {
                return selectedGoals;
            }
        }
    }
}
