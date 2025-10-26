using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GoalMaster
{
    public partial class ExportWindow : Form
    {
        public ExportWindow(string cmdDir, string fmDir, string lang, int missNumber, List<Goal> listOfGoals)
        {
            InitializeComponent();
            
            //Set values
            commandDir = cmdDir;
            fanMissionDir = fmDir;
            if (lang == "none") language = "";
            else language = lang;

            gList.Clear();
            foreach (Goal g in listOfGoals)
            {
                gList.Add(g);
            }

            cmdFilePath = Path.Combine(cmdDir, "miss" + missNumber + "goals.cmd");

            chkCMD.Text += cmdFilePath;

            goalsFilePath = Path.Combine(fmDir, "intrface", "miss" + missNumber, language, "goals.str");

            chkGoals.Text += goalsFilePath;
        }

        private string commandDir;
        private string fanMissionDir;
        private string language;
        private List<Goal> gList = new List<Goal>();

        private string cmdFilePath;

        /// <summary>
        /// Path to goals str, includes optional language subfolder and filename
        /// </summary>
        private string goalsFilePath;

        private string cmdList = "";
        private string goalList = "";

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(chkCMD.Checked) generateCMDs();
            if (chkGoals.Checked) generateGoalsSTRText();
            writeFiles();
        }

        private void generateGoalsSTRText()
        {
            StringBuilder gText = new StringBuilder();

            for (int n = 0; n < gList.Count; n++)
            {
                gText.AppendLine("fiction_" + n + ": \"" + gList[n].Fiction + "\"");
                gText.AppendLine("text_" + n + ": \"" + gList[n].Text + "\"");
            }
            goalList = gText.ToString();
        }

        private void generateCMDs()
        {
            cmdList = GoalsCMDFile.GenerateCMDString(gList);
        }

        private void writeFiles()
        {
            string userTempFolder = Path.GetTempPath();
            
            //Create .cmd file in temp dir
            string CMDShortName = Path.GetFileName(cmdFilePath);
            string tempCMDPath = Path.Combine(userTempFolder, CMDShortName);

            //Create .str file in temp
            string strShortName = Path.GetFileName(goalsFilePath);
            string tempGoalsPath = Path.Combine(userTempFolder, strShortName);

            if (cmdList != "")
            {
                File.WriteAllText(tempCMDPath, cmdList);
            }
           if (goalList != "")
            {
                File.WriteAllText(tempGoalsPath, goalList, Encoding.GetEncoding("Ibm850"));
            }

            try
            {
                if (cmdList != "")
                {
                    
                    if (!Directory.Exists(commandDir)) Directory.CreateDirectory(commandDir);    
                    File.Copy(tempCMDPath, cmdFilePath, true);
                    File.Delete(tempCMDPath);
                }
                if (goalList != "")
                {
                    string goalsDir = Path.GetDirectoryName(goalsFilePath);
                    if(!Directory.Exists(goalsDir)) Directory.CreateDirectory(goalsDir);

                    File.Copy(tempGoalsPath, goalsFilePath, true);
                    File.Delete(tempGoalsPath);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Program.copyFiles(tempCMDPath, cmdFilePath, tempGoalsPath, goalsFilePath);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
