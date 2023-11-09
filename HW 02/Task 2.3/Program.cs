using System;

namespace Task_2._3
{
    class Program
    {
        static void Main()
        {
            Training training = new Training("Entrenamiento de Programación");

            PracticalLesson practicalLesson1 = new PracticalLesson("Programación en C#");
            PracticalLesson practicalLesson2 = new PracticalLesson("Diseño de bases de datos");
            Lecture lecture1 = new Lecture("Introducción a la programación");

            training.Add(practicalLesson1);
            training.Add(practicalLesson2);
            training.Add(lecture1);

            if (training.IsPractical())
            {
                Console.WriteLine("Todos los elementos en el conjunto son prácticos.");
            }
            else
            {
                Console.WriteLine("Al menos un elemento en el conjunto no es práctico.");
            }
            Training training2 = (Training)training.Clone();
            if (training2.IsPractical())
            {
                Console.WriteLine("Todos los elementos en el conjunto son prácticos.");
            }
            else
            {
                Console.WriteLine("Al menos un elemento en el conjunto no es práctico.");
            }
        }
    }
}
