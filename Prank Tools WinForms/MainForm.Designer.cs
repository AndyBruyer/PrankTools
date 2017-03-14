namespace Prank_Tools_WinForms
{
    partial class MainForm
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
            this.eZ_MessageBox1 = new Prank_Tools.EZ_MessageBox();
            this.SuspendLayout();
            // 
            // eZ_MessageBox1
            // 
            this.eZ_MessageBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.eZ_MessageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eZ_MessageBox1.Location = new System.Drawing.Point(0, 0);
            this.eZ_MessageBox1.Name = "eZ_MessageBox1";
            this.eZ_MessageBox1.Size = new System.Drawing.Size(334, 136);
            this.eZ_MessageBox1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 136);
            this.Controls.Add(this.eZ_MessageBox1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Prank Tools Example";
            this.ResumeLayout(false);

        }

        #endregion

        private Prank_Tools.EZ_MessageBox eZ_MessageBox1;

    }
}

