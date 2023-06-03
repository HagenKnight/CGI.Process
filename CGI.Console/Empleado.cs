using System.ComponentModel.DataAnnotations;

namespace CGI.Console
{
    #region Pregunta #9
    
    public class Empleado
    {
        public string Nombre { get; set; }

        [Range(1, 1000, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Codigo { get; set; }
        public string PuestoTrabajo { get; set; }
        public decimal SueldoBase { get; set; }
        public Empleado SuperiorDirecto { get; set; }
        public Grupo GrupoPertenece { get; set; }
    }

    public class Grupo
    {
        public string NombreOficina { get; set; }

        [Range(1, 23, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int CodigoDepartamento { get; set; }
        public List<Empleado> Empleados { get; set; }

        public Grupo()
        {
            Empleados = new List<Empleado>();
        }
    }

    #endregion
}
