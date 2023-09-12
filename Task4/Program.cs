class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть кількість повторювань: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───\r" +
                            "\n───█▒▒░░░░░░░░░▒▒█───\r" +
                            "\n────█░░█░░░░░█░░█────\r" +
                            "\n─▄▄──█░░░▀█▀░░░█──▄▄─\r" +
                            "\n█░░█─▀▄░░░░░░░▄▀─█░░█\r\n");
        }
    }
}