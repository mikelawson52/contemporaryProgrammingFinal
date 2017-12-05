/*
 * Author: Michael Lawson
 * Assignment: Final Semester Project
 * Seminar: IT3045C Contemporary Programming
 * Proffessor: Bill Nicholson
 * Description: Recreate Bill's Sat Nav based on his provided youtube video, implimenting only buttons that were pushed in the video.
 * Class Description: frmStateProvince controls
 * Due Date: 12/5/17
 * References : Bill's youtube video showcasing the sat nav model: https://www.youtube.com/watch?v=uddPUWHdaqo
 *              Creating only one instance of a form at a time: https://stackoverflow.com/questions/3087841/how-can-i-make-a-single-instance-form-not-application
 *              Using events to close forms and go back to invisible previous forms: http://www.techotopia.com/index.php/Hiding_and_Showing_Forms_in_C_Sharp
 */
namespace lawsonm6_FinalProject
{
    partial class frmStateProvince
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
            this.lbStates = new System.Windows.Forms.ListBox();
            this.btnAddressReturn = new System.Windows.Forms.Button();
            this.btnABC = new System.Windows.Forms.Button();
            this.btnDEF = new System.Windows.Forms.Button();
            this.btnGHI = new System.Windows.Forms.Button();
            this.btnJKL = new System.Windows.Forms.Button();
            this.btnMNO = new System.Windows.Forms.Button();
            this.btnPQRS = new System.Windows.Forms.Button();
            this.btnTUV = new System.Windows.Forms.Button();
            this.btnWXYZ = new System.Windows.Forms.Button();
            this.btnZeroThroughNine = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.btnUnitedStates = new System.Windows.Forms.Button();
            this.btnCanada = new System.Windows.Forms.Button();
            this.btnMexico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbStates
            // 
            this.lbStates.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbStates.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbStates.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStates.ForeColor = System.Drawing.SystemColors.Window;
            this.lbStates.FormattingEnabled = true;
            this.lbStates.ItemHeight = 31;
            this.lbStates.Location = new System.Drawing.Point(149, 109);
            this.lbStates.Name = "lbStates";
            this.lbStates.Size = new System.Drawing.Size(408, 283);
            this.lbStates.TabIndex = 0;
            this.lbStates.Click += new System.EventHandler(this.lbStates_SelectedIndexChanged);
            // 
            // btnAddressReturn
            // 
            this.btnAddressReturn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddressReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddressReturn.Location = new System.Drawing.Point(796, 34);
            this.btnAddressReturn.Name = "btnAddressReturn";
            this.btnAddressReturn.Size = new System.Drawing.Size(119, 33);
            this.btnAddressReturn.TabIndex = 3;
            this.btnAddressReturn.Text = "Return";
            this.btnAddressReturn.UseVisualStyleBackColor = false;
            this.btnAddressReturn.Click += new System.EventHandler(this.btnAddressReturn_Click);
            // 
            // btnABC
            // 
            this.btnABC.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnABC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABC.Location = new System.Drawing.Point(690, 109);
            this.btnABC.Name = "btnABC";
            this.btnABC.Size = new System.Drawing.Size(101, 53);
            this.btnABC.TabIndex = 4;
            this.btnABC.Text = "ABC";
            this.btnABC.UseVisualStyleBackColor = false;
            this.btnABC.Click += new System.EventHandler(this.btnABC_Click);
            // 
            // btnDEF
            // 
            this.btnDEF.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDEF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDEF.Location = new System.Drawing.Point(814, 109);
            this.btnDEF.Name = "btnDEF";
            this.btnDEF.Size = new System.Drawing.Size(101, 53);
            this.btnDEF.TabIndex = 5;
            this.btnDEF.Text = "DEF";
            this.btnDEF.UseVisualStyleBackColor = false;
            this.btnDEF.Click += new System.EventHandler(this.btnDEF_Click);
            // 
            // btnGHI
            // 
            this.btnGHI.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGHI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGHI.Location = new System.Drawing.Point(690, 168);
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.Size = new System.Drawing.Size(101, 53);
            this.btnGHI.TabIndex = 6;
            this.btnGHI.Text = "GHI";
            this.btnGHI.UseVisualStyleBackColor = false;
            this.btnGHI.Click += new System.EventHandler(this.btnGHI_Click);
            // 
            // btnJKL
            // 
            this.btnJKL.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnJKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJKL.Location = new System.Drawing.Point(814, 168);
            this.btnJKL.Name = "btnJKL";
            this.btnJKL.Size = new System.Drawing.Size(101, 53);
            this.btnJKL.TabIndex = 7;
            this.btnJKL.Text = "JKL";
            this.btnJKL.UseVisualStyleBackColor = false;
            this.btnJKL.Click += new System.EventHandler(this.btnJKL_Click);
            // 
            // btnMNO
            // 
            this.btnMNO.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMNO.Location = new System.Drawing.Point(690, 227);
            this.btnMNO.Name = "btnMNO";
            this.btnMNO.Size = new System.Drawing.Size(101, 53);
            this.btnMNO.TabIndex = 8;
            this.btnMNO.Text = "MNO";
            this.btnMNO.UseVisualStyleBackColor = false;
            this.btnMNO.Click += new System.EventHandler(this.btnMNO_Click);
            // 
            // btnPQRS
            // 
            this.btnPQRS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPQRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPQRS.Location = new System.Drawing.Point(814, 227);
            this.btnPQRS.Name = "btnPQRS";
            this.btnPQRS.Size = new System.Drawing.Size(101, 53);
            this.btnPQRS.TabIndex = 9;
            this.btnPQRS.Text = "PQRS";
            this.btnPQRS.UseVisualStyleBackColor = false;
            this.btnPQRS.Click += new System.EventHandler(this.btnPQRS_Click);
            // 
            // btnTUV
            // 
            this.btnTUV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTUV.Location = new System.Drawing.Point(690, 286);
            this.btnTUV.Name = "btnTUV";
            this.btnTUV.Size = new System.Drawing.Size(101, 53);
            this.btnTUV.TabIndex = 10;
            this.btnTUV.Text = "TUV";
            this.btnTUV.UseVisualStyleBackColor = false;
            this.btnTUV.Click += new System.EventHandler(this.btnTUV_Click);
            // 
            // btnWXYZ
            // 
            this.btnWXYZ.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnWXYZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWXYZ.Location = new System.Drawing.Point(814, 286);
            this.btnWXYZ.Name = "btnWXYZ";
            this.btnWXYZ.Size = new System.Drawing.Size(101, 53);
            this.btnWXYZ.TabIndex = 11;
            this.btnWXYZ.Text = "WXYZ";
            this.btnWXYZ.UseVisualStyleBackColor = false;
            this.btnWXYZ.Click += new System.EventHandler(this.btnWXYZ_Click);
            // 
            // btnZeroThroughNine
            // 
            this.btnZeroThroughNine.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnZeroThroughNine.Enabled = false;
            this.btnZeroThroughNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZeroThroughNine.Location = new System.Drawing.Point(690, 345);
            this.btnZeroThroughNine.Name = "btnZeroThroughNine";
            this.btnZeroThroughNine.Size = new System.Drawing.Size(101, 53);
            this.btnZeroThroughNine.TabIndex = 12;
            this.btnZeroThroughNine.Text = "0-9";
            this.btnZeroThroughNine.UseVisualStyleBackColor = false;
            // 
            // btnOther
            // 
            this.btnOther.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOther.Enabled = false;
            this.btnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.Location = new System.Drawing.Point(814, 345);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(101, 53);
            this.btnOther.TabIndex = 13;
            this.btnOther.Text = "Other";
            this.btnOther.UseVisualStyleBackColor = false;
            // 
            // btnUnitedStates
            // 
            this.btnUnitedStates.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUnitedStates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnitedStates.Location = new System.Drawing.Point(78, 22);
            this.btnUnitedStates.Name = "btnUnitedStates";
            this.btnUnitedStates.Size = new System.Drawing.Size(147, 53);
            this.btnUnitedStates.TabIndex = 14;
            this.btnUnitedStates.Text = "United States";
            this.btnUnitedStates.UseVisualStyleBackColor = false;
            // 
            // btnCanada
            // 
            this.btnCanada.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCanada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanada.Location = new System.Drawing.Point(290, 22);
            this.btnCanada.Name = "btnCanada";
            this.btnCanada.Size = new System.Drawing.Size(155, 53);
            this.btnCanada.TabIndex = 15;
            this.btnCanada.Text = "Canada";
            this.btnCanada.UseVisualStyleBackColor = false;
            // 
            // btnMexico
            // 
            this.btnMexico.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMexico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMexico.Location = new System.Drawing.Point(513, 22);
            this.btnMexico.Name = "btnMexico";
            this.btnMexico.Size = new System.Drawing.Size(173, 53);
            this.btnMexico.TabIndex = 16;
            this.btnMexico.Text = "Mexico";
            this.btnMexico.UseVisualStyleBackColor = false;
            // 
            // frmStateProvince
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btnMexico);
            this.Controls.Add(this.btnCanada);
            this.Controls.Add(this.btnUnitedStates);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.btnZeroThroughNine);
            this.Controls.Add(this.btnWXYZ);
            this.Controls.Add(this.btnTUV);
            this.Controls.Add(this.btnPQRS);
            this.Controls.Add(this.btnMNO);
            this.Controls.Add(this.btnJKL);
            this.Controls.Add(this.btnGHI);
            this.Controls.Add(this.btnDEF);
            this.Controls.Add(this.btnABC);
            this.Controls.Add(this.btnAddressReturn);
            this.Controls.Add(this.lbStates);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "frmStateProvince";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "State/Province";
            this.Load += new System.EventHandler(this.frmStateProvince_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbStates;
        private System.Windows.Forms.Button btnAddressReturn;
        private System.Windows.Forms.Button btnABC;
        private System.Windows.Forms.Button btnDEF;
        private System.Windows.Forms.Button btnGHI;
        private System.Windows.Forms.Button btnJKL;
        private System.Windows.Forms.Button btnMNO;
        private System.Windows.Forms.Button btnPQRS;
        private System.Windows.Forms.Button btnTUV;
        private System.Windows.Forms.Button btnWXYZ;
        private System.Windows.Forms.Button btnZeroThroughNine;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button btnUnitedStates;
        private System.Windows.Forms.Button btnCanada;
        private System.Windows.Forms.Button btnMexico;
    }
}