namespace NovitskiyOnline
{
    public class GoalKeeper : Player
    {
        public GoalKeeper(string name)
        {
            Name = name;
            Role = "вратарь";
        }

        public void CatchBall()
        {
            Console.WriteLine($"вратарь {Name} берет мяч в руки");
        }

        public void MissBall()
        {
            Console.WriteLine("ГОООЛ!");
        }
    }
}
