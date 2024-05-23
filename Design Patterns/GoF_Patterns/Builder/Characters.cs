using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   public  enum CharacterCategorie { Human, Elf, Ork, Wizzard };

    public abstract class Character
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public int HP { get; set; }
        public CharacterCategorie CharacterCategorie { get; set; }
        public bool hasArch { get; set; }
        public bool hasKnife { get; set; }
        public bool hasSword { get; set; }
        public bool hasArmour { get; set; }
        public bool hasBackpack { get; set; }


        //public Character(string Name, string Description, int HP, CharacterCategorie characterCategorie,
        //                bool hasArch, bool hasKnife, bool hasSword, bool hasArmour, bool hasBackpack)
        //{
        //    this.Name = Name;
        //    this.Description = Description;
        //    this.HP = HP;
        //    this.CharacterCategorie = CharacterCategorie;
        //    this.hasArch = hasArch;
        //    this.hasKnife = hasSword;
        //    this.hasSword = hasArmour;
        //    this.hasBackpack = hasBackpack;
        //}

        public abstract void SetName();
        public abstract void SetDescription();
        public abstract void SetHP();
        public abstract void SetCharacterCategorie();
        public abstract void HasArch();
        public abstract void HasKnife();
        public abstract void HasSword();
        public abstract void HasBackpack();
    }


    public class HumanBuilder : Character
    {
        public HumanBuilder() 
        { 
         
        }

        public override void SetName()
        {
            Name = "Human";
        }

        public override void SetDescription()
        {
            Description = "Celovek";
        }

        public override void SetHP()
        {
            HP = 100;
        }
        public override void SetCharacterCategorie()
        {
            CharacterCategorie = CharacterCategorie.Human;
        }
        public override void HasArch()
        {
            hasArch = true;
        }
        public override void HasKnife()
        {
            hasKnife = true;
        }
        public override void HasSword()
        {
            hasSword = true;
        }
        public override void HasBackpack()
        {
            hasBackpack = true;
        }

    }

}
