
class ContactesClassV1
{
    static List<int> ids = new List<int>();
    static Dictionary<int, string> names = new Dictionary<int, string>();
    static Dictionary<int, string> lastnames = new Dictionary<int, string>();
    static Dictionary<int, string> addresses = new Dictionary<int, string>();
    static Dictionary<int, string> telephones = new Dictionary<int, string>();
    static Dictionary<int, string> emails = new Dictionary<int, string>();
    static Dictionary<int, int> ages = new Dictionary<int, int>();
    static Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n1. Agregar Contacto   2. Ver Contactos   3. Buscar Contacto   4. Modificar Contacto   5. Eliminar Contacto   6. Salir");
            Console.Write("Digite el número de la opción deseada: ");

            int typeOption;
            if (!int.TryParse(Console.ReadLine(), out typeOption))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                continue;
            }

            switch (typeOption)
            {
                case 1:
                    AddContact();
                    break;
                case 2:
                    ViewContacts();
                    break;
                case 3:
                    SearchContact();
                    break;
                case 4:
                    ModifyContact();
                    break;
                case 5:
                    DeleteContact();
                    break;
                case 6:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Tu eres o te haces el idiota?.");
                    break;
            }
        }
    }

    static void AddContact()
    {
        Console.Write("Digite el nombre de la persona: ");
        string name = Console.ReadLine();
        Console.Write("Digite el apellido de la persona: ");
        string lastname = Console.ReadLine();
        Console.Write("Digite la dirección: ");
        string address = Console.ReadLine();
        Console.Write("Digite el teléfono de la persona: ");
        string phone = Console.ReadLine();
        Console.Write("Digite el email de la persona: ");
        string email = Console.ReadLine();
        Console.Write("Digite la edad de la persona en números: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Especifique si es mejor amigo: 1. Sí, 2. No: ");
        bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

        int id = ids.Count + 1;
        ids.Add(id);
        names[id] = name;
        lastnames[id] = lastname;
        addresses[id] = address;
        telephones[id] = phone;
        emails[id] = email;
        ages[id] = age;
        bestFriends[id] = isBestFriend;

        Console.WriteLine("Contacto agregado exitosamente.");
    }

    static void ViewContacts()
    {
        Console.WriteLine("\nLista de Contactos:");
        Console.WriteLine("ID | Nombre | Apellido | Dirección | Teléfono | Email | Edad | Mejor Amigo?");
        Console.WriteLine("---------------------------------------------------------------------------");

        foreach (var id in ids)
        {
            Console.WriteLine($"{id} | {names[id]} | {lastnames[id]} | {addresses[id]} | {telephones[id]} | {emails[id]} | {ages[id]} | {(bestFriends[id] ? "Sí" : "No")}");
        }
    }

    static void SearchContact()
    {
        Console.Write("Ingrese el nombre del contacto a buscar: ");
        string searchName = Console.ReadLine().ToLower();
        bool found = false;

        Console.WriteLine("\nResultados de la búsqueda:");
        foreach (var id in ids)
        {
            if (names[id].ToLower().Contains(searchName))
            {
                Console.WriteLine($"{id} | {names[id]} | {lastnames[id]} | {addresses[id]} | {telephones[id]} | {emails[id]} | {ages[id]} | {(bestFriends[id] ? "Sí" : "No")}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No se encontró ningún contacto con ese nombre.");
        }
    }

    static void ModifyContact()
    {
        Console.Write("Ingrese el ID del contacto a modificar: ");
        int id;
        if (!int.TryParse(Console.ReadLine(), out id) || !ids.Contains(id))
        {
            Console.WriteLine("ID no encontrado.");
            return;
        }

        Console.Write("Nuevo nombre (deje vacío para mantener el actual): ");
        string name = Console.ReadLine();
        if (!string.IsNullOrEmpty(name)) names[id] = name;

        Console.Write("Nuevo apellido (deje vacío para mantener el actual): ");
        string lastname = Console.ReadLine();
        if (!string.IsNullOrEmpty(lastname)) lastnames[id] = lastname;

        Console.Write("Nueva dirección (deje vacío para mantener la actual): ");
        string address = Console.ReadLine();
        if (!string.IsNullOrEmpty(address)) addresses[id] = address;

        Console.Write("Nuevo teléfono (deje vacío para mantener el actual): ");
        string phone = Console.ReadLine();
        if (!string.IsNullOrEmpty(phone)) telephones[id] = phone;

        Console.Write("Nuevo email (deje vacío para mantener el actual): ");
        string email = Console.ReadLine();
        if (!string.IsNullOrEmpty(email)) emails[id] = email;

        Console.Write("Nueva edad (deje vacío para mantener la actual): ");
        string ageInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(ageInput)) ages[id] = Convert.ToInt32(ageInput);

        Console.Write("Es mejor amigo? (1. Sí, 2. No, deje vacío para mantener el actual): ");
        string bestFriendInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(bestFriendInput)) bestFriends[id] = Convert.ToInt32(bestFriendInput) == 1;

        Console.WriteLine("Contacto modificado exitosamente.");
    }

    static void DeleteContact()
    {
        Console.Write("Ingrese el ID del contacto a eliminar: ");
        int id;
        if (!int.TryParse(Console.ReadLine(), out id) || !ids.Contains(id))
        {
            Console.WriteLine("ID no encontrado.");
            return;
        }

        ids.Remove(id);
        names.Remove(id);
        lastnames.Remove(id);
        addresses.Remove(id);
        telephones.Remove(id);
        emails.Remove(id);
        ages.Remove(id);
        bestFriends.Remove(id);

        Console.WriteLine("Contacto eliminado exitosamente.");
    }
}
