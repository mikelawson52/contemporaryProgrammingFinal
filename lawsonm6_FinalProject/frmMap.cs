/*
 * Author: Michael Lawson
 * Assignment: Final Semester Project
 * Seminar: IT3045C Contemporary Programming
 * Proffessor: Bill Nicholson
 * Description: Recreate Bill's Sat Nav based on his provided youtube video, implimenting only buttons that were pushed in the video.
 * Class Description: App's final form, this will display the map and the entire selected address.  Can go back to house number form from here.
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
    public partial class frmMap : Form
    {
        //selected street, city, state and house number from previous forms
        public string SelectedStreet { get; set; }
        public string SelectedCity { get; set; }
        public string SelectedState { get; set; }
        public string SelectedNumber { get; set; }
        public frmMap()
        {
            InitializeComponent();
        }
        //return button
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //displays your selections as one address in a textbox.  Lat and Long are constant.
        private void frmMap_Load(object sender, EventArgs e)
        {
            tbInput.AppendText(SelectedNumber + " ");
            tbInput.AppendText(SelectedStreet + " STREET \n");
            tbInput.AppendText(SelectedCity + ", ");
            tbInput.AppendText(SelectedState);
            tbLatLong.Text = "N 41°55'35''  W 84°37'45''";
        }
    }
}
