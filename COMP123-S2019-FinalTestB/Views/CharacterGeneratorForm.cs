using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        List<string> firstNames = new List<string>();
        List<string> lastNames = new List<string>();
        List<string> inventoryList = new List<string>();
        //List<string> firstName = new List<string>();
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

        /// <summary>
        /// Creates random number and uses it to index through text file, displays information in text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateNameButton_Click(object sender, EventArgs e)
        {
            LoadNames();
            LoadInventory();
            GenerateNames();
            Program.character.firstName = firstNameDataLabel.Text;
            Program.character.lastName = lastNameDataLabel.Text;

        }
        private void LoadNames()
        {
            firstNames = new List<string>();
            firstNames = File.ReadAllLines("../../Data/firstNames.txt").ToList();
            lastNames = File.ReadAllLines("../../Data/lastnames.txt").ToList();
        }
        private void GenerateNames()
        {
            var r = new Random();
            var randomFirstNameLine = r.Next(0, firstNames.Count);
            var firstName = firstNames[randomFirstNameLine];
            firstNameDataLabel.Text = firstName;

            var randomLastNameLine = r.Next(0, lastNames.Count);
            var lastName = lastNames[randomLastNameLine];
            lastNameDataLabel.Text = lastName;

        }
        /// <summary>
        /// Saves the information to text file named Character.txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            characterSheetSaveFileDialog.FileName = "Character.txt";
            characterSheetSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            characterSheetSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open file dialog - Modal Form
            var result = characterSheetSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                //open file to write
                using (StreamWriter outputStream = new StreamWriter
                    (File.Open(characterSheetSaveFileDialog.FileName, FileMode.Create)))
                {
                    //writing stuff to file

                    outputStream.WriteLine();//(Program);
                   
                    //Close file
                    outputStream.Close();
                    //Dispose of memory
                    outputStream.Dispose();
                }
                MessageBox.Show("File Saved", "Saving...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Open the text file 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialogue
            characterSheetOpenFileDialog.FileName = "Character.txt";
            characterSheetOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            characterSheetOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            //open file dialogue
            var result = characterSheetOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    //open your stream to read
                    using (StreamReader inputStream =
                        new StreamReader(File.Open(characterSheetOpenFileDialog.FileName, FileMode.Open)))
                    {
                        //reading stuff to file

                        //Program.product.platform = inputStream.ReadLine();
                        //Program.product.productID = short.Parse(inputStream.ReadLine());
                        //Program.product.cost = Convert.ToDecimal(inputStream.ReadLine());
                        

                        //Close file
                        inputStream.Close();
                        //Dispose of memory
                        inputStream.Dispose();

                    }
                }
                catch (IOException exception)
                {
                    MessageBox.Show("Error: " + exception.Message, "File I/O Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutBox.Show();
        }

        private void genrateAbilitiesButton_Click(object sender, EventArgs e)
        {
            var r = new Random();
            var newNumber1 = r.Next(3, 18);
            var newNumber2 = r.Next(3, 18);
            var newNumber3 = r.Next(3, 18);
            var newNumber4 = r.Next(3, 18);
            var newNumber5 = r.Next(3, 18);
            var newNumber6 = r.Next(3, 18);
            strengthDataLabel.Text = newNumber1.ToString();
            dexterityDataLabel.Text = newNumber2.ToString();
            constitutionDataLabel.Text = newNumber3.ToString();
            intelligenceDataLabel.Text = newNumber4.ToString();
            wisdomDataLabel.Text = newNumber5.ToString();
            charismaDataLabel.Text = newNumber6.ToString();

            Program.character.Strength = strengthDataLabel.Text;
            Program.character.Dexterity = dexterityDataLabel.Text;
            Program.character.Constitution = constitutionDataLabel.Text;
            Program.character.Intelligence = intelligenceDataLabel.Text;
            Program.character.Wisdom = wisdomDataLabel.Text;
            Program.character.Charisma = charismaDataLabel.Text;
        }

        public void LoadInventory()
        {
            inventoryList = new List<string>();
            inventoryList = File.ReadAllLines("../../Data/inventory.txt").ToList();
        }
        public void GenerateInventory()
        {
            var r = new Random();
            var firstLine = r.Next(0, inventoryList.Count - 1);
            var secondLine = r.Next(0, inventoryList.Count - 1);
            var thirdLine = r.Next(0, inventoryList.Count - 1);
            var fourthLine = r.Next(0, inventoryList.Count - 1);

            var firstinventory = inventoryList[firstLine];
            var secondinventory = inventoryList[secondLine];
            var thirdinventory = inventoryList[thirdLine];
            var fourthinventory = inventoryList[fourthLine];

            firstInventoryItem.Text = firstinventory;
            secondInventoryItem.Text = secondinventory;
            thirdInventoryItem.Text = thirdinventory;
            fourthInventoryItem.Text = fourthinventory;



            //Program.character.Inventory = firstInventoryItem.Text;
        }

        private void generateInventoryButton_Click(object sender, EventArgs e)
        {
            GenerateInventory();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void characterSheetPage_Click(object sender, EventArgs e)
        {

        }

        private void mainTabControl_TabIndexChanged(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedIndex == 3)
            {
                //heroNameLabel.Text = Program.character.;
                generatedFirstNameLabel.Text = Program.character.firstName;
                generatedLastNameLabel.Text = Program.character.lastName;

                abilitiesLabel1.Text = Program.character.Charisma;
                abilitiesLabel2.Text = Program.character.Strength;
                abilitiesLabel3.Text = Program.character.Wisdom;
                abilitiesLabel4.Text = Program.character.Intelligence;
                abilitiesLabel5.Text = Program.character.Dexterity;
                abilitiesLabel6.Text = Program.character.Constitution;
            }
        }
    }
}
