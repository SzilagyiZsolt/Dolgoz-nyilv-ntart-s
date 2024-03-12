namespace Grafikus_rest_api
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
            this.listbox_adatok = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // listbox_adatok
            // 
            this.listbox_adatok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listbox_adatok.FormattingEnabled = true;
            this.listbox_adatok.Location = new System.Drawing.Point(0, 0);
            this.listbox_adatok.Name = "listbox_adatok";
            this.listbox_adatok.Size = new System.Drawing.Size(120, 450);
            this.listbox_adatok.TabIndex = 0;
            this.listbox_adatok.SelectedIndexChanged += new System.EventHandler(this.adatok_listbox_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listbox_adatok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_adatok;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

