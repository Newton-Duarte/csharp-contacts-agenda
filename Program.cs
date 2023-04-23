namespace ContactsAgenda
{
  class Program
  {
    static List<Contact> contacts = new List<Contact>();

    static void Main(string[] args)
    {
      Console.Clear();
      ShowMenu();
    }

    private static void ShowMenu()
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

      Notification.Success("Contact added successfully!");
      ShowMenu();
    }

    static void RemoveContact()
    {
      Menu.RemoveContactMenu();
      System.Console.Write("Id: ");
      int id = int.Parse(Console.ReadLine());

      var contact = contacts.Find((contact) => contact.Id == id);

      if (contact != null)
      {
        contacts.Remove(contact);
        Notification.Success("Contact removed successfully!");
      }
      else {
        Notification.Error("Contact not found.");
      }

      ShowMenu();
    }

    static void SearchContact()
    {
      Menu.SearchContactMenu();

      System.Console.Write("Name of contact: ");
      string term = Console.ReadLine();

      var contact = contacts.Find((contact) => contact.Name.ToLower().Contains(term));

      if (contact != null) {
        Notification.Info(contact.ToString());
      } else {
        Notification.Warning("Contact not found.");
      }

      ShowMenu();
    }

    static void ListContacts()
    {
      Menu.ListAllMenu();

      if (contacts.Count == 0) {
        Notification.Info("Contacts List is empty.");
      } else {
        foreach(var contact in contacts)
        {
          Notification.Info(contact.ToString());
        }
      }


      ShowMenu();
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
          SearchContact();
          break;
        case 4:
          ListContacts();
          break;
        case 5:
          Environment.Exit(0);
          break;
        default:
          Menu.InvalidOptionMenu();
          ShowMenu();
          break;
      }
    }
  }
}