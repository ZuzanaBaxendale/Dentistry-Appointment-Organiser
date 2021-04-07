
namespace dentist_orangiser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pctBxBlueHeading = new System.Windows.Forms.PictureBox();
            this.lblHeadingMain = new System.Windows.Forms.Label();
            this.pctBxToolBar = new System.Windows.Forms.PictureBox();
            this.btnAdminLogIn = new System.Windows.Forms.Button();
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTreatments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxBlueHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxToolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBxBlueHeading
            // 
            this.pctBxBlueHeading.BackColor = System.Drawing.Color.SteelBlue;
            this.pctBxBlueHeading.Location = new System.Drawing.Point(0, 0);
            this.pctBxBlueHeading.Name = "pctBxBlueHeading";
            this.pctBxBlueHeading.Size = new System.Drawing.Size(1338, 89);
            this.pctBxBlueHeading.TabIndex = 0;
            this.pctBxBlueHeading.TabStop = false;
            // 
            // lblHeadingMain
            // 
            this.lblHeadingMain.AutoSize = true;
            this.lblHeadingMain.BackColor = System.Drawing.Color.SteelBlue;
            this.lblHeadingMain.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeadingMain.ForeColor = System.Drawing.Color.White;
            this.lblHeadingMain.Location = new System.Drawing.Point(12, 9);
            this.lblHeadingMain.Name = "lblHeadingMain";
            this.lblHeadingMain.Size = new System.Drawing.Size(575, 67);
            this.lblHeadingMain.TabIndex = 1;
            this.lblHeadingMain.Text = "Dentistry Organiser 3000";
            // 
            // pctBxToolBar
            // 
            this.pctBxToolBar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pctBxToolBar.Location = new System.Drawing.Point(0, 87);
            this.pctBxToolBar.Name = "pctBxToolBar";
            this.pctBxToolBar.Size = new System.Drawing.Size(1338, 44);
            this.pctBxToolBar.TabIndex = 2;
            this.pctBxToolBar.TabStop = false;
            // 
            // btnAdminLogIn
            // 
            this.btnAdminLogIn.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAdminLogIn.Location = new System.Drawing.Point(32, 93);
            this.btnAdminLogIn.Name = "btnAdminLogIn";
            this.btnAdminLogIn.Size = new System.Drawing.Size(151, 33);
            this.btnAdminLogIn.TabIndex = 3;
            this.btnAdminLogIn.Text = "Admin Log In";
            this.btnAdminLogIn.UseVisualStyleBackColor = false;
            this.btnAdminLogIn.Click += new System.EventHandler(this.btnAdminLogIn_Click);
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBookAppointment.Location = new System.Drawing.Point(211, 93);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(151, 33);
            this.btnBookAppointment.TabIndex = 4;
            this.btnBookAppointment.Text = "Book Appointment";
            this.btnBookAppointment.UseMnemonic = false;
            this.btnBookAppointment.UseVisualStyleBackColor = false;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1338, 798);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnTreatments
            // 
            this.btnTreatments.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTreatments.Location = new System.Drawing.Point(387, 93);
            this.btnTreatments.Name = "btnTreatments";
            this.btnTreatments.Size = new System.Drawing.Size(151, 33);
            this.btnTreatments.TabIndex = 6;
            this.btnTreatments.Text = "View Treatments";
            this.btnTreatments.UseMnemonic = false;
            this.btnTreatments.UseVisualStyleBackColor = false;
            this.btnTreatments.Click += new System.EventHandler(this.btnTreatments_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 927);
            this.Controls.Add(this.btnTreatments);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBookAppointment);
            this.Controls.Add(this.btnAdminLogIn);
            this.Controls.Add(this.pctBxToolBar);
            this.Controls.Add(this.lblHeadingMain);
            this.Controls.Add(this.pctBxBlueHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBxBlueHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxToolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBxBlueHeading;
        private System.Windows.Forms.Label lblHeadingMain;
        private System.Windows.Forms.PictureBox pctBxToolBar;
        private System.Windows.Forms.Button btnAdminLogIn;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTreatments;
    }
}

