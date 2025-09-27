using System;
using System.Collections.Generic;
using System.Linq;

class Curso
{
    public string Nombre { get; set; }
    public double Nota { get; set; }
}

class Program
{
    static void Main()
    {
        try
        {
            List<Curso> cursos = new List<Curso>
            {
                new Curso { Nombre = "Calculo", Nota = 50 },
                new Curso { Nombre = "Ecuaciones Diferenciales", Nota = 65 },
                new Curso { Nombre = "Programación", Nota = 60 },
                new Curso { Nombre = "Recursos Humanos", Nota = 95 },
                new Curso { Nombre = "Mecanica de Fluidos", Nota = 78 },
                new Curso { Nombre = "Física", Nota = 88 },
                new Curso { Nombre = "Química", Nota = 92 },
                new Curso { Nombre = "Costos", Nota = 84 },
                new Curso { Nombre = "Inglés", Nota = 69 },
                new Curso { Nombre = "Finanzas", Nota = 98 }
            };

            double promedio = CalcularPromedio(cursos);

            Console.WriteLine("El promedio es de: " + promedio);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static double CalcularPromedio(List<Curso> listaCursos)
    {
        if (listaCursos.Count == 0)
        {
            throw new InvalidOperationException("La lista de cursos está vacía. No se puede calcular el promedio.");
        }

        return listaCursos.Average(c => c.Nota);
    }
}
