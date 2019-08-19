using System;

namespace LicenceKeyGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generate Fake License For FakeInstaller");

            Console.WriteLine("Type a PIN, Must be number");
            var PINOption = Console.ReadLine();
            int PIN;
            if (int.TryParse(PINOption, out PIN))
            {
                Console.WriteLine("PIN set to " + PIN);
            }
            else
            {
                Console.WriteLine("Invalid PIN, please restart");
                
            }

            Console.WriteLine("Pick a ID number or type nothing/R for random");
            var IDOption = Console.ReadLine();
            int ID;
            bool successID = int.TryParse(IDOption, out ID);
            if (successID)
            {
                Console.WriteLine("ID set to " + ID);
            }
            else
            {
                var rndID = new Random();
                ID = rndID.Next(1000);
                Console.WriteLine("ID set to " + ID);
            }

            Console.WriteLine("Completed Info:");
            var rnd = new Random(PIN);
            int licenceKey;
            string usableKey;
            for (int range = 0; range <= ID; range++)
            {
                int currentRandom = rnd.Next(999999);
                if (range == ID)
                {
                    licenceKey = currentRandom;
                    usableKey = licenceKey.ToString("X");
                    Console.WriteLine("Key is " + usableKey);
                }
            }
            Console.WriteLine("Press enter to end.....");
            Console.ReadLine();

        }
    }
}
