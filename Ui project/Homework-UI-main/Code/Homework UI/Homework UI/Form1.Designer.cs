namespace Homework_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBXDesc = new System.Windows.Forms.TextBox();
            this.TBXDueDate = new System.Windows.Forms.TextBox();
            this.TBXTitle = new System.Windows.Forms.TextBox();
            this.TBXSubject = new System.Windows.Forms.TextBox();
            this.BTNCreateTask = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 509);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1057, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Assigned";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1057, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Done";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1057, 480);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Missing";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Controls.Add(this.BTNCreateTask);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1057, 480);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Assign Tasks";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TBXDesc);
            this.panel1.Controls.Add(this.TBXDueDate);
            this.panel1.Controls.Add(this.TBXTitle);
            this.panel1.Controls.Add(this.TBXSubject);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 206);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Due Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subject";
            // 
            // TBXDesc
            // 
            this.TBXDesc.Location = new System.Drawing.Point(3, 88);
            this.TBXDesc.Multiline = true;
            this.TBXDesc.Name = "TBXDesc";
            this.TBXDesc.Size = new System.Drawing.Size(213, 115);
            this.TBXDesc.TabIndex = 4;
            // 
            // TBXDueDate
            // 
            this.TBXDueDate.Location = new System.Drawing.Point(3, 60);
            this.TBXDueDate.Multiline = true;
            this.TBXDueDate.Name = "TBXDueDate";
            this.TBXDueDate.Size = new System.Drawing.Size(213, 22);
            this.TBXDueDate.TabIndex = 3;
            // 
            // TBXTitle
            // 
            this.TBXTitle.Location = new System.Drawing.Point(3, 32);
            this.TBXTitle.Multiline = true;
            this.TBXTitle.Name = "TBXTitle";
            this.TBXTitle.Size = new System.Drawing.Size(213, 22);
            this.TBXTitle.TabIndex = 1;
            // 
            // TBXSubject
            // 
            this.TBXSubject.Location = new System.Drawing.Point(3, 3);
            this.TBXSubject.Multiline = true;
            this.TBXSubject.Name = "TBXSubject";
            this.TBXSubject.Size = new System.Drawing.Size(213, 22);
            this.TBXSubject.TabIndex = 0;
            // 
            // BTNCreateTask
            // 
            this.BTNCreateTask.Location = new System.Drawing.Point(6, 431);
            this.BTNCreateTask.Name = "BTNCreateTask";
            this.BTNCreateTask.Size = new System.Drawing.Size(1045, 43);
            this.BTNCreateTask.TabIndex = 2;
            this.BTNCreateTask.Text = "Create Task";
            this.BTNCreateTask.UseVisualStyleBackColor = true;
            this.BTNCreateTask.Click += new System.EventHandler(this.BTNCreateTask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 529);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 500);
            this.Name = "Form1";
            this.Text = "Homework Manager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BTNCreateTask;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBXDesc;
        private System.Windows.Forms.TextBox TBXDueDate;
        private System.Windows.Forms.TextBox TBXTitle;
        private System.Windows.Forms.TextBox TBXSubject;
    }
}

