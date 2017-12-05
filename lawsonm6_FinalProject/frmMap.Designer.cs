/*
 * Author: Michael Lawson
 * Assignment: Final Semester Project
 * Seminar: IT3045C Contemporary Programming
 * Proffessor: Bill Nicholson
 * Description: Recreate Bill's Sat Nav based on his provided youtube video, implimenting only buttons that were pushed in the video.
 * Class Description: frmMap controls
 * Due Date: 12/5/17
 * References : Bill's youtube video showcasing the sat nav model: https://www.youtube.com/watch?v=uddPUWHdaqo
 *              Creating only one instance of a form at a time: https://stackoverflow.com/questions/3087841/how-can-i-make-a-single-instance-form-not-application
 *              Using events to close forms and go back to invisible previous forms: http://www.techotopia.com/index.php/Hiding_and_Showing_Forms_in_C_Sharp
 */
namespace lawsonm6_FinalProject
{
    partial class frmMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMap));
            this.btnReturn = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblConfirmDestination = new System.Windows.Forms.Label();
            this.btnMark = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbPlaceHolderTop = new System.Windows.Forms.TextBox();
            this.tbLatLong = new System.Windows.Forms.TextBox();
            this.tbPlaceHolderSmall = new System.Windows.Forms.TextBox();
            this.btnCall = new System.Windows.Forms.Button();
            this.pbMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(845, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(119, 33);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tbInput
            // 
            this.tbInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.tbInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.ForeColor = System.Drawing.SystemColors.Window;
            this.tbInput.Location = new System.Drawing.Point(63, 116);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ReadOnly = true;
            this.tbInput.Size = new System.Drawing.Size(382, 136);
            this.tbInput.TabIndex = 21;
            // 
            // lblConfirmDestination
            // 
            this.lblConfirmDestination.AutoSize = true;
            this.lblConfirmDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmDestination.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblConfirmDestination.Location = new System.Drawing.Point(57, 23);
            this.lblConfirmDestination.Name = "lblConfirmDestination";
            this.lblConfirmDestination.Size = new System.Drawing.Size(253, 31);
            this.lblConfirmDestination.TabIndex = 22;
            this.lblConfirmDestination.Text = "Confirm Destination";
            // 
            // btnMark
            // 
            this.btnMark.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMark.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMark.Location = new System.Drawing.Point(63, 376);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(172, 43);
            this.btnMark.TabIndex = 23;
            this.btnMark.Text = "Mark";
            this.btnMark.UseVisualStyleBackColor = false;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGo.Location = new System.Drawing.Point(285, 376);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(160, 43);
            this.btnGo.TabIndex = 24;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            // 
            // tbPlaceHolderTop
            // 
            this.tbPlaceHolderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.tbPlaceHolderTop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPlaceHolderTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlaceHolderTop.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPlaceHolderTop.Location = new System.Drawing.Point(63, 70);
            this.tbPlaceHolderTop.Name = "tbPlaceHolderTop";
            this.tbPlaceHolderTop.ReadOnly = true;
            this.tbPlaceHolderTop.Size = new System.Drawing.Size(382, 35);
            this.tbPlaceHolderTop.TabIndex = 25;
            // 
            // tbLatLong
            // 
            this.tbLatLong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.tbLatLong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLatLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLatLong.ForeColor = System.Drawing.SystemColors.Window;
            this.tbLatLong.Location = new System.Drawing.Point(63, 267);
            this.tbLatLong.Name = "tbLatLong";
            this.tbLatLong.ReadOnly = true;
            this.tbLatLong.Size = new System.Drawing.Size(382, 35);
            this.tbLatLong.TabIndex = 26;
            // 
            // tbPlaceHolderSmall
            // 
            this.tbPlaceHolderSmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.tbPlaceHolderSmall.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPlaceHolderSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlaceHolderSmall.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPlaceHolderSmall.Location = new System.Drawing.Point(63, 319);
            this.tbPlaceHolderSmall.Name = "tbPlaceHolderSmall";
            this.tbPlaceHolderSmall.ReadOnly = true;
            this.tbPlaceHolderSmall.Size = new System.Drawing.Size(288, 35);
            this.tbPlaceHolderSmall.TabIndex = 27;
            // 
            // btnCall
            // 
            this.btnCall.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCall.Enabled = false;
            this.btnCall.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCall.Location = new System.Drawing.Point(346, 319);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(99, 35);
            this.btnCall.TabIndex = 28;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = false;
            // 
            // pbMap
            // 
            this.pbMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMap.Image = ((System.Drawing.Image)(resources.GetObject("pbMap.Image")));
            this.pbMap.Location = new System.Drawing.Point(494, 71);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(470, 348);
            this.pbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMap.TabIndex = 29;
            this.pbMap.TabStop = false;
            // 
            // frmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.pbMap);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.tbPlaceHolderSmall);
            this.Controls.Add(this.tbLatLong);
            this.Controls.Add(this.tbPlaceHolderTop);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.lblConfirmDestination);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnReturn);
            this.Name = "frmMap";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.frmMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lblConfirmDestination;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbPlaceHolderTop;
        private System.Windows.Forms.TextBox tbLatLong;
        private System.Windows.Forms.TextBox tbPlaceHolderSmall;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.PictureBox pbMap;
    }
}