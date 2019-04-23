namespace ConsoleApp1
{
    public class Score
    {
        protected int level;
        protected int points;

        public Score(int level, int points)
        {
            this.level = level;
            this.points = points;
        }
        public virtual int ComputeValue()
        {
            int pointsWorth = level * points;
            return pointsWorth;
        }
        
        public override string ToString()
        {
            string print = $"Score Of level {level}: value = {ComputeValue()}, points: {points}";
            return print;
        }
    }
}
