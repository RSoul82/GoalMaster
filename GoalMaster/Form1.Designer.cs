namespace GoalMaster
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gBGoalType = new System.Windows.Forms.GroupBox();
            this.chkT1GSpecial = new System.Windows.Forms.CheckBox();
            this.tbRoomID = new System.Windows.Forms.TextBox();
            this.tbCreratureID = new System.Windows.Forms.TextBox();
            this.tbObjectID = new System.Windows.Forms.TextBox();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblT1G = new System.Windows.Forms.Label();
            this.tbT1Special = new System.Windows.Forms.TextBox();
            this.cbT2Special = new System.Windows.Forms.ComboBox();
            this.tbT2Specials = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbGoods = new System.Windows.Forms.TextBox();
            this.tbGems = new System.Windows.Forms.TextBox();
            this.tbGold = new System.Windows.Forms.TextBox();
            this.rdoNone = new System.Windows.Forms.RadioButton();
            this.rdoGoto = new System.Windows.Forms.RadioButton();
            this.rdoLoot = new System.Windows.Forms.RadioButton();
            this.rdoKill = new System.Windows.Forms.RadioButton();
            this.rdoSteal = new System.Windows.Forms.RadioButton();
            this.gBState = new System.Windows.Forms.GroupBox();
            this.rdoFailed = new System.Windows.Forms.RadioButton();
            this.rdoInactive = new System.Windows.Forms.RadioButton();
            this.rdoComplete = new System.Windows.Forms.RadioButton();
            this.rdoIncomplete = new System.Windows.Forms.RadioButton();
            this.gBVisibility = new System.Windows.Forms.GroupBox();
            this.rdoVisible = new System.Windows.Forms.RadioButton();
            this.rdoInvisible = new System.Windows.Forms.RadioButton();
            this.gBOther = new System.Windows.Forms.GroupBox();
            this.chkIrreversible = new System.Windows.Forms.CheckBox();
            this.chkFinal = new System.Windows.Forms.CheckBox();
            this.chkBonus = new System.Windows.Forms.CheckBox();
            this.chkOptional = new System.Windows.Forms.CheckBox();
            this.chkReverse = new System.Windows.Forms.CheckBox();
            this.gBDifficulty = new System.Windows.Forms.GroupBox();
            this.cbMaxDiff = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMinDiff = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFiction = new System.Windows.Forms.TextBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSummary = new System.Windows.Forms.TextBox();
            this.btnUpdateList = new System.Windows.Forms.Button();
            this.btnResetGoal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbGoals = new System.Windows.Forms.ListBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGoalNumber = new System.Windows.Forms.ComboBox();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLegacygmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.udMissNumber = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkSkipGoal = new System.Windows.Forms.CheckBox();
            this.openLegacyFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openForImport = new System.Windows.Forms.OpenFileDialog();
            this.btnWarning = new System.Windows.Forms.Button();
            this.gBGoalType.SuspendLayout();
            this.gBState.SuspendLayout();
            this.gBVisibility.SuspendLayout();
            this.gBOther.SuspendLayout();
            this.gBDifficulty.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMissNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // gBGoalType
            // 
            this.gBGoalType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBGoalType.Controls.Add(this.chkT1GSpecial);
            this.gBGoalType.Controls.Add(this.tbRoomID);
            this.gBGoalType.Controls.Add(this.tbCreratureID);
            this.gBGoalType.Controls.Add(this.tbObjectID);
            this.gBGoalType.Controls.Add(this.lblT2);
            this.gBGoalType.Controls.Add(this.lblT1G);
            this.gBGoalType.Controls.Add(this.tbT1Special);
            this.gBGoalType.Controls.Add(this.cbT2Special);
            this.gBGoalType.Controls.Add(this.tbT2Specials);
            this.gBGoalType.Controls.Add(this.tbTotal);
            this.gBGoalType.Controls.Add(this.tbGoods);
            this.gBGoalType.Controls.Add(this.tbGems);
            this.gBGoalType.Controls.Add(this.tbGold);
            this.gBGoalType.Controls.Add(this.rdoNone);
            this.gBGoalType.Controls.Add(this.rdoGoto);
            this.gBGoalType.Controls.Add(this.rdoLoot);
            this.gBGoalType.Controls.Add(this.rdoKill);
            this.gBGoalType.Controls.Add(this.rdoSteal);
            this.gBGoalType.Location = new System.Drawing.Point(518, 130);
            this.gBGoalType.Name = "gBGoalType";
            this.gBGoalType.Size = new System.Drawing.Size(420, 204);
            this.gBGoalType.TabIndex = 6;
            this.gBGoalType.TabStop = false;
            this.gBGoalType.Text = "Type";
            // 
            // chkT1GSpecial
            // 
            this.chkT1GSpecial.AutoSize = true;
            this.chkT1GSpecial.Enabled = false;
            this.chkT1GSpecial.Location = new System.Drawing.Point(271, 98);
            this.chkT1GSpecial.Name = "chkT1GSpecial";
            this.chkT1GSpecial.Size = new System.Drawing.Size(112, 17);
            this.chkT1GSpecial.TabIndex = 10;
            this.chkT1GSpecial.Text = "Use T1/G Special";
            this.chkT1GSpecial.UseVisualStyleBackColor = true;
            this.chkT1GSpecial.CheckedChanged += new System.EventHandler(this.chkT1GSpecial_CheckedChanged);
            // 
            // tbRoomID
            // 
            this.tbRoomID.Enabled = false;
            this.tbRoomID.Location = new System.Drawing.Point(124, 149);
            this.tbRoomID.Name = "tbRoomID";
            this.tbRoomID.Size = new System.Drawing.Size(68, 20);
            this.tbRoomID.TabIndex = 14;
            this.tbRoomID.Text = "Room ID";
            // 
            // tbCreratureID
            // 
            this.tbCreratureID.Enabled = false;
            this.tbCreratureID.Location = new System.Drawing.Point(124, 44);
            this.tbCreratureID.Name = "tbCreratureID";
            this.tbCreratureID.Size = new System.Drawing.Size(68, 20);
            this.tbCreratureID.TabIndex = 3;
            this.tbCreratureID.Text = "Creature ID";
            // 
            // tbObjectID
            // 
            this.tbObjectID.Enabled = false;
            this.tbObjectID.Location = new System.Drawing.Point(124, 18);
            this.tbObjectID.Name = "tbObjectID";
            this.tbObjectID.Size = new System.Drawing.Size(68, 20);
            this.tbObjectID.TabIndex = 1;
            this.tbObjectID.Text = "Object ID";
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Enabled = false;
            this.lblT2.Location = new System.Drawing.Point(172, 125);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(20, 13);
            this.lblT2.TabIndex = 21;
            this.lblT2.Text = "T2";
            // 
            // lblT1G
            // 
            this.lblT1G.AutoSize = true;
            this.lblT1G.Enabled = false;
            this.lblT1G.Location = new System.Drawing.Point(159, 99);
            this.lblT1G.Name = "lblT1G";
            this.lblT1G.Size = new System.Drawing.Size(33, 13);
            this.lblT1G.TabIndex = 20;
            this.lblT1G.Text = "T1/G";
            // 
            // tbT1Special
            // 
            this.tbT1Special.Enabled = false;
            this.tbT1Special.Location = new System.Drawing.Point(197, 96);
            this.tbT1Special.Name = "tbT1Special";
            this.tbT1Special.Size = new System.Drawing.Size(68, 20);
            this.tbT1Special.TabIndex = 9;
            // 
            // cbT2Special
            // 
            this.cbT2Special.Enabled = false;
            this.cbT2Special.FormattingEnabled = true;
            this.cbT2Special.Items.AddRange(new object[] {
            "Special",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbT2Special.Location = new System.Drawing.Point(196, 122);
            this.cbT2Special.Name = "cbT2Special";
            this.cbT2Special.Size = new System.Drawing.Size(68, 21);
            this.cbT2Special.TabIndex = 11;
            // 
            // tbT2Specials
            // 
            this.tbT2Specials.Enabled = false;
            this.tbT2Specials.Location = new System.Drawing.Point(270, 122);
            this.tbT2Specials.Multiline = true;
            this.tbT2Specials.Name = "tbT2Specials";
            this.tbT2Specials.Size = new System.Drawing.Size(68, 21);
            this.tbT2Specials.TabIndex = 12;
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(345, 70);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(68, 20);
            this.tbTotal.TabIndex = 8;
            // 
            // tbGoods
            // 
            this.tbGoods.Enabled = false;
            this.tbGoods.Location = new System.Drawing.Point(271, 70);
            this.tbGoods.Name = "tbGoods";
            this.tbGoods.Size = new System.Drawing.Size(68, 20);
            this.tbGoods.TabIndex = 7;
            // 
            // tbGems
            // 
            this.tbGems.Enabled = false;
            this.tbGems.Location = new System.Drawing.Point(197, 70);
            this.tbGems.Name = "tbGems";
            this.tbGems.Size = new System.Drawing.Size(68, 20);
            this.tbGems.TabIndex = 6;
            // 
            // tbGold
            // 
            this.tbGold.Enabled = false;
            this.tbGold.Location = new System.Drawing.Point(124, 70);
            this.tbGold.Name = "tbGold";
            this.tbGold.Size = new System.Drawing.Size(68, 20);
            this.tbGold.TabIndex = 5;
            // 
            // rdoNone
            // 
            this.rdoNone.AutoSize = true;
            this.rdoNone.Location = new System.Drawing.Point(13, 177);
            this.rdoNone.Name = "rdoNone";
            this.rdoNone.Size = new System.Drawing.Size(376, 17);
            this.rdoNone.TabIndex = 15;
            this.rdoNone.TabStop = true;
            this.rdoNone.Text = "No type (for goals which are handled by QuestVarTraps or scripted events)";
            this.rdoNone.UseVisualStyleBackColor = true;
            this.rdoNone.CheckedChanged += new System.EventHandler(this.rdoNone_CheckedChanged);
            // 
            // rdoGoto
            // 
            this.rdoGoto.AutoSize = true;
            this.rdoGoto.Location = new System.Drawing.Point(13, 151);
            this.rdoGoto.Name = "rdoGoto";
            this.rdoGoto.Size = new System.Drawing.Size(106, 17);
            this.rdoGoto.TabIndex = 13;
            this.rdoGoto.TabStop = true;
            this.rdoGoto.Text = "Go to location (4)";
            this.rdoGoto.UseVisualStyleBackColor = true;
            this.rdoGoto.CheckedChanged += new System.EventHandler(this.rdoGoto_CheckedChanged);
            // 
            // rdoLoot
            // 
            this.rdoLoot.AutoSize = true;
            this.rdoLoot.Location = new System.Drawing.Point(13, 72);
            this.rdoLoot.Name = "rdoLoot";
            this.rdoLoot.Size = new System.Drawing.Size(77, 17);
            this.rdoLoot.TabIndex = 4;
            this.rdoLoot.TabStop = true;
            this.rdoLoot.Text = "Get loot (3)";
            this.rdoLoot.UseVisualStyleBackColor = true;
            this.rdoLoot.CheckedChanged += new System.EventHandler(this.rdoLoot_CheckedChanged);
            // 
            // rdoKill
            // 
            this.rdoKill.AutoSize = true;
            this.rdoKill.Location = new System.Drawing.Point(13, 46);
            this.rdoKill.Name = "rdoKill";
            this.rdoKill.Size = new System.Drawing.Size(104, 17);
            this.rdoKill.TabIndex = 2;
            this.rdoKill.TabStop = true;
            this.rdoKill.Text = "Kill a creature (2)";
            this.rdoKill.UseVisualStyleBackColor = true;
            this.rdoKill.CheckedChanged += new System.EventHandler(this.rdoKill_CheckedChanged);
            // 
            // rdoSteal
            // 
            this.rdoSteal.AutoSize = true;
            this.rdoSteal.Location = new System.Drawing.Point(13, 19);
            this.rdoSteal.Name = "rdoSteal";
            this.rdoSteal.Size = new System.Drawing.Size(111, 17);
            this.rdoSteal.TabIndex = 0;
            this.rdoSteal.TabStop = true;
            this.rdoSteal.Text = "Steal an object (1)";
            this.rdoSteal.UseVisualStyleBackColor = true;
            this.rdoSteal.CheckedChanged += new System.EventHandler(this.rdoSteal_CheckedChanged);
            // 
            // gBState
            // 
            this.gBState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBState.Controls.Add(this.rdoFailed);
            this.gBState.Controls.Add(this.rdoInactive);
            this.gBState.Controls.Add(this.rdoComplete);
            this.gBState.Controls.Add(this.rdoIncomplete);
            this.gBState.Location = new System.Drawing.Point(518, 340);
            this.gBState.Name = "gBState";
            this.gBState.Size = new System.Drawing.Size(207, 115);
            this.gBState.TabIndex = 7;
            this.gBState.TabStop = false;
            this.gBState.Text = "State";
            // 
            // rdoFailed
            // 
            this.rdoFailed.AutoSize = true;
            this.rdoFailed.Location = new System.Drawing.Point(13, 88);
            this.rdoFailed.Name = "rdoFailed";
            this.rdoFailed.Size = new System.Drawing.Size(68, 17);
            this.rdoFailed.TabIndex = 3;
            this.rdoFailed.Text = "Failed (3)";
            this.rdoFailed.UseVisualStyleBackColor = true;
            this.rdoFailed.CheckedChanged += new System.EventHandler(this.rdoFailed_CheckedChanged);
            // 
            // rdoInactive
            // 
            this.rdoInactive.AutoSize = true;
            this.rdoInactive.Location = new System.Drawing.Point(13, 65);
            this.rdoInactive.Name = "rdoInactive";
            this.rdoInactive.Size = new System.Drawing.Size(78, 17);
            this.rdoInactive.TabIndex = 2;
            this.rdoInactive.Text = "Inactive (2)";
            this.rdoInactive.UseVisualStyleBackColor = true;
            this.rdoInactive.CheckedChanged += new System.EventHandler(this.rdoInactive_CheckedChanged);
            // 
            // rdoComplete
            // 
            this.rdoComplete.AutoSize = true;
            this.rdoComplete.Location = new System.Drawing.Point(13, 42);
            this.rdoComplete.Name = "rdoComplete";
            this.rdoComplete.Size = new System.Drawing.Size(84, 17);
            this.rdoComplete.TabIndex = 1;
            this.rdoComplete.Text = "Complete (1)";
            this.rdoComplete.UseVisualStyleBackColor = true;
            this.rdoComplete.CheckedChanged += new System.EventHandler(this.rdoComplete_CheckedChanged);
            // 
            // rdoIncomplete
            // 
            this.rdoIncomplete.AutoSize = true;
            this.rdoIncomplete.Checked = true;
            this.rdoIncomplete.Location = new System.Drawing.Point(13, 19);
            this.rdoIncomplete.Name = "rdoIncomplete";
            this.rdoIncomplete.Size = new System.Drawing.Size(92, 17);
            this.rdoIncomplete.TabIndex = 0;
            this.rdoIncomplete.TabStop = true;
            this.rdoIncomplete.Text = "Incomplete (0)";
            this.rdoIncomplete.UseVisualStyleBackColor = true;
            this.rdoIncomplete.CheckedChanged += new System.EventHandler(this.rdoIncomplete_CheckedChanged);
            // 
            // gBVisibility
            // 
            this.gBVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBVisibility.Controls.Add(this.rdoVisible);
            this.gBVisibility.Controls.Add(this.rdoInvisible);
            this.gBVisibility.Location = new System.Drawing.Point(731, 340);
            this.gBVisibility.Name = "gBVisibility";
            this.gBVisibility.Size = new System.Drawing.Size(207, 69);
            this.gBVisibility.TabIndex = 8;
            this.gBVisibility.TabStop = false;
            this.gBVisibility.Text = "Visibility";
            // 
            // rdoVisible
            // 
            this.rdoVisible.AutoSize = true;
            this.rdoVisible.Checked = true;
            this.rdoVisible.Location = new System.Drawing.Point(10, 42);
            this.rdoVisible.Name = "rdoVisible";
            this.rdoVisible.Size = new System.Drawing.Size(70, 17);
            this.rdoVisible.TabIndex = 1;
            this.rdoVisible.TabStop = true;
            this.rdoVisible.Text = "Visible (1)";
            this.rdoVisible.UseVisualStyleBackColor = true;
            // 
            // rdoInvisible
            // 
            this.rdoInvisible.AutoSize = true;
            this.rdoInvisible.Location = new System.Drawing.Point(10, 19);
            this.rdoInvisible.Name = "rdoInvisible";
            this.rdoInvisible.Size = new System.Drawing.Size(78, 17);
            this.rdoInvisible.TabIndex = 0;
            this.rdoInvisible.Text = "Invisible (0)";
            this.rdoInvisible.UseVisualStyleBackColor = true;
            // 
            // gBOther
            // 
            this.gBOther.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBOther.Controls.Add(this.chkIrreversible);
            this.gBOther.Controls.Add(this.chkFinal);
            this.gBOther.Controls.Add(this.chkBonus);
            this.gBOther.Controls.Add(this.chkOptional);
            this.gBOther.Controls.Add(this.chkReverse);
            this.gBOther.Location = new System.Drawing.Point(518, 461);
            this.gBOther.Name = "gBOther";
            this.gBOther.Size = new System.Drawing.Size(207, 139);
            this.gBOther.TabIndex = 9;
            this.gBOther.TabStop = false;
            this.gBOther.Text = "Other";
            // 
            // chkIrreversible
            // 
            this.chkIrreversible.AutoSize = true;
            this.chkIrreversible.Location = new System.Drawing.Point(13, 111);
            this.chkIrreversible.Name = "chkIrreversible";
            this.chkIrreversible.Size = new System.Drawing.Size(77, 17);
            this.chkIrreversible.TabIndex = 4;
            this.chkIrreversible.Text = "Irreversible";
            this.toolTip1.SetToolTip(this.chkIrreversible, "Once this has been completed, it cannot be changed to incomplete. Useful for any " +
        "\"go to location\" goal, e.g. \"find a way in to the building\", or a \"final\" goal t" +
        "o leave the area when complete.\r\n\r\n");
            this.chkIrreversible.UseVisualStyleBackColor = true;
            // 
            // chkFinal
            // 
            this.chkFinal.AutoSize = true;
            this.chkFinal.Location = new System.Drawing.Point(13, 88);
            this.chkFinal.Name = "chkFinal";
            this.chkFinal.Size = new System.Drawing.Size(48, 17);
            this.chkFinal.TabIndex = 3;
            this.chkFinal.Text = "Final";
            this.toolTip1.SetToolTip(this.chkFinal, "Can only be marked as complete when all other compulsory goals have been complete" +
        "d. Typical use is for going to the exit point of the mission.");
            this.chkFinal.UseVisualStyleBackColor = true;
            // 
            // chkBonus
            // 
            this.chkBonus.AutoSize = true;
            this.chkBonus.Location = new System.Drawing.Point(13, 65);
            this.chkBonus.Name = "chkBonus";
            this.chkBonus.Size = new System.Drawing.Size(100, 17);
            this.chkBonus.TabIndex = 2;
            this.chkBonus.Text = "Bonus (T2 only)";
            this.chkBonus.UseVisualStyleBackColor = true;
            // 
            // chkOptional
            // 
            this.chkOptional.AutoSize = true;
            this.chkOptional.Location = new System.Drawing.Point(13, 42);
            this.chkOptional.Name = "chkOptional";
            this.chkOptional.Size = new System.Drawing.Size(109, 17);
            this.chkOptional.TabIndex = 1;
            this.chkOptional.Text = "Optional (T2 only)";
            this.toolTip1.SetToolTip(this.chkOptional, "Can be completed, but if not, will be marked as \"cancelled\" when all compulsory g" +
        "oals have been completed, allowing the mission to end.");
            this.chkOptional.UseVisualStyleBackColor = true;
            // 
            // chkReverse
            // 
            this.chkReverse.AutoSize = true;
            this.chkReverse.Location = new System.Drawing.Point(13, 20);
            this.chkReverse.Name = "chkReverse";
            this.chkReverse.Size = new System.Drawing.Size(66, 17);
            this.chkReverse.TabIndex = 0;
            this.chkReverse.Text = "Reverse";
            this.toolTip1.SetToolTip(this.chkReverse, "Changes a \"kill a creature\" goal to \"don\'t kill a creature\". Could also be used f" +
        "or \"don\'t go into this room\", etc.");
            this.chkReverse.UseVisualStyleBackColor = true;
            // 
            // gBDifficulty
            // 
            this.gBDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gBDifficulty.Controls.Add(this.cbMaxDiff);
            this.gBDifficulty.Controls.Add(this.label2);
            this.gBDifficulty.Controls.Add(this.cbMinDiff);
            this.gBDifficulty.Controls.Add(this.label1);
            this.gBDifficulty.Location = new System.Drawing.Point(731, 461);
            this.gBDifficulty.Name = "gBDifficulty";
            this.gBDifficulty.Size = new System.Drawing.Size(207, 139);
            this.gBDifficulty.TabIndex = 10;
            this.gBDifficulty.TabStop = false;
            this.gBDifficulty.Text = "Difficulty Levels";
            // 
            // cbMaxDiff
            // 
            this.cbMaxDiff.FormattingEnabled = true;
            this.cbMaxDiff.Items.AddRange(new object[] {
            "Normal",
            "Hard",
            "Expert"});
            this.cbMaxDiff.Location = new System.Drawing.Point(37, 49);
            this.cbMaxDiff.Name = "cbMaxDiff";
            this.cbMaxDiff.Size = new System.Drawing.Size(68, 21);
            this.cbMaxDiff.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max";
            // 
            // cbMinDiff
            // 
            this.cbMinDiff.FormattingEnabled = true;
            this.cbMinDiff.Items.AddRange(new object[] {
            "Normal",
            "Hard",
            "Expert"});
            this.cbMinDiff.Location = new System.Drawing.Point(37, 22);
            this.cbMinDiff.Name = "cbMinDiff";
            this.cbMinDiff.Size = new System.Drawing.Size(68, 21);
            this.cbMinDiff.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fiction";
            // 
            // tbFiction
            // 
            this.tbFiction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFiction.Location = new System.Drawing.Point(591, 56);
            this.tbFiction.Name = "tbFiction";
            this.tbFiction.Size = new System.Drawing.Size(347, 20);
            this.tbFiction.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tbFiction, "Goal text shown in the before the mission starts, and were difficulty is chosen.\r" +
        "\n");
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Location = new System.Drawing.Point(591, 82);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(347, 20);
            this.tbText.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbText, "Goal text shown during the mission.");
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Text";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Summary";
            // 
            // tbSummary
            // 
            this.tbSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSummary.Location = new System.Drawing.Point(591, 108);
            this.tbSummary.Name = "tbSummary";
            this.tbSummary.Size = new System.Drawing.Size(347, 20);
            this.tbSummary.TabIndex = 5;
            this.toolTip1.SetToolTip(this.tbSummary, "Only used in GoalMaster. Allows you to change the text shown in the goal list on " +
        "the left without affecting the mission goal text.");
            // 
            // btnUpdateList
            // 
            this.btnUpdateList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateList.Location = new System.Drawing.Point(518, 612);
            this.btnUpdateList.Name = "btnUpdateList";
            this.btnUpdateList.Size = new System.Drawing.Size(207, 27);
            this.btnUpdateList.TabIndex = 11;
            this.btnUpdateList.Text = "Update List";
            this.btnUpdateList.UseVisualStyleBackColor = true;
            this.btnUpdateList.Click += new System.EventHandler(this.btnUpdateList_Click);
            // 
            // btnResetGoal
            // 
            this.btnResetGoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetGoal.Location = new System.Drawing.Point(731, 612);
            this.btnResetGoal.Name = "btnResetGoal";
            this.btnResetGoal.Size = new System.Drawing.Size(207, 27);
            this.btnResetGoal.TabIndex = 12;
            this.btnResetGoal.Text = "Reset Target Fields";
            this.btnResetGoal.UseVisualStyleBackColor = true;
            this.btnResetGoal.Click += new System.EventHandler(this.btnResetGoal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Goals";
            // 
            // lbGoals
            // 
            this.lbGoals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGoals.FormattingEnabled = true;
            this.lbGoals.Location = new System.Drawing.Point(12, 51);
            this.lbGoals.Name = "lbGoals";
            this.lbGoals.ScrollAlwaysVisible = true;
            this.lbGoals.Size = new System.Drawing.Size(395, 628);
            this.lbGoals.TabIndex = 17;
            this.lbGoals.SelectedIndexChanged += new System.EventHandler(this.lbGoals_SelectedIndexChanged);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Enabled = false;
            this.btnUp.Location = new System.Drawing.Point(417, 52);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(89, 52);
            this.btnUp.TabIndex = 18;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Enabled = false;
            this.btnDown.Location = new System.Drawing.Point(417, 112);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(89, 52);
            this.btnDown.TabIndex = 19;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(417, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 52);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Goal Number";
            // 
            // cbGoalNumber
            // 
            this.cbGoalNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGoalNumber.FormattingEnabled = true;
            this.cbGoalNumber.Items.AddRange(new object[] {
            "0"});
            this.cbGoalNumber.Location = new System.Drawing.Point(591, 29);
            this.cbGoalNumber.Name = "cbGoalNumber";
            this.cbGoalNumber.Size = new System.Drawing.Size(55, 21);
            this.cbGoalNumber.TabIndex = 0;
            this.cbGoalNumber.SelectedIndexChanged += new System.EventHandler(this.cbGoalNumber_SelectedIndexChanged);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetAll.Location = new System.Drawing.Point(731, 645);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(207, 27);
            this.btnResetAll.TabIndex = 13;
            this.btnResetAll.Text = "Reset All Variables";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.openLegacygmlToolStripMenuItem,
            this.importSToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.ToolTipText = "Clear goals list and begin anew.";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.ToolTipText = "Open existing goals list.";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openLegacygmlToolStripMenuItem
            // 
            this.openLegacygmlToolStripMenuItem.Name = "openLegacygmlToolStripMenuItem";
            this.openLegacygmlToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.openLegacygmlToolStripMenuItem.Text = "Open Legacy (*.gml)...";
            this.openLegacygmlToolStripMenuItem.ToolTipText = "Open old format goals list.";
            this.openLegacygmlToolStripMenuItem.Click += new System.EventHandler(this.openLegacygmlToolStripMenuItem_Click);
            // 
            // importSToolStripMenuItem
            // 
            this.importSToolStripMenuItem.Name = "importSToolStripMenuItem";
            this.importSToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.importSToolStripMenuItem.Text = "Import Selection...";
            this.importSToolStripMenuItem.ToolTipText = "Import selected goals from another file.";
            this.importSToolStripMenuItem.Click += new System.EventHandler(this.importSToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.ToolTipText = "Save goals list to file.";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.exportToolStripMenuItem.Text = "Export...";
            this.exportToolStripMenuItem.ToolTipText = "Export as Dromed commands and Goals.str";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.exitToolStripMenuItem.Text = "Exit...";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Mission Number";
            // 
            // udMissNumber
            // 
            this.udMissNumber.Location = new System.Drawing.Point(359, 28);
            this.udMissNumber.Name = "udMissNumber";
            this.udMissNumber.Size = new System.Drawing.Size(48, 20);
            this.udMissNumber.TabIndex = 28;
            this.toolTip1.SetToolTip(this.udMissNumber, "This creates a folder in which Goals.str is stored, and must match the values in " +
        "Dromed: Editors > Dark Mission Description");
            this.udMissNumber.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "GoalMaster List|*.json";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "...";
            this.openFileDialog1.Filter = "GoalMaster List|*.json";
            // 
            // chkSkipGoal
            // 
            this.chkSkipGoal.AutoSize = true;
            this.chkSkipGoal.Location = new System.Drawing.Point(654, 31);
            this.chkSkipGoal.Name = "chkSkipGoal";
            this.chkSkipGoal.Size = new System.Drawing.Size(47, 17);
            this.chkSkipGoal.TabIndex = 1;
            this.chkSkipGoal.Text = "Skip";
            this.toolTip1.SetToolTip(this.chkSkipGoal, "Do not generate commands for this goal number. Only a sensible option if that goa" +
        "l is or will be defined in DromEd or another .cmd file.");
            this.chkSkipGoal.UseVisualStyleBackColor = true;
            this.chkSkipGoal.CheckedChanged += new System.EventHandler(this.cbSkipGoal_CheckedChanged);
            // 
            // openLegacyFileDialog
            // 
            this.openLegacyFileDialog.FileName = "...";
            this.openLegacyFileDialog.Filter = "Legacy GoalMaster List|*.gml";
            // 
            // openForImport
            // 
            this.openForImport.FileName = "...";
            this.openForImport.Filter = "GoalMaster List|*.json|GoalMaster List|*.gml";
            // 
            // btnWarning
            // 
            this.btnWarning.Image = global::GoalMaster.Properties.Resources.gWarningIcon12x12;
            this.btnWarning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWarning.Location = new System.Drawing.Point(708, 30);
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.Size = new System.Drawing.Size(229, 21);
            this.btnWarning.TabIndex = 2;
            this.btnWarning.Text = "Heed the warning...!";
            this.btnWarning.UseVisualStyleBackColor = true;
            this.btnWarning.Visible = false;
            this.btnWarning.Click += new System.EventHandler(this.btnWarning_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnUpdateList;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 698);
            this.Controls.Add(this.btnWarning);
            this.Controls.Add(this.chkSkipGoal);
            this.Controls.Add(this.udMissNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lbGoals);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnResetGoal);
            this.Controls.Add(this.btnUpdateList);
            this.Controls.Add(this.cbGoalNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSummary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFiction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gBDifficulty);
            this.Controls.Add(this.gBOther);
            this.Controls.Add(this.gBVisibility);
            this.Controls.Add(this.gBState);
            this.Controls.Add(this.gBGoalType);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(810, 737);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoalMaster";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBGoalType.ResumeLayout(false);
            this.gBGoalType.PerformLayout();
            this.gBState.ResumeLayout(false);
            this.gBState.PerformLayout();
            this.gBVisibility.ResumeLayout(false);
            this.gBVisibility.PerformLayout();
            this.gBOther.ResumeLayout(false);
            this.gBOther.PerformLayout();
            this.gBDifficulty.ResumeLayout(false);
            this.gBDifficulty.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udMissNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBGoalType;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbGoods;
        private System.Windows.Forms.TextBox tbGems;
        private System.Windows.Forms.TextBox tbGold;
        private System.Windows.Forms.RadioButton rdoNone;
        private System.Windows.Forms.RadioButton rdoGoto;
        private System.Windows.Forms.RadioButton rdoLoot;
        private System.Windows.Forms.RadioButton rdoKill;
        private System.Windows.Forms.RadioButton rdoSteal;
        private System.Windows.Forms.TextBox tbT2Specials;
        private System.Windows.Forms.ComboBox cbT2Special;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblT1G;
        private System.Windows.Forms.TextBox tbT1Special;
        private System.Windows.Forms.TextBox tbCreratureID;
        private System.Windows.Forms.TextBox tbObjectID;
        private System.Windows.Forms.TextBox tbRoomID;
        private System.Windows.Forms.GroupBox gBState;
        private System.Windows.Forms.RadioButton rdoFailed;
        private System.Windows.Forms.RadioButton rdoInactive;
        private System.Windows.Forms.RadioButton rdoComplete;
        private System.Windows.Forms.RadioButton rdoIncomplete;
        private System.Windows.Forms.GroupBox gBVisibility;
        private System.Windows.Forms.RadioButton rdoVisible;
        private System.Windows.Forms.RadioButton rdoInvisible;
        private System.Windows.Forms.GroupBox gBOther;
        private System.Windows.Forms.CheckBox chkIrreversible;
        private System.Windows.Forms.CheckBox chkFinal;
        private System.Windows.Forms.CheckBox chkBonus;
        private System.Windows.Forms.CheckBox chkOptional;
        private System.Windows.Forms.CheckBox chkReverse;
        private System.Windows.Forms.GroupBox gBDifficulty;
        private System.Windows.Forms.ComboBox cbMaxDiff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMinDiff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFiction;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSummary;
        private System.Windows.Forms.Button btnUpdateList;
        private System.Windows.Forms.Button btnResetGoal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbGoals;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGoalNumber;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.CheckBox chkT1GSpecial;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown udMissNumber;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkSkipGoal;
        private System.Windows.Forms.Button btnWarning;
        private System.Windows.Forms.ToolStripMenuItem openLegacygmlToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openLegacyFileDialog;
        private System.Windows.Forms.ToolStripMenuItem importSToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openForImport;
    }
}

