namespace NovitskiyOnline
{
    public class Referee : INameble
    {
        public string Name { get; set; }

        public Referee(string name)
        {
            Name = name;
        }

        public void Whistle()
        {
            Console.WriteLine($"Арбитр {Name} свистит");
        }
    }
}
