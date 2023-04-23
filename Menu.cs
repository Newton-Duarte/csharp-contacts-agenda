static class Menu
{
  public static void Show()
  {
    System.Console.WriteLine("------------> Contacts Agenda <------------");
    MenuList();
  }

  static void MenuList()
  {
    System.Console.WriteLine("01 - Add Contact");
    System.Console.WriteLine("02 - Remove Contact");
    System.Console.WriteLine("03 - List All");
    System.Console.WriteLine("04 - Exit");
  }

  public static void AddContactMenu()
  {
    System.Console.WriteLine("01 - Add Contact");
  }

  public static void RemoveContactMenu()
  {
    System.Console.WriteLine("02 - Remove Contact");
  }

  public static void ListAllMenu()
  {
    System.Console.WriteLine("03 - List All");
  }

  public static void InvalidOptionMenu()
  {
    System.Console.WriteLine("Invalid option!");
    Show();
  }
}