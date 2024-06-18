namespace TafesaClient
{
    partial class enrolment
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
            this.studentTextBox = new System.Windows.Forms.TextBox();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.enrolListBox = new System.Windows.Forms.ListBox();
            this.messageLabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentTextBox
            // 
            this.studentTextBox.Location = new System.Drawing.Point(169, 81);
            this.studentTextBox.Name = "studentTextBox";
            this.studentTextBox.Size = new System.Drawing.Size(100, 22);
            this.studentTextBox.TabIndex = 0;
            // 
            // courseTextBox
            // 
            this.courseTextBox.Location = new System.Drawing.Point(495, 81);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(100, 22);
            this.courseTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Enrol Student ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.enrol_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Get Enrolments";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.getEnrol_click);
            // 
            // enrolListBox
            // 
            this.enrolListBox.FormattingEnabled = true;
            this.enrolListBox.ItemHeight = 16;
            this.enrolListBox.Location = new System.Drawing.Point(180, 285);
            this.enrolListBox.Name = "enrolListBox";
            this.enrolListBox.Size = new System.Drawing.Size(291, 100);
            this.enrolListBox.TabIndex = 6;
            // 
            // messageLabel3
            // 
            this.messageLabel3.AutoSize = true;
            this.messageLabel3.Location = new System.Drawing.Point(561, 176);
            this.messageLabel3.Name = "messageLabel3";
            this.messageLabel3.Size = new System.Drawing.Size(0, 16);
            this.messageLabel3.TabIndex = 7;
            // 
            // enrolment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.messageLabel3);
            this.Controls.Add(this.enrolListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseTextBox);
            this.Controls.Add(this.studentTextBox);
            this.Name = "enrolment";
            this.Text = "enrolment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentTextBox;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox enrolListBox;
        private System.Windows.Forms.Label messageLabel3;
    }
}