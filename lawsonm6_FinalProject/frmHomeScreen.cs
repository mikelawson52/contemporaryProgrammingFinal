/*
 * Author: Michael Lawson
 * Assignment: Final Semester Project
 * Seminar: IT3045C Contemporary Programming
 * Proffessor: Bill Nicholson
 * Description: Recreate Bill's Sat Nav based on his provided youtube video, implimenting only buttons that were pushed in the video.
 * Class Description: Home screen for all forms.  Can kill the app here or continue to selecting an address.
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
    public partial class frmHomeScreen : Form
    {

        public frmHomeScreen()
        {
            InitializeComponent();

        }
        //Takes user to address screen. hides this form, and creates a new address form.
        private void btnAddress_Click(object sender, EventArgs e)
        {
            frmAddress address = new frmAddress();
            //if address closes, make this form visible.
            address.FormClosed += new FormClosedEventHandler(address_FormClosed);
            this.Hide();
            address.Show();
        }
        //accidental implimentation, does nothing
        private void frmHomeScreen_Load(object sender, EventArgs e)
        {

        }
        //event to show this form if address closes
        void address_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        //Closes the program when exit is pressed
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
