namespace fachaGym.models
{
public class Plan
    {
        public int Id { get; set; }
        public string TipoPlan { get; set; }
        public int duracion { get; set; }
        public DateTime fechaActivacion { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public float valor { get; set; }

    }
}