namespace ACTIVIDAD_2___PROGRWEB.Models
{
    public class PromedioViewModel
    {
        public float Calificacion1 { get; set; }
        public float Calificacion2 { get; set; }
        public float Calificacion3 { get; set; }

        public float Promedio { get { return (Calificacion1 + Calificacion2 + Calificacion3) / 3; } }

        public string EstadoDelAlumno()
        {
            if(Promedio==0)
            {
                return "No aprobado";
            }
            else if(Promedio>=70)
            {
                return "Aprobado";
            }
            else
            {
                return "Reprobado";
            }
        }
    }
}
