namespace doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Bank Account Transaction System
            double balance = 1000.00;
                int transactionCount = 0;
                string continueTransaction;

                Console.WriteLine("Bank Account Transaction System");
                Console.WriteLine($"Initial balance: ${balance:F2}");
                Console.WriteLine();

                do
                {
                    Console.WriteLine("Available transactions:");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Check Balance");
                    Console.WriteLine("4. View Transaction History");

                    Console.Write("Select transaction type (1-4): ");
                    int transactionType = int.Parse(Console.ReadLine());

                    switch (transactionType)
                    {
                        case 1:
                            Console.Write("Enter deposit amount: $");
                            double depositAmount = double.Parse(Console.ReadLine());

                            if (depositAmount > 0)
                            {
                                balance += depositAmount;
                                transactionCount++;
                                Console.WriteLine($"Deposited: ${depositAmount:F2}");
                                Console.WriteLine($"New balance: ${balance:F2}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid deposit amount!");
                            }
                            break;

                        case 2:
                            Console.Write("Enter withdrawal amount: $");
                            double withdrawAmount = double.Parse(Console.ReadLine());

                            if (withdrawAmount > 0 && withdrawAmount <= balance)
                            {
                                balance -= withdrawAmount;
                                transactionCount++;
                                Console.WriteLine($"Withdrawn: ${withdrawAmount:F2}");
                                Console.WriteLine($"New balance: ${balance:F2}");
                            }
                            else if (withdrawAmount > balance)
                            {
                                Console.WriteLine("Insufficient funds!");
                                Console.WriteLine($"Available balance: ${balance:F2}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid withdrawal amount!");
                            }
                            break;

                        case 3:
                            Console.WriteLine($"Current balance: ${balance:F2}");
                            break;

                        case 4:
                            Console.WriteLine($"Total transactions performed: {transactionCount}");
                            Console.WriteLine($"Current balance: ${balance:F2}");
                            break;

                        default:
                            Console.WriteLine("Invalid transaction type!");
                            break;
                    }

                    Console.WriteLine();
                    Console.Write("Do you want to perform another transaction? (yes/no): ");
                    continueTransaction = Console.ReadLine().ToLower();

                } while (continueTransaction == "yes" || continueTransaction == "y");

                Console.WriteLine("\n=== SESSION SUMMARY ===");
                Console.WriteLine($"Final balance: ${balance:F2}");
                Console.WriteLine($"Total transactions: {transactionCount}");

                if (balance > 1000)
                {
                    double profit = balance - 1000;
                    Console.WriteLine($"Net gain: +${profit:F2}");
                }
                else if (balance < 1000)
                {
                    double loss = 1000 - balance;
                    Console.WriteLine($"Net loss: -${loss:F2}");
                }
                else
                {
                    Console.WriteLine("No change in balance");
                }

                Console.WriteLine("Thank you for using our banking system!");
            }
        }
    }
    
