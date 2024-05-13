class Program
{
    static void Main()
    {
        double radius;
        bool validInput = false;

        do
        {
            Console.Write("Enter the radius of the circle: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out radius))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid radius.");
            }
        } while (!validInput);

        Circle circle = new Circle();
        double inputRadius;

        do
        {
            Console.WriteLine("\nDiameter: " + circle.Diameter());
            Console.WriteLine("Circumference: " + circle.Circumference());
            Console.WriteLine("Area: " + circle.Area());

            Console.Write("\nDo you want the circle to grow? (yes/no): ");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "yes")
            {
                circle.Grow();
            }
            else if (choice.ToLower() == "no")
            {
                Console.WriteLine($"Goodbye! The final radius of the circle is: {circle.GetRadius()}");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 'yes' or 'no'.");
            }

        } while (true);
    }
}