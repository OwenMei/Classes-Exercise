namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Car carOne = new Car() { make = "honda", model = "crv", year = 2016};
            //asdf
            Console.WriteLine($"Make: {carOne.make} \nModel: {carOne.model} \nYear: {carOne.year}");
        }
    }
}
