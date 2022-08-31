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
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.timerGameTick = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreen)).BeginInit();
            this.groupBoxMenu.SuspendLayout();
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
            this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            this.tableLayoutPanelMenu.RowCount = 1;
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMenu.Size = new System.Drawing.Size(1056, 593);
            this.tableLayoutPanelMenu.TabIndex = 0;
            // 
            // pictureBoxScreen
            // 
            this.pictureBoxScreen.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxScreen.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxScreen.Name = "pictureBoxScreen";
            this.pictureBoxScreen.Size = new System.Drawing.Size(850, 587);
            this.pictureBoxScreen.TabIndex = 0;
            this.pictureBoxScreen.TabStop = false;
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.labelScore);
            this.groupBoxMenu.Controls.Add(this.buttonStartStop);
            this.groupBoxMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMenu.Location = new System.Drawing.Point(859, 3);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(194, 183);
            this.groupBoxMenu.TabIndex = 0;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Штуки";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(29, 46);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(39, 15);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Очки:";
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(51, 136);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStartStop.TabIndex = 0;
            this.buttonStartStop.Text = "Старт";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // timerGameTick
            // 
            this.timerGameTick.Interval = 400;
            this.timerGameTick.Tick += new System.EventHandler(this.timerGameTick_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 593);
            this.Controls.Add(this.tableLayoutPanelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}