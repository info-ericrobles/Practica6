class contacto
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public int Telephone { get; set; }
    public void SetContacto(string name, string Lastname , string Address , int Telephone)
    {
      this.Name =  name;
      this.LastName = LastName;
      this.Address =  Address;
      this.Telephone = Telephone;
    }
    public void Saludar()
    {
        System.Console.WriteLine($"Hola soy {Name} y mi apellido {LastName}, y mi telefono es {Telephone} y mi direccion es {Address}");
    }
}