using System;
using System.Collections.Generic;

class Contacto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public string Direccion { get; set; }

    public Contacto(int id, string nombre, string telefono, string email, string direccion)
    {
        Id = id;
        Nombre = nombre;
        Telefono = telefono;
        Email = email;
        Direccion = direccion;
    }

    public void Mostrar()
    {
        Console.WriteLine($"{Id} - {Nombre}, {Telefono}, {Email}, {Direccion}");
    }
}

class Agenda
{
    private List<Contacto> contactos = new List<Contacto>();

    public void AgregarContacto()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Teléfono: ");
        string telefono = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Dirección: ");
        string direccion = Console.ReadLine();

        int nuevoId = contactos.Count + 1;
        contactos.Add(new Contacto(nuevoId, nombre, telefono, email, direccion));
        Console.WriteLine("Contacto agregado exitosamente.\n");
    }

    public void VerContactos()
    {
        Console.WriteLine("Lista de contactos:");
        foreach (var c in contactos)
        {
            c.Mostrar();
        }
        Console.WriteLine();
    }

    public void BuscarContacto()
    {
        Console.Write("Ingrese el ID del contacto a buscar: ");
        int id = int.Parse(Console.ReadLine());

        Contacto c = contactos.Find(x => x.Id == id);
        if (c != null)
            c.Mostrar();
        else
            Console.WriteLine("Contacto no encontrado.\n");
    }

    public void EditarContacto()
    {
        Console.Write("Ingrese el ID del contacto a editar: ");
        int id = int.Parse(Console.ReadLine());

        Contacto c = contactos.Find(x => x.Id == id);
        if (c != null)
        {
            Console.Write("Nuevo nombre: ");
            c.Nombre = Console.ReadLine();
            Console.Write("Nuevo teléfono: ");
            c.Telefono = Console.ReadLine();
            Console.Write("Nuevo email: ");
            c.Email = Console.ReadLine();
            Console.Write("Nueva dirección: ");
            c.Direccion = Console.ReadLine();
            Console.WriteLine("Contacto actualizado.\n");
        }
        else
        {
            Console.WriteLine("Contacto no encontrado.\n");
        }
    }

    public void EliminarContacto()
    {
        Console.Write("Ingrese el ID del contacto a eliminar: ");
        int id = int.Parse(Console.ReadLine());

        Contacto c = contactos.Find(x => x.Id == id);
        if (c != null)
        {
            contactos.Remove(c);
            Console.WriteLine("Contacto eliminado.\n");
        }
        else
        {
            Console.WriteLine("Contacto no encontrado.\n");
        }
    }
}

class Program
{
    static void Main()
    {
        Agenda agenda = new Agenda();
        bool enEjecucion = true;

        while (enEjecucion)
        {
            Console.WriteLine("1. Agregar Contacto");
            Console.WriteLine("2. Ver Contactos");
            Console.WriteLine("3. Buscar Contacto");
            Console.WriteLine("4. Editar Contacto");
            Console.WriteLine("5. Eliminar Contacto");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();
            Console.WriteLine();

            switch (opcion)
            {
                case "1":
                    agenda.AgregarContacto();
                    break;
                case "2":
                    agenda.VerContactos();
                    break;
                case "3":
                    agenda.BuscarContacto();
                    break;
                case "4":
                    agenda.EditarContacto();
                    break;
                case "5":
                    agenda.EliminarContacto();
                    break;
                case "6":
                    enEjecucion = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida.\n");
                    break;
            }
        }
    }
}
