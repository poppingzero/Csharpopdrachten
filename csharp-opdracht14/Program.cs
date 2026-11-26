namespace csharp_opdracht14;

class Program
{
    static void Main()
    {
        int[,] tabel = { { 10, 20 }, { 30, 40 }, { 50, 60 } };

        Console.WriteLine(tabel[2, 1]);
        Console.WriteLine(tabel[0, 0] + tabel[1, 1]);
        //dan print het uit 60
        // de tweede print uit 10+40=50
    }
}