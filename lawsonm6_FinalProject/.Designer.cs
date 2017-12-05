/*
 * Author: Michael Lawson
 * Assignment: Final Semester Project
 * Seminar: IT3045C Contemporary Programming
 * Proffessor: Bill Nicholson
 * Description: Recreate Bill's Sat Nav based on his provided youtube video, implimenting only buttons that were pushed in the video.
 * Class Description: frmHomeScreen controls
 * Due Date: 12/5/17
 * References : Bill's youtube video showcasing the sat nav model: https://www.youtube.com/watch?v=uddPUWHdaqo
 *              Creating only one instance of a form at a time: https://stackoverflow.com/questions/3087841/how-can-i-make-a-single-instance-form-not-application
 *              Using events to close forms and go back to invisible previous forms: http://www.techotopia.com/index.php/Hiding_and_Showing_Forms_in_C_Sharp
 */
namespace lawsonm6_FinalProject
{
    partial class frmHomeScreen
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
            this.btnAddress = new System.Windows.Forms.Button();
            this.btnPointOfInterest = new System.Windows.Forms.Button();
            this.btnPreviousDestinations = new System.Windows.Forms.Button();
            this.btnAddressBook = new System.Windows.Forms.Button();
            this.btnEmergency = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.btnDeleteDestination = new System.Windows.Forms.Button();
            this.btnPreset1 = new System.Windows.Forms.Button();
            this.btnPreset2 = new System.Windows.Forms.Button();
            this.btnPreset3 = new System.Windows.Forms.Button();
            this.btnPreset4 = new System.Windows.Forms.Button();
            this.btnPreset5 = new System.Windows.Forms.Button();
            this.btnPresetGoHome = new System.Windows.Forms.Button();
            this.lblPresets = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddress
            // 
            this.btnAddress.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddress.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddress.Location = new System.Drawing.Point(49, 118);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(133, 183);
            this.btnAddress.TabIndex = 0;
            this.btnAddress.Text = "Address";
            this.btnAddress.UseVisualStyleBackColor = false;
            this.btnAddress.Click += new System.EventHandler(this.btnAddress_Click);
            // 
            // btnPointOfInterest
            // 
            this.btnPointOfInterest.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPointOfInterest.Location = new System.Drawing.Point(188, 118);
            this.btnPointOfInterest.Name = "btnPointOfInterest";
            this.btnPointOfInterest.Size = new System.Drawing.Size(133, 183);
            this.btnPointOfInterest.TabIndex = 1;
            this.btnPointOfInterest.Text = "Point of Interest";
            this.btnPointOfInterest.UseVisualStyleBackColor = false;
            // 
            // btnPreviousDestinations
            // 
            this.btnPreviousDestinations.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPreviousDestinations.Location = new System.Drawing.Point(327, 118);
            this.btnPreviousDestinations.Name = "btnPreviousDestinations";
            this.btnPreviousDestinations.Size = new System.Drawing.Size(133, 183);
            this.btnPreviousDestinations.TabIndex = 2;
            this.btnPreviousDestinations.Text = "Previous Destinations";
            this.btnPreviousDestinations.UseVisualStyleBackColor = false;
            // 
            // btnAddressBook
            // 
            this.btnAddressBook.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddressBook.Location = new System.Drawing.Point(466, 118);
            this.btnAddressBook.Name = "btnAddressBook";
            this.btnAddressBook.Size = new System.Drawing.Size(133, 183);
            this.btnAddressBook.TabIndex = 3;
            this.btnAddressBook.Text = "Address Book";
            this.btnAddressBook.UseVisualStyleBackColor = false;
            // 
            // btnEmergency
            // 
            this.btnEmergency.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEmergency.Location = new System.Drawing.Point(605, 118);
            this.btnEmergency.Name = "btnEmergency";
            this.btnEmergency.Size = new System.Drawing.Size(133, 183);
            this.btnEmergency.TabIndex = 4;
            this.btnEmergency.Text = "Emergency";
            this.btnEmergency.UseVisualStyleBackColor = false;
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMore.Location = new System.Drawing.Point(744, 118);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(133, 183);
            this.btnMore.TabIndex = 5;
            this.btnMore.Text = "More";
            this.btnMore.UseVisualStyleBackColor = false;
            // 
            // btnDeleteDestination
            // 
            this.btnDeleteDestination.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteDestination.Location = new System.Drawing.Point(744, 68);
            this.btnDeleteDestination.Name = "btnDeleteDestination";
            this.btnDeleteDestination.Size = new System.Drawing.Size(133, 44);
            this.btnDeleteDestination.TabIndex = 6;
            this.btnDeleteDestination.Text = "Delete Destination";
            this.btnDeleteDestination.UseVisualStyleBackColor = false;
            // 
            // btnPreset1
            // 
            this.btnPreset1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPreset1.Location = new System.Drawing.Point(188, 350);
            this.btnPreset1.Name = "btnPreset1";
            this.btnPreset1.Size = new System.Drawing.Size(133, 44);
            this.btnPreset1.TabIndex = 7;
            this.btnPreset1.Text = "1";
            this.btnPreset1.UseVisualStyleBackColor = false;
            // 
            // btnPreset2
            // 
            this.btnPreset2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPreset2.Location = new System.Drawing.Point(327, 350);
            this.btnPreset2.Name = "btnPreset2";
            this.btnPreset2.Size = new System.Drawing.Size(133, 44);
            this.btnPreset2.TabIndex = 8;
            this.btnPreset2.Text = "2";
            this.btnPreset2.UseVisualStyleBackColor = false;
            // 
            // btnPreset3
            // 
            this.btnPreset3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPreset3.Location = new System.Drawing.Point(466, 350);
            this.btnPreset3.Name = "btnPreset3";
            this.btnPreset3.Size = new System.Drawing.Size(133, 44);
            this.btnPreset3.TabIndex = 9;
            this.btnPreset3.Text = "3";
            this.btnPreset3.UseVisualStyleBackColor = false;
            // 
            // btnPreset4
            // 
            this.btnPreset4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPreset4.Location = new System.Drawing.Point(605, 350);
            this.btnPreset4.Name = "btnPreset4";
            this.btnPreset4.Size = new System.Drawing.Size(133, 44);
            this.btnPreset4.TabIndex = 10;
            this.btnPreset4.Text = "4";
            this.btnPreset4.UseVisualStyleBackColor = false;
            // 
            // btnPreset5
            // 
            this.btnPreset5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPreset5.Location = new System.Drawing.Point(744, 350);
            this.btnPreset5.Name = "btnPreset5";
            this.btnPreset5.Size = new System.Drawing.Size(133, 44);
            this.btnPreset5.TabIndex = 11;
            this.btnPreset5.Text = "5";
            this.btnPreset5.UseVisualStyleBackColor = false;
            // 
            // btnPresetGoHome
            // 
            this.btnPresetGoHome.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPresetGoHome.Location = new System.Drawing.Point(49, 350);
            this.btnPresetGoHome.Name = "btnPresetGoHome";
            this.btnPresetGoHome.Size = new System.Drawing.Size(133, 44);
            this.btnPresetGoHome.TabIndex = 12;
            this.btnPresetGoHome.Text = "Go Home";
            this.btnPresetGoHome.UseVisualStyleBackColor = false;
            // 
            // lblPresets
            // 
            this.lblPresets.AutoSize = true;
            this.lblPresets.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresets.Location = new System.Drawing.Point(53, 303);
            this.lblPresets.Name = "lblPresets";
            this.lblPresets.Size = new System.Drawing.Size(115, 31);
            this.lblPresets.TabIndex = 13;
            this.lblPresets.Text = "Presets:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExit.Location = new System.Drawing.Point(744, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 44);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(922, 426);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPresets);
            this.Controls.Add(this.btnPresetGoHome);
            this.Controls.Add(this.btnPreset5);
            this.Controls.Add(this.btnPreset4);
            this.Controls.Add(this.btnPreset3);
            this.Controls.Add(this.btnPreset2);
            this.Controls.Add(this.btnPreset1);
            this.Controls.Add(this.btnDeleteDestination);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.btnEmergency);
            this.Controls.Add(this.btnAddressBook);
            this.Controls.Add(this.btnPreviousDestinations);
            this.Controls.Add(this.btnPointOfInterest);
            this.Controls.Add(this.btnAddress);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "frmHomeScreen";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHomeScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.Button btnPointOfInterest;
        private System.Windows.Forms.Button btnPreviousDestinations;
        private System.Windows.Forms.Button btnAddressBook;
        private System.Windows.Forms.Button btnEmergency;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Button btnDeleteDestination;
        private System.Windows.Forms.Button btnPreset1;
        private System.Windows.Forms.Button btnPreset2;
        private System.Windows.Forms.Button btnPreset3;
        private System.Windows.Forms.Button btnPreset4;
        private System.Windows.Forms.Button btnPreset5;
        private System.Windows.Forms.Button btnPresetGoHome;
        private System.Windows.Forms.Label lblPresets;
        private System.Windows.Forms.Button btnExit;
    }
}

