using System;
namespace BibliotecaDeClases
{
	public class Hogar : Seguro
	{
		public int CantidadHabitaciones { get; set; }
		public int CantidadHeladeras { get; set; }
		public int CanitdadVentanas { get; set; }

        public Hogar(int codigoAutoincremental, string? nombre, string? aseguradora, double monto, DateTime fechaEliminacion, int cantidadHabitaciones, int cantidadHeladeras, int canitdadVentanas): base(codigoAutoincremental,nombre,aseguradora,monto,fechaEliminacion)
        {
            CantidadHabitaciones = cantidadHabitaciones;
            CantidadHeladeras = cantidadHeladeras;
            CanitdadVentanas = canitdadVentanas;
        }
        public override int CalcularIndiceRiesgo()
        {
            int indice = 0;
            base.CalcularIndiceRiesgo();
            return indice;
        }
    }
}

