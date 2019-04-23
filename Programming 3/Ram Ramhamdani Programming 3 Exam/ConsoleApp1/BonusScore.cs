namespace ConsoleApp1
{
    public class BonusScore : Score
    {
        public int bonus;
        public BonusScore(int points, int level, int bonus) :base(level,points)
        {
            this.points = points;
            this.level = level;
            this.bonus = bonus;
        }
        public override int ComputeValue()
        {
            int count = bonus;
            while (count!=0)
            {
                points = points + 10;
                count--;
            }
            return points;
        }
        public override string ToString()
        {
            string print = $"Score Of level {level}: value = {ComputeValue()}, points: {points}, bonus: {bonus}";
            return print;
        }
    }
}
