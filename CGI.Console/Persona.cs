using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGI.Console
{

    /// <summary>
    /// Clase para pregunta # 16
    /// </summary>
    public class Persona
    {
        public string Nombre { get; set; } = string.Empty;
        public int Edad { get; set; }
        public float Peso { get; set; }

        public void CambiaNombre()
        {
            this.Nombre = $"Hola_{Nombre}";
        }
        public float Calcula()
        {
            return Edad * Peso;
        }

    }
}
