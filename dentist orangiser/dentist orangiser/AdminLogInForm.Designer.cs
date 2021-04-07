
namespace dentist_orangiser
{
    partial class AdminLogInForm
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
            this.pctBxBlueHeading = new System.Windows.Forms.PictureBox();
            this.lblHeadingAdminLogIn = new System.Windows.Forms.Label();
            this.pctBxToolBar = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxBlueHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxToolBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBxBlueHeading
            // 
            this.pctBxBlueHeading.BackColor = System.Drawing.Color.SteelBlue;
            this.pctBxBlueHeading.Location = new System.Drawing.Point(1, 0);
            this.pctBxBlueHeading.Name = "pctBxBlueHeading";
            this.pctBxBlueHeading.Size = new System.Drawing.Size(1338, 89);
            this.pctBxBlueHeading.TabIndex = 1;
            this.pctBxBlueHeading.TabStop = false;
            // 
            // lblHeadingAdminLogIn
            // 
            this.lblHeadingAdminLogIn.AutoSize = true;
            this.lblHeadingAdminLogIn.BackColor = System.Drawing.Color.SteelBlue;
            this.lblHeadingAdminLogIn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeadingAdminLogIn.ForeColor = System.Drawing.Color.White;
            this.lblHeadingAdminLogIn.Location = new System.Drawing.Point(12, 18);
            this.lblHeadingAdminLogIn.Name = "lblHeadingAdminLogIn";
            this.lblHeadingAdminLogIn.Size = new System.Drawing.Size(262, 54);
            this.lblHeadingAdminLogIn.TabIndex = 2;
            this.lblHeadingAdminLogIn.Text = "Admin Log In";
            // 
            // pctBxToolBar
            // 
            this.pctBxToolBar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pctBxToolBar.Location = new System.Drawing.Point(1, 88);
            this.pctBxToolBar.Name = "pctBxToolBar";
            this.pctBxToolBar.Size = new System.Drawing.Size(1338, 44);
            this.pctBxToolBar.TabIndex = 3;
            this.pctBxToolBar.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.SkyBlue;
            this.btnHome.Location = new System.Drawing.Point(32, 93);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(151, 33);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.Location = new System.Drawing.Point(32, 251);
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(322, 27);
            this.txtBxUsername.TabIndex = 5;
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(32, 322);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(322, 27);
            this.txtBxPassword.TabIndex = 6;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(32, 210);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(142, 38);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(32, 281);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(132, 38);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogIn.Location = new System.Drawing.Point(32, 374);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(322, 33);
            this.btnLogIn.TabIndex = 9;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            // 
            // AdminLogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 927);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsername);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pctBxToolBar);
            this.Controls.Add(this.lblHeadingAdminLogIn);
            this.Controls.Add(this.pctBxBlueHeading);
            this.Name = "AdminLogInForm";
            this.Text = "AdminLogInForm";
            ((System.ComponentModel.ISupportInitialize)(this.pctBxBlueHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxToolBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBxBlueHeading;
        private System.Windows.Forms.Label lblHeadingAdminLogIn;
        private System.Windows.Forms.PictureBox pctBxToolBar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtBxUsername;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogIn;
    }
}