using System;
using System.Collections.Generic;
using System.Linq;


namespace OOP_RPG
{
    public class Shop
    {
        public Game game { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Armor> Armors { get; set; }
        public List<Potion> Potions { get; set; }

        public Shop(Game game)
        {
            this.Weapons = new List<Weapon>();
            this.Armors = new List<Armor>();
            this.Potions = new List<Potion>();

            this.game = game;

            var Weapon1 = new Weapon("Sword", 10, 2, 3, 1);
            var Weapon2 = new Weapon("Axe", 12, 3, 4, 2);
            var Weapon3 = new Weapon("Longsword", 20, 5, 7, 3);
            var Armor1 = new Armor("Wooden Armor", 10, 2, 3);
            var Armor2 = new Armor("Metal Armor", 20, 5, 7);
            var Potion1 = new Potion("Healing potion", 5, 5, 2);

            this.Weapons.Add(Weapon1);
            this.Weapons.Add(Weapon2);
            this.Weapons.Add(Weapon3);
            this.Armors.Add(Armor1);
            this.Armors.Add(Armor2);
            this.Potions.Add(Potion1);
        }

        public void Menu()
        {
            Console.WriteLine("Welcome to My Shop What you want?");
            Console.WriteLine("1.Buy Item");
            Console.WriteLine("2.Sell Item");
            Console.WriteLine("3.Return to the game");
            var input = Console.ReadLine();
            if (input == "1")
            {
                this.ShowInventory();
            }
            else if (input == "2")
            {
                this.BuyFromUser();
            }
            else if (input == "3")
            {
                this.game.Main();
            }
        }
        public void ShowInventory()
        {
            Console.WriteLine("1. Weapons");
            Console.WriteLine("2. Armors");
            Console.WriteLine("3. Potions");
            Console.WriteLine("4. Menu");

            var ShowInventory = Console.ReadLine();

            if (ShowInventory == "1")
            {
                foreach (var a in this.Weapons)
                {
                    Console.WriteLine(Weapons.IndexOf(a) + a.Name + " requires " + a.OriginalValue + " Gold");
                }
            }
        }

        public void BuyFromUser()
        {
            Console.WriteLine("Select item to sell.");
            Console.WriteLine("1. Weapons");
            Console.WriteLine("2. Armors");
            Console.WriteLine("3. Potions");
            Console.WriteLine("4. Menu");

            var SoldItem = Console.ReadLine();
        }

    }
}