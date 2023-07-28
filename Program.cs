using System;
using System.Threading;
class Program

{
    //Definimos un método llamado LimpiarPantalla que utiliza el método Clear de la clase Console para limpiar la pantalla.
    static void LimpiarPantalla()
    {
        Console.Clear();
    }

    static void Main()
    {
        string Ejercicio_1()
        //If-else
        {
            int Ln_Nota;
            Console.WriteLine("Ingrese su nota: ");
            Ln_Nota = Convert.ToInt32(Console.ReadLine());
            //Compara la nota ingresada y retorna el mensaje correspondiente
            if (Ln_Nota >= 90)
            {
                return "A (Muy satisfactorioooo)";
            }
            else if (Ln_Nota >= 80)
            {
                return "B (Satisfactorio)";
            }
            else if (Ln_Nota >= 70)
            {
                return "C (Aceptable)";
            }
            else if (Ln_Nota >= 60)
            {
                return "D (Poco satisfactorio)";
            }
            else
            {
                return "F (Insatisfactorio)";
            }
        }
        string Ejercicio_2()
        //If-else
        {
            Console.WriteLine("Ingrese el apellido que desea buscar en la siguiente lista:");
            Console.WriteLine("'Pedrero', 'Moreno', 'Andrade', 'Vernaza', 'Cisneros', 'Briones'");
            //Arreglo de apellidos
            string[] apellidos = new string[]
            {
              "Pedrero",
              "Moreno",
              "Andrade",
              "Vernaza",
              "Cisneros",
              "Briones"
            };

            Console.WriteLine("Ingrese un apellido:");
            string Lv_ApellidoBuscado = Console.ReadLine();

            //Buscar el apellido en el array
            int posicion = -1;
            //Recorremos con un for
            for (int i = 0; i < apellidos.Length; i++)
            {
                if (string.Equals(apellidos[i], Lv_ApellidoBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    posicion = i;
                    break;
                }
            }
            //Utilizamos If-else para saber si está o no y en qué posición se encuentra
            if (posicion != -1)
            {
                return "El apellido '" + Lv_ApellidoBuscado + "' se encuentra en la posición " + posicion;
            }
            else
            {
                return "El apellido '" + Lv_ApellidoBuscado + "' no se encuentra en la lista.";
            }
        }

        string Ejercicio_3()
        //If-else
        {
            Console.WriteLine("Números del 1 al 15 en 1-5-10-15 se presentará una frase motivacional");
            int Ln_Numero = 1;
            //Mediante el bucle while presentamos un mensaje según el número
            while (Ln_Numero <= 15)
            {
                if (Ln_Numero == 1)
                {
                    Console.WriteLine(Ln_Numero + ": Eres capaz de hacer todo lo que te propones, ¡Tú puedes!");
                }
                else if (Ln_Numero == 5)
                {
                    Console.WriteLine(Ln_Numero + ": ¡Pon en práctica tus capacidades!");
                }
                else if (Ln_Numero == 10)
                {
                    Console.WriteLine(Ln_Numero + ": ¡Confía en Dios!");
                }
                else if (Ln_Numero == 15)
                {
                    Console.WriteLine(Ln_Numero + ": ¡Ánimo, no te detengas!");
                }
                else
                {
                    Console.WriteLine(Ln_Numero);
                }

                Ln_Numero++;
            }
            return string.Empty; /// Se devuelve la cadena vacía, ya que el tipo de retorno del método es string.
        }
        string Ejercicio_4()
        //If-else
        {
            Console.WriteLine("Ingrese la 1era frase u oración: ");
            string Lv_Cadena1 = Console.ReadLine().Replace(" ", "");
            //Con Console.ReadLine().Replace(" ", "") quitamos los espacios
            Console.WriteLine("Ingrese la 2da frase u oración: ");
            string Lv_Cadena2 = Console.ReadLine().Replace(" ", "");

            int Longitud_1 = Lv_Cadena1.Length;
            int Longitud_2 = Lv_Cadena2.Length;

            if (Longitud_1 > Longitud_2)
            //Se retorna la cadena según sea el caso
            {
                return "La cadena de mayor longitud es: " + Lv_Cadena1;
            }
            else if (Longitud_2 > Longitud_1)
            {
                return "La cadena de mayor longitud es: " + Lv_Cadena2;
            }
            else
            {
                return "Las cadenas tienen igual longitud.";
            }
        }
        string Ejercicio_5()
        //If-else
        {
            Console.WriteLine("Ingrese una frase u oración: ");
            string entrada = Console.ReadLine();
            //bool para agregarle valor de false a a la variable
            bool contieneDigitos = false;
            // Se implementó el bucle foreach para recorrer cada carácter de la cadena entrada
            foreach (char caracter in entrada)
            {
              //sS utiliza el método estático IsDigit de la clase char para verificar si el carácter actual es un dígito numérico
                if (char.IsDigit(caracter))
                {
                    contieneDigitos = true;
                    break;
                }
            }
            
            if (contieneDigitos)
            {
                return "La cadena contiene dígitos numéricos.";
            }
            else
            {
                return "La cadena NO contiene dígitos numéricos.";
            }
        }
        string Ejercicio_6()
        //If-else
        {
            Console.WriteLine("Ingrese una cadena de texto:");
            string cadena = Console.ReadLine();

            Console.WriteLine("Ingrese la letra específica para verificar:");
            char letra = char.Parse(Console.ReadLine());

            bool comienzaConLetraEspecifica = false;

            // Verificar si la cadena no está vacía y la primera letra coincide con la letra específica
            if (cadena.Length > 0 && (cadena[0] == letra || Char.ToLower(cadena[0]) == Char.ToLower(letra)))
            {
                comienzaConLetraEspecifica = true;
            }
            //Se retorna la cadena según sea el caso
            if (comienzaConLetraEspecifica)
            {
                return "La cadena comienza con la letra específica.";
            }
            else
            {
                return "La cadena NO comienza con la letra específica.";
            }
        }

        string Ejercicio_7()
        {
          //While
          //Convert.ToInt32 devuelve un valor entero de 32 bits
            Console.Write("Introduce un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            while (num > 0)
            {
                int remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num = num / 10;
            }
            // Se retorna el inverso del número
            return "El número en orden inverso es: " + reverse;
        }
        string Ejercicio_8()
        {
          //While
            Console.Write("Introduce la cantidad de números: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //Declaramos un arreglo
            int[] numbers = new int[n];
            int i = 0;
            while (i < n)
            {
                Console.Write("Introduce el número " + (i + 1) + ": ");
                int num = Convert.ToInt32(Console.ReadLine());
                numbers[i] = num;
                i++;
            }
            //Verificamos cuál es par o no 
            int Cont = 0;
            i = 0;
            while (i < n)
            {
                //Se verifica si es divisible
                if (numbers[i] % 2 == 0)
                {
                    Cont++;
                }
                i++;
            }
            return "La cantidad de números pares es: " + Cont;
        }
        string Ejercicio_9()
        {
            //While
            Console.Write("Introduce una cadena: ");
            //Declaramos variables
            string input = Console.ReadLine();
            string result = "";
            int i = 0;
            while (i < input.Length)
            {
                char c = input[i];
              //IndexOf devuelve el primer índice en el que se puede encontrar un elemento dado en el arreglo, o retorna -1 si el elemento no está presente
                if (result.IndexOf(c) == -1)
                {
                    result += c;
                }
                i++;
            }
            //retornamos el resultado
            return "La cadena sin caracteres repetidos es: " + result;
        }
        string Ejercicio_10()
        {
          //for
          //Determinamos el rango
            Console.Write("Introduce el límite inferior del rango: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el límite superior del rango: ");
            int u = Convert.ToInt32(Console.ReadLine());
            // La longitud del arreglo se calcula restando el valor de lower del valor de upper, dividiendo el resultado entre 6 y sumando 1.
            int[] divisibleNumbers = new int[(u - l) / 6 + 1];
            int index = 0;
            for (int i = l; i <= u; i++)
            {
                if (i % 6 == 0)
                {
                    divisibleNumbers[index] = i;
                    index++;
                }
            }
            string result = "Los números divisibles son: ";
            //Utilizamos for para recorrer
            for (int i = 0; i < index; i++)
            {
                result += divisibleNumbers[i] + " ";
            }
            return result;
        }
        string Ejercicio_11()
        //for
        {
            //Declaramos un arreglo
            int[] numbers = new int[] { 25, 47, 35, 14, 5 };
            int sum = 0;
            //recorremos ocn un for
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double average = (double)sum / numbers.Length;
            return "El promedio de los elementos del arreglo es: " + average;
        }
        string Ejercicio_12()
        //for
        {
            //Colocamos los elementos en una cadena
            string elementos = "cuchara, tenedor, cuchillo";
            Console.WriteLine("La cadena original es: " + elementos);
            Console.Write("Introduce la cantidad de elementos a añadir: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //recorremos ocn un for
            for (int i = 0; i < n; i++)
            {
                //Agregamos
                Console.Write("Introduce el elemento " + (i + 1) + ": ");
                string newItem = Console.ReadLine();
                elementos += ", " + newItem;
            }
            return "La cadena después de añadir los elementos es: " + elementos;
        }
        string Ejercicio_13()
        // do-while
        {
            int sum = 0;
            int num;
            do
            {
                Console.Write("Introduce un número (0 para terminar): ");
                num = Convert.ToInt32(Console.ReadLine());
                //Sumamos los números ingresados
                sum += num;
              //Condición
            } while (num != 0);
            return "La suma de los números es: " + sum;
        }
        string Ejercicio_14()
        // do-while
        {
            int sum = 0;
            Console.WriteLine("Los números impares del 50 al 1 de forma descendente son:");
            int i = 50;
            do
            {
              //Se verifica si es divisible para 2
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    //Solo se sumarán los impares
                    sum += i;
                }
                i--;
              //Condición
            } while (i >= 1);
            return "La suma de los números impares es: " + sum;
        }
        string Ejercicio_15()
        // do-while
        {
            Console.Write("Introduce la cantidad de números: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            //Devuelve el valor más pequeño
            int lar = Int32.MinValue;
            do
            {
                Console.Write("Introduce el número " + (i + 1) + ": ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > lar)
                {
                    lar = num;
                }
                i++;
              //Condición
            } while (i < n);
            return "El número más grande es: " + lar;
        }
      //El bucle continuará ejecutándose si es true
        while (true)
        {
            LimpiarPantalla();

            Console.WriteLine("1. Nota del estudiante");
            Console.WriteLine("2. Encontrar apellido y su posición");
            Console.WriteLine("3. Generación de números del 1 al 15");
            Console.WriteLine("4. Comparación de cadenas");
            Console.WriteLine("5. Verificación de contención de dígitos numéricos");
            Console.WriteLine("6. Verificación de la primera letra específica");
            Console.WriteLine("7. Impresión de una cantidad en orden inverso");
            Console.WriteLine("8. Contar la cantidad de elementos pares en una lista de números pedidos por el usuario");
            Console.WriteLine("9. Eliminar caracteres repetidos de una cadena");
            Console.WriteLine("10.Impresión los números divisibles para 6 dentro de un rango pedidos por el usuario");
            Console.WriteLine("11.Recorrer un arreglo y calcular el promedio de sus elementos");
            Console.WriteLine("12. Añadir más elementos a una cadena de implementos de cocina");
            Console.WriteLine("13. Cálculo de la suma de números ingresados por el usuario hasta que ingrese 0.");
            Console.WriteLine("14. Impresión de números pares del 1 al 50 de forma descendente y su suma");
            Console.WriteLine("15. Solicitar cantidad e números para verificar cuál es el mayor");
            Console.WriteLine("16. Salir");
            Console.WriteLine("Seleccione una opcion:");

            //Thread.Sleep(5000) es una llamada al método Sleep de la clase Thread en C#.
            //Utilizamos switch para seleccionar uno de varios bloques de código para ejecutar.
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 1");
                    Console.WriteLine(Ejercicio_1());
                    Thread.Sleep(5000);
                    break;
                case 2:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 2");
                    Console.WriteLine(Ejercicio_2());
                    Thread.Sleep(5000);
                    break;
                case 3:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 3");
                    Console.WriteLine(Ejercicio_3());
                    Thread.Sleep(5000);
                    break;
                case 4:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 4");
                    Console.WriteLine(Ejercicio_4());
                    Thread.Sleep(5000);
                    break;
                case 5:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 5");
                    Console.WriteLine(Ejercicio_5());
                    Thread.Sleep(5000);
                    break;
                case 6:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 6");
                    Console.WriteLine(Ejercicio_6());
                    Thread.Sleep(5000);
                    break;
                case 7:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 7");
                    Console.WriteLine(Ejercicio_7());
                    Thread.Sleep(5000);
                    break;
                case 8:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 8");
                    Console.WriteLine(Ejercicio_8());
                    Thread.Sleep(5000);
                    break;
                case 9:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 9");
                    Console.WriteLine(Ejercicio_9());
                    Thread.Sleep(5000);
                    break;
                case 10:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 10");
                    Console.WriteLine(Ejercicio_10());
                    Thread.Sleep(5000);
                    break;
                case 11:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 11");
                    Console.WriteLine(Ejercicio_11());
                    Thread.Sleep(5000);
                    break;
                case 12:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 12");
                    Console.WriteLine(Ejercicio_12());
                    Thread.Sleep(5000);
                    break;
                case 13:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 13");
                    Console.WriteLine(Ejercicio_13());
                    Thread.Sleep(5000);
                    break;
                case 14:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 14");
                    Console.WriteLine(Ejercicio_14());
                    Thread.Sleep(5000);
                    break;
                case 15:
                    LimpiarPantalla();
                    Console.WriteLine("Selecciono la opcion 15");
                    Console.WriteLine(Ejercicio_15());
                    Thread.Sleep(5000);
                    break;
                case 16:
                    Console.WriteLine("selecciono la opcion 16 salir");
                    Thread.Sleep(5000);
                    return;
                default:
                    LimpiarPantalla();
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                    Thread.Sleep(3000);
                    break;

            }



        }

    }


}