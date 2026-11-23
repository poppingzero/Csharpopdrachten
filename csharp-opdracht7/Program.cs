class Program
{
    static void Main(string[] args)
    {
        int geluksgetal = 5;
        Console.WriteLine("wat is mijn geluksgetal?");

        ConsoleKeyInfo toets = Console.ReadKey();
        Console.WriteLine();

        if (char.IsDigit(toets.KeyChar))
        {
            int gekozengetal = int.Parse(toets.KeyChar.ToString());

            if (gekozengetal == geluksgetal)
            {
                Console.WriteLine($"{gekozengetal} is juist! Je hebt mijn geluksgetal geraden");
            }
            else
            {
                Console.WriteLine($"{gekozengetal} is niet mijn geluksgetal");
            }
        }
        else
        {
            Console.WriteLine("Dat is niet juist, vul in een nummer");
        }
    }
}