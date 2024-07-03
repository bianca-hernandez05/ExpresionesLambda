namespace EjercicioLambda
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a programa lambda");
            Console.WriteLine();

            List<Estudiante> estudiantes = new List<Estudiante>
        {
            // Se crea una lista de tipo Estudiante llamada estudiantes y se inicializa con 5 objetos Estudiante
            new Estudiante { Nombre = "Marian", Edad = 20, Nota = 90 },
            new Estudiante { Nombre = "Mario", Edad = 22, Nota = 60 },
            new Estudiante { Nombre = "Blanca", Edad = 19, Nota = 30.5 },
            new Estudiante { Nombre = "Isaac", Edad = 17, Nota = 43.7 },
            new Estudiante { Nombre = "Varela", Edad = 16, Nota = 100 }
        };
            // Se utiliza el método Where de LINQ para filtrar la lista de estudiantes y obtener solo aquellos
            // que tienen una edad mayor a 18 años. El resultado se almacena en la variable estudiantesMayores18 
            var estudiantesMayores18 = estudiantes.Where(e => e.Edad > 18);
            Console.WriteLine("Los estudiantes que son mayores a 18 años de edad:");
            foreach (var estudiante in estudiantesMayores18)
            {
               //Se imprime en la consola el nombre y la edad de cada estudiante mayor de 18 años.
                Console.WriteLine($" Su nombre: {estudiante.Nombre}, Su edad: {estudiante.Edad}");
            }
            Console.WriteLine();

            // Obtener el estudiante con la nota más alta
            //Se utiliza el método OrderByDescending de LINQ para ordenar la lista de estudiantes
            //de forma descendente por la propiedad Nota.
            //Luego, se toma el primer elemento de la lista ordenada, que corresponde al estudiante con la nota más alta
            //y se almacena en la variable estudianteNotaMax.
            var estudianteNotaMax = estudiantes.OrderByDescending(e => e.Nota).FirstOrDefault();
            Console.WriteLine($"Estudiante con la nota más alta: {estudianteNotaMax.Nombre}, Nota: {estudianteNotaMax.Nota}");
            Console.WriteLine();

            // Ordenar la lista de estudiantes por nombre en orden ascendente
            //Se utiliza el método OrderBy de LINQ para ordenar la lista de estudiantes
            //de forma ascendente por la propiedad Nombre.
            //El resultado se almacena en la variable estudiantesOrdenadosNombre.
            var estudiantesOrdenadosNombre = estudiantes.OrderBy(e => e.Nombre);
            Console.WriteLine("Estudiantes ordenados por nombre:");
            foreach (var estudiante in estudiantesOrdenadosNombre)
            {
                Console.WriteLine($"Nombre: {estudiante.Nombre}");
            }
            Console.WriteLine();

            // Calcular el promedio de notas de los estudiantes
            var promedioNotas = estudiantes.Average(e => e.Nota);
            Console.WriteLine($"Promedio de notas: {promedioNotas}");

        }
    }
}
