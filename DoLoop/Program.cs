using System.Xml.Serialization;

namespace DoLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variable
            int mySquare = 0,
                sum,
                count;
            bool isValid = false;
            const int MinValue = 1,
                MaxValue = 10;
            char option;

            do
            {
                do
            {
                    try
                    {
                        Console.WriteLine("Enter the value for mySquare: ");
                        mySquare = int.Parse(Console.ReadLine());

                        //range check
                        if (mySquare >= MinValue && mySquare <= MaxValue)
                        {
                            isValid = true;
                        }
                        else
                        {
                            Console.WriteLine($"Number entered not between {MinValue} and {MaxValue} inclusive .... please try again");
                        }


                    }
                    catch (Exception)
                    {
                        Console.WriteLine("ERROR: Not a number. Try again.");
                        mySquare = -1;

                    }
                } while (!isValid) ;

                //initialize sum and count

                sum = 0;
                count = 1;

                //while loop

                while (count <= mySquare)
                {
                    sum += count * count;
                    Console.Write($"({count} x {count})");

                    if (count == mySquare)
                    {
                        Console.Write(" = ");
                    }
                    else
                    {
                        Console.Write(" + ");
                    }
                    count++;
                }

                Console.Write(sum);
                Console.Write("Another square?: ");
                option = char.Parse(Console.ReadLine().ToUpper().Substring(0, 1));
            } while (option == 'Y');
            
            Console.ReadLine();

        }
    }
}