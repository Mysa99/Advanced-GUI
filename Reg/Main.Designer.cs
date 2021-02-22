
namespace Reg
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientButton1 = new GradiantControl.GradientButton();
            this.gradientButton6 = new GradiantControl.GradientButton();
            this.gradientButton5 = new GradiantControl.GradientButton();
            this.button1 = new System.Windows.Forms.Button();
            this.messageBoxes11 = new Reg.MessageBoxes1();
            this.open_File_Dialogs11 = new Reg.Open_File_Dialogs1();
            this.MessageBtn2 = new GradiantControl.GradientButton();
            this.MessageBtn1 = new GradiantControl.GradientButton();
            this.dashboaard1 = new Reg.dashboaard();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gradientButton1);
            this.panel1.Controls.Add(this.gradientButton6);
            this.panel1.Controls.Add(this.gradientButton5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 590);
            this.panel1.TabIndex = 2;
            // 
            // gradientButton1
            // 
            this.gradientButton1.FlatAppearance.BorderSize = 0;
            this.gradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("gradientButton1.Image")));
            this.gradientButton1.LeftColor = System.Drawing.Color.Crimson;
            this.gradientButton1.Location = new System.Drawing.Point(12, 9);
            this.gradientButton1.Name = "gradientButton1";
            this.gradientButton1.RightColor = System.Drawing.Color.Blue;
            this.gradientButton1.Size = new System.Drawing.Size(111, 37);
            this.gradientButton1.TabIndex = 4;
            this.gradientButton1.Text = "Dashboard";
            this.gradientButton1.UseVisualStyleBackColor = true;
            this.gradientButton1.Click += new System.EventHandler(this.gradientButton1_Click_1);
            // 
            // gradientButton6
            // 
            this.gradientButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradientButton6.FlatAppearance.BorderSize = 0;
            this.gradientButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gradientButton6.LeftColor = System.Drawing.Color.Cyan;
            this.gradientButton6.Location = new System.Drawing.Point(12, 95);
            this.gradientButton6.Name = "gradientButton6";
            this.gradientButton6.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gradientButton6.Size = new System.Drawing.Size(108, 37);
            this.gradientButton6.TabIndex = 3;
            this.gradientButton6.Text = "Open File Dialogs";
            this.gradientButton6.UseVisualStyleBackColor = true;
            this.gradientButton6.Click += new System.EventHandler(this.gradientButton6_Click);
            // 
            // gradientButton5
            // 
            this.gradientButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradientButton5.FlatAppearance.BorderSize = 0;
            this.gradientButton5.LeftColor = System.Drawing.Color.Cyan;
            this.gradientButton5.Location = new System.Drawing.Point(12, 52);
            this.gradientButton5.Name = "gradientButton5";
            this.gradientButton5.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gradientButton5.Size = new System.Drawing.Size(108, 37);
            this.gradientButton5.TabIndex = 2;
            this.gradientButton5.Text = "MessageBox";
            this.gradientButton5.UseVisualStyleBackColor = true;
            this.gradientButton5.Click += new System.EventHandler(this.gradientButton5_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(881, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // messageBoxes11
            // 
            this.messageBoxes11.BackColor = System.Drawing.Color.Transparent;
            this.messageBoxes11.Location = new System.Drawing.Point(117, 0);
            this.messageBoxes11.Name = "messageBoxes11";
            this.messageBoxes11.Size = new System.Drawing.Size(568, 457);
            this.messageBoxes11.TabIndex = 4;
            // 
            // open_File_Dialogs11
            // 
            this.open_File_Dialogs11.BackColor = System.Drawing.Color.Transparent;
            this.open_File_Dialogs11.Location = new System.Drawing.Point(117, 26);
            this.open_File_Dialogs11.Name = "open_File_Dialogs11";
            this.open_File_Dialogs11.Size = new System.Drawing.Size(692, 489);
            this.open_File_Dialogs11.TabIndex = 5;
            this.open_File_Dialogs11.Load += new System.EventHandler(this.open_File_Dialogs11_Load);
            // 
            // MessageBtn2
            // 
            this.MessageBtn2.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MessageBtn2.Location = new System.Drawing.Point(575, 259);
            this.MessageBtn2.Name = "MessageBtn2";
            this.MessageBtn2.RightColor = System.Drawing.Color.Navy;
            this.MessageBtn2.Size = new System.Drawing.Size(200, 37);
            this.MessageBtn2.TabIndex = 10;
            this.MessageBtn2.Text = "Show Info";
            this.MessageBtn2.UseVisualStyleBackColor = true;
            this.MessageBtn2.Click += new System.EventHandler(this.GradientButton2_Click);
            // 
            // MessageBtn1
            // 
            this.MessageBtn1.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MessageBtn1.Location = new System.Drawing.Point(152, 131);
            this.MessageBtn1.Name = "MessageBtn1";
            this.MessageBtn1.RightColor = System.Drawing.Color.Navy;
            this.MessageBtn1.Size = new System.Drawing.Size(193, 37);
            this.MessageBtn1.TabIndex = 11;
            this.MessageBtn1.Text = "Show Info";
            this.MessageBtn1.UseVisualStyleBackColor = true;
            this.MessageBtn1.Click += new System.EventHandler(this.gradientButton3_Click);
            // 
            // dashboaard1
            // 
            this.dashboaard1.BackColor = System.Drawing.Color.Transparent;
            this.dashboaard1.Location = new System.Drawing.Point(129, 0);
            this.dashboaard1.Name = "dashboaard1";
            this.dashboaard1.Size = new System.Drawing.Size(764, 558);
            this.dashboaard1.TabIndex = 12;
            this.dashboaard1.Load += new System.EventHandler(this.dashboaard1_Load);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(912, 590);
            this.Controls.Add(this.dashboaard1);
            this.Controls.Add(this.MessageBtn1);
            this.Controls.Add(this.MessageBtn2);
            this.Controls.Add(this.open_File_Dialogs11);
            this.Controls.Add(this.messageBoxes11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private GradiantControl.GradientButton gradientButton6;
        private GradiantControl.GradientButton gradientButton5;
        private GradiantControl.GradientButton gradientButton1;
        private MessageBoxes1 messageBoxes11;
        private Open_File_Dialogs1 open_File_Dialogs11;
        private GradiantControl.GradientButton MessageBtn2;
        private GradiantControl.GradientButton MessageBtn1;
        private dashboaard dashboaard1;
    }
}