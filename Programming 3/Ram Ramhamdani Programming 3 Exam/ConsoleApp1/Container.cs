using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    abstract class Container : GameOject
    {
        private int maxWeight;
        List<GameOject> content = new List<GameOject>();
        public Container(int max)
        {
            maxWeight = max;
        }

        public void AddContent(GameOject gameOject)
        {
            if (content.Count > maxWeight)
            {
                Console.WriteLine("Object is Full!");
                return;
            }
            else
            {
                content.Add(gameOject);
            }
        }
        public int CalculateWeight()
        {
            int weight = 0;
            foreach (GameOject item in content)
            {
                weight = weight + item.Weight;
            }
            return weight;
        }
    }
}
