/*
 * Author: Michael Lawson
 * Assignment: Final Semester Project
 * Seminar: IT3045C Contemporary Programming
 * Proffessor: Bill Nicholson
 * Description: Recreate Bill's Sat Nav based on his provided youtube video, implimenting only buttons that were pushed in the video.
 * Class Description: Select your state or province from here.  Only States in the US are implimented.  Can go back to address form from here.
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
    public partial class frmStateProvince : Form
    {
        //create a variable to store your selected state
        public string State { get; set; }
        //create counters for each button
        int countABC = 0;
        int countDEF = 0;
        int countGHI = 0;
        int countJKL = 0;
        int countMNO = 0;
        int countPQRS = 0;
        int countTUV = 0;
        int countWXYZ = 0;
        //list of states
        List<String> States = new List<String>();
        public frmStateProvince()
        {
            InitializeComponent();
        }
        //hide this form on return.  Do not close it like the others.
        private void btnAddressReturn_Click(object sender, EventArgs e)
        {
            countABC = 0;
            countDEF = 0;
            countGHI = 0;
            countJKL = 0;
            countMNO = 0;
            countPQRS = 0;
            countTUV = 0;
            countWXYZ = 0;
            this.Hide();
        }
        //fill listbox and list of states with all 50 states
        private void frmStateProvince_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (string line in File.ReadLines("../states.txt", Encoding.UTF8))
                {
                    States.Add(line);
                    lbStates.Items.Add(line);
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex + " thrown.");
                string message = ex.Message;
                string caption = "Error Detected";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }
        //Make state set to selected listbox item, return to previous form
        private void lbStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                State = lbStates.SelectedItem.ToString();
                btnAddressReturn.PerformClick();
            }
            catch (Exception ex)
            {

            }
        }
        //Logic for each button.  Cycles through each letter/button based on number of times pressed, and resets upon any other button being pressed.
        private void btnABC_Click(object sender, EventArgs e)
        {
            countDEF = 0;
            countGHI = 0;
            countJKL = 0;
            countMNO = 0;
            countPQRS = 0;
            countTUV = 0;
            countWXYZ = 0;
            countABC++;
            if (countABC % 3 == 1)
            {
                int index = lbStates.FindString("A");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
            if (countABC % 3 == 2)
            {
                int index = lbStates.FindString("B");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
            if (countABC % 3 == 0)
            {
                int index = lbStates.FindString("C");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
        }

        private void btnDEF_Click(object sender, EventArgs e)
        {
            countABC = 0;
            countGHI = 0;
            countJKL = 0;
            countMNO = 0;
            countPQRS = 0;
            countTUV = 0;
            countWXYZ = 0;
            countDEF++;
            if (countDEF % 3 == 1)
            {
                int index = lbStates.FindString("D");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
            if (countDEF % 3 == 2)
            {
                int index = lbStates.FindString("E");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
            if (countDEF % 3 == 0)
            {
                int index = lbStates.FindString("F");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
        }

        private void btnGHI_Click(object sender, EventArgs e)
        {
            countABC = 0;
            countDEF = 0;
            countJKL = 0;
            countMNO = 0;
            countPQRS = 0;
            countTUV = 0;
            countWXYZ = 0;
            countGHI++;
            if (countGHI % 3 == 1)
            {
                int index = lbStates.FindString("G");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
            if (countGHI % 3 == 2)
            {
                int index = lbStates.FindString("H");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
            if (countGHI % 3 == 0)
            {
                int index = lbStates.FindString("I");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
        }

        private void btnJKL_Click(object sender, EventArgs e)
        {
            countABC = 0;
            countDEF = 0;
            countGHI = 0;
            countMNO = 0;
            countPQRS = 0;
            countTUV = 0;
            countWXYZ = 0;
            countJKL++;
            if (countJKL % 3 == 1)
            {
                int index = lbStates.FindString("J");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
            if (countJKL % 3 == 2)
            {
                int index = lbStates.FindString("K");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
            if (countJKL % 3 == 0)
            {
                int index = lbStates.FindString("L");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
        }

        private void btnMNO_Click(object sender, EventArgs e)
        {
            countABC = 0;
            countDEF = 0;
            countGHI = 0;
            countJKL = 0;
            countPQRS = 0;
            countTUV = 0;
            countWXYZ = 0;
            countMNO++;
            if (countMNO % 3 == 1)
            {
                int index = lbStates.FindString("M");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
            if (countMNO % 3 == 2)
            {
                int index = lbStates.FindString("N");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
            if (countMNO % 3 == 0)
            {
                int index = lbStates.FindString("O");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
        }

        private void btnPQRS_Click(object sender, EventArgs e)
        {
            countABC = 0;
            countDEF = 0;
            countGHI = 0;
            countJKL = 0;
            countMNO = 0;
            countTUV = 0;
            countWXYZ = 0;
            countPQRS++;
            if (countPQRS % 4 == 1)
            {
                int index = lbStates.FindString("P");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
            if (countPQRS % 4 == 2)
            {
                int index = lbStates.FindString("Q");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
            if (countPQRS % 4 == 3)
            {
                int index = lbStates.FindString("R");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
            if (countPQRS % 4 == 0)
            {
                int index = lbStates.FindString("S");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }

        }

        private void btnTUV_Click(object sender, EventArgs e)
        {
            countABC = 0;
            countDEF = 0;
            countGHI = 0;
            countJKL = 0;
            countMNO = 0;
            countPQRS = 0;
            countWXYZ = 0;
            countTUV++;
            if (countTUV % 3 == 1)
            {
                int index = lbStates.FindString("T");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
            if (countTUV % 3 == 2)
            {
                int index = lbStates.FindString("U");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
            if (countTUV % 3 == 0)
            {
                int index = lbStates.FindString("V");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
        }

        private void btnWXYZ_Click(object sender, EventArgs e)
        {
            countABC = 0;
            countDEF = 0;
            countGHI = 0;
            countJKL = 0;
            countMNO = 0;
            countPQRS = 0;
            countTUV = 0;
            countWXYZ++;
            if (countWXYZ % 4 == 1)
            {
                int index = lbStates.FindString("W");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
            if (countWXYZ % 4 == 2)
            {
                int index = lbStates.FindString("X");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
            if (countWXYZ % 4 == 3)
            {
                int index = lbStates.FindString("Y");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
            if (countWXYZ % 4 == 0)
            {
                int index = lbStates.FindString("Z");
                if (index != -1)
                {
                    lbStates.SetSelected(index, true);
                }
            }
        }
    }
}
