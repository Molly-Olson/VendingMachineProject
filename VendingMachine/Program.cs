using System;
using System.IO;


namespace VendingMachine
{
    internal class Program
    {

        public class InstanceCounterVend
        {
            public int SodasCount { get; private set; }
            public int ChipsCount { get; private set; }
            public int CandyCount { get; private set; }
            public int EnergyDrinkCount { get; set; }
            public int GumCount { get; set; }
            public int VeggieSticksCount { get; set; }
            public int ProteinShakeCount { get; set; }
            public int MushroomJerkyCount { get; set; }
            public int RiceCakesCount { get; set; }
            public int FruitBarCount { get; set; }

            public void TrackSoda() => SodasCount++;
            public void TrackChips() => ChipsCount++;
            public void TrackCandy() => CandyCount++;
            public void TrackEnergyDrink() => EnergyDrinkCount++;
            public void TrackGum() => GumCount++;
            public void TrackVeggieSticks() => VeggieSticksCount++;
            public void TrackProteinShake() => ProteinShakeCount++;
            public void TrackMushroomJerky() => MushroomJerkyCount++;
            public void TrackRiceCakes() => RiceCakesCount++;
            public void TrackFruitBar() => FruitBarCount++;
            public void PrintTotals()
            {

                Console.WriteLine
                    ($"Current Items Vended Sodas: {SodasCount}, " +
                    $"EnergyDrink: {EnergyDrinkCount}, " +
                    $"Chips: {ChipsCount}, " +
                    $"Candy: {CandyCount}, " +
                    $"Gum: {GumCount}," +
                    $"VeggieSticks: {VeggieSticksCount}, " +
                    $"ProteinShake: { ProteinShakeCount}, " +
                    $"MushroomJerky: {MushroomJerkyCount}, " +
                    $"RiceCakes: {RiceCakesCount}," +
                    $"FruitBar: {FruitBarCount}, " +
                    $" time(s). Thank you!");
            }
        }

        static void Main(string[] args)
        {

            string writeText = "Vend History"; //add a link to count here
            File.WriteAllText("filename.txt", writeText);

            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);


            bool isRunning = true;

            InstanceCounterVend counter = new InstanceCounterVend();

            counter.PrintTotals();
            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine("Welcome to the Vending Machine");

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1.) Candy Bar");
                Console.WriteLine("2.) Soda");
                Console.WriteLine("3.) Energy Drink");
                Console.WriteLine("4.) Chips");
                Console.WriteLine("5.) Gum");
                Console.WriteLine("6.) Veggie Sticks");
                Console.WriteLine("7.) Protein Shake");
                Console.WriteLine("8.) Mushroom Jerky");
                Console.WriteLine("9.) Rice Cakes");
                Console.WriteLine("10.) Fruit Bar");
                Console.WriteLine("0.) Exit");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
                Console.Write("What option would you like? (0-10) ");


                // using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, Write)))

                int answer;
                if (!int.TryParse(Console.ReadLine(), out answer))
                {
                    Console.WriteLine("\nInvalid input, please select a number.");
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadLine();
                    continue;
                }
                string itemName = "";

                switch (answer)
                {
                    case 1:
                        itemName = "Candy Bar";
                        counter.TrackCandy();
                        Console.WriteLine("\nNow Vending a Candy Bar."); break;
                    case 2:
                        itemName = "Soda";
                        counter.TrackSoda();
                        Console.WriteLine("\nNow Vending a Soda."); break;
                    case 3:
                        itemName = "Energy Drink";
                        counter.TrackSoda();
                        Console.WriteLine("\nNow Vending an Energy Drink."); break;
                    case 4:
                        itemName = "Chips";
                        counter.TrackChips();
                        Console.WriteLine("\nNow Vending Chips."); break;
                    case 5:
                        itemName = "Gum";
                        Console.WriteLine("\nNow Vending Gum."); break;
                    case 6:
                        itemName = "Veggie Sticks";
                        Console.WriteLine("\nNow Vending Veggie Sticks."); break;
                    case 7:
                        itemName = "Protein Shake";
                        Console.WriteLine("\nNow Vending a Protein Shake."); break;
                    case 8:
                        itemName = "Mushroom Jerky";
                        Console.WriteLine("\nNow Vending  Mushroom Jerky."); break;
                    case 9:
                        itemName = "Rice Cakes";
                        Console.WriteLine("\nNow Vending Rice Cakes."); break;
                    case 10:
                        itemName = "Fruit Bar";
                        Console.WriteLine("\nNow Vending a Fruit Bar."); break;
                    case 0:
                        itemName = "Exit";
                        Console.WriteLine("\nThank you for Vending with us!");
                        isRunning = false;
                        break;
                    default:
                        itemName = "Invalid Option";
                        Console.WriteLine("\nInvalid option -- Please try again.");
                        break;
                }

                string logMessage = $"[{DateTime.Now:MM/dd/yyyy hh:mm:ss tt}] User selected: {itemName}";
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "WriteLines.txt");
                using (StreamWriter outputFile = new StreamWriter(filePath, true))
                {
                    outputFile.WriteLine(logMessage);
                }

                counter.PrintTotals();
                Console.WriteLine("\nPress enter to continue.");
                Console.ReadKey();
            }
        }
    }
}

//            } } } }
//                    case 1:
//                        Console.WriteLine("\nNow Vending a Candy Bar.");
//                        break;

//                    case 2:
//                        Console.WriteLine("\nNow Vending a Soda.");
//                        break;

//                    case 3:
//                        Console.WriteLine("\nNow Vending an Energy Drink.");
//                        break;

//                    case 4:
//                        Console.WriteLine("\nNow Vending a Bag of Chips.");
//                        break;

//                    case 5:
//                        Console.WriteLine("\nNow Vending a Package of Gum");
//                        break;

//                    case 6:
//                        Console.WriteLine("\nNow Vending a Package of Veggie Sticks");
//                        break;

//                    case 7:
//                        Console.WriteLine("\nNow Vending a Protein Shake");
//                        break;

//                    case 8:
//                        Console.WriteLine("\nNow Vending a delicious Mushroom Jerky!");
//                        break;

//                    case 9:
//                        Console.WriteLine("\nNow Vending Rice Cakes");
//                        break;

//                    case 10:
//                        Console.WriteLine("\nNow Vending a Fruit Bar");
//                        break;

//                    case 0:
//                        Console.WriteLine("\nWalking away from the Vending Machine.");
//                        isRunning = false;
//                        break;

//                    default:
//                        Console.WriteLine("\nInvalid Option -- Please try again!");
//                        break;
//                }

//                Console.WriteLine("\nPress any key to continue.");
//                Console.ReadLine();
//            }
//        }
//    }
//}