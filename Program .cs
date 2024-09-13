using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon
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

        public pokemon_Axew(string name, string tip, int hp, int attack, int defense, int spesial_attack, int spesial_defense, int speed, List<string> skills)
        {
            List<string> skills = new List<string> skills { "Полёт"}
            this.name = name;
            this.tip = tip;
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
            this.spesial_attack = spesial_attack;
            this.spesial_defense = spesial_defense;
            this.speed = speed;

            foreach (string item_skills in skills)

                Console.WriteLine($"Имя:{name} Тип:{tip}  ХП:{hp}  Аттака:{attack}  Защита:{defense}  Спец атака:{spesial_attack}  Спец защита:" +
                    $"{spesial_defense}  Скорость:{speed}");
            Console.WriteLine(item_skills);

        }
        void imyn_rock(int yron, string tipe_yron)
        {
            if (tipe_yron = "rock")
            {
                hp - 0;
            }
            else
            {
                hp - yron;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            pokemon_Axew _Axew = new pokemon_Axew("Axew", "dragon", 46, 87, 60, 30, 40, 57);

        }
    }
}
