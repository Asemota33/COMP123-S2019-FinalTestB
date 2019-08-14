using COMP123_S2019_FinalTestB.Objects;
using COMP123_S2019_FinalTestB.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Student Name: Michael Asemota
 * Student ID: 301052117
 * Description: This is the driver class for the forms
 */
namespace COMP123_S2019_FinalTestB
{
    static class Program
    {
        //temporary
        public static CharacterGeneratorForm characterForm;
        public static AboutBox aboutBox;
        public static Character character;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            character = new Character();
            aboutBox = new AboutBox();
            characterForm = new CharacterGeneratorForm();
            Application.Run(characterForm);
        }
    }
}
