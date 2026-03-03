using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacter
{
    using System;

    class Character
    {
        public string name;
        public int health;
        public int level;

        public Character() { }

        public virtual void Attack()
        {
            Console.WriteLine(name + " attacks!");
        }

        public void LevelUp()
        {
            level++;
            health += 20;
            Console.WriteLine(name + " leveled up to " + level);
        }
    }

  
    class Warrior : Character
    {
        public Warrior(string n)
        {
            name = n;
            health = 100;
            level = 1;
        }

        public override void Attack()
        {
            Console.WriteLine(name + " swings a sword!");
        }
    }

    class Mage : Character
    {
        public Mage(string n)
        {
            name = n;
            health = 80;
            level = 1;
        }

        public override void Attack()
        {
            Console.WriteLine(name + " casts a fireball!");
        }
    }

    class Archer : Character
    {
        public Archer(string n)
        {
            name = n;
            health = 90;
            level = 1;
        }

        public override void Attack()
        {
            Console.WriteLine(name + " shoots an arrow!");
        }
    }

    class Skill
    {
        public string skillName;

        public Skill(string s)
        {
            skillName = s;
        }

        public void ShowSkill()
        {
            Console.WriteLine("Skill: " + skillName);
        }
    }


    class Inventory
    {
        public string[] items = new string[3];
        public int count = 0;

        public void AddItem(string item)
        {
            if (count < 3)
            {
                items[count] = item;
                count++;
            }
        }

        public void ShowInventory()
        {
            Console.WriteLine("Inventory Items:");
            for (int i = 0; i < count; i++)
                Console.WriteLine(items[i]);
        }
    }

   

    
}
