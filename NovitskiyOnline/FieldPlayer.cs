namespace NovitskiyOnline
{
    public class FieldPlayer : Player
    {
        public FieldPlayer(string name)
        {
            Name = name;
            Role = "игрок";
        }
        public void KickOnGoal()
        {
            Console.WriteLine($"игрок {Name} бьет по воротам");
        }

        public void CatchBall()
        {
            Console.WriteLine($"игрок {Name} берет мяч в руки\n... и нарушает правила");
        }
    }
}
