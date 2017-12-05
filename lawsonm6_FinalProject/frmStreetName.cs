/*
 * Author: Michael Lawson
 * Assignment: Final Semester Project
 * Seminar: IT3045C Contemporary Programming
 * Proffessor: Bill Nicholson
 * Description: Recreate Bill's Sat Nav based on his provided youtube video, implimenting only buttons that were pushed in the video.
 * Class Description: select the street using on screen keyboard, then goes to house number.  Can also go back to select city name.
 * Due Date: 12/5/17
 * References : Bill's youtube video showcasing the sat nav model: https://www.youtube.com/watch?v=uddPUWHdaqo
 *              Creating only one instance of a form at a time: https://stackoverflow.com/questions/3087841/how-can-i-make-a-single-instance-form-not-application
 *              Using events to close forms and go back to invisible previous forms: http://www.techotopia.com/index.php/Hiding_and_Showing_Forms_in_C_Sharp
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lawsonm6_FinalProject
{
    public partial class frmStreetName : Form
    {
        //get and set selected city and state from previous form
        public string SelectedCity { get; set; }
        public string SelectedState { get; set; }
        public frmStreetName()
        {
            InitializeComponent();

        }
        //return button, closes this form.
        private void btnCityNameReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Refer to frmCityName's documentation of this event for a full explaination.  These events are exactly the same.
        private void tbCityInput_TextChanged(object sender, EventArgs e)
        {
            var changed0 = 0;
            var changed1 = 0;
            var changed2 = 0;
            var changed3 = 0;
            var changed4 = 0;
            var changed5 = 0;
            var changed6 = 0;
            var changed7 = 0;
            var changed8 = 0;
            var changed9 = 0;
            var changedQ = 0;
            var changedW = 0;
            var changedE = 0;
            var changedR = 0;
            var changedT = 0;
            var changedY = 0;
            var changedU = 0;
            var changedI = 0;
            var changedO = 0;
            var changedP = 0;
            var changedA = 0;
            var changedS = 0;
            var changedD = 0;
            var changedF = 0;
            var changedG = 0;
            var changedH = 0;
            var changedJ = 0;
            var changedK = 0;
            var changedL = 0;
            var changedZ = 0;
            var changedX = 0;
            var changedC = 0;
            var changedV = 0;
            var changedB = 0;
            var changedN = 0;
            var changedM = 0;
            var changedSpace = 0;
            var countMatches = 0;
            List<string> matches = new List<string>();
            lbSelectMatch.Items.Clear();

            foreach (var street in streets)
            {
                if (tbInput.Text.Equals(street))
                {
                    countMatches = 1;
                }
                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                    {
                        string cityText;
                        if (tbInput.Text.Length + 1 >= street.Length == false)
                        {
                            cityText = street.Remove(tbInput.Text.Length + 1);
                        }
                        else
                        {
                            cityText = street;
                        }

                        if (c == btn0)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "0";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed0 = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changed0 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btn1)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "1";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed1 = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changed1 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btn2)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "2";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed2 = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changed2 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btn3)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "3";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed3 = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changed3 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btn4)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "4";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed4 = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changed4 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btn5)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "5";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed5 = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changed5 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btn6)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "6";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed6 = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changed6 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btn7)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "7";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed7 = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changed7 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btn8)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "8";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed8 = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changed8 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btn9)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "9";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed9 = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changed9 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnQ)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "Q";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedQ = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedQ == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnW)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "W";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedW = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedW == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnE)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "E";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedE = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedE == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnR)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "R";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedR = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedR == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnT)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "T";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedT = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedT == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnY)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "Y";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedY = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedY == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnU)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "U";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedU = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedU == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnI)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "I";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedI = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedI == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnO)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "O";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedO = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedO == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnP)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "P";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedP = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedP == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnA)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "A";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedA = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedA == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnS)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "S";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedS = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedS == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnD)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "D";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedD = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedD == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnF)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "F";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedF = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedF == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnG)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "G";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedG = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedG == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnH)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "H";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedH = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedH == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnJ)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "J";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedJ = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedJ == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnK)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "K";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedK = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedK == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnL)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "L";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedL = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedL == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnZ)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "Z";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedZ = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedZ == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnX)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "X";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedX = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedX == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnC)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "C";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedC = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedC == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnV)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "V";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedV = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedV == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnB)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "B";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedB = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedB == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnN)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "N";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedN = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedN == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnM)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "M";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedM = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedM == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnSpace)
                        {
                            var newText = tbInput.Text;
                            newText = newText + " ";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedSpace = 1;
                                countMatches++;
                                matches.Add(street);
                            }
                            else if (changedSpace == 0)
                            {
                                c.Enabled = false;
                            }
                        }

                    }
                }
            }
            tbMatches.Text = countMatches.ToString() + " Matches";
            foreach (var match in matches)
            {
                lbSelectMatch.Items.Add(match);
            }
            if (matches.Count < 4 && matches.Count > 0)
            {
                lbSelectMatch.Show();
            }
            else
            {
                lbSelectMatch.Hide();
            }
            if (tbInput.TextLength == 0)
            {
                btnBackSpace.Enabled = false;
            }
            else
            {
                btnBackSpace.Enabled = true;
            }
        }
        //backspace button logic.  Removes the last index char in the textbox string.
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            tbInput.Select(0, tbInput.TextLength);
            if (tbInput.TextLength > 0)
            {
                tbInput.Text = tbInput.SelectedText.Remove(tbInput.TextLength - 1, 1);
            }
        }
        //Append each button's face value to the textbox text.
        private void btn1_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("0");
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("Q");
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("W");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("E");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("R");
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("T");
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("Y");
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("U");
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("I");
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("O");
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("P");
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("A");
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("Z");
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("S");
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("X");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("D");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("C");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("F");
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("V");
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("G");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("B");
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("H");
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("N");
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("M");
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("J");
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("K");
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            tbInput.AppendText("L");
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            tbInput.AppendText(" ");
        }
        //OK button logic.  Sets the city, checks if you entered one at all, and creates the street form.  Hides this form.
        private void btnOK_Click(object sender, EventArgs e)
        {
            frmHouseNumber houseNumber = new frmHouseNumber();
            //If the next form closes, make this one visable again.
            houseNumber.FormClosed += new FormClosedEventHandler(houseNumber_FormClosed);
            houseNumber.SelectedCity = SelectedCity;
            houseNumber.SelectedState = SelectedState;
            houseNumber.SelectedStreet = tbInput.Text;
            if (tbInput.Text.Length == 0)
            {
                string message = "Please enter a street.";
                string caption = "Error: No street selected.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                this.Hide();
                houseNumber.Show();
            }
        }
        //show this form on next form closing.
        void houseNumber_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        //create list of streets
        List<string> streets = new List<string>();
        //fill streets list based on selections and which file should be read on those selections.
        private void frmCityName_Load(object sender, EventArgs e)
        {
            if (SelectedState.Equals("MICHIGAN"))
            {
                if (SelectedCity.Equals("HILLSDALE"))
                {
                    try
                    {
                        foreach (string line in File.ReadLines("../michiganHillsdaleStreets.txt", Encoding.UTF8))
                        {
                            streets.Add(line);
                        }
                        //Activates the matches in tbChange event before user sees it
                        tbInput.Text = "L";
                        tbInput.Text = "";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception " + ex + " thrown.");
                        string message = ex.Message;
                        string caption = "Error Detected";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons);
                    }
                }
                if (SelectedCity.Equals("LANSING"))
                {
                    try
                    {
                        foreach (string line in File.ReadLines("../michiganLansingStreets.txt", Encoding.UTF8))
                        {
                            streets.Add(line);
                        }
                        tbInput.Text = "L";
                        tbInput.Text = "";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception " + ex + " thrown.");
                        string message = ex.Message;
                        string caption = "Error Detected";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons);
                    }
                }
            }
            if (SelectedState.Equals("OHIO"))
            {
                if (SelectedCity.Equals("BETHEL"))
                {
                    try
                    {
                        foreach (string line in File.ReadLines("../ohioBethelStreets.txt", Encoding.UTF8))
                        {
                            streets.Add(line);
                        }
                        tbInput.Text = "L";
                        tbInput.Text = "";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception " + ex + " thrown.");
                        string message = ex.Message;
                        string caption = "Error Detected";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons);
                    }
                }
                if (SelectedCity.Equals("CINCINNATI"))
                {
                    try
                    {
                        foreach (string line in File.ReadLines("../ohioCincinnatiStreets.txt", Encoding.UTF8))
                        {
                            streets.Add(line);
                        }
                        tbInput.Text = "L";
                        tbInput.Text = "";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception " + ex + " thrown.");
                        string message = ex.Message;
                        string caption = "Error Detected";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons);
                    }
                }
            }
            //if matches is the default value, opening any file at all failed and will make you pick a street that is implimented.

            if (tbMatches.Text.Equals("***"))
            {
                string message = "City selection returned no streets, please try Hillsdale and Lansing for Michigan; Cincinnati and Bethel for Ohio.";
                string caption = "Error Detected: City Invalid";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
                this.Close();
            }
        }
        //Allows user to select a list box item and automatically move on to the next form by programatically clicking the OK button.

        private void lbSelectMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbInput.Text = lbSelectMatch.SelectedItem.ToString();
                btnOK.PerformClick();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
