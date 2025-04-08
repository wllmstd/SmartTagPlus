
namespace SmartTagPlus
{
    partial class F12_ConfirmLogOut
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
            this.yes_btn = new System.Windows.Forms.Button();
            this.no_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yes_btn
            // 
            this.yes_btn.Location = new System.Drawing.Point(442, 351);
            this.yes_btn.Name = "yes_btn";
            this.yes_btn.Size = new System.Drawing.Size(75, 23);
            this.yes_btn.TabIndex = 0;
            this.yes_btn.Text = "Yes";
            this.yes_btn.UseVisualStyleBackColor = true;
            // 
            // no_btn
            // 
            this.no_btn.Location = new System.Drawing.Point(556, 351);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(75, 23);
            this.no_btn.TabIndex = 1;
            this.no_btn.Text = "No";
            this.no_btn.UseVisualStyleBackColor = true;
            // 
            // F12_ConfirmLogOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.no_btn);
            this.Controls.Add(this.yes_btn);
            this.Name = "F12_ConfirmLogOut";
            this.Text = "F12_ConfirmLogOut";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yes_btn;
        private System.Windows.Forms.Button no_btn;
    }
}