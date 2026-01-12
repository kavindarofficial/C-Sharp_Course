internal class Program
{
    private static void Main(string[] args)
    {
        void printOptions()
        {
            Console.WriteLine("What do you want to do?\n[S]ee all TODOs\n[A]dd a TODO\n[R]emove a TODO\n[E]xit\n");
        }

        void printList(List<string> toDos)
        {
            if (toDos != null)
            {
                int index = 1;
                foreach (string toDo in toDos)
                {
                    Console.WriteLine($"{index++}. {toDo}");
                }
            }
            else
            {
                Console.WriteLine("Nothing ToDo");
            }
        }

        var toDos = new List<string>();
        string input = "";

        do
        {
            printOptions();
            input = Console.ReadLine();
            switch (input)
            {
                case "S":
                case "s":
                    printList(toDos);
                    break;
                case "A":
                case "a":
                    string toDo = Console.ReadLine();
                    toDos.Add(toDo);
                    break;
                case "R":
                case "r":
                    Console.WriteLine("Enter the index of the ToDo to remove.");
                    int index = Console.Read();
                    toDos.Remove(toDos[--index]);
                    break;
                default:
                    Console.WriteLine("Wrong Option");
                    break;
            }
        } while (input != "E");
        printOptions();
        Console.ReadKey();
    }
}