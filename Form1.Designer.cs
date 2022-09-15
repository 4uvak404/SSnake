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
            this.checkBoxMSCS = new System.Windows.Forms.CheckBox();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.timerGameTick = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreen)).BeginInit();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMenu
            // 
            this.tableLayoutPanelMenu.ColumnCount = 2;
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanelMenu.Controls.Add(this.pictureBoxScreen, 0, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.groupBoxMenu, 1, 0);
            this.tableLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            this.tableLayoutPanelMenu.RowCount = 1;
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenu.Size = new System.Drawing.Size(1019, 557);
            this.tableLayoutPanelMenu.TabIndex = 0;
            // 
            // pictureBoxScreen
            // 
            this.pictureBoxScreen.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxScreen.Location = new System.Drawing.Point(3, 4);
            this.pictureBoxScreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxScreen.Name = "pictureBoxScreen";
            this.pictureBoxScreen.Size = new System.Drawing.Size(784, 549);
            this.pictureBoxScreen.TabIndex = 0;
            this.pictureBoxScreen.TabStop = false;
            this.pictureBoxScreen.SizeChanged += new System.EventHandler(this.pictureBoxScreen_SizeChanged);
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.checkBoxMSCS);
            this.groupBoxMenu.Controls.Add(this.labelTimer);
            this.groupBoxMenu.Controls.Add(this.labelScore);
            this.groupBoxMenu.Controls.Add(this.buttonStartStop);
            this.groupBoxMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMenu.Location = new System.Drawing.Point(793, 4);
            this.groupBoxMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMenu.Size = new System.Drawing.Size(223, 313);
            this.groupBoxMenu.TabIndex = 0;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Штуки";
            // 
            // checkBoxMSCS
            // 
            this.checkBoxMSCS.Checked = true;
            this.checkBoxMSCS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMSCS.Location = new System.Drawing.Point(12, 226);
            this.checkBoxMSCS.Name = "checkBoxMSCS";
            this.checkBoxMSCS.Size = new System.Drawing.Size(202, 51);
            this.checkBoxMSCS.TabIndex = 3;
            this.checkBoxMSCS.Text = "Обеспечить квадратные клетки (бета)";
            this.checkBoxMSCS.UseVisualStyleBackColor = true;
            this.checkBoxMSCS.CheckedChanged += new System.EventHandler(this.checkBoxMSCS_CheckedChanged);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(33, 90);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(135, 20);
            this.labelTimer.TabIndex = 2;
            this.labelTimer.Text = "Время игры: 00:00";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(33, 61);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(59, 20);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Очки: 0";
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(58, 181);
            this.buttonStartStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(86, 31);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 557);
            this.Controls.Add(this.tableLayoutPanelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}