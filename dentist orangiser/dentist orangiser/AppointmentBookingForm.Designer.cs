
namespace dentist_orangiser
{
    partial class AppointmentBookingForm
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
            this.pctBxToolBar = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblHeadingAppointment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxBlueHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxToolBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBxBlueHeading
            // 
            this.pctBxBlueHeading.BackColor = System.Drawing.Color.SteelBlue;
            this.pctBxBlueHeading.Location = new System.Drawing.Point(0, 0);
            this.pctBxBlueHeading.Name = "pctBxBlueHeading";
            this.pctBxBlueHeading.Size = new System.Drawing.Size(1338, 89);
            this.pctBxBlueHeading.TabIndex = 1;
            this.pctBxBlueHeading.TabStop = false;
            // 
            // pctBxToolBar
            // 
            this.pctBxToolBar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pctBxToolBar.Location = new System.Drawing.Point(0, 87);
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
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblHeadingAppointment
            // 
            this.lblHeadingAppointment.AutoSize = true;
            this.lblHeadingAppointment.BackColor = System.Drawing.Color.SteelBlue;
            this.lblHeadingAppointment.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeadingAppointment.ForeColor = System.Drawing.Color.White;
            this.lblHeadingAppointment.Location = new System.Drawing.Point(12, 18);
            this.lblHeadingAppointment.Name = "lblHeadingAppointment";
            this.lblHeadingAppointment.Size = new System.Drawing.Size(413, 54);
            this.lblHeadingAppointment.TabIndex = 6;
            this.lblHeadingAppointment.Text = "Book an Appointment";
            // 
            // AppointmentBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 927);
            this.Controls.Add(this.lblHeadingAppointment);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pctBxToolBar);
            this.Controls.Add(this.pctBxBlueHeading);
            this.Name = "AppointmentBookingForm";
            this.Text = "AppointmentBookingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pctBxBlueHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxToolBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBxBlueHeading;
        private System.Windows.Forms.PictureBox pctBxToolBar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblHeadingAppointment;
    }
}