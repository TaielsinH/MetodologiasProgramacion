
using System;
using System.Linq;

namespace MetodologíasDeProgramaciónI
{
    class Program
    {
        public static void Main(string[] args)
        {

            inicioClases();
            
            Console.ReadKey(true);

        }
        public static void jornadaDeVentas(Iterable vendedores)
        {
            Iterador iterador = vendedores.crearIterador();
            for (int i = 0; i<20; i++)
            {
                iterador.primero();
                while(!iterador.fin())
                {
                    GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
                    int monto = generador.numeroAleatorio(7000);
                    ((Vendedor)iterador.actual()).Venta(monto);
                    iterador.siguiente();
                }
            }
        }

        public static void inicioClases() //ejercicio 4 tp 4
        {
            Teacher maestro = new Teacher();
            for (int i = 0; i<10; i++)
            {
                Comparable elemento = FabricaDeComparables.crearAleatorio(2);
                StudentAdapter alumnoAdapted = new StudentAdapter((Alumno)elemento);
                maestro.goToClass(alumnoAdapted);
            }
            for (int i = 0; i<10; i++)
            {
                Comparable elemento = FabricaDeComparables.crearAleatorio(4);
                StudentAdapter estudiosoAdapted = new StudentAdapter((AlumnoMuyEstudioso)elemento);
                maestro.goToClass(estudiosoAdapted);
            }
            maestro.teachingAClass();
        }
        public static void llenar(Coleccionable col, int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable elemento = FabricaDeComparables.crearAleatorio(opcion);
                col.agregar(elemento);
            }
        }
        public static void Informar(Coleccionable col, int opcion)
        {
            Console.WriteLine(col.cuantos());
            Console.WriteLine(col.minimo());
            Console.WriteLine(col.maximo());
            Comparable com = FabricaDeComparables.crearPorTeclado(opcion);
            if (col.contiene(com))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            { Console.WriteLine("El elemento leído no está en la colección"); }
        }
        public static void ImprimirElementos(Iterable col)
        {
            Iterador iterador = col.crearIterador();
            while(!iterador.fin())
            {
                Console.WriteLine(iterador.actual().ToString());
                Console.WriteLine("===");
                iterador.siguiente();
            }
        }
        public static string nombreAzar()
        {
            var caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var caracteresArray = new char[8];
            var random = new Random();

            for (int i = 0; i < caracteresArray.Length; i++)
            {
                caracteresArray[i] = caracteres[random.Next(caracteres.Length)];
            }
            var resulNombre = new String(caracteresArray);
            return resulNombre;
        }
        public static int dniAzar()
        {
            var numeros = "1234567890";
            var numerosArray = new char[8];
            var random = new Random();

            for (int i = 0; i < numerosArray.Length; i++)
                numerosArray[i] = numeros[random.Next(numeros.Length)];
            var resulDni = new String(numerosArray);
            int resultado = int.Parse(resulDni);
            return resultado;
        }

  

        public static float promedioAzar()
        {
            Random rnd = new Random();
            float promedio = rnd.Next(1, 10);
            return promedio;
        }

        public static int legajoAzar()
        {
            var numeros = "1234567890";
            var numerosArray = new char[6];
            var random = new Random();

            for (int i = 0; i < numerosArray.Length; i++)
                numerosArray[i] = numeros[random.Next(numeros.Length)];
            var resulDni = new String(numerosArray);
            int resultado = int.Parse(resulDni);
            return resultado;
        }




        public static void informar(Coleccionable c)
        {
            int cantidad = c.cuantos();
            Console.WriteLine("La lista tiene {0} elementos", cantidad);
            Console.Write("Ingrese 'legajo' si quiere comparar por legajos o 'promedio' si por eso quiere comparar: ");
            Alumno.Opcion = Console.ReadLine();
            Comparable min = c.minimo();
            if (Alumno.Opcion == "legajo")
                Console.WriteLine("El mínimo de la lista es: " + ((Alumno)min).getLegajo());
            else
                Console.WriteLine("El mínimo de la lista es: " + ((Alumno)min).getPromedio);

            Comparable max = c.maximo();
            if (Alumno.Opcion == "legajo")
                Console.WriteLine("El maximo numero de la lista es: " + ((Alumno)max).getLegajo());
            else
                Console.WriteLine("El maximo numero de la lista es: " + ((Alumno)max).getPromedio);

            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el dni: ");
            int dni = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el legajo del alumno: ");
            int legajo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el promedio: ");
            float promedio = float.Parse(Console.ReadLine());

            Comparable num = new Alumno(nombre, dni, legajo, promedio);
            if (c.contiene(num))
                Console.WriteLine("La lista contiene ese numero");
            else
            {
                Console.WriteLine("La lista no contiene ese numero");
            }
        }
    }
}