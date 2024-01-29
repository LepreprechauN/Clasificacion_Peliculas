class Program
{
    enum CalificacionEdad { General, Adolescentes, Adultos }

    const int EdadMinimaAdolescentes = 13;
    const int EdadMinimaAdultos = 18;

    static void Main()
    {
        //loop infinito para estar probando la edad hasta que el usuario haga ctrl + c
        while (true)
        {
            Console.Write("Introduce tu edad: ");
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                CalificacionEdad categoria = edad < EdadMinimaAdolescentes ? CalificacionEdad.General :
                                             edad < EdadMinimaAdultos ? CalificacionEdad.Adolescentes :
                                             CalificacionEdad.Adultos;

                Console.WriteLine($"Tu edad pertenece a la categoría: {categoria}");

                Console.Write("Puedes ver películas para: ");

                if (categoria >= CalificacionEdad.General)
                {
                    Console.Write("General, ");
                }

                if (categoria >= CalificacionEdad.Adolescentes)
                {
                    Console.Write("Adolescentes ");
                }

                if (categoria >= CalificacionEdad.Adultos)
                {
                    Console.Write("y Adultos ");
                }
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("Por favor, introduce una edad válida.");
            }
        }
    }
}
