
namespace SmartTagPlus
{
    partial class F06_InOrOut
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
            this.timeout_btn = new System.Windows.Forms.Button();
            this.timein_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeout_btn
            // 
            this.timeout_btn.Location = new System.Drawing.Point(625, 330);
            this.timeout_btn.Name = "timeout_btn";
            this.timeout_btn.Size = new System.Drawing.Size(75, 23);
            this.timeout_btn.TabIndex = 3;
            this.timeout_btn.Text = "Time Out";
            this.timeout_btn.UseVisualStyleBackColor = true;
            this.timeout_btn.Click += new System.EventHandler(this.timeout_btn_Click);
            // 
            // timein_btn
            // 
            this.timein_btn.Location = new System.Drawing.Point(395, 330);
            this.timein_btn.Name = "timein_btn";
            this.timein_btn.Size = new System.Drawing.Size(75, 23);
            this.timein_btn.TabIndex = 2;
            this.timein_btn.Text = "Time In";
            this.timein_btn.UseVisualStyleBackColor = true;
            this.timein_btn.Click += new System.EventHandler(this.timein_btn_Click);
            // 
            // F06_InOrOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.timeout_btn);
            this.Controls.Add(this.timein_btn);
            this.Name = "F06_InOrOut";
            this.Text = "F06_InOrOut";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button timeout_btn;
        private System.Windows.Forms.Button timein_btn;
    }
}