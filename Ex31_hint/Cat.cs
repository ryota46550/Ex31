using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Cat:Character
    {
        public Cat(string name, float hp, float power,bool animal) : base(name, hp, power,animal) { }
        public override void Attack(Character destination)
        {
                Console.WriteLine($"{this.name}は{destination.name}に爪でひっかいた！");
                Console.WriteLine($"{destination.name}はうしろに吹っ飛んだ！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
        }
    }
}
