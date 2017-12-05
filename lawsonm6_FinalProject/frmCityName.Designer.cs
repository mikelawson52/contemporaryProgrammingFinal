/*
 * Author: Michael Lawson
 * Assignment: Final Semester Project
 * Seminar: IT3045C Contemporary Programming
 * Proffessor: Bill Nicholson
 * Description: Recreate Bill's Sat Nav based on his provided youtube video, implimenting only buttons that were pushed in the video.
 * Class Description: frmCityName controls.
 * Due Date: 12/5/17
 * References : Bill's youtube video showcasing the sat nav model: https://www.youtube.com/watch?v=uddPUWHdaqo
 *              Creating only one instance of a form at a time: https://stackoverflow.com/questions/3087841/how-can-i-make-a-single-instance-form-not-application
 *              Using events to close forms and go back to invisible previous forms: http://www.techotopia.com/index.php/Hiding_and_Showing_Forms_in_C_Sharp
 */
namespace lawsonm6_FinalProject
{
    partial class frmCityName
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
            this.btnAddressReturn = new System.Windows.Forms.Button();
            this.tbCityInput = new System.Windows.Forms.TextBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.tbMatches = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnForwardSlash = new System.Windows.Forms.Button();
            this.btnApostrophe = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnShift = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbSelectMatch = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddressReturn
            // 
            this.btnAddressReturn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddressReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddressReturn.Location = new System.Drawing.Point(870, 12);
            this.btnAddressReturn.Name = "btnAddressReturn";
            this.btnAddressReturn.Size = new System.Drawing.Size(119, 33);
            this.btnAddressReturn.TabIndex = 4;
            this.btnAddressReturn.Text = "Return";
            this.btnAddressReturn.UseVisualStyleBackColor = false;
            this.btnAddressReturn.Click += new System.EventHandler(this.btnAddressReturn_Click);
            // 
            // tbCityInput
            // 
            this.tbCityInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.tbCityInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCityInput.ForeColor = System.Drawing.SystemColors.Window;
            this.tbCityInput.Location = new System.Drawing.Point(59, 71);
            this.tbCityInput.Name = "tbCityInput";
            this.tbCityInput.ReadOnly = true;
            this.tbCityInput.Size = new System.Drawing.Size(533, 35);
            this.tbCityInput.TabIndex = 5;
            this.tbCityInput.TextChanged += new System.EventHandler(this.tbCityInput_TextChanged);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComplete.Location = new System.Drawing.Point(598, 12);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(158, 37);
            this.btnComplete.TabIndex = 17;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = false;
            // 
            // tbMatches
            // 
            this.tbMatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.tbMatches.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatches.ForeColor = System.Drawing.SystemColors.Window;
            this.tbMatches.Location = new System.Drawing.Point(762, 71);
            this.tbMatches.Name = "tbMatches";
            this.tbMatches.ReadOnly = true;
            this.tbMatches.Size = new System.Drawing.Size(213, 35);
            this.tbMatches.TabIndex = 18;
            this.tbMatches.Text = "***";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1.Location = new System.Drawing.Point(157, 126);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(57, 57);
            this.btn1.TabIndex = 19;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn2.Location = new System.Drawing.Point(220, 126);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(57, 57);
            this.btn2.TabIndex = 20;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn3.Location = new System.Drawing.Point(283, 126);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(57, 57);
            this.btn3.TabIndex = 21;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn4.Location = new System.Drawing.Point(346, 126);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(57, 57);
            this.btn4.TabIndex = 22;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn5.Location = new System.Drawing.Point(409, 126);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(57, 57);
            this.btn5.TabIndex = 23;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn6.Location = new System.Drawing.Point(472, 126);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(57, 57);
            this.btn6.TabIndex = 24;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn7.Location = new System.Drawing.Point(535, 126);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(57, 57);
            this.btn7.TabIndex = 25;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn8.Location = new System.Drawing.Point(598, 126);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(57, 57);
            this.btn8.TabIndex = 26;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn9.Location = new System.Drawing.Point(661, 126);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(57, 57);
            this.btn9.TabIndex = 27;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn0.Location = new System.Drawing.Point(724, 126);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(57, 57);
            this.btn0.TabIndex = 28;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSpace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackSpace.Location = new System.Drawing.Point(598, 55);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(158, 51);
            this.btnBackSpace.TabIndex = 29;
            this.btnBackSpace.Text = "BackSpace";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnQ
            // 
            this.btnQ.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQ.Location = new System.Drawing.Point(188, 189);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(57, 57);
            this.btnQ.TabIndex = 30;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = false;
            this.btnQ.Click += new System.EventHandler(this.btnQ_Click);
            // 
            // btnW
            // 
            this.btnW.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnW.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnW.Location = new System.Drawing.Point(251, 189);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(57, 57);
            this.btnW.TabIndex = 31;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = false;
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnE.Location = new System.Drawing.Point(314, 189);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(57, 57);
            this.btnE.TabIndex = 32;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnR.Location = new System.Drawing.Point(377, 189);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(57, 57);
            this.btnR.TabIndex = 33;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnT.Location = new System.Drawing.Point(440, 189);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(57, 57);
            this.btnT.TabIndex = 34;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnY
            // 
            this.btnY.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnY.Location = new System.Drawing.Point(503, 189);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(57, 57);
            this.btnY.TabIndex = 35;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = false;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnU.Location = new System.Drawing.Point(566, 189);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(57, 57);
            this.btnU.TabIndex = 36;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = false;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnI.Location = new System.Drawing.Point(629, 189);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(57, 57);
            this.btnI.TabIndex = 37;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = false;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnO.Location = new System.Drawing.Point(692, 189);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(57, 57);
            this.btnO.TabIndex = 38;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = false;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnP.Location = new System.Drawing.Point(755, 189);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(57, 57);
            this.btnP.TabIndex = 39;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnA.Location = new System.Drawing.Point(220, 252);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(57, 57);
            this.btnA.TabIndex = 40;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnS.Location = new System.Drawing.Point(283, 252);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(57, 57);
            this.btnS.TabIndex = 41;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnD.Location = new System.Drawing.Point(346, 252);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(57, 57);
            this.btnD.TabIndex = 42;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnF.Location = new System.Drawing.Point(409, 252);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(57, 57);
            this.btnF.TabIndex = 43;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = false;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnG.Location = new System.Drawing.Point(472, 252);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(57, 57);
            this.btnG.TabIndex = 44;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = false;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnH.Location = new System.Drawing.Point(535, 252);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(57, 57);
            this.btnH.TabIndex = 45;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = false;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btnJ
            // 
            this.btnJ.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnJ.Location = new System.Drawing.Point(598, 252);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(57, 57);
            this.btnJ.TabIndex = 46;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = false;
            this.btnJ.Click += new System.EventHandler(this.btnJ_Click);
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnK.Location = new System.Drawing.Point(661, 252);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(57, 57);
            this.btnK.TabIndex = 47;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = false;
            this.btnK.Click += new System.EventHandler(this.btnK_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnL.Location = new System.Drawing.Point(724, 252);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(57, 57);
            this.btnL.TabIndex = 48;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnX.Location = new System.Drawing.Point(314, 315);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(57, 57);
            this.btnX.TabIndex = 50;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnZ
            // 
            this.btnZ.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnZ.Location = new System.Drawing.Point(251, 315);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(57, 57);
            this.btnZ.TabIndex = 51;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = false;
            this.btnZ.Click += new System.EventHandler(this.btnZ_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnC.Location = new System.Drawing.Point(377, 315);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(57, 57);
            this.btnC.TabIndex = 52;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnV
            // 
            this.btnV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnV.Location = new System.Drawing.Point(440, 315);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(57, 57);
            this.btnV.TabIndex = 53;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = false;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnB.Location = new System.Drawing.Point(503, 315);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(57, 57);
            this.btnB.TabIndex = 54;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnN.Location = new System.Drawing.Point(566, 315);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(57, 57);
            this.btnN.TabIndex = 55;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = false;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnM.Location = new System.Drawing.Point(629, 315);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(57, 57);
            this.btnM.TabIndex = 56;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = false;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnForwardSlash
            // 
            this.btnForwardSlash.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnForwardSlash.Enabled = false;
            this.btnForwardSlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForwardSlash.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnForwardSlash.Location = new System.Drawing.Point(692, 315);
            this.btnForwardSlash.Name = "btnForwardSlash";
            this.btnForwardSlash.Size = new System.Drawing.Size(57, 57);
            this.btnForwardSlash.TabIndex = 57;
            this.btnForwardSlash.Text = "/";
            this.btnForwardSlash.UseVisualStyleBackColor = false;
            // 
            // btnApostrophe
            // 
            this.btnApostrophe.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnApostrophe.Enabled = false;
            this.btnApostrophe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApostrophe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnApostrophe.Location = new System.Drawing.Point(755, 315);
            this.btnApostrophe.Name = "btnApostrophe";
            this.btnApostrophe.Size = new System.Drawing.Size(57, 57);
            this.btnApostrophe.TabIndex = 58;
            this.btnApostrophe.Text = "\'";
            this.btnApostrophe.UseVisualStyleBackColor = false;
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDash.Enabled = false;
            this.btnDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDash.Location = new System.Drawing.Point(818, 315);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(57, 57);
            this.btnDash.TabIndex = 59;
            this.btnDash.Text = "-";
            this.btnDash.UseVisualStyleBackColor = false;
            // 
            // btnShift
            // 
            this.btnShift.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShift.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShift.Location = new System.Drawing.Point(59, 315);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(188, 57);
            this.btnShift.TabIndex = 60;
            this.btnShift.Text = "Shift";
            this.btnShift.UseVisualStyleBackColor = false;
            // 
            // btnPeriod
            // 
            this.btnPeriod.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPeriod.Enabled = false;
            this.btnPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPeriod.Location = new System.Drawing.Point(787, 252);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(57, 57);
            this.btnPeriod.TabIndex = 61;
            this.btnPeriod.Text = ".";
            this.btnPeriod.UseVisualStyleBackColor = false;
            // 
            // btnOther
            // 
            this.btnOther.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOther.Enabled = false;
            this.btnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOther.Location = new System.Drawing.Point(157, 378);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(183, 57);
            this.btnOther.TabIndex = 62;
            this.btnOther.Text = "Other";
            this.btnOther.UseVisualStyleBackColor = false;
            // 
            // btnSpace
            // 
            this.btnSpace.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSpace.Location = new System.Drawing.Point(346, 378);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(366, 57);
            this.btnSpace.TabIndex = 63;
            this.btnSpace.Text = "Space";
            this.btnSpace.UseVisualStyleBackColor = false;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOK.Location = new System.Drawing.Point(718, 378);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(157, 57);
            this.btnOK.TabIndex = 64;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbSelectMatch
            // 
            this.lbSelectMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.lbSelectMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectMatch.ForeColor = System.Drawing.SystemColors.Window;
            this.lbSelectMatch.FormattingEnabled = true;
            this.lbSelectMatch.ItemHeight = 31;
            this.lbSelectMatch.Location = new System.Drawing.Point(59, 120);
            this.lbSelectMatch.Name = "lbSelectMatch";
            this.lbSelectMatch.Size = new System.Drawing.Size(916, 314);
            this.lbSelectMatch.TabIndex = 65;
            this.lbSelectMatch.Visible = false;
            this.lbSelectMatch.SelectedIndexChanged += new System.EventHandler(this.lbSelectMatch_SelectedIndexChanged);
            // 
            // frmCityName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1001, 464);
            this.Controls.Add(this.lbSelectMatch);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSpace);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.btnPeriod);
            this.Controls.Add(this.btnShift);
            this.Controls.Add(this.btnDash);
            this.Controls.Add(this.btnApostrophe);
            this.Controls.Add(this.btnForwardSlash);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.tbMatches);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.tbCityInput);
            this.Controls.Add(this.btnAddressReturn);
            this.Name = "frmCityName";
            this.Text = "City Name";
            this.Load += new System.EventHandler(this.frmCityName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddressReturn;
        private System.Windows.Forms.TextBox tbCityInput;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.TextBox tbMatches;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnForwardSlash;
        private System.Windows.Forms.Button btnApostrophe;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox lbSelectMatch;
    }
}