public class Program {
    static void Main(String[] args)
    {
        //int[] arr= { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //var result = arr.Where(e => e % 2 == 0);

        object[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var result = arr.Cast<int>().Where(e => e % 2 == 0);

        foreach(var e in result)
        {
            Console.WriteLine(e);
        }

        object[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var result2 = arr2.Cast<int>().FirstOrDefault(e => e % 12 == 0);
        Console.WriteLine(result2);
    }
}
