using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poc
{
    public abstract class pocemon
    {
        public int hp;
        public int attack;
        public int defense;
        public int spesial_attack;
        public int spesial_defense;
        public int speed;
    }
    class pokemon_Axew : pocemon
    {
        string tip;
        string name;

        int hp_damage;
        string tipe_hp_damage;
        public pokemon_Axew(string name, string tip, int hp, int attack, int defense, int spesial_attack, int spesial_defense, int speed, List<string> skills)
        {
            // List<string> skills = new List<string> skills { "Полёт"}
            this.name = name;
            this.tip = tip;
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
            this.spesial_attack = spesial_attack;
            this.spesial_defense = spesial_defense;
            this.speed = speed;



            Console.WriteLine($"Имя:{name} Тип:{tip}  ХП:{hp}  Аттака:{attack}  Защита:{defense}  Спец атака:{spesial_attack}  Спец защита:" +
                    $"{spesial_defense}  Скорость:{speed}");
            foreach (string item_skills in skills)
                Console.WriteLine($"Умения:{item_skills} ");
            Console.WriteLine();

        }
        void imyn_rock(int yron, string tipe_yron)
        {
            this.hp_damage = yron;
            this.tipe_hp_damage = tipe_yron;
            if (tipe_yron == "rock")
            {
                hp = hp - 0;
            }
            else
            {
                hp = hp - yron;
            }
        }
        void double_damage()
        {
            attack = attack * 2;
        }
    }

    class pokemon_Fraxure : pocemon
    {
        string tip;
        string name;
        public pokemon_Fraxure(string name, string tip, int hp, int attack, int defense, int spesial_attack, int spesial_defense, int speed)
        {
            this.name = name;
            this.tip = tip;
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
            this.spesial_attack = spesial_attack;
            this.spesial_defense = spesial_defense;
            this.speed = speed;
            Console.WriteLine($"Имя:{name} Тип:{tip}  ХП:{hp}  Аттака:{attack}  Защита:{defense}  Спец атака:{spesial_attack}  Спец защита:" +
                $"{spesial_defense}  Скорость:{speed} ");
            Console.WriteLine();
        }
    }


    class pokemon_Haxorus : pocemon
    {
        string tip;
        string name;
        public pokemon_Haxorus(string name, string tip, int hp, int attack, int defense, int spesial_attack, int spesial_defense, int speed, List<string> skills)
        {
            this.name = name;
            this.tip = tip;
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
            this.spesial_attack = spesial_attack;
            this.spesial_defense = spesial_defense;
            this.speed = speed;
            Console.WriteLine($"Имя:{name} Тип:{tip}  ХП:{hp}  Аттака:{attack}  Защита:{defense}  Спец атака:{spesial_attack}  Спец защита:" +
                $"{spesial_defense}  Скорость:{speed}");
            foreach (string item_skills in skills)
                Console.WriteLine($"Умения:{item_skills} ");
            Console.WriteLine();
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> team = new List<string> { "Axew", "Haxorus" };
            team.Add("Fraxure");

            pokemon_Axew _Axew = new pokemon_Axew("Axew", "dragon", 46, 87, 60, 30, 40, 57, new List<string> { "защита от камней", "Полёт", "Двойной урон" });
            pokemon_Fraxure _Fraxure = new pokemon_Fraxure("Fraxure", "dragon", 66, 117, 70, 40, 50, 67);
            pokemon_Haxorus _Haxorus = new pokemon_Haxorus("Haxorus", "dragon", 76, 147, 90, 60, 70, 97, new List<string> { "защита от огня" });
            Console.WriteLine("В вашей комманде:");
            foreach (var i in team) Console.WriteLine($"{i}");
        }
    }
}
