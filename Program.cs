using System;
using System.Globalization;
using System.IO;
using System.Collections;

namespace TodoList
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackTareas stackTareas = new StackTareas();

            

            string opcion = "";
            while (opcion != "7")
            {
                opcion = "";
                while (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5" && opcion != "6" && opcion != "7")
                {
                Console.WriteLine("Escoja una opcion del menu, por favor");
                
                Console.WriteLine("1) Agregar tarea");
                Console.WriteLine("2) Siguiente tarea");
                Console.WriteLine("3) Pendientes por Hacer");
                Console.WriteLine("4) Tareas terminadas");
                Console.WriteLine("5) salir");
                opcion = Console.ReadLine(); 

                if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5" && opcion != "6" && opcion != "7")
                {
                    Console.WriteLine("La opcion seleccionada no es correcta, selecciona otra por favor");

                }

                }
            if (opcion == "1")
            {
                stackTareas.PrintStack();
            }
            else if(opcion =="2")
            {
                Console.WriteLine("Tienes un pendiente menos");
                string descripcion = Console.ReadLine();
                Console.WriteLine("Este es tu pendiente" + descripcion);
            }
            else if (opcion =="3")
            {
                Console.WriteLine("Tareas pendientes por hacer");
                Console.WriteLine(stackTareas);
            }
            else if (opcion =="4")
            {
                Console.WriteLine("Tareas realizadas");
            }
            else if (opcion =="5")
            {
                Console.WriteLine("Saliendo...");
            }


            }
        }
    }
}
