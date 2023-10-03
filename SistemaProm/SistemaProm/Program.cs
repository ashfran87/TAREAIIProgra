using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaProm
{
    internal class Program
    {
        static float[] quiz = new float[3];//variables globales
        static float[] tarea = new float[3];
        static float[] examen = new float[3];
        static float[] notas = new float[3];
        static float promedio = 0;

        static void Main(string[] args)
        {
            SolicitarDatos();
            promedioQuiz();
            promedioTarea();
            promedioExamenes();
            CalcNotaFinal();
            Console.ReadLine();
        }
        static void SolicitarDatos()
        {
            //Solicitar nombre
            Console.WriteLine("Por favor, ingrese su nombre: ");
            //Leer nombre desde consola
            string nombre = Console.ReadLine();

            Console.WriteLine("Por favor, ingrese su numero de carnet");
            string carnet = Console.ReadLine();

            Console.WriteLine($"Hola, {nombre}! Bienvenido al Sistema de Calculo de Promedio");



        }
        static void promedioQuiz()
        {

            promedio = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingrese la nota del Quiz {i + 1}: ");
                float nota = float.Parse(Console.ReadLine());
                quiz[i] = nota;
                promedio += quiz[i];
            }
            promedio /= 3;
            notas[0] = promedio *= 0.25f;


        }
        static void promedioTarea()
        {

            promedio = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingrese la nota de la Tarea {i + 1}: ");
                float nota = float.Parse(Console.ReadLine());
                tarea[i] = nota;
                promedio += tarea[i];
            }
            promedio /= 3;
            notas[1] = promedio *= 0.30f;


        }
        static void promedioExamenes()
        {

            promedio = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingrese la nota del examen {i + 1}: ");
                float nota = float.Parse(Console.ReadLine());
                examen[i] = nota;
                promedio += examen[i];
            }
            promedio /= 3;
            notas[2] = promedio *= 0.45f;


        }

        static void CalcNotaFinal()
        {
            float suma = 0;
            for (int i = 0; i < 3; i++)
            {
                suma += notas[i];
            }
            if (suma < 50)
            {
                Console.WriteLine("Reprobado nota: {0}", suma);
            }
            else if (suma >= 50 && suma < 70)
            {
                Console.WriteLine("Aplazado nota: {0}", suma);
            }
            else Console.WriteLine("Aprobado nota: {0} ", suma);
        }
    }
}
