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
    System.Console.WriteLine("03 - Search Contact");
    System.Console.WriteLine("04 - List Contacts");
    System.Console.WriteLine("05 - Exit");
  }

  public static void AddContactMenu()
  {
    Notification.Warning("Add Contact");
  }

  public static void RemoveContactMenu()
  {
    Notification.Warning("Remove Contact");
  }

  public static void SearchContactMenu()
  {
    Notification.Warning("Search Contact");
  }

  public static void ListAllMenu()
  {
    Notification.Warning("Contacts List");
  }

  public static void InvalidOptionMenu()
  {
    Notification.Error("Invalid option!");
  }
}