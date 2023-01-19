using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Hornet : Character
    {
        public Hornet(string name, float hp, float power, bool animal) : base(name, hp, power, animal) { }
        public override void Attack(Character destination)
        {
            if (destination.animal)
            {
                Console.WriteLine($"{this.name}は{destination.name}に向けものすごい勢いで毒針を刺した");
                Console.WriteLine($"{destination.name}はその場で膝を突いた！");
                Console.WriteLine($"{destination.name}は{this.power + destination.hp}のダメージ");
                destination.hp -= this.power + destination.hp;
                Console.WriteLine($"{destination.name}は一瞬で全身に毒が回り即死した。");
            }
            else
            {
                Console.WriteLine($"{this.name}は{destination.name}に向けものすごい勢いで毒針を刺した！");
                Console.WriteLine($"{destination.name}はうしろに吹っ飛んだ！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"いまいち効果が薄かったようだ。");
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
        }
    }
}
