namespace NovitskiyOnline
{
    public class Player : INameble
    {
        public string Name { get; set; }

        public string Role { get; set; }

        public bool isYellow { get; set; }

        public virtual void Pass(Player player)
        {
            Console.WriteLine($"{Name} отдает пас {player.Name}-у");
        }

        public void PickBooking()
        {
            if (isYellow == false)
            {
                isYellow = true;
                Console.WriteLine($"игрок {Name} получает желтую карточку");
            }
            else
            {
                Console.WriteLine($"игрок {Name} получает красную карточку");
            }
        }
    }
}
