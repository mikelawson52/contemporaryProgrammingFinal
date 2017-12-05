/*
 * Author: Michael Lawson
 * Assignment: Final Semester Project
 * Seminar: IT3045C Contemporary Programming
 * Proffessor: Bill Nicholson
 * Description: Recreate Bill's Sat Nav based on his provided youtube video, implimenting only buttons that were pushed in the video.
 * Class Description: frmAddress logic, form to navigate to selecting your state and city.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lawsonm6_FinalProject
{
    public partial class frmAddress : Form
    {
        //declare new frmStateProvince but do not instnatiate.
        public frmStateProvince stateProvince = null;
        public frmAddress()
        {
            InitializeComponent();

        }
        //return to home form, close this one
        private void btnAddressReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //instantiates the StateProvince form if one does not exist, or else it just opens the hidden form. Hides this form, instantiates/shows stateProvince.
        private void btnChangeStateProvince_Click(object sender, EventArgs e)
        {
            if (stateProvince != null)
            {
                stateProvince.Show();
            }
            else
            {
                stateProvince = new frmStateProvince();
            }
            //opens this form when stateProvince gets hidden.
            stateProvince.VisibleChanged += new EventHandler(stateProvince_FormVisibilityChanged);
            this.Hide();
            stateProvince.Show();
        }
        //If stateProvince is hidden, show this form.
        void stateProvince_FormVisibilityChanged(object sender, EventArgs e)
        {
            tbAddressDisplaySelectedState.Text = stateProvince.State;
            if (!stateProvince.Visible)
            {
                this.Show();
            }
        }
        //if cityName closes, show this form
        void cityName_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        //create new frmCityName, show it, hide this. Set selected state.
        private void btnCity_Click(object sender, EventArgs e)
        {
            frmCityName cityName = new frmCityName();
            //if next form closes, show this one
            cityName.FormClosed += new FormClosedEventHandler(cityName_FormClosed);
            cityName.SelectedState = tbAddressDisplaySelectedState.Text;
            //if you did not select a state, tell user to do it
            if (cityName.SelectedState.Length == 0)
            {
                string message = "Please select a State.";
                string caption = "Error: No state selected.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                this.Hide();
                cityName.Show();
            }
        }
    }
}
