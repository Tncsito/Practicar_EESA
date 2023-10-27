namespace Practicar_EESA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Datos.Datos datos = new Datos.Datos();
            datos.Burbuja();
            datos.seleccion();
            datos.insercion();
        }
    }
}