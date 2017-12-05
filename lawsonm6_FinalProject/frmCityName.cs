/*
 * Author: Michael Lawson
 * Assignment: Final Semester Project
 * Seminar: IT3045C Contemporary Programming
 * Proffessor: Bill Nicholson
 * Description: Recreate Bill's Sat Nav based on his provided youtube video, implimenting only buttons that were pushed in the video.
 * Class Description: frmCityName logic, select your city here using an on screen keyboard and continue to selecting your street.
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
    public partial class frmCityName : Form
    {
        //get and set selected state from previous form
        public string SelectedState {get; set;}
        public frmCityName()
        {
            InitializeComponent();

        }
        //return button, closes this form.
        private void btnAddressReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //City name text box event.  Contains logic for checking matches and hiding/showing keys based on those matches.
        private void tbCityInput_TextChanged(object sender, EventArgs e)
        {
            //variables for each key to check if the next key press has a match
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
            //variable to count the number of matches for the match text box
            var countMatches = 0;
            //list of each match to store for the choices in the listbox when matches gets to 3 or less
            List<string> matches = new List<string>();
            //clear matches on every iteration, or else it gets messy
            lbSelectMatch.Items.Clear();
            //iterate through the cities list that contains all cities
            foreach (var city in cities)
            {
                //special condition of one remaining match so an exact match does not equal 0 matches.
                if (tbCityInput.Text.Equals(city))
                {
                    countMatches = 1;
                }
                //go through every control
                foreach (Control c in this.Controls)
                {
                    //only look at buttons
                    if (c is Button)
                    {
                        //compare the text in the textbox with an instance of each button press appended onto the text vs each city cut to the same new textbox length.
                        string cityText;
                        //cut the city to the textbox+1 length, unless the city is equal less in length.
                        if (tbCityInput.Text.Length + 1 >= city.Length == false)
                        {
                            cityText = city.Remove(tbCityInput.Text.Length + 1);
                        }
                        else
                        {
                            cityText = city;
                        }
                        //logic for checking every button.  Every button is the same.
                        if (c == btn0)
                        {
                            //Create the new textbox text of that button press, if it matches a city then keep that button enabled and add it to the matches.  Add city to listbox matches.  If not, disable the button.
                            var newText = tbCityInput.Text;
                            newText = newText + "0";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed0 = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changed0 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btn1)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "1";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed1 = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changed1 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btn2)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "2";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed2 = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changed2 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btn3)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "3";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed3 = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changed3 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btn4)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "4";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed4 = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changed4 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btn5)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "5";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed5 = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changed5 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btn6)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "6";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed6 = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changed6 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btn7)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "7";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed7 = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changed7 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btn8)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "8";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed8 = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changed8 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btn9)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "9";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed9 = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changed9 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnQ)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "Q";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedQ = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedQ == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnW)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "W";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedW = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedW == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnE)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "E";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedE = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedE == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnR)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "R";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedR = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedR == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnT)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "T";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedT = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedT == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnY)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "Y";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedY = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedY == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnU)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "U";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedU = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedU == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnI)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "I";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedI = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedI == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnO)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "O";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedO = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedO == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnP)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "P";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedP = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedP == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnA)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "A";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedA = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedA == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnS)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "S";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedS = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedS == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnD)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "D";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedD = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedD == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnF)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "F";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedF = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedF == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnG)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "G";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedG = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedG == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnH)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "H";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedH = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedH == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnJ)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "J";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedJ = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedJ == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnK)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "K";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedK = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedK == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnL)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "L";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedL = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedL == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnZ)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "Z";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedZ = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedZ == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnX)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "X";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedX = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedX == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnC)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "C";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedC = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedC == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnV)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "V";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedV = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedV == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnB)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "B";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedB = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedB == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnN)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "N";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedN = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedN == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnM)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + "M";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedM = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedM == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                        if (c == btnSpace)
                        {
                            var newText = tbCityInput.Text;
                            newText = newText + " ";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changedSpace = 1;
                                countMatches++;
                                matches.Add(city);
                            }
                            else if (changedSpace == 0)
                            {
                                c.Enabled = false;
                            }
                        }

                    }
                }
            }
            //Display the number of matches, add each match to the list box, and bring up the listbox if the number of matches has reached 3 or below so long as there is a match.
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
            //backspace enable/disable logic.  Disables if nothing to backspace.
            if (tbCityInput.TextLength == 0)
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
            tbCityInput.Select(0, tbCityInput.TextLength);
            if (tbCityInput.TextLength > 0)
            {
                tbCityInput.Text = tbCityInput.SelectedText.Remove(tbCityInput.TextLength - 1, 1);
            }
        }
        //Append each button's face value to the textbox text.
        private void btn1_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("0");
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("Q");
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("W");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("E");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("R");
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("T");
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("Y");
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("U");
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("I");
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("O");
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("P");
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("A");
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("Z");
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("S");
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("X");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("D");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("C");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("F");
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("V");
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("G");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("B");
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("H");
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("N");
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("M");
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("J");
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("K");
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText("L");
        }
    
        private void btnSpace_Click(object sender, EventArgs e)
        {
            tbCityInput.AppendText(" ");
        }
        //OK button logic.  Sets the city, checks if you entered one at all, and creates the street form.  Hides this form.
        private void btnOK_Click(object sender, EventArgs e)
        {
            frmStreetName streetName = new frmStreetName();
            streetName.SelectedState = SelectedState;
            streetName.SelectedCity = tbCityInput.Text;
            //If the next form closes, make this one visable again.
            streetName.FormClosed += new FormClosedEventHandler(cityStreetName_FormClosed);
            if (tbCityInput.Text.Length == 0)
            {
                string message = "Please enter a city.";
                string caption = "Error: No city selected.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                this.Hide();
                streetName.Show();
            }
        }
        //show this form on next form closing.
        void cityStreetName_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        //create list of cities
        List<string> cities = new List<string>();
        //fill cities list based on selections and which file should be read on those selections.
        private void frmCityName_Load(object sender, EventArgs e)
        {
            if (SelectedState.Equals("MICHIGAN"))
            {
                try
                {
                    foreach (string line in File.ReadLines("../michiganCities.txt", Encoding.UTF8))
                    {
                        cities.Add(line);
                    }
                    //Activates the matches in tbChange event before user sees it
                    tbCityInput.Text = "L";
                    tbCityInput.Text = "";
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
            if (SelectedState.Equals("OHIO"))
            {
                try
                {
                    foreach (string line in File.ReadLines("../ohioCities.txt", Encoding.UTF8))
                    {
                        cities.Add(line);
                    }
                    tbCityInput.Text = "L";
                    tbCityInput.Text = "";
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
            //if matches is the default value, opening any file at all failed and will make you pick a city that is implimented.
            if (tbMatches.Text.Equals("***"))
            {
                string message = "State selection returned no cities, please try Michigan or Ohio.";
                string caption = "Error Detected: State Invalid";
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
                tbCityInput.Text = lbSelectMatch.SelectedItem.ToString();
                btnOK.PerformClick();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
