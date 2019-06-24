using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1__Strategy_Pattern_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>();
            characters.Add(new Queen());
            characters.Add(new Troll());
            characters.Add(new King());
            characters.Add(new Knight());

            foreach (Character character in characters)
            {
                character.Fight();
            }

            //change weapon of the knight to axe
            characters[3].Weapon = new AxeBehaviour();
            foreach (Character character in characters)
            {
                character.Fight();
            }
            Console.ReadKey();
        }
    }
}
