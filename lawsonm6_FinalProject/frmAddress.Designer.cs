/*
 * Author: Michael Lawson
 * Assignment: Final Semester Project
 * Seminar: IT3045C Contemporary Programming
 * Proffessor: Bill Nicholson
 * Description: Recreate Bill's Sat Nav based on his provided youtube video, implimenting only buttons that were pushed in the video.
 * Class Description: frmAddress controls
 * Due Date: 12/5/17
 * References : Bill's youtube video showcasing the sat nav model: https://www.youtube.com/watch?v=uddPUWHdaqo
 *              Creating only one instance of a form at a time: https://stackoverflow.com/questions/3087841/how-can-i-make-a-single-instance-form-not-application
 *              Using events to close forms and go back to invisible previous forms: http://www.techotopia.com/index.php/Hiding_and_Showing_Forms_in_C_Sharp
 */
namespace lawsonm6_FinalProject
{
    partial class frmAddress
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
            this.btnChangeStateProvince = new System.Windows.Forms.Button();
            this.tbAddressDisplaySelectedState = new System.Windows.Forms.TextBox();
            this.btnAddressReturn = new System.Windows.Forms.Button();
            this.btnStreetAddress = new System.Windows.Forms.Button();
            this.btnCity = new System.Windows.Forms.Button();
            this.lblChoose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangeStateProvince
            // 
            this.btnChangeStateProvince.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChangeStateProvince.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnChangeStateProvince.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeStateProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnChangeStateProvince.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnChangeStateProvince.Location = new System.Drawing.Point(98, 84);
            this.btnChangeStateProvince.Name = "btnChangeStateProvince";
            this.btnChangeStateProvince.Size = new System.Drawing.Size(385, 43);
            this.btnChangeStateProvince.TabIndex = 0;
            this.btnChangeStateProvince.Text = "Change State/Province";
            this.btnChangeStateProvince.UseVisualStyleBackColor = false;
            this.btnChangeStateProvince.Click += new System.EventHandler(this.btnChangeStateProvince_Click);
            // 
            // tbAddressDisplaySelectedState
            // 
            this.tbAddressDisplaySelectedState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.tbAddressDisplaySelectedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbAddressDisplaySelectedState.ForeColor = System.Drawing.SystemColors.Window;
            this.tbAddressDisplaySelectedState.Location = new System.Drawing.Point(475, 84);
            this.tbAddressDisplaySelectedState.Multiline = true;
            this.tbAddressDisplaySelectedState.Name = "tbAddressDisplaySelectedState";
            this.tbAddressDisplaySelectedState.ReadOnly = true;
            this.tbAddressDisplaySelectedState.Size = new System.Drawing.Size(483, 43);
            this.tbAddressDisplaySelectedState.TabIndex = 1;
            this.tbAddressDisplaySelectedState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddressReturn
            // 
            this.btnAddressReturn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddressReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddressReturn.Location = new System.Drawing.Point(838, 23);
            this.btnAddressReturn.Name = "btnAddressReturn";
            this.btnAddressReturn.Size = new System.Drawing.Size(119, 33);
            this.btnAddressReturn.TabIndex = 2;
            this.btnAddressReturn.Text = "Return";
            this.btnAddressReturn.UseVisualStyleBackColor = false;
            this.btnAddressReturn.Click += new System.EventHandler(this.btnAddressReturn_Click);
            // 
            // btnStreetAddress
            // 
            this.btnStreetAddress.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStreetAddress.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnStreetAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStreetAddress.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnStreetAddress.Location = new System.Drawing.Point(573, 322);
            this.btnStreetAddress.Name = "btnStreetAddress";
            this.btnStreetAddress.Size = new System.Drawing.Size(385, 43);
            this.btnStreetAddress.TabIndex = 3;
            this.btnStreetAddress.Text = "Street Address";
            this.btnStreetAddress.UseVisualStyleBackColor = false;
            // 
            // btnCity
            // 
            this.btnCity.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCity.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCity.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCity.Location = new System.Drawing.Point(98, 322);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(385, 43);
            this.btnCity.TabIndex = 4;
            this.btnCity.Text = "City";
            this.btnCity.UseVisualStyleBackColor = false;
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChoose.Location = new System.Drawing.Point(267, 260);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(516, 31);
            this.lblChoose.TabIndex = 5;
            this.lblChoose.Text = "Select a method to search for an address:";
            // 
            // frmAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1032, 462);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.btnCity);
            this.Controls.Add(this.btnStreetAddress);
            this.Controls.Add(this.btnAddressReturn);
            this.Controls.Add(this.tbAddressDisplaySelectedState);
            this.Controls.Add(this.btnChangeStateProvince);
            this.Name = "frmAddress";
            this.Text = "Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeStateProvince;
        private System.Windows.Forms.TextBox tbAddressDisplaySelectedState;
        private System.Windows.Forms.Button btnAddressReturn;
        private System.Windows.Forms.Button btnStreetAddress;
        private System.Windows.Forms.Button btnCity;
        private System.Windows.Forms.Label lblChoose;
    }
}