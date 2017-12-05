/*
 * Author: Michael Lawson
 * Assignment: Final Semester Project
 * Seminar: IT3045C Contemporary Programming
 * Proffessor: Bill Nicholson
 * Description: Recreate Bill's Sat Nav based on his provided youtube video, implimenting only buttons that were pushed in the video.
 * Class Description: Select a house number for the address using an on screen keyboard.  Continue to the map form or go back to street name.
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
    public partial class frmHouseNumber : Form
    {
        //selected street, city and state from previous forms
        public string SelectedStreet { get; set; }
        public string SelectedCity { get; set; }
        public string SelectedState { get; set; }
        public frmHouseNumber()
        {
            InitializeComponent();
        }
        //return button
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Refer to frmCityName for full documentation of this event.  They are very similar, but this event has no matches textbox or match listboxes.  Still checks for matches for buttons.
        private void tbInput_TextChanged(object sender, EventArgs e)
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

            foreach (var number in houseNumbers)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                    {
                        string cityText;
                        if (tbInput.Text.Length + 1 >= number.Length == false)
                        {
                            cityText = number.Remove(tbInput.Text.Length + 1);
                        }
                        else
                        {
                            cityText = number;
                        }

                        if (c == btn0)
                        {
                            var newText = tbInput.Text;
                            newText = newText + "0";
                            if (newText.Equals(cityText))
                            {
                                c.Enabled = true;
                                changed0 = 1;
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
                            }
                            else if (changed9 == 0)
                            {
                                c.Enabled = false;
                            }
                        }
                    }
                }
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
        //Append face value of each button to text
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
        //OK button logic.  Sets the street number, and creates the street form.  Hides this form.
        private void btnOK_Click(object sender, EventArgs e)
        {
            frmMap map = new frmMap();
            //if next form closes, make this one visible again
            map.FormClosed += new FormClosedEventHandler(map_FormClosed);
            map.SelectedCity = SelectedCity;
            map.SelectedState = SelectedState;
            map.SelectedStreet = SelectedStreet;
            map.SelectedNumber = tbInput.Text;
            this.Hide();
            map.Show();
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
        //Show this form on next form closing
        void map_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        //List of house numbers
        List<string> houseNumbers = new List<string>();
        //fill houseNumbers based on previous selections
        private void frmHouseNumber_Load(object sender, EventArgs e)
        {
            if (SelectedState.Equals("MICHIGAN"))
            {
                if (SelectedCity.Equals("HILLSDALE"))
                {
                    if (SelectedStreet.Equals("UNION"))
                    {
                        try
                        {
                            foreach (string line in File.ReadLines("../michiganHillsdaleUnionNumbers.txt", Encoding.UTF8))
                            {
                                houseNumbers.Add(line);
                            }
                            //activate button matches before user sees it
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
                    if (SelectedStreet.Equals("URAN"))
                    {
                        try
                        {
                            foreach (string line in File.ReadLines("../michiganHillsdaleUranNumbers.txt", Encoding.UTF8))
                            {
                                houseNumbers.Add(line);
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
                if (SelectedCity.Equals("LANSING"))
                {
                    if (SelectedStreet.Equals("CEDAR"))
                    {
                        try
                        {
                            foreach (string line in File.ReadLines("../michiganLansingCedarNumbers.txt", Encoding.UTF8))
                            {
                                houseNumbers.Add(line);
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
                    if (SelectedStreet.Equals("KALAMAZOO"))
                    {
                        try
                        {
                            foreach (string line in File.ReadLines("../michiganLansingKalamazooNumbers.txt", Encoding.UTF8))
                            {
                                houseNumbers.Add(line);
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
            }
            if (SelectedState.Equals("OHIO"))
            {
                if (SelectedCity.Equals("BETHEL"))
                {
                    if (SelectedStreet.Equals("MAIN"))
                    {
                        try
                        {
                            foreach (string line in File.ReadLines("../ohioBethelMainNumbers.txt", Encoding.UTF8))
                            {
                                houseNumbers.Add(line);
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
                    if (SelectedStreet.Equals("UNION"))
                    {
                        try
                        {
                            foreach (string line in File.ReadLines("../ohioBethelUnionNumbers.txt", Encoding.UTF8))
                            {
                                houseNumbers.Add(line);
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
                if (SelectedCity.Equals("CINCINNATI"))
                {
                    if (SelectedStreet.Equals("VINE"))
                    {
                        try
                        {
                            foreach (string line in File.ReadLines("../ohioCincinnatiVineNumbers.txt", Encoding.UTF8))
                            {
                                houseNumbers.Add(line);
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
                    if (SelectedStreet.Equals("RAVINE"))
                    {
                        try
                        {
                            foreach (string line in File.ReadLines("../ohioCincinnatiRavineNumbers.txt", Encoding.UTF8))
                            {
                                houseNumbers.Add(line);
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
            }
            //If this button is enabled, then the street was not implimented or no file was read at all.  Takes you back to streets form.
            if (btn0.Enabled)
            {
                string message = "Selected street has no house numbers, please select a different one.";
                string caption = "Error: Street Invalid";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
                this.Close();
            }
        }
        //accidental implimentation, does nothing
        private void lbSelectMatch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
