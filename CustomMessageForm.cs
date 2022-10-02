using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSnake
{
    internal partial class CustomMessageForm : Form
    {
        public CustomMessageForm()
        {
            InitializeComponent();
        }
        internal string MainText
        {
            get { return labelMainText.Text; }
            set { labelMainText.Text = value; }
        }
        internal string TextBoxText
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void timerOn_Tick(object sender, EventArgs e)
        {
            timerOn.Stop();
            textBox.Enabled = true;
            buttonNo.Enabled = true;
            buttonYes.Enabled = true;
            textBox.Focus();
        }
    }
}
