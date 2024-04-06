Arreglos.Pila pila = new Arreglos.Pila(5);


try
{
    pila.Agregar("pepe0");
    pila.Agregar("pepe1");
    pila.Agregar("pepe2");
    pila.Agregar("pepe3");
    pila.Agregar("pepe4");
    pila.Agregar("pepe5");

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}