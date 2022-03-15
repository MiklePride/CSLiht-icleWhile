class program
{
    static void Main(string[] args)
    {
        int ageFriend;
        string congratulationToFriend;

        Console.Write("Сколько лет вашему другу:");
        ageFriend = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите поздравление:");
        congratulationToFriend = Console.ReadLine();

        for(int i = 0; i < ageFriend; i++)
        {
            Console.WriteLine(congratulationToFriend);
        }
    }
}