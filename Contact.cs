class Contact
{
  public int Id { get; private set; }
  public string Name { get; set; }
  public string Number { get; set; }

  public Contact(int id, string name, string number)
  {
    this.Id = id;
    this.Name = name;
    this.Number = number;
  }

  public override string ToString()
  {
    return $"{Id} - {Name} - {Number}";
  }
}