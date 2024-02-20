namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create new instance of Car class
            var redSkodaCar = new Car();

            //set values for the properties of the car instance
            redSkodaCar.Year = 2024;
            redSkodaCar.Make = "Skoda";
            redSkodaCar.Model = "Suberb iV";

            Console.WriteLine($"{redSkodaCar.Year}, {redSkodaCar.Make}, {redSkodaCar.Model}");

            Console.ReadLine();
        }
    }
}
