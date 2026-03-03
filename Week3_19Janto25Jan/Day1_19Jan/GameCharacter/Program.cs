namespace GameCharacter
{
    class Program
    {
        static void Main()
        {
            Warrior w1 = new Warrior("Arjun");
            Mage m1 = new Mage("Merlin");
            Archer a1 = new Archer("Robin");

            Inventory inv = new Inventory();
            inv.AddItem("Sword");
            inv.AddItem("Health Potion");

            Skill s1 = new Skill("Power Strike");

            Console.WriteLine("GAME CHARACTER SYSTEM ");

            w1.Attack();
            w1.LevelUp();

            m1.Attack();
            a1.Attack();

            s1.ShowSkill();
            inv.ShowInventory();
        }
    }

}
