using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("¡Bienvenid@ al sistema electrónico para la compra de boletos!");


        Console.WriteLine("Por favor, ingrese su nombre y apellido dejando un espacio entre ellos");
        string nombrecompleto = Console.ReadLine();
        int dni;
        string inputDni;
        Console.WriteLine("Hola, sr/a " + nombrecompleto + ". Porfavor, ingrese su dni sin puntos ni comas");
        inputDni = Console.ReadLine(); 
        while (!int.TryParse(inputDni, out dni) || inputDni.Length != 8)
        {
            Console.WriteLine("El DNI ingresado no es válido. Intente nuevamente:");
            inputDni = Console.ReadLine();
        }
        Console.WriteLine("DNI: " + dni);


      Console.WriteLine("Ingrese su fecha de nacimiento (formato: yyyy-MM-dd):");
        DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());
        DateTime hoy = DateTime.Today;
        int edad = hoy.Year - fechaNacimiento.Year;
        if (edad <= 17)
        {
            string inputDniadulto;
            Console.WriteLine("- ATENCIÓN -\n" +
            "Toda persona menor a 18 años deberá estar acompañada por un adulto responsable para que se le permita su ingreso.");
            Console.WriteLine("Por favpr, ingrese el dni del adulto a cargo");
            inputDniadulto = Console.ReadLine();
            while (!int.TryParse(inputDniadulto, out dni) || inputDniadulto.Length != 8)
            {
                Console.WriteLine("El DNI ingresado no es válido. Intente nuevamente:");
                inputDniadulto = Console.ReadLine();
            }
            Console.WriteLine("Tener en cuenta que el acompañante deberá adquirir su paquete para poder ingresar");
        }


        Console.WriteLine("A continuación, ingrese su nacionalidad:");
        string nacionalidad = Console.ReadLine();
        Console.WriteLine("Perfecto! Ahora ingrese su correo electrónico:");
        string correo = Console.ReadLine();


// Elección de paquete. PARTE PRINCIPAL
//

        Console.WriteLine("\nIngrese el paquete que desea adquirir:");
        Console.WriteLine("(1) Paddock General (€500) → Acceso limitado a zona de paddock");
        Console.WriteLine("(2) VIP/Paddock Club (€3,000) → Incluye lounge y acceso a pit lane");
        Console.WriteLine("(3) Prensa Acreditada (€200) → Requiere credencial de medio registrado");
        Console.WriteLine("(4) Personal de Equipo (Gratis) → Debe ingresar código de equipo válido");
        Console.WriteLine("(5) Invitado FIA (Gratis) → Requiere código de aprobación");

       int paquete = Convert.ToInt32(Console.ReadLine());

        int preciobase = 0;
        string nombrepaquete = "";
        string credencialEspecial = "";

        switch (paquete)
        {
            case 1:
                preciobase = 500;
                nombrepaquete = "Paddock General";
                break;
            case 2:
                preciobase = 3000;
                nombrepaquete = "VIP/Paddock Club";
                break;
            case 3:
                preciobase = 200;
                nombrepaquete = "Prensa";
                Console.WriteLine("Ingrese su credencial de prensa (8 dígitos):");
                credencialEspecial = Console.ReadLine();
                if (credencialEspecial.Length != 8 || !int.TryParse(credencialEspecial, out _))
                {
                    Console.WriteLine("Credencial inválida.");
                    return;
                }
                break;
            case 4:
                nombrepaquete = "Personal de Equipo";
                Console.WriteLine("Ingrese su código de equipo (5 dígitos):");
                credencialEspecial = Console.ReadLine();
                if (credencialEspecial.Length != 5 || !int.TryParse(credencialEspecial, out _))
                {
                    Console.WriteLine("Código inválido.");
                    return;
                }
                break;
            case 5:
                nombrepaquete = "Invitado FIA";
                Console.WriteLine("Ingrese su código FIA (10 dígitos):");
                credencialEspecial = Console.ReadLine();
                if (credencialEspecial.Length != 10 || !int.TryParse(credencialEspecial, out _))
                {
                    Console.WriteLine("Código inválido.");
                    return;
                }
                break;

            default:
                Console.WriteLine("Opción no válida. Por favor seleccione un paquete entre 1 y 5.");
                break;    
        }



//Parte 2

  Console.WriteLine("Por favor, indicar días a asistir: " +
            "\n(1) Full Weekend (Viernes, Sábado y Domingo) → Precio completo" +
            "\n(2) Solo domingo → 25% de descuento");
        int dias = int.Parse(Console.ReadLine());
        double descuentodias = 0;

        if (dias == 2)
        {
            descuentodias = 0.25;
            Console.WriteLine("Elegist domingo");
        }
        double precioFinal = preciobase * (1 - descuentodias);

// Vuelta guiada boxes.

        bool vueltaGuiada = false;
        if ((paquete == 1 || paquete == 3 || paquete == 5) && dias == 1)
        {
            Console.WriteLine("¿Desea realizar vuelta guiada por nuestros boxes? (€500) (si/no)");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta == "si")
            {
                vueltaGuiada = true;
                precioFinal += 500;
            }
        }
        else if (paquete == 2 || paquete == 4)
        {
            Console.WriteLine("¿Desea complementar su estadía con nuestra visita guiada por las boxes?\n" +
                "Debido a su paquete, esto no tendrá un costo adicional\n" +
                "si/no");
            if (Console.ReadLine().ToLower() == "si")
            {
                vueltaGuiada = true;
            }
        }

// Camara.

        bool camaraProfesional = false;
        string permisoFilmacion = "";
        string traecamara= "";
        if (paquete == 1 || paquete == 3 || paquete == 5)
        {
            Console.WriteLine("¿Trae consigo una cámara profesional?");
            Console.WriteLine("Debido a su paquete, esto no tendrá un costo adicional");
            Console.WriteLine("si/no");
            traecamara = Console.ReadLine().ToLower();
            if (traecamara == "si") {
                camaraProfesional = true;
                Console.WriteLine("Ingrese nombre del archivo con permiso de filmación:");
                permisoFilmacion = Console.ReadLine();
                precioFinal = precioFinal + 3000;
            }
        }

        else if (paquete == 2 || paquete == 4)
        {
            Console.WriteLine("¿Trae consigo una cámara profesional?");
            Console.WriteLine("Debido a su paquete, esto no tendrá un costo adicional");
            Console.WriteLine("si/no");
            traecamara = Console.ReadLine().ToLower();
            if (traecamara == "si") {
                camaraProfesional = true;
                Console.WriteLine("Ingrese nombre del archivo con permiso de filmación:");
                permisoFilmacion = Console.ReadLine();
            }
        }


//Descuentos para jubilados y suscripciones. 

        double descuentoTotal = 0;
        if (edad >= 65)
        {
            descuentoTotal += 0.10;
        }
        
        Console.WriteLine("¿Está suscrito a F1TV Pro? (si/no)");
        if (Console.ReadLine().ToLower() == "si")
        {
            descuentoTotal += 0.15;
        }

        precioFinal *= (1 - descuentoTotal);




// Código de acreditación aleatorio.

        Random random = new Random();
        string codigoAcreditacion = "XZ" + random.Next(10000, 99999).ToString();





// EXTRACTO FINAL. 

        Console.WriteLine("\n--- SU TICKET DE INGRESO ---");
        Console.WriteLine($"Nombre: {nombrecompleto}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Tipo de acceso: {nombrepaquete}");
        Console.WriteLine($"Días: {(dias == 1 ? "Full Weekend" : "Solo Domingo")}");
        Console.WriteLine($"Visita guiada: {(vueltaGuiada ? "Sí" : "No")}");
        Console.WriteLine($"Cámara profesional: {(camaraProfesional ? "Sí" : "No")}");
        
        if (preciobase > 0)
        {
            Console.WriteLine($"Costo total: ${precioFinal}");
        }
        else
        {
            Console.WriteLine("Costo total: Su pase es Gratuito");
        }

        Console.WriteLine($"Código de acreditación: {codigoAcreditacion}");
        Console.WriteLine($"Fecha de de credencial: {DateTime.Now.ToString()}");
        Console.WriteLine(" Esperamos que disfrutes tu estadía, recordá que tenés que presentar este código junto con tu documento de identidad para ingresar.");
    }
}