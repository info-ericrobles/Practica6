class TestContacto:contacto
{
    public static void TestContacMain()
    {

        contacto Contacto = new contacto();

        contacto Contacto2 = new contacto();

        Contacto.SetContacto("Eric","Robles","Sabana Perdida", 809);

        Contacto.Saludar();

        Contacto2.SetContacto("Kamila","Chalas","Sabana Perdida", 829);

        Contacto2.Saludar();
    }
}
 