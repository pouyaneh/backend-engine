namespace ifElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //BasicIfElse();
            //UserLevelSystem();
            //LoginSystem();
            //DiscountSystem();
            //GameStatusSystem();
            //ConditionalOperator();
            //WeatherSystem();

            Console.ReadLine();
        }
        static void BasicIfElse ()
            {
            Console.WriteLine("=== Basic If-Else Example ===");

            int age = 20;

            if (age >= 18)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Teenager");
            }

            Console.ReadLine();
        }
        static void UserLevelSystem ()
            {
            Console.WriteLine("=== User Level Detection System ===");

            int score = 85;

            if (score >= 90)
            {
                Console.WriteLine("Level: Diamond");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Level: Gold");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Level: Silver");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Level: Bronze");
            }
            else
            {
                Console.WriteLine("Needs more effort");
            }

            Console.ReadLine();
        }
        static void LoginSystem ()
            {
            Console.WriteLine("=== Smart Login System ===");

            string username = "admin";
            string password = "12345";
            bool isTwoFactorEnabled = true;

            if (username == "admin" && password == "12345")
            {
                if (isTwoFactorEnabled)
                {
                    Console.WriteLine("Two-factor authentication code sent");
                }
                else
                {
                    Console.WriteLine("Login successful!");
                }
            }
            else
            {
                Console.WriteLine("Invalid username or password");
            }

            Console.ReadLine();
        }
        static void DiscountSystem ()
            {
            Console.WriteLine("=== Intelligent Discount System ===");

            double purchaseAmount = 150000;
            bool isFirstPurchase = false;
            int customerPoints = 250;

            double discount = 0;

            if (purchaseAmount > 100000)
            {
                discount = 0.15;

                if (isFirstPurchase)
                {
                    discount += 0.05;
                }

                if (customerPoints > 200)
                {
                    discount += 0.02;
                }
            }

            double finalAmount = purchaseAmount * (1 - discount);
            Console.WriteLine($"Final amount: {finalAmount} $");
            Console.WriteLine($"Applied discount: {discount * 100}%");

            Console.ReadLine();
        }
        static void GameStatusSystem ()
            {
            Console.WriteLine("=== Game Status Detection System ===");

            int playerHealth = 30;
            bool hasPotion = true;
            int enemiesCount = 2;

            if (playerHealth <= 0)
            {
                Console.WriteLine("Game Over!");
            }
            else if (playerHealth < 20 && hasPotion)
            {
                Console.WriteLine("Potion used! Health restored.");
                playerHealth = 100;
            }
            else if (playerHealth < 50 && enemiesCount > 0)
            {
                Console.WriteLine("Dangerous situation! Be careful!");
            }
            else if (enemiesCount == 0)
            {
                Console.WriteLine("Level completed!");
            }
            else
            {
                Console.WriteLine("Normal status");
            }

            Console.ReadLine();
        }
        static void ConditionalOperator ()
            {
            Console.WriteLine("=== Conditional Operator Example ===");

            int number = 7;
            string result = (number % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine($"Number {number} is {result}");

            Console.ReadLine();
        }
        static void WeatherSystem()
        {
            Console.WriteLine("=== Weather Analysis System ===");

            int temperature = 25;
            bool isRaining = false;
            int windSpeed = 25;

            if (temperature > 30)
            {
                if (isRaining)
                {
                    Console.WriteLine("Hot and rainy weather");
                }                      
                else                   
                {                      
                    Console.WriteLine("Very hot weather");
                }
            }
            else if (temperature > 20)
            {
                if (isRaining)
                {
                    Console.WriteLine("Warm and rainy");
                }
                else
                {
                    Console.WriteLine("Pleasant weather");
                }
            }
            else if (temperature > 10)
            {
                Console.WriteLine("Cool weather");
            }
            else
            {
                Console.WriteLine("Cold weather");
            }

            if (windSpeed > 30)
            {
                Console.WriteLine("Strong winds detected!");
            }

            Console.ReadLine();
        }
    }
}
