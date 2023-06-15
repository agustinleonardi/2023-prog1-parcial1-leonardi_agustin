using System;
namespace BibliotecaDeClases
{
	public class Seguro
	{
		public int CodigoAutoincremental { get; set; }
		public string? Nombre { get; set; }
		public string? Aseguradora { get; set; }
		public double Monto { get; set; }
		public DateTime FechaEliminacion { get; set; }

        public Seguro(int codigoAutoincremental, string? nombre, string? aseguradora, double monto, DateTime fechaEliminacion)
        {
            CodigoAutoincremental = codigoAutoincremental;
            Nombre = nombre;
            Aseguradora = aseguradora;
            Monto = monto;
            FechaEliminacion = fechaEliminacion;
        }
        public virtual int CalcularIndiceRiesgo()
        {
            int indice = 0;
            return indice
        }
    }
}

