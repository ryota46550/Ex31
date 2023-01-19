using System;

namespace Ex31_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character("しむら人", 500, 2,true);
            Character character2 = new Character("ささっき", 1000, 25,true);
            Tank tank1 = new Tank("Tiger", 500000, 250,false);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125,false);
            tank2.bullet = 5;
            Cow cow = new Cow("みるタンク", 700, 60,true);
            Cat cat = new Cat("タマ", 530, 20,true);
            Hornet hornet = new Hornet("はちみー", 510, 5, true);
            Character[] characters = { character1, character2, tank1, tank2, cow, cat, hornet};
            for(var i = 1; i < characters.Length; i++)
            {
                characters[i].Attack(character1);
            }
        }
    }
}
