using CGI.Console;
using System.Diagnostics;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Program p = new Program();

        #region Pregunta # 12

        string nuevaCadena = p.MostrarCadenaAlreves("abcdefg");
        Console.WriteLine(nuevaCadena);

        #endregion

        #region Pregunta # 15
        /*
        
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
        /*
        Persona usuario = new Persona
        {
            Nombre = "Giovanni García",
            Edad = 41,
            Peso = 68.5f
        };
        usuario.CambiaNombre();
        Console.WriteLine($"{usuario.Nombre}");
        Console.WriteLine($"{usuario.Calcula()}");
        */
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


    #region #Pregunta 11

    public int metodoA(int[] vec, int pos)
    {
        int sum = 0, i = 0;
        while (i == pos)
        {
            sum = sum + vec[i];
        }
        return sum;
    }
    #endregion

    #region Pregunta 12
    string MostrarCadenaAlreves(string cadena)
    {
        string nuevaCadena = string.Empty;
        for (int i = 0; i < cadena.Length; i++)
            nuevaCadena += cadena[cadena.Length - i - 1];
        return nuevaCadena;
    }
    #endregion

}
