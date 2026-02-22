
Console.WriteLine("Menú:\n1 Estudiante \n2.Docente \n3 Técnico IT \n4 Visitante ");
int options = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese hora en formano 24:");
int time = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese dia de la semana:");
int day = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese carnet vigente s/n:");
string carnet = Console.ReadLine();
Console.WriteLine("ingrese autorizacion escrita s/n:");
string autorization = Console.ReadLine();
Console.WriteLine("trae usb s/n:");
string usb = Console.ReadLine();
Console.WriteLine("Si trae USB preguntar si está acompañado s/n:");
string partner = Console.ReadLine();

if (time >= 0 && time <= 24 && day >= 1 && day <= 7 && carnet == "s" || carnet == "n" & autorization == "s" || autorization == "n" && usb == "s" || usb == "n" && partner == "s" || partner == "n")
{
    switch (options)
    {
        case 1:
            if (time >= 7 && time <= 18 && day >= 1 && day <= 5)
            {
                Console.WriteLine("Puede ingresar a la laboratorio");
            }
            else
            {
                Console.WriteLine("No puede ingresar a la laboratorio ");
            }

            break;
        case 2:
            Console.WriteLine("Bienvenido docente");
            if (time >= 7 && time <= 18 && day >= 1 && day <= 5)
            {
                Console.WriteLine("Puede ingresar a la laboratorio");
            }
            else
            {
                Console.WriteLine("No puede ingresar a la laboratorio ");
            }
            break;
        case 3:
            Console.WriteLine("Bienvenido técnico IT");
            if (time >= 18 && autorization == "s")
            {
                Console.WriteLine("Puede ingresar a la laboratorio");
            }
            else if (time >= 18 && autorization == "n")
            {
                Console.WriteLine("no puede ingresar necesita autorizacion");
            }
            else
            {
                Console.WriteLine("Puede ingresar a la laboratorio sin autorizacion");
            }
            break;
        case 4:
            Console.WriteLine("Bienvenido visitante");

            if (time >= 18 && usb == "s" && partner == "s")
            {
                Console.WriteLine("Puede ingresar a la laboratorio");
            }
            else if (time >= 18 && usb == "s" && partner == "n")
            {
                Console.WriteLine("no puede ingresar necesita estar acompañado");
            }
            else if (time >= 18 && usb == "n" && partner == "s")
            {
                Console.WriteLine("no puede ingresar necesita traer USB");
            }
            else if (time >= 18 && usb == "n" && partner == "n")
            {
                Console.WriteLine("no puede ingresar necesita traer USB y estar acompañado");
            }
            else
            {
                Console.WriteLine("Puede ingresar a la laboratorio sin necesidad de traer USB ni estar acompañado");
            }
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }

}
else
{
    Console.WriteLine("Datos ingresados no válidos");

}