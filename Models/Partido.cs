namespace MarcadorApi.Models;

public class Partido
{
    public int Id { get; set; }
    public string EquipoLocal { get; set; } = string.Empty;
    public string EquipoVisitante { get; set; } = string.Empty;
    public int PuntosLocal { get; set; }
    public int PuntosVisitante { get; set; }
    public int FaltasLocal { get; set; }
    public int FaltasVisitante { get; set; }
    public int Cuarto { get; set; }
    public string Estado { get; set; } = "En curso";
    public DateTime Fecha { get; set; } = DateTime.Now;
}
