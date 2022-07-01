namespace NovitskiyOnline
{
    public class Simulator
    {
        public static void Move(string position, params INameble[] participants)
        {
            var result = participants.Select(participant => participant.Name);
            var stringResult = string.Join(", ", result);
            Console.WriteLine($"{stringResult} {position}");
        }
    }
}
