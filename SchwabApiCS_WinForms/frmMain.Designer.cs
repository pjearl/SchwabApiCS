namespace SchwabApiCS_WinForms
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAccounts = new Button();
            SuspendLayout();
            // 
            // btnAccounts
            // 
            btnAccounts.Location = new Point(34, 65);
            btnAccounts.Name = "btnAccounts";
            btnAccounts.Size = new Size(121, 60);
            btnAccounts.TabIndex = 0;
            btnAccounts.Text = " Accounts";
            btnAccounts.UseVisualStyleBackColor = true;
            btnAccounts.Click += btnAccounts_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAccounts);
            Name = "frmMain";
            Text = "Schwab API";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAccounts;
    }
}
