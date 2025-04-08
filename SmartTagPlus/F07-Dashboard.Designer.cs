
namespace SmartTagPlus
{
    partial class F07_Dashboard
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
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.records_btn = new System.Windows.Forms.Button();
            this.students_btn = new System.Windows.Forms.Button();
            this.calendar_btn = new System.Windows.Forms.Button();
            this.news_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Location = new System.Drawing.Point(38, 54);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(160, 37);
            this.dashboard_btn.TabIndex = 0;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            // 
            // records_btn
            // 
            this.records_btn.Location = new System.Drawing.Point(38, 122);
            this.records_btn.Name = "records_btn";
            this.records_btn.Size = new System.Drawing.Size(160, 37);
            this.records_btn.TabIndex = 1;
            this.records_btn.Text = "Records";
            this.records_btn.UseVisualStyleBackColor = true;
            this.records_btn.Click += new System.EventHandler(this.records_btn_Click);
            // 
            // students_btn
            // 
            this.students_btn.Location = new System.Drawing.Point(38, 190);
            this.students_btn.Name = "students_btn";
            this.students_btn.Size = new System.Drawing.Size(160, 37);
            this.students_btn.TabIndex = 2;
            this.students_btn.Text = "Students";
            this.students_btn.UseVisualStyleBackColor = true;
            this.students_btn.Click += new System.EventHandler(this.students_btn_Click);
            // 
            // calendar_btn
            // 
            this.calendar_btn.Location = new System.Drawing.Point(38, 260);
            this.calendar_btn.Name = "calendar_btn";
            this.calendar_btn.Size = new System.Drawing.Size(160, 37);
            this.calendar_btn.TabIndex = 3;
            this.calendar_btn.Text = "Calendar";
            this.calendar_btn.UseVisualStyleBackColor = true;
            this.calendar_btn.Click += new System.EventHandler(this.calendar_btn_Click);
            // 
            // news_btn
            // 
            this.news_btn.Location = new System.Drawing.Point(38, 333);
            this.news_btn.Name = "news_btn";
            this.news_btn.Size = new System.Drawing.Size(160, 37);
            this.news_btn.TabIndex = 4;
            this.news_btn.Text = "News";
            this.news_btn.UseVisualStyleBackColor = true;
            this.news_btn.Click += new System.EventHandler(this.news_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(38, 521);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(160, 37);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time In Today";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(747, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time Out Today";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Events";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(747, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Students";
            // 
            // F07_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.news_btn);
            this.Controls.Add(this.calendar_btn);
            this.Controls.Add(this.students_btn);
            this.Controls.Add(this.records_btn);
            this.Controls.Add(this.dashboard_btn);
            this.Name = "F07_Dashboard";
            this.Text = "F07_Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button records_btn;
        private System.Windows.Forms.Button students_btn;
        private System.Windows.Forms.Button calendar_btn;
        private System.Windows.Forms.Button news_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}