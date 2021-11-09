namespace Homework_UI
{
    partial class Assignment
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
            this.PBXSubject = new System.Windows.Forms.PictureBox();
            this.TBXDespcription = new System.Windows.Forms.TextBox();
            this.TBXDue = new System.Windows.Forms.TextBox();
            this.TBXSubject = new System.Windows.Forms.TextBox();
            this.TBXName = new System.Windows.Forms.TextBox();
            this.CBXSubmit = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBXSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // PBXSubject
            // 
            this.PBXSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBXSubject.Location = new System.Drawing.Point(4, 5);
            this.PBXSubject.Margin = new System.Windows.Forms.Padding(4);
            this.PBXSubject.Name = "PBXSubject";
            this.PBXSubject.Size = new System.Drawing.Size(120, 120);
            this.PBXSubject.TabIndex = 0;
            this.PBXSubject.TabStop = false;
            // 
            // TBXDespcription
            // 
            this.TBXDespcription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXDespcription.Location = new System.Drawing.Point(127, 36);
            this.TBXDespcription.Margin = new System.Windows.Forms.Padding(4);
            this.TBXDespcription.Multiline = true;
            this.TBXDespcription.Name = "TBXDespcription";
            this.TBXDespcription.Size = new System.Drawing.Size(869, 89);
            this.TBXDespcription.TabIndex = 2;
            // 
            // TBXDue
            // 
            this.TBXDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXDue.Location = new System.Drawing.Point(682, 6);
            this.TBXDue.Margin = new System.Windows.Forms.Padding(4);
            this.TBXDue.Name = "TBXDue";
            this.TBXDue.Size = new System.Drawing.Size(209, 27);
            this.TBXDue.TabIndex = 3;
            // 
            // TBXSubject
            // 
            this.TBXSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXSubject.Location = new System.Drawing.Point(127, 6);
            this.TBXSubject.Margin = new System.Windows.Forms.Padding(4);
            this.TBXSubject.Name = "TBXSubject";
            this.TBXSubject.Size = new System.Drawing.Size(130, 27);
            this.TBXSubject.TabIndex = 4;
            // 
            // TBXName
            // 
            this.TBXName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXName.Location = new System.Drawing.Point(265, 6);
            this.TBXName.Margin = new System.Windows.Forms.Padding(4);
            this.TBXName.Name = "TBXName";
            this.TBXName.Size = new System.Drawing.Size(132, 27);
            this.TBXName.TabIndex = 5;
            // 
            // CBXSubmit
            // 
            this.CBXSubmit.AutoSize = true;
            this.CBXSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CBXSubmit.Location = new System.Drawing.Point(898, 11);
            this.CBXSubmit.Name = "CBXSubmit";
            this.CBXSubmit.Size = new System.Drawing.Size(73, 21);
            this.CBXSubmit.TabIndex = 6;
            this.CBXSubmit.Text = "Submit";
            this.CBXSubmit.UseVisualStyleBackColor = true;
            // 
            // Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.CBXSubmit);
            this.Controls.Add(this.TBXName);
            this.Controls.Add(this.TBXSubject);
            this.Controls.Add(this.TBXDue);
            this.Controls.Add(this.TBXDespcription);
            this.Controls.Add(this.PBXSubject);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Assignment";
            this.Size = new System.Drawing.Size(1000, 130);
            this.Load += new System.EventHandler(this.Assignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBXSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBXSubject;
        private System.Windows.Forms.TextBox TBXDespcription;
        private System.Windows.Forms.TextBox TBXDue;
        private System.Windows.Forms.TextBox TBXSubject;
        private System.Windows.Forms.TextBox TBXName;
        private System.Windows.Forms.CheckBox CBXSubmit;
    }
}
