namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car favoriteCar = new Car() { Make = "Toyota", Model = "Tacoma", Year = 2024 };

            Console.WriteLine(favoriteCar.Make);
            Console.WriteLine(favoriteCar.Model);
            Console.WriteLine(favoriteCar.Year);
        }
    }
}
