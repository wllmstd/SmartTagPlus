
namespace SmartTagPlus
{
    partial class F10_Calendar
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
            this.logout_btn = new System.Windows.Forms.Button();
            this.news_btn = new System.Windows.Forms.Button();
            this.calendar_btn = new System.Windows.Forms.Button();
            this.students_btn = new System.Windows.Forms.Button();
            this.records_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(48, 524);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(160, 37);
            this.logout_btn.TabIndex = 17;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // news_btn
            // 
            this.news_btn.Location = new System.Drawing.Point(48, 336);
            this.news_btn.Name = "news_btn";
            this.news_btn.Size = new System.Drawing.Size(160, 37);
            this.news_btn.TabIndex = 16;
            this.news_btn.Text = "News";
            this.news_btn.UseVisualStyleBackColor = true;
            this.news_btn.Click += new System.EventHandler(this.news_btn_Click);
            // 
            // calendar_btn
            // 
            this.calendar_btn.Location = new System.Drawing.Point(48, 263);
            this.calendar_btn.Name = "calendar_btn";
            this.calendar_btn.Size = new System.Drawing.Size(160, 37);
            this.calendar_btn.TabIndex = 15;
            this.calendar_btn.Text = "Calendar";
            this.calendar_btn.UseVisualStyleBackColor = true;
            // 
            // students_btn
            // 
            this.students_btn.Location = new System.Drawing.Point(48, 193);
            this.students_btn.Name = "students_btn";
            this.students_btn.Size = new System.Drawing.Size(160, 37);
            this.students_btn.TabIndex = 14;
            this.students_btn.Text = "Students";
            this.students_btn.UseVisualStyleBackColor = true;
            this.students_btn.Click += new System.EventHandler(this.students_btn_Click);
            // 
            // records_btn
            // 
            this.records_btn.Location = new System.Drawing.Point(48, 125);
            this.records_btn.Name = "records_btn";
            this.records_btn.Size = new System.Drawing.Size(160, 37);
            this.records_btn.TabIndex = 13;
            this.records_btn.Text = "Records";
            this.records_btn.UseVisualStyleBackColor = true;
            this.records_btn.Click += new System.EventHandler(this.records_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Location = new System.Drawing.Point(48, 57);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(160, 37);
            this.dashboard_btn.TabIndex = 12;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // F10_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.news_btn);
            this.Controls.Add(this.calendar_btn);
            this.Controls.Add(this.students_btn);
            this.Controls.Add(this.records_btn);
            this.Controls.Add(this.dashboard_btn);
            this.Name = "F10_Calendar";
            this.Text = "F10_Calendar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button news_btn;
        private System.Windows.Forms.Button calendar_btn;
        private System.Windows.Forms.Button students_btn;
        private System.Windows.Forms.Button records_btn;
        private System.Windows.Forms.Button dashboard_btn;
    }
}