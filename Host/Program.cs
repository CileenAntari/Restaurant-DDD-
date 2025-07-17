using App;
using Contracts;
using Domain;

internal class Program
{
    private static void Main(string[] args)
    {
        FoodService fl = new FoodService();  
        FoodDTO fd1 = new FoodDTO("pizza", "italian", 50);
        FoodDTO fd2 = new FoodDTO("burger", "junk food", 35);
        FoodDTO fd3 = new FoodDTO("pasta", "italian", 45);
        fl.Add(fd1);
        fl.Add(fd2);
        fl.Add(fd3);
        var foods = fl.GetAll();
        foreach (var n in foods)
        {
            Console.Write($"{n.Id}:{n.Name} ,");
        }
        Console.WriteLine();
        fl.Remove(fd1.Id);
        var foo = fl.GetAll();
        foreach (var n in foo)
        {
            Console.Write($"{n.Id}:{n.Name} ,");
        }
        Console.WriteLine();
        FoodDTO fd4 = new FoodDTO("sandwich", "junk food", 35);
        FoodDTO fd5 = new FoodDTO("mansaf", "arabic food", 45);
        fl.Add(fd4);
        fl.Add(fd5);
        var fo = fl.GetAll();
        foreach (var n in fo)
        {
            Console.Write($"{n.Id}:{n.Name} ,");
        }
        Console.WriteLine();
        FoodDTO fd6 = new FoodDTO("pesto pasta", "italian", 45);
        fl.Update(fd3.Id, fd6);
        var f = fl.GetAll();
        foreach (var n in f)
        {
            Console.Write($"{n.Id}:{n.Name} ,");
        }
        Console.ReadKey();
    }
}
