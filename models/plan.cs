namespace fachaGym.models
{
public class Plan
    {
        public int Id { get; set; }
        public string TipoPlan { get; set; } //eje: diario, mensual, trimestral(tres meses jijij)
        public int duracion { get; set; } //esta caga la duracion es en dias
        public DateTime fechaActivacion { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public float valor { get; set; }

    }
}