
namespace WindowsFormsApp3
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
            this.btnsayhello = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblenteryourname = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher3 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher4 = new System.DirectoryServices.DirectorySearcher();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblreasult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsayhello
            // 
            this.btnsayhello.Enabled = false;
            this.btnsayhello.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsayhello.Location = new System.Drawing.Point(48, 123);
            this.btnsayhello.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsayhello.Name = "btnsayhello";
            this.btnsayhello.Size = new System.Drawing.Size(131, 96);
            this.btnsayhello.TabIndex = 0;
            this.btnsayhello.Text = "say hello";
            this.btnsayhello.UseVisualStyleBackColor = true;
            this.btnsayhello.Click += new System.EventHandler(this.btnsayhello_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(445, 123);
            this.btnexit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(144, 94);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblenteryourname
            // 
            this.lblenteryourname.AutoSize = true;
            this.lblenteryourname.Location = new System.Drawing.Point(35, 22);
            this.lblenteryourname.Name = "lblenteryourname";
            this.lblenteryourname.Size = new System.Drawing.Size(122, 19);
            this.lblenteryourname.TabIndex = 3;
            this.lblenteryourname.Text = "enter your name:";
            this.lblenteryourname.Click += new System.EventHandler(this.label1_Click);
            this.lblenteryourname.MouseLeave += new System.EventHandler(this.lblenteryourname_MouseLeave);
            this.lblenteryourname.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblenteryourname_MouseMove);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher3
            // 
            this.directorySearcher3.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher3.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher3.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher4
            // 
            this.directorySearcher4.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher4.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher4.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(199, 22);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(229, 43);
            this.txtname.TabIndex = 4;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(236, 123);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(141, 94);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 6;
            // 
            // lblreasult
            // 
            this.lblreasult.AutoSize = true;
            this.lblreasult.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreasult.Location = new System.Drawing.Point(65, 275);
            this.lblreasult.Name = "lblreasult";
            this.lblreasult.Size = new System.Drawing.Size(194, 22);
            this.lblreasult.TabIndex = 7;
            this.lblreasult.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(806, 352);
            this.Controls.Add(this.lblreasult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblenteryourname);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsayhello);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsayhello;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblenteryourname;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.DirectoryServices.DirectorySearcher directorySearcher3;
        private System.DirectoryServices.DirectorySearcher directorySearcher4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lblreasult;
    }
}

