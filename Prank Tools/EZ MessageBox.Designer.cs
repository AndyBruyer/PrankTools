namespace Prank_Tools
{
    partial class EZ_MessageBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MsgBoxTitle = new System.Windows.Forms.TextBox();
            this.MsgBoxText = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ErrorIcon = new System.Windows.Forms.PictureBox();
            this.WarningIcon = new System.Windows.Forms.PictureBox();
            this.QuestionIcon = new System.Windows.Forms.PictureBox();
            this.ExlamationIcon = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExlamationIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.MsgBoxText);
            this.groupBox1.Controls.Add(this.MsgBoxTitle);
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MessageBox Text/Title";
            // 
            // MsgBoxTitle
            // 
            this.MsgBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MsgBoxTitle.Location = new System.Drawing.Point(6, 19);
            this.MsgBoxTitle.Name = "MsgBoxTitle";
            this.MsgBoxTitle.Size = new System.Drawing.Size(165, 20);
            this.MsgBoxTitle.TabIndex = 0;
            this.MsgBoxTitle.Text = "Enter Title For Message Box";
            // 
            // MsgBoxText
            // 
            this.MsgBoxText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MsgBoxText.Location = new System.Drawing.Point(6, 45);
            this.MsgBoxText.Name = "MsgBoxText";
            this.MsgBoxText.Size = new System.Drawing.Size(165, 81);
            this.MsgBoxText.TabIndex = 1;
            this.MsgBoxText.Text = "Enter Text For The Message Box";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ExlamationIcon);
            this.groupBox2.Controls.Add(this.QuestionIcon);
            this.groupBox2.Controls.Add(this.WarningIcon);
            this.groupBox2.Controls.Add(this.ErrorIcon);
            this.groupBox2.Location = new System.Drawing.Point(187, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MessageBox Icon";
            // 
            // ErrorIcon
            // 
            this.ErrorIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ErrorIcon.Image = global::Prank_Tools.Properties.Resources.ErrorIcon;
            this.ErrorIcon.Location = new System.Drawing.Point(6, 19);
            this.ErrorIcon.Name = "ErrorIcon";
            this.ErrorIcon.Size = new System.Drawing.Size(49, 49);
            this.ErrorIcon.TabIndex = 0;
            this.ErrorIcon.TabStop = false;
            this.ErrorIcon.Click += new System.EventHandler(this.ErrorIcon_Click);
            // 
            // WarningIcon
            // 
            this.WarningIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WarningIcon.Image = global::Prank_Tools.Properties.Resources.WarningIcon;
            this.WarningIcon.Location = new System.Drawing.Point(57, 19);
            this.WarningIcon.Name = "WarningIcon";
            this.WarningIcon.Size = new System.Drawing.Size(51, 49);
            this.WarningIcon.TabIndex = 1;
            this.WarningIcon.TabStop = false;
            this.WarningIcon.Click += new System.EventHandler(this.WarningIcon_Click);
            // 
            // QuestionIcon
            // 
            this.QuestionIcon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.QuestionIcon.Image = global::Prank_Tools.Properties.Resources.QuestionIcon;
            this.QuestionIcon.Location = new System.Drawing.Point(6, 74);
            this.QuestionIcon.Name = "QuestionIcon";
            this.QuestionIcon.Size = new System.Drawing.Size(49, 52);
            this.QuestionIcon.TabIndex = 2;
            this.QuestionIcon.TabStop = false;
            this.QuestionIcon.Click += new System.EventHandler(this.QuestionIcon_Click);
            // 
            // ExlamationIcon
            // 
            this.ExlamationIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExlamationIcon.Image = global::Prank_Tools.Properties.Resources.ExclimationIcon;
            this.ExlamationIcon.Location = new System.Drawing.Point(57, 74);
            this.ExlamationIcon.Name = "ExlamationIcon";
            this.ExlamationIcon.Size = new System.Drawing.Size(51, 52);
            this.ExlamationIcon.TabIndex = 3;
            this.ExlamationIcon.TabStop = false;
            this.ExlamationIcon.Click += new System.EventHandler(this.ExlamationIcon_Click);
            // 
            // EZ_MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EZ_MessageBox";
            this.Size = new System.Drawing.Size(306, 135);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExlamationIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox MsgBoxText;
        private System.Windows.Forms.TextBox MsgBoxTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox ExlamationIcon;
        private System.Windows.Forms.PictureBox QuestionIcon;
        private System.Windows.Forms.PictureBox WarningIcon;
        private System.Windows.Forms.PictureBox ErrorIcon;
    }
}
