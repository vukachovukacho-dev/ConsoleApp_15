namespace ConsoleApp_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User validUser = new User("giorgi123", "giorgi@example.com", 25);
                Console.WriteLine($"User '{validUser.Username}' created successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error for validUser: {ex.Message}");
            }

            Console.WriteLine(new string('-', 40));

            try
            {
                User invalidUser = new User("ana", "invalid-email", 15);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Range Error: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Validation Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }

            Console.ReadLine(); 
        }
    }
}
