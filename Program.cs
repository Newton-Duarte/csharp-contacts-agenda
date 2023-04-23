namespace ContactsAgenda
{
  class Program
  {
    static List<Contact> contacts = new List<Contact>();
    static void Main(string[] args)
    {
      Menu.Show();
      int option = int.Parse(Console.ReadLine());
      HandleMenuOption(option);
    }

    static void AddContact()
    {
      Menu.AddContactMenu();
      System.Console.Write("Name: ");
      string name = Console.ReadLine();

      System.Console.Write("Number: ");
      string number = Console.ReadLine();
      int nextId = contacts.Count + 1;

      var newContact = new Contact(nextId, name, number);

      contacts.Add(newContact);

      System.Console.WriteLine("Contact added successfully!");
    }

    static void RemoveContact()
    {
      Menu.RemoveContactMenu();
      System.Console.Write("Id: ");
      int id = int.Parse(Console.ReadLine());

      var contact = contacts.Find((contact) => contact.Id == id);

      if (contact != null)
      {
        System.Console.WriteLine("Contact removed successfully!");
        contacts.Remove(contact);
      }
      else {
        System.Console.WriteLine("Contact not found.");
      }

      Menu.Show();

    }

    static void ListContacts()
    {
      Menu.ListAllMenu();
      foreach(var contact in contacts)
      {
        System.Console.WriteLine(contact.ToString());
      }

      Menu.Show();
    }

    static void HandleMenuOption(int option)
    {
      switch (option)
      {
        case 1:
          AddContact();
          break;
        case 2:
          RemoveContact();
          break;
        case 3:
          ListContacts();
          break;
        default:
          Menu.InvalidOptionMenu();
          break;
      }
    }
  }
}