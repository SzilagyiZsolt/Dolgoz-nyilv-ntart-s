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
            this.Create_button = new System.Windows.Forms.Button();
            this.Read_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Position = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Salary = new System.Windows.Forms.TextBox();
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
            this.listbox_adatok.SelectedIndexChanged += new System.EventHandler(this.listbox_adatok_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Create_button
            // 
            this.Create_button.Location = new System.Drawing.Point(207, 51);
            this.Create_button.Name = "Create_button";
            this.Create_button.Size = new System.Drawing.Size(75, 23);
            this.Create_button.TabIndex = 1;
            this.Create_button.Text = "Create";
            this.Create_button.UseVisualStyleBackColor = true;
            this.Create_button.Click += new System.EventHandler(this.Create_button_Click);
            // 
            // Read_button
            // 
            this.Read_button.Location = new System.Drawing.Point(207, 96);
            this.Read_button.Name = "Read_button";
            this.Read_button.Size = new System.Drawing.Size(75, 23);
            this.Read_button.TabIndex = 2;
            this.Read_button.Text = "Read";
            this.Read_button.UseVisualStyleBackColor = true;
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(207, 146);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 23);
            this.Update_button.TabIndex = 3;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(207, 189);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 4;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(358, 53);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Position";
            // 
            // textBox_Position
            // 
            this.textBox_Position.Location = new System.Drawing.Point(464, 54);
            this.textBox_Position.Name = "textBox_Position";
            this.textBox_Position.Size = new System.Drawing.Size(100, 20);
            this.textBox_Position.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Salary";
            // 
            // textBox_Salary
            // 
            this.textBox_Salary.Location = new System.Drawing.Point(570, 54);
            this.textBox_Salary.Name = "textBox_Salary";
            this.textBox_Salary.Size = new System.Drawing.Size(100, 20);
            this.textBox_Salary.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Salary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Position);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Read_button);
            this.Controls.Add(this.Create_button);
            this.Controls.Add(this.listbox_adatok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_adatok;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Create_button;
        private System.Windows.Forms.Button Read_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Position;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Salary;
    }
}

