using System;
using System.IO;

namespace TableauMoyenne
{
    internal class Program
    {
        public static void Main(string[] args)
        {
//#,Name,Type 1,Type 2,Total,HP,Attack,Defense,Sp. Atk,Sp. Def,Speed,Generation,Legendary

            StreamReader fileReader = new StreamReader("./../../../Pokemon.csv");
            string line;
            int count = 0;
            int sumAttack = 0;
            fileReader.ReadLine();
            while ((line = fileReader.ReadLine()) != null)
            {
                string[] pokemon = line.Split(',');
                sumAttack += Convert.ToInt32(pokemon[6]);
                count++;
            }

            float meanAttack = (float)(sumAttack * 1.0 / count);
            Console.WriteLine($"La moyenne des attaques est de {meanAttack}");
        }
    }
}