using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Assignment1();
            Assignment2();
            Assignment3();
            Assignment5();
            Assignment6();
            Console.ReadKey();
        }

        void Assignment1()
        {
            Score score = new Score(6, 500);
            int points = score.ComputeValue();
            Console.WriteLine(score.ToString());
        }
        void Assignment2()
        {
            BonusScore bonus = new BonusScore(500, 7, 8);
            bonus.ComputeValue();
            Console.WriteLine(bonus.ToString());
            List<Score> scores = new List<Score>();
            Score score1 = new Score(3, 600);
            BonusScore bonus2 = new BonusScore(240, 4, 6);
            Score score2 = new Score(6, 750);
            scores.Add(score1);
            scores.Add(bonus);
            scores.Add(score2);
            scores.Add(bonus2);
            foreach (Score item in scores)
            {
                Console.WriteLine(item.ToString());
            }
        }
        void Assignment3()
        {
            HighScore highScore = new HighScore("Feyenoord",DateTime.Today);
            BonusScore bonus = new BonusScore(500, 7, 8);
            Score score1 = new Score(3, 600);
            BonusScore bonus2 = new BonusScore(240, 4, 6);
            Score score2 = new Score(6, 750);
            highScore.Scores.Add(score1);
            highScore.Scores.Add(bonus);
            highScore.Scores.Add(score2);
            highScore.Scores.Add(bonus2);
            Console.WriteLine(highScore.Value);
        }
        void Assignment5()
        {
            Bag bag = new Bag(10);
            Weapon weapon = new Weapon();
            weapon.type = Weapon.Type.Sword;
            Gem gem = new Gem();
            bag.AddContent(weapon);
            bag.AddContent(gem);
            bag.AddContent(gem);
        }
        void Assignment6()
        {
            Chest chest = new Chest(20);
            Weapon weapon = new Weapon();
            weapon.type = Weapon.Type.Axe;
            Weapon weapon2 = new Weapon();
            weapon2.type = Weapon.Type.Crossbow;
            chest.AddContent(weapon);
            chest.AddContent(weapon2);
            Bag bag = new Bag(10);
            Weapon weapon3 = new Weapon();
            weapon3.type = Weapon.Type.Sword;
            Gem gem = new Gem();
            bag.AddContent(weapon3);
            bag.AddContent(gem);
            bag.AddContent(gem);
            chest.AddContent(bag);
        }
    }
}
