using System;
namespace BibliotecaDeClases
{
	public class Robo : Seguro
	{
		public TipoDispositivo Tipo { get; set; }
		public int NumeroSerie { get; set; }
		public string Descripcion { get; set; }
		public ZonasDeRiesgo Zona { get; set; }

        public Robo(int codigoAutoincremental, string? nombre, string? aseguradora, double monto, DateTime fechaEliminacion, int tipo, int numeroSerie, string descripcion, ZonasDeRiesgo zona): base(codigoAutoincremental,nombre,aseguradora,monto,fechaEliminacion)
        {
            Tipo = (TipoDispositivo)tipo;
            NumeroSerie = numeroSerie;
            Descripcion = descripcion;
            Zona = zona;
        }
        public override int CalcularIndiceRiesgo()
        {
            int indice=0;
            base.CalcularIndiceRiesgo();
            return indice;
        }
    }
}

