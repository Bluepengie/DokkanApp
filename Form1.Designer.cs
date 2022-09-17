namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.superMult = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.kiMult = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.onSuper = new System.Windows.Forms.NumericUpDown();
            this.buildupPassive = new System.Windows.Forms.NumericUpDown();
            this.turnStartPassive = new System.Windows.Forms.NumericUpDown();
            this.cardATK = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.leaderSkill = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.ki = new System.Windows.Forms.NumericUpDown();
            this.dupeButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.advancedSettings = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.saEffect = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.linkSum = new System.Windows.Forms.NumericUpDown();
            this.smartMode = new System.Windows.Forms.CheckBox();
            this.nukeMenu = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onSuper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildupPassive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnStartPassive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardATK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ki)).BeginInit();
            this.dupeButtonsPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saEffect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkSum)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Card ATK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "SoT Passive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Buildup Passive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "On Super";
            // 
            // superMult
            // 
            this.superMult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.superMult.FormattingEnabled = true;
            this.superMult.Items.AddRange(new object[] {
            "Immense",
            "Colossal",
            "Mega-Colossal"});
            this.superMult.Location = new System.Drawing.Point(111, 198);
            this.superMult.Margin = new System.Windows.Forms.Padding(8);
            this.superMult.Name = "superMult";
            this.superMult.Size = new System.Drawing.Size(181, 21);
            this.superMult.TabIndex = 8;
            this.superMult.SelectedIndexChanged += new System.EventHandler(this.superMult_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SA Multiplier";
            // 
            // output
            // 
            this.output.Enabled = false;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(497, 368);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(267, 40);
            this.output.TabIndex = 10;
            this.output.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Output";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 450);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.onSuper, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.buildupPassive, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.superMult, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.turnStartPassive, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cardATK, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.leaderSkill, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(305, 450);
            this.tableLayoutPanel2.TabIndex = 13;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(8, 152);
            this.label10.Margin = new System.Windows.Forms.Padding(8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 58);
            this.label10.TabIndex = 24;
            this.label10.Text = "Dupes";
            this.label10.Visible = false;
            // 
            // kiMult
            // 
            this.kiMult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kiMult.Location = new System.Drawing.Point(99, 116);
            this.kiMult.Margin = new System.Windows.Forms.Padding(8);
            this.kiMult.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.kiMult.Name = "kiMult";
            this.kiMult.Size = new System.Drawing.Size(183, 20);
            this.kiMult.TabIndex = 21;
            this.kiMult.Value = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.kiMult.Visible = false;
            this.kiMult.ValueChanged += new System.EventHandler(this.kiMult_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(8, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ki";
            this.label9.Visible = false;
            // 
            // onSuper
            // 
            this.onSuper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onSuper.Location = new System.Drawing.Point(111, 126);
            this.onSuper.Margin = new System.Windows.Forms.Padding(8);
            this.onSuper.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.onSuper.Name = "onSuper";
            this.onSuper.Size = new System.Drawing.Size(181, 20);
            this.onSuper.TabIndex = 17;
            this.onSuper.ThousandsSeparator = true;
            this.onSuper.ValueChanged += new System.EventHandler(this.onSuper_ValueChanged);
            // 
            // buildupPassive
            // 
            this.buildupPassive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildupPassive.Location = new System.Drawing.Point(111, 90);
            this.buildupPassive.Margin = new System.Windows.Forms.Padding(8);
            this.buildupPassive.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.buildupPassive.Name = "buildupPassive";
            this.buildupPassive.Size = new System.Drawing.Size(181, 20);
            this.buildupPassive.TabIndex = 16;
            this.buildupPassive.ThousandsSeparator = true;
            this.buildupPassive.ValueChanged += new System.EventHandler(this.buildupPassive_ValueChanged);
            // 
            // turnStartPassive
            // 
            this.turnStartPassive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turnStartPassive.Location = new System.Drawing.Point(111, 54);
            this.turnStartPassive.Margin = new System.Windows.Forms.Padding(8);
            this.turnStartPassive.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.turnStartPassive.Name = "turnStartPassive";
            this.turnStartPassive.Size = new System.Drawing.Size(181, 20);
            this.turnStartPassive.TabIndex = 15;
            this.turnStartPassive.ThousandsSeparator = true;
            this.turnStartPassive.ValueChanged += new System.EventHandler(this.turnStartPassive_ValueChanged);
            // 
            // cardATK
            // 
            this.cardATK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardATK.Location = new System.Drawing.Point(111, 18);
            this.cardATK.Margin = new System.Windows.Forms.Padding(8);
            this.cardATK.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.cardATK.Name = "cardATK";
            this.cardATK.Size = new System.Drawing.Size(181, 20);
            this.cardATK.TabIndex = 14;
            this.cardATK.ThousandsSeparator = true;
            this.cardATK.ValueChanged += new System.EventHandler(this.cardATK_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Leader Skill ";
            // 
            // leaderSkill
            // 
            this.leaderSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leaderSkill.Location = new System.Drawing.Point(111, 162);
            this.leaderSkill.Margin = new System.Windows.Forms.Padding(8);
            this.leaderSkill.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.leaderSkill.Name = "leaderSkill";
            this.leaderSkill.Size = new System.Drawing.Size(181, 20);
            this.leaderSkill.TabIndex = 19;
            this.leaderSkill.ValueChanged += new System.EventHandler(this.leaderSkill_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(8, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "12 Ki Multiplier";
            this.label8.Visible = false;
            // 
            // ki
            // 
            this.ki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ki.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ki.Location = new System.Drawing.Point(99, 80);
            this.ki.Margin = new System.Windows.Forms.Padding(8);
            this.ki.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.ki.Name = "ki";
            this.ki.Size = new System.Drawing.Size(183, 20);
            this.ki.TabIndex = 23;
            this.ki.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.ki.Visible = false;
            this.ki.ValueChanged += new System.EventHandler(this.ki_ValueChanged);
            // 
            // dupeButtonsPanel
            // 
            this.dupeButtonsPanel.AutoSize = true;
            this.dupeButtonsPanel.ColumnCount = 5;
            this.dupeButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.dupeButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.dupeButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.dupeButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.dupeButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.dupeButtonsPanel.Controls.Add(this.radioButton1, 0, 0);
            this.dupeButtonsPanel.Controls.Add(this.radioButton5, 4, 0);
            this.dupeButtonsPanel.Controls.Add(this.radioButton2, 1, 0);
            this.dupeButtonsPanel.Controls.Add(this.radioButton4, 3, 0);
            this.dupeButtonsPanel.Controls.Add(this.radioButton3, 2, 0);
            this.dupeButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dupeButtonsPanel.Location = new System.Drawing.Point(94, 147);
            this.dupeButtonsPanel.Name = "dupeButtonsPanel";
            this.dupeButtonsPanel.RowCount = 1;
            this.dupeButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dupeButtonsPanel.Size = new System.Drawing.Size(193, 68);
            this.dupeButtonsPanel.TabIndex = 25;
            this.dupeButtonsPanel.Visible = false;
            this.dupeButtonsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton4.AutoSize = true;
            this.radioButton4.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton4.Location = new System.Drawing.Point(124, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(17, 30);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "3";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton3.AutoSize = true;
            this.radioButton3.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton3.Location = new System.Drawing.Point(86, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(17, 30);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "2";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton2.AutoSize = true;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton2.Location = new System.Drawing.Point(48, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 30);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "1";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton1.AutoSize = true;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 30);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "0";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton5.AutoSize = true;
            this.radioButton5.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton5.Location = new System.Drawing.Point(164, 3);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(17, 30);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "4";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // advancedSettings
            // 
            this.advancedSettings.AutoSize = true;
            this.advancedSettings.Location = new System.Drawing.Point(495, 12);
            this.advancedSettings.Name = "advancedSettings";
            this.advancedSettings.Size = new System.Drawing.Size(116, 17);
            this.advancedSettings.TabIndex = 14;
            this.advancedSettings.Text = "Advanced Settings";
            this.advancedSettings.UseVisualStyleBackColor = true;
            this.advancedSettings.CheckedChanged += new System.EventHandler(this.advancedSettings_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.linkSum, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.saEffect, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.kiMult, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.ki, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.dupeButtonsPanel, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(484, 41);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(290, 218);
            this.tableLayoutPanel3.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 44);
            this.label11.Margin = new System.Windows.Forms.Padding(8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "SA Effect";
            this.label11.Visible = false;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // saEffect
            // 
            this.saEffect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saEffect.Location = new System.Drawing.Point(99, 44);
            this.saEffect.Margin = new System.Windows.Forms.Padding(8);
            this.saEffect.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.saEffect.Name = "saEffect";
            this.saEffect.Size = new System.Drawing.Size(183, 20);
            this.saEffect.TabIndex = 27;
            this.saEffect.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.saEffect.Visible = false;
            this.saEffect.ValueChanged += new System.EventHandler(this.saEffect_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 8);
            this.label12.Margin = new System.Windows.Forms.Padding(8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Total Links";
            this.label12.Visible = false;
            // 
            // linkSum
            // 
            this.linkSum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkSum.Location = new System.Drawing.Point(99, 8);
            this.linkSum.Margin = new System.Windows.Forms.Padding(8);
            this.linkSum.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.linkSum.Name = "linkSum";
            this.linkSum.Size = new System.Drawing.Size(183, 20);
            this.linkSum.TabIndex = 29;
            this.linkSum.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.linkSum.Visible = false;
            this.linkSum.ValueChanged += new System.EventHandler(this.linkSum_ValueChanged);
            // 
            // smartMode
            // 
            this.smartMode.AutoSize = true;
            this.smartMode.Checked = true;
            this.smartMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smartMode.Location = new System.Drawing.Point(676, 12);
            this.smartMode.Name = "smartMode";
            this.smartMode.Size = new System.Drawing.Size(83, 17);
            this.smartMode.TabIndex = 27;
            this.smartMode.Text = "Smart Mode";
            this.smartMode.UseVisualStyleBackColor = true;
            this.smartMode.CheckedChanged += new System.EventHandler(this.smartMode_CheckedChanged);
            // 
            // nukeMenu
            // 
            this.nukeMenu.AutoSize = true;
            this.nukeMenu.Location = new System.Drawing.Point(321, 12);
            this.nukeMenu.Name = "nukeMenu";
            this.nukeMenu.Size = new System.Drawing.Size(60, 17);
            this.nukeMenu.TabIndex = 28;
            this.nukeMenu.Text = "Nuking";
            this.nukeMenu.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.numericUpDown1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(311, 41);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(157, 218);
            this.tableLayoutPanel4.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 8);
            this.label13.Margin = new System.Windows.Forms.Padding(8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Any orb";
            this.label13.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(71, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown1.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.nukeMenu);
            this.Controls.Add(this.smartMode);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.advancedSettings);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onSuper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildupPassive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnStartPassive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardATK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ki)).EndInit();
            this.dupeButtonsPanel.ResumeLayout(false);
            this.dupeButtonsPanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saEffect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkSum)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox superMult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown onSuper;
        private System.Windows.Forms.NumericUpDown buildupPassive;
        private System.Windows.Forms.NumericUpDown turnStartPassive;
        private System.Windows.Forms.NumericUpDown cardATK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown leaderSkill;
        private System.Windows.Forms.NumericUpDown kiMult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown ki;
        private System.Windows.Forms.CheckBox advancedSettings;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel dupeButtonsPanel;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown saEffect;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown linkSum;
        private System.Windows.Forms.CheckBox smartMode;
        private System.Windows.Forms.CheckBox nukeMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label13;
    }
}

