Arreglos.Pila pila = new Arreglos.Pila(5);
void Imprimir(string[] elementos )
{
    Console.Clear();
    foreach (string elemento in elementos)
    {
        Console.WriteLine();
    }
}

try
{
    pila.Agregar("pepe0");
    pila.Agregar("pepe1");
    pila.Agregar("pepe2");
    pila.Agregar("pepe3");
    pila.Agregar("pepe4");
   

     pila.ObtenerArreglo();

    Imprimir (pila.ObtenereArreglo));
    pila.Eliminar();
    Imprimir(pila.ObtenereArreglo());
    pila.Eliminar();
    Imprimir(pila.ObtenereArreglo());
    pila.Eliminar();
    Imprimir(pila.ObtenereArreglo());
    pila.Eliminar();
    Imprimir(pila.ObtenereArreglo());
    pila.Eliminar();





    
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}