using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace GoalMaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setWindowTitle();
            setDefaultBackColours();
        }

        public Form1(int mNumber)
        {   
            InitializeComponent();
            setWindowTitle();
            setDefaultBackColours();
            mNumFromArg = true;
            mNum = mNumber;
        }

        private void setDefaultBackColours()
        {
            defaultTextBoxBackgColour = tbFiction.BackColor;
            defaultGroupBoxBackColour = gBState.BackColor;
        }

        private void setWindowTitle()
        {
            string version = ProductVersion;
            if (version.EndsWith(".0"))
            {
                int endOf = version.LastIndexOf(".0");
                version = version.Substring(0, endOf);
            }

            Text += " " + version;
        }

        private Color defaultTextBoxBackgColour = Color.White;
        private Color defaultGroupBoxBackColour = Color.White;

        private ProgramSettings settings = new ProgramSettings();

        private string defOpenSaveDir = "";
        private string cmdFileDir = "";
        private string fmRoot = "";
        private string fmLanguage = "";

        private bool mNumFromArg = false;
        private int mNum;

        private string defSummary = "(Optional)";
        private string defObjId = "Object ID";
        private string defCretID = "Creature ID";
        private string defGold = "Gold";
        private string defGoods = "Goods";
        private string defGems = "Gems";
        private string defTotal = "Total";
        private string defSpecial = "Special";
        private string defSpecials = "Specials";
        private string defRoomID = "Room ID";

        private int type;
        private int state;

        private List<string> errorList = new List<string>();

        public List<Goal> gList = new List<Goal>();
        private List<int> existingNumbers = new List<int>();

        private const int GOAL_MAX = 31;

        private void Form1_Load(object sender, EventArgs e)
        {
            getProgramSettings();
            setUserInterfaceDefaults(true, true);
        }

        private void getProgramSettings()
        {
            settings.checkForSettings();
            defOpenSaveDir = settings.DefaultOpenSavePath;
            cmdFileDir = settings.CmdPath;
            fmRoot = settings.FMRoot;
            fmLanguage = settings.Language;

            if (Directory.Exists(defOpenSaveDir))
            {
                openFileDialog1.InitialDirectory = defOpenSaveDir;
                openForImport.InitialDirectory = defOpenSaveDir;
                openLegacyFileDialog.InitialDirectory = defOpenSaveDir;
                saveFileDialog1.InitialDirectory = defOpenSaveDir;
            }
        }

        private void setUserInterfaceDefaults(bool setGoalNumber, bool setMissNumber)
        {
            if (setMissNumber)
                if (mNumFromArg) udMissNumber.Value = mNum;
                else udMissNumber.Value = 17;
            if (setGoalNumber)
                cbGoalNumber.SelectedIndex = 0;
            tbFiction.Text = "";
            tbText.Text = "";
            tbSummary.Text = defSummary;
            rdoSteal.Checked = true;
            rdoNone.Checked = true;
            setStealDefault();
            setKillDefault();
            setLootDefaults();
            setRoomDefault();
            rdoIncomplete.Checked = true;
            rdoVisible.Checked = true;
            chkBonus.Checked = false;
            chkFinal.Checked = false;
            chkIrreversible.Checked = false;
            chkOptional.Checked = false;
            chkReverse.Checked = false;
            cbMinDiff.SelectedIndex = 0;
            cbMaxDiff.SelectedIndex = 2;
        }

        private void setStealDefault()
        {
            tbObjectID.Text = defObjId;
        }

        private void setKillDefault()
        {
            tbCreratureID.Text = defCretID;
        }

        private void setLootDefaults()
        {
            tbGold.Text = defGold;
            tbGems.Text = defGems;
            tbGoods.Text = defGoods;
            tbTotal.Text = defTotal;
            tbT1Special.Text = defSpecial;
            cbT2Special.SelectedIndex = 0;
            tbT2Specials.Text = defSpecials;
        }

        private void setRoomDefault()
        {
            tbRoomID.Text = defRoomID;
        }

        private void rdoSteal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSteal.Checked)
            {
                tbObjectID.Enabled = true;
                type = 1;
            }
            else tbObjectID.Enabled = false;
        }

        private void rdoKill_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoKill.Checked)
            {
                tbCreratureID.Enabled = true;
                type = 2;
            }
            else tbCreratureID.Enabled = false;
        }

        private void rdoLoot_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLoot.Checked)
            {
                setLootFields(true);
                type = 3;
            }
            else setLootFields(false);
        }

        private void setLootFields(bool enableState)
        {
            tbGold.Enabled = enableState;
            tbGems.Enabled = enableState;
            tbGoods.Enabled = enableState;
            tbTotal.Enabled = enableState;
            chkT1GSpecial.Enabled = enableState;
            if (enableState == false)
            {
                lblT1G.Enabled = false;
                tbT1Special.Enabled = false;

                lblT2.Enabled = false;
                cbT2Special.Enabled = false;
                tbT2Specials.Enabled = false;
            }
            else
                setSpecialState();
        }

        private void rdoGoto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGoto.Checked)
            {
                tbRoomID.Enabled = true;
                type = 4;
            }
            else tbRoomID.Enabled = false;
        }

        private void rdoNone_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNone.Checked) type = 0;
        }

        private void btnUpdateList_Click(object sender, EventArgs e)
        {
          addGoalFromUItoGoalList();
        }

        private void addGoalFromUItoGoalList()
        {
            errorList.Clear();

            int currentGoalNumber = Convert.ToInt32(cbGoalNumber.SelectedIndex);

            Goal newGoal = new Goal();
            newGoal.SkipGoal = chkSkipGoal.Checked;
            newGoal.Number = currentGoalNumber;
            
            newGoal.Fiction = tbFiction.Text;
            newGoal.Text = tbText.Text;
            newGoal.Summary = tbSummary.Text;

            newGoal.Type = type;

            //Set target/loot values
            int target;
            if (type == 1)
            {
                Int32.TryParse(tbObjectID.Text, out target);
                if (target == 0) errorList.Add("Object ID is not a number above 0 (or below 0 for archetypes).");
                else newGoal.Target = target;
            }
            else if (type == 2)
            {
                Int32.TryParse(tbCreratureID.Text, out target);
                if (target == 0)
                    errorList.Add("Creature ID is not a number above 0 (or below 0 for archetypes).");
                else newGoal.Target = target;
            }
            else if (type == 3)
            {
                newGoal.T1Special = chkT1GSpecial.Checked;
                lootValues lt = getLootValues(!chkT1GSpecial.Checked);
                newGoal.Gold = lt.gold;
                newGoal.Gems = lt.gems;
                newGoal.Goods = lt.goods;
                newGoal.Loot = lt.loot;
                newGoal.Special = lt.special;
                newGoal.Specials = lt.specials;

                if (lt.gold + lt.gems + lt.goods + lt.loot + lt.special + lt.specials == 0)
                    errorList.Add("No loot values have been set.");
            }
            else if (type == 4)
            {
                Int32.TryParse(tbRoomID.Text, out target);
                if (target == 0)
                    errorList.Add("Room ID is not a number above 0.");
                else newGoal.Target = target;
            }

            newGoal.State = state;
            if (rdoVisible.Checked) newGoal.Visible = 1;
            else newGoal.Visible = 0;

            //Other flags
            if (chkReverse.Checked) newGoal.Reverse = 1;
            else newGoal.Reverse = 0;
            if (chkOptional.Checked) newGoal.Optional = 1;
            else newGoal.Optional = 0;
            if (chkBonus.Checked) newGoal.Bonus = 1;
            else newGoal.Bonus = 0;
            if (chkFinal.Checked) newGoal.Final = 1;
            else newGoal.Final = 0;
            if (chkIrreversible.Checked) newGoal.Irreversible = 1;
            else newGoal.Irreversible = 0;

            //Difficulty
            if (cbMinDiff.SelectedIndex <= cbMaxDiff.SelectedIndex)
            {
                newGoal.MinDiff = cbMinDiff.SelectedIndex;
                newGoal.MaxDiff = cbMaxDiff.SelectedIndex;
            }
            else errorList.Add("Min diff is greater than Max diff.");

            //Check for errors
            if (errorList.Count > 0)
            {
                StringBuilder eList = new StringBuilder();
                eList.AppendLine("Errors:");
                foreach (string e in errorList)
                {
                    eList.AppendLine(e);
                }

                MessageBox.Show(eList.ToString());
            }

            else
            {
                if (currentGoalNumber != gList.Count) //if user hasn't selected the current last goal in the comboBox
                {
                    DialogResult dR = MessageBox.Show(String.Format("Goal {0} already exists. Overwrite?", currentGoalNumber), "Er...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dR == DialogResult.Yes)
                    {
                        removeExistingGoal(currentGoalNumber);
                    }
                    else
                    {
                        goto end;
                    }
                }

                gList.Add(newGoal);
                updateListBox();
                setUserInterfaceDefaults(false, false);
                updateGoalNumbers();

            end:
                { }
            }
        }

        private void removeExistingGoal(int curGoalNumber)
        {
            gList.RemoveAt(curGoalNumber);
            updateListBox();
        }

        private void updateListBox()
        {
            gList.Sort();
            lbGoals.Items.Clear();
            
            for(int i = 0; i< gList.Count;i++)
            {
                if (gList[i].Summary != defSummary && gList[i].Summary != "") lbGoals.Items.Add(gList[i].Number + ": " + gList[i].Summary);
                else if (gList[i].Text != "") lbGoals.Items.Add(gList[i].Number + ": " + gList[i].Text);
                else if (gList[i].Fiction != "") lbGoals.Items.Add(gList[i].Number + ": " + gList[i].Fiction);
                else lbGoals.Items.Add("Goal " + gList[i].Number);
            }

            if (gList.Count > 0) exportToolStripMenuItem.Enabled = true;
            else exportToolStripMenuItem.Enabled = false;
        }

        private void updateGoalNumbers()
        {
            if (cbGoalNumber.Items.Count != GOAL_MAX)
            {
                cbGoalNumber.Items.Clear();
                for (int i = 0; i < gList.Count + 1; i++)
                {
                    cbGoalNumber.Items.Add(i);
                    cbGoalNumber.SelectedIndex = i;
                }
            }
        }

        private lootValues getLootValues(bool t2)
        {
            lootValues lt = new lootValues();

            Int32.TryParse(tbGold.Text, out lt.gold);

            Int32.TryParse(tbGems.Text, out lt.gems);

            Int32.TryParse(tbGoods.Text, out lt.goods);

            Int32.TryParse(tbTotal.Text, out lt.loot);

            if (t2)
            {
                lt.special = cbT2Special.SelectedIndex;
                Int32.TryParse(tbT2Specials.Text, out lt.specials);
            }
            else
                Int32.TryParse(tbT1Special.Text, out lt.special);

            return lt;
        }

        private void btnResetGoal_Click(object sender, EventArgs e)
        {
            if (rdoSteal.Checked) setStealDefault();
            else if (rdoKill.Checked) setKillDefault();
            else if (rdoLoot.Checked) setLootDefaults();
            else if (rdoGoto.Checked) setRoomDefault();
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            setUserInterfaceDefaults(false, false);
        }

        private struct lootValues
        {
            public int gold;
            public int gems;
            public int goods;
            public int loot;
            public int special;
            public int specials;
        }

        private void chkT1GSpecial_CheckedChanged(object sender, EventArgs e)
        {
            setSpecialState();
        }

        private void setSpecialState()
        {
            if (chkT1GSpecial.Checked)
            {
                lblT1G.Enabled = true;
                tbT1Special.Enabled = true;

                lblT2.Enabled = false;
                cbT2Special.Enabled = false;
                tbT2Specials.Enabled = false;
            }
            else
            {
                lblT1G.Enabled = false;
                tbT1Special.Enabled = false;

                lblT2.Enabled = true;
                cbT2Special.Enabled = true;
                tbT2Specials.Enabled = true;
            }
        }

        private void rdoIncomplete_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoIncomplete.Checked) state = 0;
        }

        private void rdoComplete_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoComplete.Checked) state = 1;
        }

        private void rdoInactive_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoInactive.Checked) state = 2;
        }

        private void rdoFailed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFailed.Checked) state = 3;
        }

        private void lbGoals_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Read goal and set values of GUI controls
            setControlsFromGoal(lbGoals.SelectedIndex);
            setButtonStates();
        }
        private void cbGoalNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gList.Count > 0)
            {
                if (cbGoalNumber.SelectedIndex < gList.Count)
                    lbGoals.SetSelected(cbGoalNumber.SelectedIndex, true);
                else if (cbGoalNumber.SelectedIndex == gList.Count)
                {
                    setUserInterfaceDefaults(false, false);
                }
            }
        }

        private void setButtonStates()
        {
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnDelete.Enabled = true;

            if (lbGoals.Items.Count == 1)
            {
                btnUp.Enabled = false;
                btnDown.Enabled = false;
            }
            else if (lbGoals.SelectedIndex == 0)
            {
                btnUp.Enabled = false;
            }
            else if (lbGoals.SelectedIndex == lbGoals.Items.Count - 1)
            {
                btnDown.Enabled = false;
            }
        }

        private void setControlsFromGoal(int goalNumber)
        {
            setUserInterfaceDefaults(false, false);
            Goal selGoal;
            
            if(goalNumber == -1) selGoal = gList[gList.Count - 1];
            else selGoal = gList[lbGoals.SelectedIndex];

            cbGoalNumber.SelectedIndex = selGoal.Number;
            chkSkipGoal.Checked = selGoal.SkipGoal;
            tbFiction.Text = selGoal.Fiction;
            tbText.Text = selGoal.Text;
            tbSummary.Text = selGoal.Summary;

            //Check goal type
            switch (selGoal.Type)
            {
                case 1:
                    rdoSteal.Checked = true;
                    tbObjectID.Text = selGoal.Target.ToString();
                    break;
                case 2:
                    rdoKill.Checked = true;
                    tbCreratureID.Text = selGoal.Target.ToString();
                    break;
                case 3:
                    rdoLoot.Checked = true;
                    if (selGoal.Gold != 0)
                        tbGold.Text = selGoal.Gold.ToString();
                    if (selGoal.Gems != 0)
                        tbGems.Text = selGoal.Gems.ToString();
                    if (selGoal.Goods != 0)
                        tbGoods.Text = selGoal.Gems.ToString();
                    if (selGoal.Loot != 0)
                        tbTotal.Text = selGoal.Loot.ToString();
                    if (selGoal.T1Special)
                    {
                        chkT1GSpecial.Checked = true;
                        tbT1Special.Text = selGoal.Special.ToString();
                    }
                    else
                    {
                        chkT1GSpecial.Checked = false;
                        cbT2Special.SelectedIndex = selGoal.Special;
                        tbT2Specials.Text = selGoal.Specials.ToString();
                    }
                    break;
                case 4:
                    rdoGoto.Checked = true;
                    tbRoomID.Text = selGoal.Target.ToString();
                    break;
                default:
                    rdoNone.Checked = true;
                    break;
            }

            //Goal state
            switch (selGoal.State)
            {
                case 0:
                    rdoIncomplete.Checked = true;
                    break;
                case 1:
                    rdoComplete.Checked = true;
                    break;
                case 2:
                    rdoInactive.Checked = true;
                    break;
                case 3:
                    rdoFailed.Checked = true;
                    break;
            }

            if (selGoal.Visible == 1) rdoVisible.Checked = true;

            //Flags
            if(selGoal.Reverse == 1) chkReverse.Checked = true;
            if(selGoal.Optional == 1) chkOptional.Checked = true;
            if(selGoal.Bonus == 1) chkBonus.Checked = true;
            if(selGoal.Final == 1) chkFinal.Checked = true;
            if(selGoal.Irreversible == 1) chkIrreversible.Checked = true;

            //Visibility
            if (selGoal.Visible == 1) rdoVisible.Checked = true;
            else rdoInvisible.Checked = true;

            //Difficulty
            cbMinDiff.SelectedIndex = selGoal.MinDiff;
            cbMaxDiff.SelectedIndex = selGoal.MaxDiff;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            swapGoals(lbGoals.SelectedIndex, lbGoals.SelectedIndex - 1);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            swapGoals(lbGoals.SelectedIndex, lbGoals.SelectedIndex + 1);
        }

        private void swapGoals(int selectedGoalNumber, int newGoalNumber)
        {
            Goal selectedGoal = gList[selectedGoalNumber];
            Goal otherGoal = gList[newGoalNumber];

            int tempGoalNumber = otherGoal.Number;

            otherGoal.Number = selectedGoal.Number;

            selectedGoal.Number = tempGoalNumber;

            updateListBox();

            lbGoals.SelectedIndex = tempGoalNumber;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            removeExistingGoal(lbGoals.SelectedIndex);
            regenGoalNumbers();
            updateListBox();
            updateGoalNumbers();
        }

        //Recalculate all goal numbers from this one onwards, removing gaps
        private void regenGoalNumbers()
        {
            for (int i = 0; i < gList.Count; i++)
            {
                gList[i].Number = i;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("This will clear everything. Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dR == DialogResult.Yes)
            {
                gList.Clear();
                updateListBox();
                updateGoalNumbers();
                setUserInterfaceDefaults(true, true);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dR = openFileDialog1.ShowDialog();

            if (dR == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                GoalsData gData = GoalListJSON.GetGoalsJSON(filePath);
                loadSaveDataIntoGUI(gData);
            }
        }

        private void openLegacygmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dR = openLegacyFileDialog.ShowDialog();

            if(dR == DialogResult.OK)
            {
                GoalsData gData = getGoalsDataFromBinaryFormat(openLegacyFileDialog.FileName);
                loadSaveDataIntoGUI(gData);
            }
        }

        private GoalsData getGoalsDataFromBinaryFormat(string filepath)
        {
            FileStream fS = new FileStream(filepath, FileMode.Open);
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bF = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            object ob = bF.Deserialize(fS);
            fS.Close();

            return (GoalsData)ob;
        }

        private void loadSaveDataIntoGUI(GoalsData gData)
        {
            gList.Clear();
            foreach (Goal goal in gData.listOfGoals)
            {
                gList.Add(goal);
            }
            updateListBox();
            updateGoalNumbers();

            udMissNumber.Value = gData.missNumber;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dR = saveFileDialog1.ShowDialog();

            if (dR == DialogResult.OK)
            {
                GoalsData gData = new GoalsData();
                gData.missNumber = (int)udMissNumber.Value;
                gData.listOfGoals = gList;

                try
                {
                    GoalListJSON.SaveGoalsJSON(saveFileDialog1.FileName.Replace(".gml", ".json"), gData);
                }

                catch (UnauthorizedAccessException)
                { //do nothing
                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportWindow newExport = new ExportWindow( cmdFileDir, fmRoot, fmLanguage, (int)udMissNumber.Value, gList);
            newExport.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dR == DialogResult.Yes)
            {
                Close();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow(defOpenSaveDir, cmdFileDir, fmRoot, fmLanguage);
            DialogResult dR = settingsWindow.ShowDialog();

            if(dR == DialogResult.OK)
            {
                defOpenSaveDir = settingsWindow.DefaultOpenSavePath;
                cmdFileDir = settingsWindow.CMDPath;
                fmRoot = settingsWindow.FMRoot;
                fmLanguage = settingsWindow.Language;

                settings.SetSettings(defOpenSaveDir, cmdFileDir, fmRoot, fmLanguage);
            }
        }

        private void cbSkipGoal_CheckedChanged(object sender, EventArgs e)
        {
            setControlStyle(tbFiction);
            setControlStyle(tbText);
            setControlStyle(tbSummary);
            setControlStyle(gBGoalType);
            setControlStyle(gBState);
            setControlStyle(gBOther);
            setControlStyle(gBVisibility);
            setControlStyle(gBDifficulty);

            btnWarning.Visible = chkSkipGoal.Checked;
        }

        private void setControlStyle(Control control)
        {
            if (chkSkipGoal.Checked)
            {
                control.BackColor = Color.LightPink;
            }
            else
            {
                if(control.GetType() == typeof(TextBox))
                {
                    control.BackColor = defaultTextBoxBackgColour;
                }
                else if(control.GetType() == typeof(GroupBox))
                {
                    control.BackColor = defaultGroupBoxBackColour;
                }
            }
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The purpose of this Skip checkbox is ONLY for when the mission already has that goal defined in DromEd (or another goals .cmd file, another list from GoalMaster etc)\r\n\r\n" +
                "Thief does not support skipping goal numbers. Every number between the first and last goal HAS to be defined.", "Warning");
        }

        private void importSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dR = openForImport.ShowDialog();

            if(dR == DialogResult.OK)
            {
                GoalsData gData = new GoalsData();
                if(openForImport.FileName.ToLower().EndsWith(".gml"))
                    gData = getGoalsDataFromBinaryFormat(openForImport.FileName);
                else if(openForImport.FileName.ToLower().EndsWith(".json"))
                    gData = GoalListJSON.GetGoalsJSON(openForImport.FileName);

                ImportFromSelection goalsImport = new ImportFromSelection(gData);
                DialogResult goalsDialogResult = goalsImport.ShowDialog();
                if(goalsDialogResult == DialogResult.OK)
                {
                    listSelectedGoalsToImport(goalsImport.SelectedGoals);
                }
            }
        }

        private void listSelectedGoalsToImport(List<Goal> listOfGoals)
        {
            gList.AddRange(listOfGoals);
            
            //reset goal numbers - user may import goals 1, 4, 7 etc, this function makes all goal number contiguous
            for(int i = 0; i < gList.Count; i++)
            {
                gList[i].Number = i;
            }

            updateListBox();
            updateGoalNumbers();
        }
    }

    [Serializable]
    public class GoalsData
    {
        public int missNumber;
        public List<Goal> listOfGoals;
    }
}
