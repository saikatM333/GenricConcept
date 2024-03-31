using GenericClassConcept;

public class Program
{
    public  static void Main(string[] args)
    {
        Console.WriteLine("Generic class demo ");
        Maximum maximum = new Maximum();
        
        Console.WriteLine("find the Maximum for the given integer ");
        maximum.IntegerMaximum(13, 12, 11);

        Console.WriteLine("find the maximum form the given float");
        maximum.FloatMaximum(18.7F, 19.8F, 19.9F);

        Console.WriteLine("enter the maximum from the given string ");
        maximum.StringMaximum("saikat", "ram", "rahul");

        Console.WriteLine("find the maximum from more than three input ");
        maximum.MaximumFinder(1, 2, 3, 4, 5, 6);

        Console.WriteLine(" find the maiximum using generic concept ");
        GenericClass<int> genericClass = new GenericClass<int>();
        int maximumInteger = genericClass.MaximumFinder(1, 2, 3, 4, 8, 7);

        Console.WriteLine($"maximum out of the given input is {maximumInteger}");


    }
}