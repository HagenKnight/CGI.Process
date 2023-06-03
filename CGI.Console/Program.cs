using CGI.Console;
using System.Diagnostics;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Pregunta # 15
        /*
        Program p = new Program();
        triangulo triangulo = new triangulo();

        triangulo.altura = 10;
        triangulo.baseT = 10;
        float area1 = triangulo.altura * triangulo.baseT / 2;

        triangulo triangulo2 = p.achatar(triangulo);
        float area2 = triangulo2.altura * triangulo2.baseT / 2;
        Console.WriteLine($"Área triángulo 1 = {triangulo.altura} * {triangulo.baseT} / 2 = {area1}");
        Console.WriteLine($"Área triángulo 2 = {triangulo2.altura} * {triangulo2.baseT} / 2 = {area2}");
        */
        #endregion

        #region Pregunta # 17

        Persona usuario = new Persona
        {
            Nombre = "Giovanni García",
            Edad = 41,
            Peso = 68.5f
        };
        usuario.CambiaNombre();
        Console.WriteLine($"{usuario.Nombre}");
        Console.WriteLine($"{usuario.Calcula()}");

        #endregion

    }

    // respuesta pregunta # 15
    triangulo achatar(triangulo _triangulo)
    {
        triangulo nuevoTriangulo = new triangulo
        {
            altura = _triangulo.altura * 0.9f
        };
        nuevoTriangulo.baseT = (_triangulo.altura * _triangulo.baseT) / nuevoTriangulo.altura;
        return nuevoTriangulo;
    }
}
