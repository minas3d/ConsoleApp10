List<int> thelist = new List<int>();


string choice;
do
{
    Console.WriteLine("P - Print numbers");
    Console.WriteLine("A - Add a number");
    Console.WriteLine("M - Display mean of the numbers");
    Console.WriteLine("S - Display the smallest number");
    Console.WriteLine("L - Display the largest number");
    Console.WriteLine("C - clear");
    Console.WriteLine("F - found value");
    Console.WriteLine("Q - Quit");
    Console.WriteLine("===============================");
    Console.Write("Enter your choice: ");
    choice = Console.ReadLine().ToLower();
    switch (choice)
    {
        case "p":
            if (thelist.Count == 0)
            {
                Console.WriteLine("[] - the list is empty");

            }
            else
            {
                Console.Write("[");
                for (int i = 0; i < thelist.Count; i++)
                {
                    Console.Write(thelist[i]);
                    if (i < thelist.Count - 1)
                        Console.Write(" ");
                }
                Console.Write("]");


            }
            break;
        case "a":
            Console.Write("Enter an integer to add: ");
            int num = Convert.ToInt32(Console.ReadLine());
            thelist.Add(num);
            break;
        case "m":
            if (thelist.Count == 0)
            {
                Console.WriteLine("Unable to calculate the mean - no data");
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < thelist.Count; i++)
                    sum += thelist[i];
                double mean = sum / thelist.Count;
                Console.WriteLine(mean);
            }
            break;
        case "s":
            if (thelist.Count == 0) { Console.WriteLine("Unable to determine the smallest number - list empty"); }
            else
            {
                int smallest = thelist[0];
                for (int i = 1; i < thelist.Count; i++)
                    if (thelist[i] < smallest)
                        smallest = thelist[i];
                Console.WriteLine(smallest);
            }
            break;
        case "l":
            if (thelist.Count == 0) { Console.WriteLine("Unable to determine the largest number - array is empty"); }
            else
            {
                int largest = thelist[0];
                for (int i = 1; i < thelist.Count; i++)
                    if (thelist[i] > largest)
                        largest = thelist[i];
                Console.WriteLine(largest);
            }
            break;
        case "c":

            thelist.Clear();
            Console.WriteLine("OK your list is now empty");
            break;



        case "f":
            Console.WriteLine("enter the number  ");
            int found = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < thelist.Count; i++)
            {
                if (thelist[i] == found)
                {
                    Console.WriteLine($"This number found at index {i}");


                }

            }
            break;
        case "q":
            Console.WriteLine("Goodbye");
            break;
        default:
            Console.WriteLine("Unknown selection, please try again");
            break;

    }
} while (choice != "q");