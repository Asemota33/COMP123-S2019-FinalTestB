using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
/*
 * Student Name: Michael Asemota
 * Student ID: 301052117
 * Description: This is the character generator form  for the the main form
 */

namespace COMP123_S2019_FinalTestB.Views
{
    public partial class CharacterGeneratorForm : MasterForm
    {
        public CharacterGeneratorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for the back button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void backButton_Click(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedIndex != 0)
            {
                mainTabControl.SelectedIndex--;
            }
        }

        /// <summary>
        /// Event handler for the next button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedIndex < mainTabControl.TabPages.Count - 1)
            {
                mainTabControl.SelectedIndex++;
            }
        }
    }
}
