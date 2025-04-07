
namespace SmartTagPlus
{
    partial class F01_Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F01_Welcome));
            this.proceed_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // proceed_btn
            // 
            resources.ApplyResources(this.proceed_btn, "proceed_btn");
            this.proceed_btn.Name = "proceed_btn";
            this.proceed_btn.UseVisualStyleBackColor = true;
            this.proceed_btn.Click += new System.EventHandler(this.proceed_btn_Click);
            // 
            // exit_btn
            // 
            resources.ApplyResources(this.exit_btn, "exit_btn");
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // F01_Welcome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.proceed_btn);
            this.Name = "F01_Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button proceed_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}

