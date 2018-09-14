using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{
    public class Fight
    {
        List<Monster> Monsters { get; set; }
        public Game game { get; set; }
        public Hero hero { get; set; }
        public Monster monster { get; set; }

        public Fight(Hero hero, Game game)
        {
            this.Monsters = new List<Monster>();
            this.hero = hero;
            this.game = game;
            this.AddMonster("Squid", 11, 8, 20);
            this.AddMonster("Eevee", 10, 9, 19);
            this.AddMonster("Ditto", 9, 8, 18);
            this.AddMonster("Pichu", 8, 7, 17);

            var enemy = this.Monsters[0];
            var randomMonsters = Monsters.OrderBy(p => Guid.NewGuid()).FirstOrDefault();
            var lessThanTwentyHitPoints = this.Monsters.Where(p => p.CurrentHP < 20).FirstOrDefault();
            var strengthOfAtLeastEleven = this.Monsters.Where(p => p.Strength >= 11).FirstOrDefault();
            var secondMonster = this.Monsters[1];
            var lastMonster = this.Monsters.Last();
            var monster = randomMonsters;
        }

        public void AddMonster(string name, int strength, int defense, int hp)
        {
            var monster = new Monster(name, strength, defense, hp, hp);
            this.Monsters.Add(monster);
        }

        public void Start()
        {
            Console.WriteLine("You've encountered a " + monster.Name + "! " + monster.Strength + " Strength/" + monster.Defense + " Defense/" +
            monster.CurrentHP + " HP. What will you do?");
            Console.WriteLine("1. Fight");
            var input = Console.ReadLine();
            if (input == "1")
            {
                this.HeroTurn();
            }
            else
            {
                this.game.Main();
            }
        }

        public void HeroTurn()
        {
            var compare = hero.Strength - monster.Defense;
            int damage;

            if (compare <= 0)
            {
                damage = 1;
                monster.CurrentHP -= damage;
            }
            else
            {
                damage = compare;
                monster.CurrentHP -= damage;
            }
            Console.WriteLine("You did " + damage + " damage!");

            if (monster.CurrentHP <= 0)
            {
                this.Win();
            }
            else
            {
                this.MonsterTurn();
            }

        }

        public void MonsterTurn()
        {
            var enemy = monster;
            int damage;
            var compare = monster.Strength - hero.Defense;
            if (compare <= 0)
            {
                damage = 1;
                hero.CurrentHP -= damage;
            }
            else
            {
                damage = compare;
                hero.CurrentHP -= damage;
            }
            Console.WriteLine(monster.Name + " does " + damage + " damage!");
            if (hero.CurrentHP <= 0)
            {
                this.Lose();
            }
            else
            {
                this.Start();
            }
        }

        public void Win()
        {
            this.hero.Gold += this.monster.Gold;
            Console.WriteLine(monster.Name + " has been defeated! You win the battle!");
            game.Main();
        }

        public void Lose()
        {
            Console.WriteLine("You've been defeated! :( GAME OVER.");
            return;
        }

    }

}