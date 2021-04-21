using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instituto.Entidades;
using Instituto.Actividades;
using System.Collections;

namespace Instituto
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Instituto de Sistemas");
             Console.WriteLine("_____________________");



            //Creamos una instancia de Profesor
            //Profesor profesor = new Profesor();

            //Instancia - objeto Alumnos
            Alumnos instanciaAlumnos = new Alumnos();
            Profesores instanciaProfesores = new Profesores();
            short carga = 0;
            do
            {
                Console.WriteLine("Quiere cargar un alumno? Si(1) No(0)");
                carga = Convert.ToInt16(Console.ReadLine());
                if (carga != 0)
                {
                    //Creamos una instancia de Alumno
                    Alumno alumno = new Alumno();

                    Console.WriteLine("Ingrese el DNI");
                    alumno.DNI = Console.ReadLine();

                    Console.WriteLine("Ingrese el nombre");
                    alumno.Nombre = Console.ReadLine();

                    Console.WriteLine("Ingrese el apellido");
                    alumno.Apellido = Console.ReadLine();

                    Console.WriteLine("Ingrese la direccion");
                    alumno.Direccion = Console.ReadLine();

                    Console.WriteLine("Ingrese el telefono");
                    alumno.Telefono = Console.ReadLine();

                    Console.WriteLine("Ingrese el email");
                    alumno.Email = Console.ReadLine();

                    bool estado = instanciaAlumnos.Create(alumno);
                    
                    if(estado)
                    {
                        Console.WriteLine("Fue ingresado el alumno");
                    }
                    else
                    {
                        Console.WriteLine("No fue ingresado el alumno");
                    }
                    Console.Clear();
                }
         }
            while (carga == 1);

            Console.WriteLine("-----------------------------------------------");

            List<Alumno> alumnos = instanciaAlumnos.Read();

            //for (int i = 0; i < alumnos.Count; i++)
            //{
            //    Alumno a = instanciaAlumnos.alumnos[i];
            //    Console.WriteLine(a.DNI);
            //    Console.WriteLine(a.Nombre);
            //    Console.WriteLine(a.Apellido);
            //    Console.WriteLine("-------------------------------------------");
            //}

            foreach(var al in alumnos)
            {
                Console.WriteLine(al.DNI);
                Console.WriteLine(al.Nombre);
                Console.WriteLine(al.Apellido);
                Console.WriteLine("-------------------------------------------");
            }

            //Console.WriteLine(alumno.Actividad());
            //Console.WriteLine(profesor.Actividad());

            Console.ReadKey();
        }
    }
}
