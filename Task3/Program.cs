class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Is bear sleeping? Press 'y' if he is.");
        char userInput = Console.ReadKey().KeyChar;

        if (userInput == 'y' || userInput == 'Y')
        {
            Console.WriteLine("\n───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───\r" +
                              "\n───█▒▒░░░░░░░░░▒▒█───\r" +
                              "\n────█░░▒░░░░░▒░░█────\r" +
                              "\n─▄▄──█░░░▀█▀░░░█──▄▄─\r" +
                              "\n█░░█─▀▄░░░░░░░▄▀─█░░█\r\n");
        }
        else
        {
            Console.WriteLine("\n───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───\r" +
                              "\n───█▒▒░░░░░░░░░▒▒█───\r" +
                              "\n────█░░█░░░░░█░░█────\r" +
                              "\n─▄▄──█░░░▀█▀░░░█──▄▄─\r" +
                              "\n█░░█─▀▄░░░░░░░▄▀─█░░█\r\n");
        }
    }
}