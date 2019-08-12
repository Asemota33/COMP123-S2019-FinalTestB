using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Student Name: Michael Asemota
 * Student ID: 301052117
 * Description: This is the character class and the data container for the forms
 */

namespace COMP123_S2019_FinalTestB.Objects

{
    public class Character
    {
        // Character Abilities
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Constitution { get; set; }
        public string Intelligence { get; set; }
        public string Wisdom { get; set; }
        public string Charisma { get; set; }

        // Secondary Abilities
        public int ArmourClass { get; set; }
        public int HitPoints { get; set; }

        //Character Class
        public CharacterClass Class { get; set; }
        public int Level { get; set; }

        //Equipment
        List<Item> Inventory;

        //Constructor
        Character()
        {
            this.Inventory = new List<Item>();
        }
    }
}
