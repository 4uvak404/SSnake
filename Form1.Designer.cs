namespace SSnake
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxScreen = new System.Windows.Forms.PictureBox();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.dataGridViewRecords = new System.Windows.Forms.DataGridView();
            this.ColumnNickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDownMapHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMapWidth = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSpeed = new System.Windows.Forms.ComboBox();
            this.checkBoxMSCS = new System.Windows.Forms.CheckBox();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.timerGameTick = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreen)).BeginInit();
            this.groupBoxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMenu
            // 
            this.tableLayoutPanelMenu.ColumnCount = 2;
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelMenu.Controls.Add(this.pictureBoxScreen, 0, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.groupBoxMenu, 1, 0);
            this.tableLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            this.tableLayoutPanelMenu.RowCount = 1;
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenu.Size = new System.Drawing.Size(956, 418);
            this.tableLayoutPanelMenu.TabIndex = 0;
            // 
            // pictureBoxScreen
            // 
            this.pictureBoxScreen.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxScreen.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxScreen.Name = "pictureBoxScreen";
            this.pictureBoxScreen.Size = new System.Drawing.Size(750, 412);
            this.pictureBoxScreen.TabIndex = 0;
            this.pictureBoxScreen.TabStop = false;
            this.pictureBoxScreen.SizeChanged += new System.EventHandler(this.pictureBoxScreen_SizeChanged);
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.dataGridViewRecords);
            this.groupBoxMenu.Controls.Add(this.numericUpDownMapHeight);
            this.groupBoxMenu.Controls.Add(this.numericUpDownMapWidth);
            this.groupBoxMenu.Controls.Add(this.comboBoxSpeed);
            this.groupBoxMenu.Controls.Add(this.checkBoxMSCS);
            this.groupBoxMenu.Controls.Add(this.labelTimer);
            this.groupBoxMenu.Controls.Add(this.labelScore);
            this.groupBoxMenu.Controls.Add(this.buttonStartStop);
            this.groupBoxMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMenu.Location = new System.Drawing.Point(759, 3);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(194, 412);
            this.groupBoxMenu.TabIndex = 0;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Штуки";
            // 
            // dataGridViewRecords
            // 
            this.dataGridViewRecords.AllowUserToAddRows = false;
            this.dataGridViewRecords.AllowUserToDeleteRows = false;
            this.dataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNickName,
            this.ColumnScore,
            this.ColumnTime});
            this.dataGridViewRecords.Location = new System.Drawing.Point(10, 219);
            this.dataGridViewRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRecords.Name = "dataGridViewRecords";
            this.dataGridViewRecords.ReadOnly = true;
            this.dataGridViewRecords.RowHeadersVisible = false;
            this.dataGridViewRecords.RowHeadersWidth = 51;
            this.dataGridViewRecords.RowTemplate.Height = 29;
            this.dataGridViewRecords.Size = new System.Drawing.Size(171, 147);
            this.dataGridViewRecords.TabIndex = 7;
            // 
            // ColumnNickName
            // 
            this.ColumnNickName.HeaderText = "Никнейм";
            this.ColumnNickName.MinimumWidth = 6;
            this.ColumnNickName.Name = "ColumnNickName";
            this.ColumnNickName.ReadOnly = true;
            this.ColumnNickName.Width = 125;
            // 
            // ColumnScore
            // 
            this.ColumnScore.HeaderText = "Счёт";
            this.ColumnScore.MinimumWidth = 6;
            this.ColumnScore.Name = "ColumnScore";
            this.ColumnScore.ReadOnly = true;
            this.ColumnScore.Width = 125;
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Время";
            this.ColumnTime.MinimumWidth = 6;
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            this.ColumnTime.Width = 125;
            // 
            // numericUpDownMapHeight
            // 
            this.numericUpDownMapHeight.Location = new System.Drawing.Point(102, 134);
            this.numericUpDownMapHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownMapHeight.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownMapHeight.Name = "numericUpDownMapHeight";
            this.numericUpDownMapHeight.Size = new System.Drawing.Size(58, 23);
            this.numericUpDownMapHeight.TabIndex = 6;
            this.numericUpDownMapHeight.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownMapHeight.ValueChanged += new System.EventHandler(this.numericUpDownMapHeight_ValueChanged);
            // 
            // numericUpDownMapWidth
            // 
            this.numericUpDownMapWidth.Location = new System.Drawing.Point(23, 134);
            this.numericUpDownMapWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownMapWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownMapWidth.Name = "numericUpDownMapWidth";
            this.numericUpDownMapWidth.Size = new System.Drawing.Size(58, 23);
            this.numericUpDownMapWidth.TabIndex = 5;
            this.numericUpDownMapWidth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMapWidth.ValueChanged += new System.EventHandler(this.numericUpDownMapWidth_ValueChanged);
            // 
            // comboBoxSpeed
            // 
            this.comboBoxSpeed.FormattingEnabled = true;
            this.comboBoxSpeed.Location = new System.Drawing.Point(23, 172);
            this.comboBoxSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSpeed.Name = "comboBoxSpeed";
            this.comboBoxSpeed.Size = new System.Drawing.Size(137, 23);
            this.comboBoxSpeed.TabIndex = 4;
            this.comboBoxSpeed.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpeed_SelectedIndexChanged);
            // 
            // checkBoxMSCS
            // 
            this.checkBoxMSCS.Checked = true;
            this.checkBoxMSCS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMSCS.Location = new System.Drawing.Point(10, 371);
            this.checkBoxMSCS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxMSCS.Name = "checkBoxMSCS";
            this.checkBoxMSCS.Size = new System.Drawing.Size(177, 38);
            this.checkBoxMSCS.TabIndex = 3;
            this.checkBoxMSCS.Text = "Обеспечить квадратные клетки (бета)";
            this.checkBoxMSCS.UseVisualStyleBackColor = true;
            this.checkBoxMSCS.CheckedChanged += new System.EventHandler(this.checkBoxMSCS_CheckedChanged);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(23, 54);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(106, 15);
            this.labelTimer.TabIndex = 2;
            this.labelTimer.Text = "Время игры: 00:00";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(23, 32);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(48, 15);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Очки: 0";
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(51, 88);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStartStop.TabIndex = 0;
            this.buttonStartStop.Text = "Старт";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.ButtonStartStop_Click);
            this.buttonStartStop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // timerGameTick
            // 
            this.timerGameTick.Interval = 220;
            this.timerGameTick.Tick += new System.EventHandler(this.TimerGameTick_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 418);
            this.Controls.Add(this.tableLayoutPanelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreen)).EndInit();
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelMenu;
        private PictureBox pictureBoxScreen;
        private GroupBox groupBoxMenu;
        private Button buttonStartStop;
        private Label labelScore;
        private System.Windows.Forms.Timer timerGameTick;
        private System.Windows.Forms.Timer timerTime;
        private Label labelTimer;
        private CheckBox checkBoxMSCS;
        private ComboBox comboBoxSpeed;
        private NumericUpDown numericUpDownMapHeight;
        private NumericUpDown numericUpDownMapWidth;
        private DataGridView dataGridViewRecords;
        private DataGridViewTextBoxColumn ColumnNickName;
        private DataGridViewTextBoxColumn ColumnScore;
        private DataGridViewTextBoxColumn ColumnTime;
    }
}