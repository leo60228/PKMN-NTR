﻿namespace ntrbase
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtLog = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.disconnectTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.host = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.versionCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.moneyNum = new System.Windows.Forms.NumericUpDown();
            this.milesNum = new System.Windows.Forms.NumericUpDown();
            this.bpNum = new System.Windows.Forms.NumericUpDown();
            this.pokeMoney = new System.Windows.Forms.Button();
            this.pokeMiles = new System.Windows.Forms.Button();
            this.pokeBP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dumpBox = new System.Windows.Forms.GroupBox();
            this.radioBattleBox = new System.Windows.Forms.RadioButton();
            this.label50 = new System.Windows.Forms.Label();
            this.onlyView = new System.Windows.Forms.CheckBox();
            this.radioParty = new System.Windows.Forms.RadioButton();
            this.radioTrade = new System.Windows.Forms.RadioButton();
            this.radioOpponent = new System.Windows.Forms.RadioButton();
            this.radioDaycare = new System.Windows.Forms.RadioButton();
            this.radioBoxes = new System.Windows.Forms.RadioButton();
            this.dumpBoxes = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nameek6 = new System.Windows.Forms.TextBox();
            this.dumpek6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.slotDump = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.boxDump = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label44 = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.move4 = new System.Windows.Forms.ComboBox();
            this.ability = new System.Windows.Forms.ComboBox();
            this.move3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.move2 = new System.Windows.Forms.ComboBox();
            this.species = new System.Windows.Forms.ComboBox();
            this.move1 = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.evSPENum = new System.Windows.Forms.NumericUpDown();
            this.evSPDNum = new System.Windows.Forms.NumericUpDown();
            this.heldItem = new System.Windows.Forms.ComboBox();
            this.evSPANum = new System.Windows.Forms.NumericUpDown();
            this.evDEFNum = new System.Windows.Forms.NumericUpDown();
            this.evATKNum = new System.Windows.Forms.NumericUpDown();
            this.evHPNum = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.isEgg = new System.Windows.Forms.CheckBox();
            this.ivSPENum = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.ivSPDNum = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.ivSPANum = new System.Windows.Forms.NumericUpDown();
            this.nature = new System.Windows.Forms.ComboBox();
            this.ivDEFNum = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.ivATKNum = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.ivHPNum = new System.Windows.Forms.NumericUpDown();
            this.hiddenPower = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.nickname = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.Lang = new System.Windows.Forms.ComboBox();
            this.pokeLang = new System.Windows.Forms.Button();
            this.pokeSID = new System.Windows.Forms.Button();
            this.SIDNum = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pokeTID = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.TIDNum = new System.Windows.Forms.NumericUpDown();
            this.secNum = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.minNum = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.pokeTime = new System.Windows.Forms.Button();
            this.pokeName = new System.Windows.Forms.Button();
            this.hourNum = new System.Windows.Forms.NumericUpDown();
            this.playerName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.showKeys = new System.Windows.Forms.Button();
            this.showBerries = new System.Windows.Forms.Button();
            this.showTMs = new System.Windows.Forms.Button();
            this.showMedicine = new System.Windows.Forms.Button();
            this.showItems = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.itemAdd = new System.Windows.Forms.Button();
            this.itemWrite = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.deleteAmount = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.delPkm = new System.Windows.Forms.Button();
            this.deleteBox = new System.Windows.Forms.NumericUpDown();
            this.deleteSlot = new System.Windows.Forms.NumericUpDown();
            this.clonePkm = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.cloneFF = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.fromFile = new System.Windows.Forms.RadioButton();
            this.label39 = new System.Windows.Forms.Label();
            this.chooseCloneFF = new System.Windows.Forms.Button();
            this.clonefromSlotFB = new System.Windows.Forms.NumericUpDown();
            this.cloneAmountFF = new System.Windows.Forms.NumericUpDown();
            this.clonetoBoxFB = new System.Windows.Forms.NumericUpDown();
            this.fromBoxes = new System.Windows.Forms.RadioButton();
            this.clonetoSlotFB = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.cloneAmountFB = new System.Windows.Forms.NumericUpDown();
            this.clonetoSlotFF = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.clonetoBoxFF = new System.Windows.Forms.NumericUpDown();
            this.clonefromBoxFB = new System.Windows.Forms.NumericUpDown();
            this.cloneFB = new System.Windows.Forms.Button();
            this.dTIDNum = new System.Windows.Forms.NumericUpDown();
            this.dSIDNum = new System.Windows.Forms.NumericUpDown();
            this.dPID = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.otName = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.setShiny = new System.Windows.Forms.Button();
            this.label51 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.friendship = new System.Windows.Forms.NumericUpDown();
            this.gender = new System.Windows.Forms.Button();
            this.randomPID = new System.Windows.Forms.Button();
            this.DumpedEdit = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.Stats = new System.Windows.Forms.TabPage();
            this.Moves = new System.Windows.Forms.TabPage();
            this.OT = new System.Windows.Forms.TabPage();
            this.xp = new System.Windows.Forms.NumericUpDown();
            this.level = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milesNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpNum)).BeginInit();
            this.dumpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slotDump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxDump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evSPENum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evSPDNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evSPANum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evDEFNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evATKNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evHPNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSPENum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSPDNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSPANum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivDEFNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivATKNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivHPNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SIDNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIDNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteSlot)).BeginInit();
            this.clonePkm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clonefromSlotFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloneAmountFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clonetoBoxFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clonetoSlotFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloneAmountFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clonetoSlotFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clonetoBoxFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clonefromBoxFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTIDNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSIDNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendship)).BeginInit();
            this.DumpedEdit.SuspendLayout();
            this.Main.SuspendLayout();
            this.Stats.SuspendLayout();
            this.Moves.SuspendLayout();
            this.OT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtLog.Location = new System.Drawing.Point(1432, 769);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLog.MaxLength = 32767000;
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(1032, 609);
            this.txtLog.TabIndex = 0;
            this.txtLog.Visible = false;
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // disconnectTimer
            // 
            this.disconnectTimer.Interval = 10000;
            this.disconnectTimer.Tick += new System.EventHandler(this.disconnectTimer_Tick);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(9, 72);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(100, 32);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(118, 72);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(104, 32);
            this.buttonDisconnect.TabIndex = 4;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // host
            // 
            this.host.Location = new System.Drawing.Point(50, 29);
            this.host.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(170, 26);
            this.host.TabIndex = 5;
            this.host.Text = "192.168.0.8";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.versionCheck);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.host);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Location = new System.Drawing.Point(1116, 486);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(231, 149);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // versionCheck
            // 
            this.versionCheck.ForeColor = System.Drawing.Color.Green;
            this.versionCheck.Location = new System.Drawing.Point(9, 106);
            this.versionCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.versionCheck.Name = "versionCheck";
            this.versionCheck.Size = new System.Drawing.Size(213, 35);
            this.versionCheck.TabIndex = 44;
            this.versionCheck.Text = "Update Available";
            this.versionCheck.UseVisualStyleBackColor = true;
            this.versionCheck.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP:";
            // 
            // moneyNum
            // 
            this.moneyNum.Enabled = false;
            this.moneyNum.Location = new System.Drawing.Point(210, 55);
            this.moneyNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.moneyNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.moneyNum.Name = "moneyNum";
            this.moneyNum.Size = new System.Drawing.Size(106, 26);
            this.moneyNum.TabIndex = 7;
            // 
            // milesNum
            // 
            this.milesNum.Enabled = false;
            this.milesNum.Location = new System.Drawing.Point(210, 129);
            this.milesNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.milesNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.milesNum.Name = "milesNum";
            this.milesNum.Size = new System.Drawing.Size(106, 26);
            this.milesNum.TabIndex = 8;
            // 
            // bpNum
            // 
            this.bpNum.Enabled = false;
            this.bpNum.Location = new System.Drawing.Point(210, 200);
            this.bpNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bpNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.bpNum.Name = "bpNum";
            this.bpNum.Size = new System.Drawing.Size(106, 26);
            this.bpNum.TabIndex = 9;
            // 
            // pokeMoney
            // 
            this.pokeMoney.Enabled = false;
            this.pokeMoney.Location = new System.Drawing.Point(326, 51);
            this.pokeMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pokeMoney.Name = "pokeMoney";
            this.pokeMoney.Size = new System.Drawing.Size(68, 35);
            this.pokeMoney.TabIndex = 10;
            this.pokeMoney.Text = "Write";
            this.pokeMoney.UseVisualStyleBackColor = true;
            this.pokeMoney.Click += new System.EventHandler(this.pokeMoney_Click);
            // 
            // pokeMiles
            // 
            this.pokeMiles.Enabled = false;
            this.pokeMiles.Location = new System.Drawing.Point(326, 125);
            this.pokeMiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pokeMiles.Name = "pokeMiles";
            this.pokeMiles.Size = new System.Drawing.Size(68, 35);
            this.pokeMiles.TabIndex = 11;
            this.pokeMiles.Text = "Write";
            this.pokeMiles.UseVisualStyleBackColor = true;
            this.pokeMiles.Click += new System.EventHandler(this.pokeMiles_Click);
            // 
            // pokeBP
            // 
            this.pokeBP.Enabled = false;
            this.pokeBP.Location = new System.Drawing.Point(326, 195);
            this.pokeBP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pokeBP.Name = "pokeBP";
            this.pokeBP.Size = new System.Drawing.Size(68, 35);
            this.pokeBP.TabIndex = 12;
            this.pokeBP.Text = "Write BP";
            this.pokeBP.UseVisualStyleBackColor = true;
            this.pokeBP.Click += new System.EventHandler(this.pokeBP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Money:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Poké Miles:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Battle Points:";
            // 
            // dumpBox
            // 
            this.dumpBox.Controls.Add(this.radioBattleBox);
            this.dumpBox.Controls.Add(this.label50);
            this.dumpBox.Controls.Add(this.onlyView);
            this.dumpBox.Controls.Add(this.radioParty);
            this.dumpBox.Controls.Add(this.radioTrade);
            this.dumpBox.Controls.Add(this.radioOpponent);
            this.dumpBox.Controls.Add(this.radioDaycare);
            this.dumpBox.Controls.Add(this.radioBoxes);
            this.dumpBox.Controls.Add(this.dumpBoxes);
            this.dumpBox.Controls.Add(this.label9);
            this.dumpBox.Controls.Add(this.nameek6);
            this.dumpBox.Controls.Add(this.dumpek6);
            this.dumpBox.Controls.Add(this.label7);
            this.dumpBox.Controls.Add(this.slotDump);
            this.dumpBox.Controls.Add(this.label8);
            this.dumpBox.Controls.Add(this.boxDump);
            this.dumpBox.Location = new System.Drawing.Point(10, 8);
            this.dumpBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dumpBox.Name = "dumpBox";
            this.dumpBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dumpBox.Size = new System.Drawing.Size(398, 202);
            this.dumpBox.TabIndex = 20;
            this.dumpBox.TabStop = false;
            this.dumpBox.Text = "Dump and Edit Pokémon";
            // 
            // radioBattleBox
            // 
            this.radioBattleBox.AutoSize = true;
            this.radioBattleBox.Enabled = false;
            this.radioBattleBox.Location = new System.Drawing.Point(208, 134);
            this.radioBattleBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBattleBox.Name = "radioBattleBox";
            this.radioBattleBox.Size = new System.Drawing.Size(107, 24);
            this.radioBattleBox.TabIndex = 99;
            this.radioBattleBox.Text = "Battle Box";
            this.radioBattleBox.UseVisualStyleBackColor = true;
            this.radioBattleBox.CheckedChanged += new System.EventHandler(this.radioBattleBox_CheckedChanged);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(286, 165);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(76, 20);
            this.label50.TabIndex = 97;
            this.label50.Text = "Only Edit:";
            // 
            // onlyView
            // 
            this.onlyView.AutoSize = true;
            this.onlyView.Enabled = false;
            this.onlyView.Location = new System.Drawing.Point(364, 165);
            this.onlyView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.onlyView.Name = "onlyView";
            this.onlyView.Size = new System.Drawing.Size(22, 21);
            this.onlyView.TabIndex = 96;
            this.onlyView.UseVisualStyleBackColor = true;
            this.onlyView.CheckedChanged += new System.EventHandler(this.onlyView_CheckedChanged);
            // 
            // radioParty
            // 
            this.radioParty.AutoSize = true;
            this.radioParty.Enabled = false;
            this.radioParty.Location = new System.Drawing.Point(208, 162);
            this.radioParty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioParty.Name = "radioParty";
            this.radioParty.Size = new System.Drawing.Size(70, 24);
            this.radioParty.TabIndex = 94;
            this.radioParty.Text = "Party";
            this.radioParty.UseVisualStyleBackColor = true;
            this.radioParty.Visible = false;
            this.radioParty.CheckedChanged += new System.EventHandler(this.radioParty_CheckedChanged_1);
            // 
            // radioTrade
            // 
            this.radioTrade.AutoSize = true;
            this.radioTrade.Enabled = false;
            this.radioTrade.Location = new System.Drawing.Point(10, 162);
            this.radioTrade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioTrade.Name = "radioTrade";
            this.radioTrade.Size = new System.Drawing.Size(75, 24);
            this.radioTrade.TabIndex = 43;
            this.radioTrade.TabStop = true;
            this.radioTrade.Text = "Trade";
            this.radioTrade.UseVisualStyleBackColor = true;
            this.radioTrade.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioOpponent
            // 
            this.radioOpponent.AutoSize = true;
            this.radioOpponent.Enabled = false;
            this.radioOpponent.Location = new System.Drawing.Point(102, 162);
            this.radioOpponent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioOpponent.Name = "radioOpponent";
            this.radioOpponent.Size = new System.Drawing.Size(105, 24);
            this.radioOpponent.TabIndex = 34;
            this.radioOpponent.TabStop = true;
            this.radioOpponent.Text = "Opponent";
            this.radioOpponent.UseVisualStyleBackColor = true;
            this.radioOpponent.CheckedChanged += new System.EventHandler(this.radioOpponent_CheckedChanged);
            // 
            // radioDaycare
            // 
            this.radioDaycare.AutoSize = true;
            this.radioDaycare.Enabled = false;
            this.radioDaycare.Location = new System.Drawing.Point(102, 134);
            this.radioDaycare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioDaycare.Name = "radioDaycare";
            this.radioDaycare.Size = new System.Drawing.Size(93, 24);
            this.radioDaycare.TabIndex = 33;
            this.radioDaycare.Text = "Daycare";
            this.radioDaycare.UseVisualStyleBackColor = true;
            this.radioDaycare.CheckedChanged += new System.EventHandler(this.radioDaycare_CheckedChanged);
            // 
            // radioBoxes
            // 
            this.radioBoxes.AutoSize = true;
            this.radioBoxes.Checked = true;
            this.radioBoxes.Enabled = false;
            this.radioBoxes.Location = new System.Drawing.Point(10, 134);
            this.radioBoxes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBoxes.Name = "radioBoxes";
            this.radioBoxes.Size = new System.Drawing.Size(78, 24);
            this.radioBoxes.TabIndex = 32;
            this.radioBoxes.TabStop = true;
            this.radioBoxes.Text = "Boxes";
            this.radioBoxes.UseVisualStyleBackColor = true;
            this.radioBoxes.CheckedChanged += new System.EventHandler(this.radioBoxes_CheckedChanged);
            // 
            // dumpBoxes
            // 
            this.dumpBoxes.Enabled = false;
            this.dumpBoxes.Location = new System.Drawing.Point(148, 94);
            this.dumpBoxes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dumpBoxes.Name = "dumpBoxes";
            this.dumpBoxes.Size = new System.Drawing.Size(158, 35);
            this.dumpBoxes.TabIndex = 31;
            this.dumpBoxes.Text = "Dump All Boxes";
            this.dumpBoxes.UseVisualStyleBackColor = true;
            this.dumpBoxes.Click += new System.EventHandler(this.dumpBoxes_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Filename:";
            // 
            // nameek6
            // 
            this.nameek6.Enabled = false;
            this.nameek6.Location = new System.Drawing.Point(150, 60);
            this.nameek6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameek6.Name = "nameek6";
            this.nameek6.Size = new System.Drawing.Size(152, 26);
            this.nameek6.TabIndex = 29;
            // 
            // dumpek6
            // 
            this.dumpek6.Enabled = false;
            this.dumpek6.Location = new System.Drawing.Point(10, 94);
            this.dumpek6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dumpek6.Name = "dumpek6";
            this.dumpek6.Size = new System.Drawing.Size(129, 35);
            this.dumpek6.TabIndex = 28;
            this.dumpek6.Text = "Dump";
            this.dumpek6.UseVisualStyleBackColor = true;
            this.dumpek6.Click += new System.EventHandler(this.dumpek6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Slot:";
            // 
            // slotDump
            // 
            this.slotDump.Enabled = false;
            this.slotDump.Location = new System.Drawing.Point(80, 60);
            this.slotDump.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.slotDump.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.slotDump.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.slotDump.Name = "slotDump";
            this.slotDump.Size = new System.Drawing.Size(60, 26);
            this.slotDump.TabIndex = 25;
            this.slotDump.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Box:";
            // 
            // boxDump
            // 
            this.boxDump.Enabled = false;
            this.boxDump.Location = new System.Drawing.Point(10, 60);
            this.boxDump.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxDump.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.boxDump.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.boxDump.Name = "boxDump";
            this.boxDump.Size = new System.Drawing.Size(60, 26);
            this.boxDump.TabIndex = 24;
            this.boxDump.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(207, 205);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(48, 215);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(39, 20);
            this.label44.TabIndex = 92;
            this.label44.Text = "Ball:";
            // 
            // ball
            // 
            this.ball.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ball.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ball.Enabled = false;
            this.ball.FormattingEnabled = true;
            this.ball.Items.AddRange(new object[] {
            "Master Ball",
            "Ultra Ball",
            "Great Ball",
            "Poke Ball",
            "Safari Ball",
            "Net Ball",
            "Dive Ball",
            "Nest Ball",
            "Repeat Ball",
            "Timer Ball",
            "Luxury Ball",
            "Premier Ball",
            "Dusk Ball",
            "Heal Ball",
            "Quick Ball",
            "Cherish Ball",
            "Fast Ball",
            "Level Ball",
            "Lure Ball",
            "Heavy Ball",
            "Love Ball",
            "Friend Ball",
            "Moon Ball",
            "Sport Ball",
            "Dream Ball"});
            this.ball.Location = new System.Drawing.Point(88, 208);
            this.ball.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(115, 28);
            this.ball.TabIndex = 44;
            this.ball.SelectedIndexChanged += new System.EventHandler(this.ball_SelectedIndexChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(12, 175);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(64, 20);
            this.label42.TabIndex = 91;
            this.label42.Text = "Move 4:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(10, 120);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(64, 20);
            this.label43.TabIndex = 90;
            this.label43.Text = "Move 3:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(12, 65);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(64, 20);
            this.label41.TabIndex = 89;
            this.label41.Text = "Move 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 88;
            this.label6.Text = "Move 1:";
            // 
            // move4
            // 
            this.move4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.move4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.move4.Enabled = false;
            this.move4.FormattingEnabled = true;
            this.move4.Location = new System.Drawing.Point(9, 197);
            this.move4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.move4.Name = "move4";
            this.move4.Size = new System.Drawing.Size(178, 28);
            this.move4.TabIndex = 87;
            // 
            // ability
            // 
            this.ability.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ability.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ability.Enabled = false;
            this.ability.FormattingEnabled = true;
            this.ability.Location = new System.Drawing.Point(88, 131);
            this.ability.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ability.Name = "ability";
            this.ability.Size = new System.Drawing.Size(120, 28);
            this.ability.TabIndex = 68;
            // 
            // move3
            // 
            this.move3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.move3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.move3.Enabled = false;
            this.move3.FormattingEnabled = true;
            this.move3.Location = new System.Drawing.Point(9, 142);
            this.move3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.move3.Name = "move3";
            this.move3.Size = new System.Drawing.Size(178, 28);
            this.move3.TabIndex = 86;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(302, 205);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 44;
            this.button1.Text = "Write";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.pokeEkx_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 83;
            this.label5.Text = "EVs";
            // 
            // move2
            // 
            this.move2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.move2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.move2.Enabled = false;
            this.move2.FormattingEnabled = true;
            this.move2.Location = new System.Drawing.Point(9, 86);
            this.move2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.move2.Name = "move2";
            this.move2.Size = new System.Drawing.Size(178, 28);
            this.move2.TabIndex = 85;
            // 
            // species
            // 
            this.species.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.species.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.species.Enabled = false;
            this.species.FormattingEnabled = true;
            this.species.Location = new System.Drawing.Point(88, 17);
            this.species.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.species.Name = "species";
            this.species.Size = new System.Drawing.Size(120, 28);
            this.species.TabIndex = 44;
            // 
            // move1
            // 
            this.move1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.move1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.move1.Enabled = false;
            this.move1.FormattingEnabled = true;
            this.move1.Location = new System.Drawing.Point(9, 29);
            this.move1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.move1.Name = "move1";
            this.move1.Size = new System.Drawing.Size(178, 28);
            this.move1.TabIndex = 84;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(16, 23);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(70, 20);
            this.label32.TabIndex = 43;
            this.label32.Text = "Species:";
            // 
            // evSPENum
            // 
            this.evSPENum.Enabled = false;
            this.evSPENum.Location = new System.Drawing.Point(108, 197);
            this.evSPENum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.evSPENum.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.evSPENum.Name = "evSPENum";
            this.evSPENum.Size = new System.Drawing.Size(57, 26);
            this.evSPENum.TabIndex = 82;
            // 
            // evSPDNum
            // 
            this.evSPDNum.Enabled = false;
            this.evSPDNum.Location = new System.Drawing.Point(108, 165);
            this.evSPDNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.evSPDNum.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.evSPDNum.Name = "evSPDNum";
            this.evSPDNum.Size = new System.Drawing.Size(57, 26);
            this.evSPDNum.TabIndex = 81;
            // 
            // heldItem
            // 
            this.heldItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.heldItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.heldItem.Enabled = false;
            this.heldItem.FormattingEnabled = true;
            this.heldItem.Location = new System.Drawing.Point(88, 169);
            this.heldItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.heldItem.Name = "heldItem";
            this.heldItem.Size = new System.Drawing.Size(120, 28);
            this.heldItem.TabIndex = 43;
            // 
            // evSPANum
            // 
            this.evSPANum.Enabled = false;
            this.evSPANum.Location = new System.Drawing.Point(108, 132);
            this.evSPANum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.evSPANum.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.evSPANum.Name = "evSPANum";
            this.evSPANum.Size = new System.Drawing.Size(57, 26);
            this.evSPANum.TabIndex = 80;
            // 
            // evDEFNum
            // 
            this.evDEFNum.Enabled = false;
            this.evDEFNum.Location = new System.Drawing.Point(108, 100);
            this.evDEFNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.evDEFNum.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.evDEFNum.Name = "evDEFNum";
            this.evDEFNum.Size = new System.Drawing.Size(57, 26);
            this.evDEFNum.TabIndex = 79;
            // 
            // evATKNum
            // 
            this.evATKNum.Enabled = false;
            this.evATKNum.Location = new System.Drawing.Point(108, 68);
            this.evATKNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.evATKNum.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.evATKNum.Name = "evATKNum";
            this.evATKNum.Size = new System.Drawing.Size(57, 26);
            this.evATKNum.TabIndex = 78;
            // 
            // evHPNum
            // 
            this.evHPNum.Enabled = false;
            this.evHPNum.Location = new System.Drawing.Point(108, 35);
            this.evHPNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.evHPNum.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.evHPNum.Name = "evHPNum";
            this.evHPNum.Size = new System.Drawing.Size(57, 26);
            this.evHPNum.TabIndex = 77;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(234, 143);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(38, 20);
            this.label31.TabIndex = 76;
            this.label31.Text = "Egg";
            // 
            // isEgg
            // 
            this.isEgg.AutoSize = true;
            this.isEgg.Enabled = false;
            this.isEgg.Location = new System.Drawing.Point(243, 168);
            this.isEgg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.isEgg.Name = "isEgg";
            this.isEgg.Size = new System.Drawing.Size(22, 21);
            this.isEgg.TabIndex = 74;
            this.isEgg.UseVisualStyleBackColor = true;
            // 
            // ivSPENum
            // 
            this.ivSPENum.Enabled = false;
            this.ivSPENum.Location = new System.Drawing.Point(50, 197);
            this.ivSPENum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ivSPENum.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.ivSPENum.Name = "ivSPENum";
            this.ivSPENum.Size = new System.Drawing.Size(50, 26);
            this.ivSPENum.TabIndex = 73;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(26, 98);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 20);
            this.label23.TabIndex = 59;
            this.label23.Text = "Nature:";
            // 
            // ivSPDNum
            // 
            this.ivSPDNum.Enabled = false;
            this.ivSPDNum.Location = new System.Drawing.Point(50, 165);
            this.ivSPDNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ivSPDNum.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.ivSPDNum.Name = "ivSPDNum";
            this.ivSPDNum.Size = new System.Drawing.Size(50, 26);
            this.ivSPDNum.TabIndex = 72;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(44, 177);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 20);
            this.label24.TabIndex = 61;
            this.label24.Text = "Item:";
            // 
            // ivSPANum
            // 
            this.ivSPANum.Enabled = false;
            this.ivSPANum.Location = new System.Drawing.Point(50, 132);
            this.ivSPANum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ivSPANum.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.ivSPANum.Name = "ivSPANum";
            this.ivSPANum.Size = new System.Drawing.Size(50, 26);
            this.ivSPANum.TabIndex = 71;
            // 
            // nature
            // 
            this.nature.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.nature.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nature.Enabled = false;
            this.nature.FormattingEnabled = true;
            this.nature.Items.AddRange(new object[] {
            "Hardy",
            "Lonely",
            "Brave",
            "Adamant",
            "Naughty",
            "Bold",
            "Docile",
            "Relaxed",
            "Impish",
            "Lax",
            "Timid",
            "Hasty",
            "Serious",
            "Jolly",
            "Naive",
            "Modest",
            "Mild",
            "Quiet",
            "Bashful",
            "Rash",
            "Calm",
            "Gentle",
            "Sassy",
            "Careful",
            "Quirky"});
            this.nature.Location = new System.Drawing.Point(88, 92);
            this.nature.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nature.Name = "nature";
            this.nature.Size = new System.Drawing.Size(120, 28);
            this.nature.TabIndex = 67;
            // 
            // ivDEFNum
            // 
            this.ivDEFNum.Enabled = false;
            this.ivDEFNum.Location = new System.Drawing.Point(50, 100);
            this.ivDEFNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ivDEFNum.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.ivDEFNum.Name = "ivDEFNum";
            this.ivDEFNum.Size = new System.Drawing.Size(50, 26);
            this.ivDEFNum.TabIndex = 70;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(33, 138);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 20);
            this.label25.TabIndex = 63;
            this.label25.Text = "Ability:";
            // 
            // ivATKNum
            // 
            this.ivATKNum.Enabled = false;
            this.ivATKNum.Location = new System.Drawing.Point(50, 68);
            this.ivATKNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ivATKNum.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.ivATKNum.Name = "ivATKNum";
            this.ivATKNum.Size = new System.Drawing.Size(50, 26);
            this.ivATKNum.TabIndex = 69;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(2, 62);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(83, 20);
            this.label30.TabIndex = 66;
            this.label30.Text = "Nickname:";
            // 
            // ivHPNum
            // 
            this.ivHPNum.Enabled = false;
            this.ivHPNum.Location = new System.Drawing.Point(50, 35);
            this.ivHPNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ivHPNum.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.ivHPNum.Name = "ivHPNum";
            this.ivHPNum.Size = new System.Drawing.Size(50, 26);
            this.ivHPNum.TabIndex = 68;
            // 
            // hiddenPower
            // 
            this.hiddenPower.BackColor = System.Drawing.SystemColors.Control;
            this.hiddenPower.Location = new System.Drawing.Point(266, 34);
            this.hiddenPower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hiddenPower.Name = "hiddenPower";
            this.hiddenPower.ReadOnly = true;
            this.hiddenPower.Size = new System.Drawing.Size(73, 26);
            this.hiddenPower.TabIndex = 64;
            this.hiddenPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(188, 40);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(73, 20);
            this.label29.TabIndex = 65;
            this.label29.Text = "HP Type:";
            // 
            // nickname
            // 
            this.nickname.Enabled = false;
            this.nickname.Location = new System.Drawing.Point(88, 55);
            this.nickname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(120, 26);
            this.nickname.TabIndex = 46;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 203);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 20);
            this.label22.TabIndex = 58;
            this.label22.Text = "SPE:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(2, 171);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 20);
            this.label21.TabIndex = 57;
            this.label21.Text = "SPD:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(56, 15);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 20);
            this.label16.TabIndex = 52;
            this.label16.Text = "IVs";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 74);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 20);
            this.label18.TabIndex = 54;
            this.label18.Text = "ATK:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 138);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 20);
            this.label20.TabIndex = 56;
            this.label20.Text = "SPA:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 42);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 20);
            this.label17.TabIndex = 53;
            this.label17.Text = "HP:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 106);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 20);
            this.label19.TabIndex = 55;
            this.label19.Text = "DEF:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(9, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(286, 272);
            this.dataGridView1.TabIndex = 32;
            // 
            // Item
            // 
            this.Item.Name = "Item";
            // 
            // Amount
            // 
            this.Amount.Name = "Amount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pokeMiles);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pokeBP);
            this.groupBox2.Controls.Add(this.milesNum);
            this.groupBox2.Controls.Add(this.bpNum);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.moneyNum);
            this.groupBox2.Controls.Add(this.Lang);
            this.groupBox2.Controls.Add(this.pokeMoney);
            this.groupBox2.Controls.Add(this.pokeLang);
            this.groupBox2.Controls.Add(this.pokeSID);
            this.groupBox2.Controls.Add(this.SIDNum);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.pokeTID);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.TIDNum);
            this.groupBox2.Controls.Add(this.secNum);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.minNum);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.pokeTime);
            this.groupBox2.Controls.Add(this.pokeName);
            this.groupBox2.Controls.Add(this.hourNum);
            this.groupBox2.Controls.Add(this.playerName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(944, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(404, 375);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Trainer";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(9, 243);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(85, 20);
            this.label28.TabIndex = 44;
            this.label28.Text = "Language:";
            // 
            // Lang
            // 
            this.Lang.Enabled = false;
            this.Lang.FormattingEnabled = true;
            this.Lang.Items.AddRange(new object[] {
            "JPN",
            "ENG",
            "FRE",
            "ITA",
            "GER",
            "SPA",
            "KOR"});
            this.Lang.Location = new System.Drawing.Point(14, 269);
            this.Lang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Lang.Name = "Lang";
            this.Lang.Size = new System.Drawing.Size(72, 28);
            this.Lang.TabIndex = 43;
            // 
            // pokeLang
            // 
            this.pokeLang.Enabled = false;
            this.pokeLang.Location = new System.Drawing.Point(88, 268);
            this.pokeLang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pokeLang.Name = "pokeLang";
            this.pokeLang.Size = new System.Drawing.Size(68, 35);
            this.pokeLang.TabIndex = 42;
            this.pokeLang.Text = "Write";
            this.pokeLang.UseVisualStyleBackColor = true;
            this.pokeLang.Click += new System.EventHandler(this.pokeLang_Click);
            // 
            // pokeSID
            // 
            this.pokeSID.Enabled = false;
            this.pokeSID.Location = new System.Drawing.Point(135, 195);
            this.pokeSID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pokeSID.Name = "pokeSID";
            this.pokeSID.Size = new System.Drawing.Size(68, 35);
            this.pokeSID.TabIndex = 40;
            this.pokeSID.Text = "Write";
            this.pokeSID.UseVisualStyleBackColor = true;
            this.pokeSID.Click += new System.EventHandler(this.pokeSID_Click);
            // 
            // SIDNum
            // 
            this.SIDNum.Enabled = false;
            this.SIDNum.Location = new System.Drawing.Point(14, 200);
            this.SIDNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SIDNum.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.SIDNum.Name = "SIDNum";
            this.SIDNum.Size = new System.Drawing.Size(120, 26);
            this.SIDNum.TabIndex = 39;
            this.SIDNum.ValueChanged += new System.EventHandler(this.SIDNum_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 175);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 20);
            this.label15.TabIndex = 38;
            this.label15.Text = "SID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(170, 306);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "Secs:";
            // 
            // pokeTID
            // 
            this.pokeTID.Enabled = false;
            this.pokeTID.Location = new System.Drawing.Point(135, 122);
            this.pokeTID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pokeTID.Name = "pokeTID";
            this.pokeTID.Size = new System.Drawing.Size(68, 35);
            this.pokeTID.TabIndex = 30;
            this.pokeTID.Text = "Write";
            this.pokeTID.UseVisualStyleBackColor = true;
            this.pokeTID.Click += new System.EventHandler(this.pokeTID_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(106, 306);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "Mins:";
            // 
            // TIDNum
            // 
            this.TIDNum.Enabled = false;
            this.TIDNum.Location = new System.Drawing.Point(14, 126);
            this.TIDNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TIDNum.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.TIDNum.Name = "TIDNum";
            this.TIDNum.Size = new System.Drawing.Size(120, 26);
            this.TIDNum.TabIndex = 29;
            this.TIDNum.ValueChanged += new System.EventHandler(this.TIDNum_ValueChanged);
            // 
            // secNum
            // 
            this.secNum.Enabled = false;
            this.secNum.Location = new System.Drawing.Point(171, 331);
            this.secNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secNum.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.secNum.Name = "secNum";
            this.secNum.Size = new System.Drawing.Size(52, 26);
            this.secNum.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 102);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "TID:";
            // 
            // minNum
            // 
            this.minNum.Enabled = false;
            this.minNum.Location = new System.Drawing.Point(110, 331);
            this.minNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minNum.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minNum.Name = "minNum";
            this.minNum.Size = new System.Drawing.Size(52, 26);
            this.minNum.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Name:";
            // 
            // pokeTime
            // 
            this.pokeTime.Enabled = false;
            this.pokeTime.Location = new System.Drawing.Point(225, 326);
            this.pokeTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pokeTime.Name = "pokeTime";
            this.pokeTime.Size = new System.Drawing.Size(68, 35);
            this.pokeTime.TabIndex = 33;
            this.pokeTime.Text = "Write";
            this.pokeTime.UseVisualStyleBackColor = true;
            this.pokeTime.Click += new System.EventHandler(this.pokeTime_Click);
            // 
            // pokeName
            // 
            this.pokeName.Enabled = false;
            this.pokeName.Location = new System.Drawing.Point(134, 51);
            this.pokeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pokeName.Name = "pokeName";
            this.pokeName.Size = new System.Drawing.Size(68, 35);
            this.pokeName.TabIndex = 23;
            this.pokeName.Text = "Write";
            this.pokeName.UseVisualStyleBackColor = true;
            this.pokeName.Click += new System.EventHandler(this.pokeName_Click);
            // 
            // hourNum
            // 
            this.hourNum.Enabled = false;
            this.hourNum.Location = new System.Drawing.Point(12, 331);
            this.hourNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hourNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.hourNum.Name = "hourNum";
            this.hourNum.Size = new System.Drawing.Size(88, 26);
            this.hourNum.TabIndex = 32;
            // 
            // playerName
            // 
            this.playerName.Enabled = false;
            this.playerName.Location = new System.Drawing.Point(12, 54);
            this.playerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(118, 26);
            this.playerName.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 306);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Hours:";
            // 
            // showKeys
            // 
            this.showKeys.Enabled = false;
            this.showKeys.Location = new System.Drawing.Point(298, 206);
            this.showKeys.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showKeys.Name = "showKeys";
            this.showKeys.Size = new System.Drawing.Size(172, 40);
            this.showKeys.TabIndex = 33;
            this.showKeys.Text = "KEY ITEMS";
            this.showKeys.UseVisualStyleBackColor = true;
            this.showKeys.Click += new System.EventHandler(this.showKeys_Click);
            // 
            // showBerries
            // 
            this.showBerries.Enabled = false;
            this.showBerries.Location = new System.Drawing.Point(298, 162);
            this.showBerries.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showBerries.Name = "showBerries";
            this.showBerries.Size = new System.Drawing.Size(172, 40);
            this.showBerries.TabIndex = 34;
            this.showBerries.Text = "BERRIES";
            this.showBerries.UseVisualStyleBackColor = true;
            this.showBerries.Click += new System.EventHandler(this.showBerries_Click);
            // 
            // showTMs
            // 
            this.showTMs.Enabled = false;
            this.showTMs.Location = new System.Drawing.Point(298, 117);
            this.showTMs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showTMs.Name = "showTMs";
            this.showTMs.Size = new System.Drawing.Size(172, 40);
            this.showTMs.TabIndex = 35;
            this.showTMs.Text = "TMs && HMs";
            this.showTMs.UseVisualStyleBackColor = true;
            this.showTMs.Click += new System.EventHandler(this.showTMs_Click);
            // 
            // showMedicine
            // 
            this.showMedicine.Enabled = false;
            this.showMedicine.Location = new System.Drawing.Point(298, 72);
            this.showMedicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showMedicine.Name = "showMedicine";
            this.showMedicine.Size = new System.Drawing.Size(172, 40);
            this.showMedicine.TabIndex = 36;
            this.showMedicine.Text = "MEDICINE";
            this.showMedicine.UseVisualStyleBackColor = true;
            this.showMedicine.Click += new System.EventHandler(this.showMedicine_Click);
            // 
            // showItems
            // 
            this.showItems.Enabled = false;
            this.showItems.ForeColor = System.Drawing.Color.Green;
            this.showItems.Location = new System.Drawing.Point(298, 28);
            this.showItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showItems.Name = "showItems";
            this.showItems.Size = new System.Drawing.Size(172, 40);
            this.showItems.TabIndex = 37;
            this.showItems.Text = "ITEMS";
            this.showItems.UseVisualStyleBackColor = true;
            this.showItems.Click += new System.EventHandler(this.showItems_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(9, 29);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.Size = new System.Drawing.Size(286, 272);
            this.dataGridView2.TabIndex = 38;
            this.dataGridView2.Visible = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Enabled = false;
            this.dataGridView3.Location = new System.Drawing.Point(9, 29);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.ShowEditingIcon = false;
            this.dataGridView3.Size = new System.Drawing.Size(286, 272);
            this.dataGridView3.TabIndex = 39;
            this.dataGridView3.Visible = false;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Enabled = false;
            this.dataGridView4.Location = new System.Drawing.Point(9, 29);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.ShowEditingIcon = false;
            this.dataGridView4.Size = new System.Drawing.Size(286, 272);
            this.dataGridView4.TabIndex = 40;
            this.dataGridView4.Visible = false;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AllowUserToResizeColumns = false;
            this.dataGridView5.AllowUserToResizeRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Enabled = false;
            this.dataGridView5.Location = new System.Drawing.Point(9, 29);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.ShowEditingIcon = false;
            this.dataGridView5.Size = new System.Drawing.Size(286, 272);
            this.dataGridView5.TabIndex = 41;
            this.dataGridView5.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView5);
            this.groupBox3.Controls.Add(this.itemAdd);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.dataGridView4);
            this.groupBox3.Controls.Add(this.showKeys);
            this.groupBox3.Controls.Add(this.itemWrite);
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Controls.Add(this.showBerries);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.showTMs);
            this.groupBox3.Controls.Add(this.showItems);
            this.groupBox3.Controls.Add(this.showMedicine);
            this.groupBox3.Location = new System.Drawing.Point(458, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(477, 309);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit Items";
            // 
            // itemAdd
            // 
            this.itemAdd.Enabled = false;
            this.itemAdd.Location = new System.Drawing.Point(386, 266);
            this.itemAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemAdd.Name = "itemAdd";
            this.itemAdd.Size = new System.Drawing.Size(86, 35);
            this.itemAdd.TabIndex = 46;
            this.itemAdd.Text = "Add Item";
            this.itemAdd.UseVisualStyleBackColor = true;
            this.itemAdd.Click += new System.EventHandler(this.itemAdd_Click);
            // 
            // itemWrite
            // 
            this.itemWrite.Enabled = false;
            this.itemWrite.Location = new System.Drawing.Point(298, 266);
            this.itemWrite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemWrite.Name = "itemWrite";
            this.itemWrite.Size = new System.Drawing.Size(86, 35);
            this.itemWrite.TabIndex = 43;
            this.itemWrite.Text = "Write";
            this.itemWrite.UseVisualStyleBackColor = true;
            this.itemWrite.Click += new System.EventHandler(this.itemWrite_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label38);
            this.groupBox4.Controls.Add(this.deleteAmount);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.delPkm);
            this.groupBox4.Controls.Add(this.deleteBox);
            this.groupBox4.Controls.Add(this.deleteSlot);
            this.groupBox4.Location = new System.Drawing.Point(10, 503);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(345, 132);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete Pokémon";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(242, 31);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(88, 20);
            this.label38.TabIndex = 25;
            this.label38.Text = "# to delete:";
            // 
            // deleteAmount
            // 
            this.deleteAmount.Enabled = false;
            this.deleteAmount.Location = new System.Drawing.Point(237, 55);
            this.deleteAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteAmount.Maximum = new decimal(new int[] {
            930,
            0,
            0,
            0});
            this.deleteAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deleteAmount.Name = "deleteAmount";
            this.deleteAmount.Size = new System.Drawing.Size(99, 26);
            this.deleteAmount.TabIndex = 24;
            this.deleteAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deleteAmount.ValueChanged += new System.EventHandler(this.deleteAmount_ValueChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(128, 31);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 20);
            this.label26.TabIndex = 23;
            this.label26.Text = "Slot:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 31);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 20);
            this.label27.TabIndex = 22;
            this.label27.Text = "Box:";
            // 
            // delPkm
            // 
            this.delPkm.Enabled = false;
            this.delPkm.ForeColor = System.Drawing.Color.Red;
            this.delPkm.Location = new System.Drawing.Point(9, 89);
            this.delPkm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delPkm.Name = "delPkm";
            this.delPkm.Size = new System.Drawing.Size(327, 35);
            this.delPkm.TabIndex = 17;
            this.delPkm.Text = "Delete";
            this.delPkm.UseVisualStyleBackColor = true;
            this.delPkm.Click += new System.EventHandler(this.delPkm_Click);
            // 
            // deleteBox
            // 
            this.deleteBox.Enabled = false;
            this.deleteBox.Location = new System.Drawing.Point(9, 55);
            this.deleteBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteBox.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.deleteBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(99, 26);
            this.deleteBox.TabIndex = 18;
            this.deleteBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deleteBox.ValueChanged += new System.EventHandler(this.deleteBox_ValueChanged);
            // 
            // deleteSlot
            // 
            this.deleteSlot.Enabled = false;
            this.deleteSlot.Location = new System.Drawing.Point(123, 55);
            this.deleteSlot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteSlot.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.deleteSlot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deleteSlot.Name = "deleteSlot";
            this.deleteSlot.Size = new System.Drawing.Size(99, 26);
            this.deleteSlot.TabIndex = 19;
            this.deleteSlot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deleteSlot.ValueChanged += new System.EventHandler(this.deleteSlot_ValueChanged);
            // 
            // clonePkm
            // 
            this.clonePkm.Controls.Add(this.label37);
            this.clonePkm.Controls.Add(this.label36);
            this.clonePkm.Controls.Add(this.cloneFF);
            this.clonePkm.Controls.Add(this.label40);
            this.clonePkm.Controls.Add(this.label33);
            this.clonePkm.Controls.Add(this.fromFile);
            this.clonePkm.Controls.Add(this.label39);
            this.clonePkm.Controls.Add(this.chooseCloneFF);
            this.clonePkm.Controls.Add(this.clonefromSlotFB);
            this.clonePkm.Controls.Add(this.cloneAmountFF);
            this.clonePkm.Controls.Add(this.clonetoBoxFB);
            this.clonePkm.Controls.Add(this.fromBoxes);
            this.clonePkm.Controls.Add(this.clonetoSlotFB);
            this.clonePkm.Controls.Add(this.label34);
            this.clonePkm.Controls.Add(this.cloneAmountFB);
            this.clonePkm.Controls.Add(this.clonetoSlotFF);
            this.clonePkm.Controls.Add(this.label35);
            this.clonePkm.Controls.Add(this.clonetoBoxFF);
            this.clonePkm.Controls.Add(this.clonefromBoxFB);
            this.clonePkm.Controls.Add(this.cloneFB);
            this.clonePkm.Location = new System.Drawing.Point(452, 334);
            this.clonePkm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clonePkm.Name = "clonePkm";
            this.clonePkm.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clonePkm.Size = new System.Drawing.Size(446, 166);
            this.clonePkm.TabIndex = 43;
            this.clonePkm.TabStop = false;
            this.clonePkm.Text = "Write/Clone Pokémon";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(344, 26);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(98, 20);
            this.label37.TabIndex = 47;
            this.label37.Text = "From Game:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(356, 105);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(79, 20);
            this.label36.TabIndex = 46;
            this.label36.Text = "From File:";
            // 
            // cloneFF
            // 
            this.cloneFF.Location = new System.Drawing.Point(126, 122);
            this.cloneFF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cloneFF.Name = "cloneFF";
            this.cloneFF.Size = new System.Drawing.Size(99, 35);
            this.cloneFF.TabIndex = 30;
            this.cloneFF.Text = "Clone";
            this.cloneFF.UseVisualStyleBackColor = true;
            this.cloneFF.Visible = false;
            this.cloneFF.Click += new System.EventHandler(this.cloneFF_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(130, 102);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(82, 20);
            this.label40.TabIndex = 45;
            this.label40.Text = "From Slot:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(16, 26);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(40, 20);
            this.label33.TabIndex = 37;
            this.label33.Text = "Box:";
            // 
            // fromFile
            // 
            this.fromFile.AutoSize = true;
            this.fromFile.Enabled = false;
            this.fromFile.Location = new System.Drawing.Point(412, 129);
            this.fromFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fromFile.Name = "fromFile";
            this.fromFile.Size = new System.Drawing.Size(21, 20);
            this.fromFile.TabIndex = 45;
            this.fromFile.UseVisualStyleBackColor = true;
            this.fromFile.CheckedChanged += new System.EventHandler(this.fromFile_CheckedChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(16, 102);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(81, 20);
            this.label39.TabIndex = 44;
            this.label39.Text = "From Box:";
            // 
            // chooseCloneFF
            // 
            this.chooseCloneFF.Enabled = false;
            this.chooseCloneFF.Location = new System.Drawing.Point(12, 123);
            this.chooseCloneFF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chooseCloneFF.Name = "chooseCloneFF";
            this.chooseCloneFF.Size = new System.Drawing.Size(99, 35);
            this.chooseCloneFF.TabIndex = 0;
            this.chooseCloneFF.Text = "Browse";
            this.chooseCloneFF.UseVisualStyleBackColor = true;
            this.chooseCloneFF.Visible = false;
            this.chooseCloneFF.Click += new System.EventHandler(this.chooseCloneFF_Click);
            // 
            // clonefromSlotFB
            // 
            this.clonefromSlotFB.Enabled = false;
            this.clonefromSlotFB.Location = new System.Drawing.Point(126, 126);
            this.clonefromSlotFB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clonefromSlotFB.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.clonefromSlotFB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clonefromSlotFB.Name = "clonefromSlotFB";
            this.clonefromSlotFB.Size = new System.Drawing.Size(99, 26);
            this.clonefromSlotFB.TabIndex = 33;
            this.clonefromSlotFB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cloneAmountFF
            // 
            this.cloneAmountFF.Location = new System.Drawing.Point(240, 51);
            this.cloneAmountFF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cloneAmountFF.Maximum = new decimal(new int[] {
            930,
            0,
            0,
            0});
            this.cloneAmountFF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cloneAmountFF.Name = "cloneAmountFF";
            this.cloneAmountFF.Size = new System.Drawing.Size(99, 26);
            this.cloneAmountFF.TabIndex = 31;
            this.cloneAmountFF.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cloneAmountFF.Visible = false;
            this.cloneAmountFF.ValueChanged += new System.EventHandler(this.cloneAmountFF_ValueChanged);
            // 
            // clonetoBoxFB
            // 
            this.clonetoBoxFB.Enabled = false;
            this.clonetoBoxFB.Location = new System.Drawing.Point(12, 51);
            this.clonetoBoxFB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clonetoBoxFB.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.clonetoBoxFB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clonetoBoxFB.Name = "clonetoBoxFB";
            this.clonetoBoxFB.Size = new System.Drawing.Size(99, 26);
            this.clonetoBoxFB.TabIndex = 35;
            this.clonetoBoxFB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clonetoBoxFB.ValueChanged += new System.EventHandler(this.clonetoBoxFB_ValueChanged);
            // 
            // fromBoxes
            // 
            this.fromBoxes.AutoSize = true;
            this.fromBoxes.Checked = true;
            this.fromBoxes.Enabled = false;
            this.fromBoxes.Location = new System.Drawing.Point(412, 51);
            this.fromBoxes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fromBoxes.Name = "fromBoxes";
            this.fromBoxes.Size = new System.Drawing.Size(21, 20);
            this.fromBoxes.TabIndex = 44;
            this.fromBoxes.TabStop = true;
            this.fromBoxes.UseVisualStyleBackColor = true;
            this.fromBoxes.CheckedChanged += new System.EventHandler(this.fromBoxes_CheckedChanged);
            // 
            // clonetoSlotFB
            // 
            this.clonetoSlotFB.Enabled = false;
            this.clonetoSlotFB.Location = new System.Drawing.Point(126, 51);
            this.clonetoSlotFB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clonetoSlotFB.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.clonetoSlotFB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clonetoSlotFB.Name = "clonetoSlotFB";
            this.clonetoSlotFB.Size = new System.Drawing.Size(99, 26);
            this.clonetoSlotFB.TabIndex = 36;
            this.clonetoSlotFB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clonetoSlotFB.ValueChanged += new System.EventHandler(this.clonetoSlotFB_ValueChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(130, 26);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(41, 20);
            this.label34.TabIndex = 38;
            this.label34.Text = "Slot:";
            // 
            // cloneAmountFB
            // 
            this.cloneAmountFB.Enabled = false;
            this.cloneAmountFB.Location = new System.Drawing.Point(240, 51);
            this.cloneAmountFB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cloneAmountFB.Maximum = new decimal(new int[] {
            930,
            0,
            0,
            0});
            this.cloneAmountFB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cloneAmountFB.Name = "cloneAmountFB";
            this.cloneAmountFB.Size = new System.Drawing.Size(99, 26);
            this.cloneAmountFB.TabIndex = 40;
            this.cloneAmountFB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cloneAmountFB.ValueChanged += new System.EventHandler(this.cloneAmountFB_ValueChanged);
            // 
            // clonetoSlotFF
            // 
            this.clonetoSlotFF.Location = new System.Drawing.Point(126, 51);
            this.clonetoSlotFF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clonetoSlotFF.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.clonetoSlotFF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clonetoSlotFF.Name = "clonetoSlotFF";
            this.clonetoSlotFF.Size = new System.Drawing.Size(99, 26);
            this.clonetoSlotFF.TabIndex = 25;
            this.clonetoSlotFF.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clonetoSlotFF.Visible = false;
            this.clonetoSlotFF.ValueChanged += new System.EventHandler(this.clonetoSlotFF_ValueChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(238, 26);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(93, 20);
            this.label35.TabIndex = 41;
            this.label35.Text = "# of Clones:";
            // 
            // clonetoBoxFF
            // 
            this.clonetoBoxFF.Location = new System.Drawing.Point(12, 51);
            this.clonetoBoxFF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clonetoBoxFF.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.clonetoBoxFF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clonetoBoxFF.Name = "clonetoBoxFF";
            this.clonetoBoxFF.Size = new System.Drawing.Size(99, 26);
            this.clonetoBoxFF.TabIndex = 24;
            this.clonetoBoxFF.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clonetoBoxFF.Visible = false;
            this.clonetoBoxFF.ValueChanged += new System.EventHandler(this.clonetoBoxFF_ValueChanged);
            // 
            // clonefromBoxFB
            // 
            this.clonefromBoxFB.Enabled = false;
            this.clonefromBoxFB.Location = new System.Drawing.Point(12, 126);
            this.clonefromBoxFB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clonefromBoxFB.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.clonefromBoxFB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clonefromBoxFB.Name = "clonefromBoxFB";
            this.clonefromBoxFB.Size = new System.Drawing.Size(99, 26);
            this.clonefromBoxFB.TabIndex = 32;
            this.clonefromBoxFB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cloneFB
            // 
            this.cloneFB.Enabled = false;
            this.cloneFB.Location = new System.Drawing.Point(236, 122);
            this.cloneFB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cloneFB.Name = "cloneFB";
            this.cloneFB.Size = new System.Drawing.Size(99, 35);
            this.cloneFB.TabIndex = 39;
            this.cloneFB.Text = "Clone";
            this.cloneFB.UseVisualStyleBackColor = true;
            this.cloneFB.Click += new System.EventHandler(this.cloneFB_Click);
            // 
            // dTIDNum
            // 
            this.dTIDNum.Enabled = false;
            this.dTIDNum.Location = new System.Drawing.Point(66, 55);
            this.dTIDNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dTIDNum.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.dTIDNum.Name = "dTIDNum";
            this.dTIDNum.Size = new System.Drawing.Size(87, 26);
            this.dTIDNum.TabIndex = 44;
            this.dTIDNum.ValueChanged += new System.EventHandler(this.dTIDNum_ValueChanged);
            // 
            // dSIDNum
            // 
            this.dSIDNum.Enabled = false;
            this.dSIDNum.Location = new System.Drawing.Point(66, 95);
            this.dSIDNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dSIDNum.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.dSIDNum.Name = "dSIDNum";
            this.dSIDNum.Size = new System.Drawing.Size(87, 26);
            this.dSIDNum.TabIndex = 45;
            this.dSIDNum.ValueChanged += new System.EventHandler(this.dSIDNum_ValueChanged);
            // 
            // dPID
            // 
            this.dPID.Enabled = false;
            this.dPID.Location = new System.Drawing.Point(302, 17);
            this.dPID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dPID.Name = "dPID";
            this.dPID.Size = new System.Drawing.Size(85, 26);
            this.dPID.TabIndex = 47;
            this.dPID.TextChanged += new System.EventHandler(this.dPID_TextChanged);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(260, 23);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(40, 20);
            this.label45.TabIndex = 49;
            this.label45.Text = "PID:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(22, 62);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(39, 20);
            this.label47.TabIndex = 51;
            this.label47.Text = "TID:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(22, 102);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(41, 20);
            this.label48.TabIndex = 52;
            this.label48.Text = "SID:";
            // 
            // otName
            // 
            this.otName.Enabled = false;
            this.otName.Location = new System.Drawing.Point(66, 15);
            this.otName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.otName.Name = "otName";
            this.otName.Size = new System.Drawing.Size(120, 26);
            this.otName.TabIndex = 53;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(8, 20);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(55, 20);
            this.label46.TabIndex = 54;
            this.label46.Text = "Name:";
            // 
            // setShiny
            // 
            this.setShiny.Enabled = false;
            this.setShiny.Location = new System.Drawing.Point(219, 15);
            this.setShiny.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setShiny.Name = "setShiny";
            this.setShiny.Size = new System.Drawing.Size(33, 34);
            this.setShiny.TabIndex = 55;
            this.setShiny.Text = "☆";
            this.setShiny.UseVisualStyleBackColor = true;
            this.setShiny.Click += new System.EventHandler(this.setShiny_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(214, 62);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(87, 20);
            this.label51.TabIndex = 99;
            this.label51.Text = "Friendship:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(234, 100);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(67, 20);
            this.label49.TabIndex = 101;
            this.label49.Text = "Gender:";
            // 
            // friendship
            // 
            this.friendship.Enabled = false;
            this.friendship.Location = new System.Drawing.Point(302, 55);
            this.friendship.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.friendship.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.friendship.Name = "friendship";
            this.friendship.Size = new System.Drawing.Size(64, 26);
            this.friendship.TabIndex = 97;
            // 
            // gender
            // 
            this.gender.Enabled = false;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.gender.ForeColor = System.Drawing.Color.Gray;
            this.gender.Location = new System.Drawing.Point(302, 92);
            this.gender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(33, 34);
            this.gender.TabIndex = 100;
            this.gender.Text = "-";
            this.gender.UseVisualStyleBackColor = true;
            this.gender.Click += new System.EventHandler(this.gender_Click);
            // 
            // randomPID
            // 
            this.randomPID.Enabled = false;
            this.randomPID.Location = new System.Drawing.Point(388, 15);
            this.randomPID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.randomPID.Name = "randomPID";
            this.randomPID.Size = new System.Drawing.Size(33, 34);
            this.randomPID.TabIndex = 98;
            this.randomPID.Text = "?";
            this.randomPID.UseVisualStyleBackColor = true;
            this.randomPID.Click += new System.EventHandler(this.randomPID_Click);
            // 
            // DumpedEdit
            // 
            this.DumpedEdit.Controls.Add(this.Main);
            this.DumpedEdit.Controls.Add(this.Stats);
            this.DumpedEdit.Controls.Add(this.Moves);
            this.DumpedEdit.Controls.Add(this.OT);
            this.DumpedEdit.Location = new System.Drawing.Point(10, 214);
            this.DumpedEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DumpedEdit.Multiline = true;
            this.DumpedEdit.Name = "DumpedEdit";
            this.DumpedEdit.SelectedIndex = 0;
            this.DumpedEdit.Size = new System.Drawing.Size(438, 286);
            this.DumpedEdit.TabIndex = 57;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.SystemColors.Control;
            this.Main.Controls.Add(this.button1);
            this.Main.Controls.Add(this.label49);
            this.Main.Controls.Add(this.isEgg);
            this.Main.Controls.Add(this.label31);
            this.Main.Controls.Add(this.label51);
            this.Main.Controls.Add(this.gender);
            this.Main.Controls.Add(this.nickname);
            this.Main.Controls.Add(this.label32);
            this.Main.Controls.Add(this.friendship);
            this.Main.Controls.Add(this.species);
            this.Main.Controls.Add(this.label30);
            this.Main.Controls.Add(this.setShiny);
            this.Main.Controls.Add(this.ability);
            this.Main.Controls.Add(this.label23);
            this.Main.Controls.Add(this.pictureBox1);
            this.Main.Controls.Add(this.randomPID);
            this.Main.Controls.Add(this.nature);
            this.Main.Controls.Add(this.label25);
            this.Main.Controls.Add(this.dPID);
            this.Main.Controls.Add(this.label45);
            this.Main.Controls.Add(this.heldItem);
            this.Main.Controls.Add(this.label24);
            this.Main.Controls.Add(this.label44);
            this.Main.Controls.Add(this.ball);
            this.Main.Location = new System.Drawing.Point(4, 29);
            this.Main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Main.Size = new System.Drawing.Size(430, 253);
            this.Main.TabIndex = 2;
            this.Main.Text = "Main";
            // 
            // Stats
            // 
            this.Stats.BackColor = System.Drawing.SystemColors.Control;
            this.Stats.Controls.Add(this.ivHPNum);
            this.Stats.Controls.Add(this.evHPNum);
            this.Stats.Controls.Add(this.evATKNum);
            this.Stats.Controls.Add(this.label16);
            this.Stats.Controls.Add(this.evDEFNum);
            this.Stats.Controls.Add(this.ivSPENum);
            this.Stats.Controls.Add(this.evSPANum);
            this.Stats.Controls.Add(this.ivSPDNum);
            this.Stats.Controls.Add(this.evSPDNum);
            this.Stats.Controls.Add(this.evSPENum);
            this.Stats.Controls.Add(this.label19);
            this.Stats.Controls.Add(this.ivSPANum);
            this.Stats.Controls.Add(this.ivDEFNum);
            this.Stats.Controls.Add(this.ivATKNum);
            this.Stats.Controls.Add(this.label17);
            this.Stats.Controls.Add(this.label5);
            this.Stats.Controls.Add(this.label29);
            this.Stats.Controls.Add(this.label22);
            this.Stats.Controls.Add(this.hiddenPower);
            this.Stats.Controls.Add(this.label20);
            this.Stats.Controls.Add(this.label21);
            this.Stats.Controls.Add(this.label18);
            this.Stats.Location = new System.Drawing.Point(4, 29);
            this.Stats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Stats.Name = "Stats";
            this.Stats.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Stats.Size = new System.Drawing.Size(430, 253);
            this.Stats.TabIndex = 0;
            this.Stats.Text = "Stats";
            // 
            // Moves
            // 
            this.Moves.BackColor = System.Drawing.SystemColors.Control;
            this.Moves.Controls.Add(this.move1);
            this.Moves.Controls.Add(this.move2);
            this.Moves.Controls.Add(this.move3);
            this.Moves.Controls.Add(this.move4);
            this.Moves.Controls.Add(this.label6);
            this.Moves.Controls.Add(this.label41);
            this.Moves.Controls.Add(this.label43);
            this.Moves.Controls.Add(this.label42);
            this.Moves.Location = new System.Drawing.Point(4, 29);
            this.Moves.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Moves.Name = "Moves";
            this.Moves.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Moves.Size = new System.Drawing.Size(430, 253);
            this.Moves.TabIndex = 3;
            this.Moves.Text = "Moves";
            // 
            // OT
            // 
            this.OT.BackColor = System.Drawing.SystemColors.Control;
            this.OT.Controls.Add(this.dSIDNum);
            this.OT.Controls.Add(this.dTIDNum);
            this.OT.Controls.Add(this.label47);
            this.OT.Controls.Add(this.label48);
            this.OT.Controls.Add(this.otName);
            this.OT.Controls.Add(this.label46);
            this.OT.Location = new System.Drawing.Point(4, 29);
            this.OT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OT.Name = "OT";
            this.OT.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OT.Size = new System.Drawing.Size(430, 253);
            this.OT.TabIndex = 1;
            this.OT.Text = "OT";
            // 
            // xp
            // 
            this.xp.Location = new System.Drawing.Point(630, 534);
            this.xp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xp.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.xp.Name = "xp";
            this.xp.Size = new System.Drawing.Size(180, 26);
            this.xp.TabIndex = 58;
            this.xp.Visible = false;
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(630, 574);
            this.level.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(180, 26);
            this.level.TabIndex = 59;
            this.level.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 643);
            this.Controls.Add(this.level);
            this.Controls.Add(this.xp);
            this.Controls.Add(this.DumpedEdit);
            this.Controls.Add(this.clonePkm);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.dumpBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PKMN NTR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milesNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpNum)).EndInit();
            this.dumpBox.ResumeLayout(false);
            this.dumpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slotDump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxDump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evSPENum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evSPDNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evSPANum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evDEFNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evATKNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evHPNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSPENum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSPDNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivSPANum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivDEFNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivATKNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivHPNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SIDNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIDNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteSlot)).EndInit();
            this.clonePkm.ResumeLayout(false);
            this.clonePkm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clonefromSlotFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloneAmountFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clonetoBoxFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clonetoSlotFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloneAmountFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clonetoSlotFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clonetoBoxFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clonefromBoxFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTIDNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSIDNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendship)).EndInit();
            this.DumpedEdit.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.Stats.ResumeLayout(false);
            this.Stats.PerformLayout();
            this.Moves.ResumeLayout(false);
            this.Moves.PerformLayout();
            this.OT.ResumeLayout(false);
            this.OT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer disconnectTimer;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown moneyNum;
        private System.Windows.Forms.NumericUpDown milesNum;
        private System.Windows.Forms.NumericUpDown bpNum;
        private System.Windows.Forms.Button pokeMoney;
        private System.Windows.Forms.Button pokeMiles;
        private System.Windows.Forms.Button pokeBP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox dumpBox;
        private System.Windows.Forms.Button dumpek6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown slotDump;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown boxDump;
        private System.Windows.Forms.TextBox nameek6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button dumpBoxes;
        private System.Windows.Forms.RadioButton radioDaycare;
        private System.Windows.Forms.RadioButton radioBoxes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown TIDNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button pokeTID;
        private System.Windows.Forms.Button pokeTime;
        private System.Windows.Forms.NumericUpDown hourNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown minNum;
        private System.Windows.Forms.NumericUpDown secNum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button showKeys;
        private System.Windows.Forms.Button showBerries;
        private System.Windows.Forms.Button showTMs;
        private System.Windows.Forms.Button showMedicine;
        private System.Windows.Forms.Button showItems;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button itemWrite;
        private System.Windows.Forms.Button itemAdd;
        private System.Windows.Forms.RadioButton radioOpponent;
        private System.Windows.Forms.RadioButton radioTrade;
        private System.Windows.Forms.Button pokeSID;
        private System.Windows.Forms.NumericUpDown SIDNum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button delPkm;
        private System.Windows.Forms.NumericUpDown deleteBox;
        private System.Windows.Forms.NumericUpDown deleteSlot;
        private System.Windows.Forms.Button pokeLang;
        private System.Windows.Forms.Button pokeName;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox Lang;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox hiddenPower;
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox nature;
        private System.Windows.Forms.NumericUpDown ivSPENum;
        private System.Windows.Forms.NumericUpDown ivSPDNum;
        private System.Windows.Forms.NumericUpDown ivSPANum;
        private System.Windows.Forms.NumericUpDown ivDEFNum;
        private System.Windows.Forms.NumericUpDown ivATKNum;
        private System.Windows.Forms.NumericUpDown ivHPNum;
        private System.Windows.Forms.CheckBox isEgg;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox heldItem;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox species;
        private System.Windows.Forms.GroupBox clonePkm;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown clonefromBoxFB;
        private System.Windows.Forms.NumericUpDown clonefromSlotFB;
        private System.Windows.Forms.NumericUpDown clonetoBoxFB;
        private System.Windows.Forms.NumericUpDown clonetoSlotFB;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown cloneAmountFB;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button cloneFB;
        private System.Windows.Forms.NumericUpDown clonetoBoxFF;
        private System.Windows.Forms.Button chooseCloneFF;
        private System.Windows.Forms.NumericUpDown clonetoSlotFF;
        private System.Windows.Forms.NumericUpDown cloneAmountFF;
        private System.Windows.Forms.Button cloneFF;
        private System.Windows.Forms.RadioButton fromFile;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.RadioButton fromBoxes;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.NumericUpDown deleteAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown evSPENum;
        private System.Windows.Forms.NumericUpDown evSPDNum;
        private System.Windows.Forms.NumericUpDown evSPANum;
        private System.Windows.Forms.NumericUpDown evDEFNum;
        private System.Windows.Forms.NumericUpDown evATKNum;
        private System.Windows.Forms.NumericUpDown evHPNum;
        private System.Windows.Forms.ComboBox ability;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox move4;
        private System.Windows.Forms.ComboBox move3;
        private System.Windows.Forms.ComboBox move2;
        private System.Windows.Forms.ComboBox move1;
        private System.Windows.Forms.ComboBox ball;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button versionCheck;
        private System.Windows.Forms.RadioButton radioParty;
        private System.Windows.Forms.NumericUpDown dTIDNum;
        private System.Windows.Forms.NumericUpDown dSIDNum;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox otName;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button setShiny;
        public System.Windows.Forms.TextBox dPID;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.CheckBox onlyView;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.NumericUpDown friendship;
        private System.Windows.Forms.Button randomPID;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Button gender;
        private System.Windows.Forms.TabControl DumpedEdit;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.TabPage Stats;
        private System.Windows.Forms.TabPage Moves;
        private System.Windows.Forms.TabPage OT;
        private System.Windows.Forms.RadioButton radioBattleBox;
        private System.Windows.Forms.NumericUpDown xp;
        private System.Windows.Forms.NumericUpDown level;
    }
}

