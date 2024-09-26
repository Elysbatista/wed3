public class Accidente
{
    public DateTime Fecha { get; set; }
    public string Descripcion { get; set; }
    public decimal Costo { get; set; } // Asegúrate que esta propiedad esté definida correctamente.
    public int NumeroMuertos { get; set; }
    public int NumeroHeridos { get; set; }
    public int CantidadVehiculos { get; set; }
}
