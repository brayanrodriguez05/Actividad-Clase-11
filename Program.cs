
using Actividad_Clase__11;

List<Recetas> ListaRecetas = new List<Recetas>();


int opcion = 0;
do
{
    Console.Clear();
    Console.WriteLine("Bienvenido a la coleccion de recetas culinarias...");
    Console.Write("1. Agregar recetas");
    Console.Write("2. Buscar recetas");
    Console.Write("3. Mostrar todas las recetas que estan agregadas a la coleccion");
    Console.Write("4. Salir");
    Console.WriteLine("Seleccione una opcion:");

    int opciones = int.Parse(Console.ReadLine());

    switch (opciones)
    {
        case 1:
            // Agregar recetas

            Console.Clear();
            Console.Write("Agregue el nombre de una receta");
            string NombreReceta = Console.ReadLine();

            Console.Write("Agregue el tipo de la receta (si es un postre o alguna comida tradicional)");
            string TipoReceta = Console.ReadLine();

            Console.Write("Agregue el tiempo de preparacion");
            int TiempoPreparacion = int.Parse(Console.ReadLine());

            ListaRecetas.Add(new Recetas(NombreReceta, TipoReceta, TiempoPreparacion));
            Console.WriteLine("Receta agregada correctamente :)");
            Console.ReadKey();
            break; 
        case 2:
            // Buscar recetas

            Console.Clear();
            Console.Write("Ingrese el nombre de la receta que desea buscar en la lista:");.
            string buscarReceta = Console.ReadLine();
            Recetas recetaBuscada = ListaRecetas.Find(r => r.NombreReceta == buscarReceta);

            if (recetaBuscada != null)
            {
                Console.WriteLine("Esta reecta esta ");
            }


            Console.ReadKey();
            break; 
        case 3:

            Console.Clear();

            Console.ReadKey();
            break;
        case 4:

            Console.Clear();

            Console.ReadKey();
            break;








    }
    










} while (opcion != 0);