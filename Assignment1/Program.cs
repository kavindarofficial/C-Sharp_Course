Console.WriteLine("Welcome to Contacts!\n");
List<Contact> contacts = new List<Contact>();
string userInput;
do
{
    Contact.printInstructions();
    userInput = Console.ReadLine();
    userInput = userInput.ToUpper();    
    Console.Clear();

    switch (userInput)
    {
        case "V":
            Console.Clear();
            printAllContacts();
            Console.ReadKey();
            Console.Clear();
            break;

        case "A":
            addNewContact();
            break;

        case "D":
            printAllContacts();
            if (contacts.Count == 0)
            {
                Console.ReadKey();
                Console.Clear ();
                break;
            }
            try
            {
                int index = int.Parse(Console.ReadLine());
                if(index <= contacts.Count && index > 0)
                {
                    throw new ArgumentException("Not a valid index");
                }
                Console.WriteLine("Do you want to delete?\n[Y]es\n[N]o");
                if (Console.ReadLine() == "Y")
                {
                    contacts.RemoveAt(index-1);
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case "Q":
            Console.WriteLine("Do you really want to exit?\n[Y]es [N]o");
            string exitStatus = Console.ReadLine();
            if (exitStatus == "N" || exitStatus == "n") userInput = "";
            Console.Clear();
            break;

        default:
            Console.WriteLine("Wrong input");
            Console.ReadKey();
            Console.Clear();
            break;
    }
} while (userInput != "Q");

void printContact(int index)
{
    Console.WriteLine($"{index}.\tName: {contacts[index].Name}" +
        $"\n\tPhone Number: {contacts[index].PhoneNumber}" +
        $"\n\tEmail: {contacts[index].Email}" +
        $"\n\tDescription: {contacts[index].Description}"
        );
}
void printAllContacts()
{
    if (contacts.Count > 0)
    {
        int index = 1;
        foreach (Contact contact in contacts)
        {
            Console.WriteLine($"{index}.\tName: {contact.Name}\n\tPhone Number: {contact.PhoneNumber}\n\tEmail: {contact.Email}\n\tDescription: {contact.Description}");
        }
    }
    else
    {
        Console.WriteLine("No Contacts yet!");
    }
}
void addNewContact()
{
    string name = "", email = "", description = "";
    long phoneNumber;

    try
    {
        Console.WriteLine("Enter the Name");
        name = Console.ReadLine();
        if (name == null || name == "")
        {
            throw new ArgumentException("Name cannot be empty or null");
        }

        Console.WriteLine("Enter the phone number");
        phoneNumber = long.Parse(Console.ReadLine());
        if(phoneNumber <= 0)
        {
            throw new ArgumentException("Phone number cannot be less than or equal to zero");
        }

        Console.WriteLine("Enter the email");
        email = Console.ReadLine();

        Console.WriteLine("Enter the description");
        description = Console.ReadLine();

        Contact contactToAdd = new Contact(name, phoneNumber, email, description);
        contacts.Add(contactToAdd);
        Console.Clear();
        Console.WriteLine("Contact added successfully");
        Console.ReadKey();
        Console.Clear();
    }
    catch(ArgumentException  ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    catch(FormatException ex)
    {
        Console.Clear();
        Console.WriteLine("Please enter a valid number");
        Console.ReadKey();
        Console.Clear();
    }

}
class Contact
{
    string _name="", _email="", _description="";
    long _phoneNumber;

    public string Name { get; set; }
    public string Email { get; set; }
    public string Description { get; set; }
    public long PhoneNumber { get; set; }

    public static void printInstructions()
    {
        Console.WriteLine("=================================\r\n      Contacts Manager\r\n=================================");
        Console.WriteLine("\t[V]iew all contacts");
        Console.WriteLine("\t[A]dd new contact");
        Console.WriteLine("\t[E]dit contact");
        Console.WriteLine("\t[D]elete contact");
        Console.WriteLine("\t[Q]uit application");
    }

    public Contact(string name, long phone, string email, string description)
    {
        Name= name;
        PhoneNumber = phone;
        Email = email;
        Description = description;
    }

}
