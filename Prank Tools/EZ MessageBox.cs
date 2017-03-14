using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prank_Tools
{
    public partial class EZ_MessageBox : UserControl
    {
        public EZ_MessageBox()
        {
            InitializeComponent();
        }

        private void ErrorIcon_Click(object sender, EventArgs e)
        {
            // When The Button For ErrorIcon Is Clicked Then Show A MessageBox With The Title, Text, And Icon
            MessageBox.Show(MsgBoxText.Text, MsgBoxTitle.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void WarningIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgBoxText.Text, MsgBoxTitle.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void QuestionIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgBoxText.Text, MsgBoxTitle.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void ExlamationIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgBoxText.Text, MsgBoxTitle.Text, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
        }
    }
}
