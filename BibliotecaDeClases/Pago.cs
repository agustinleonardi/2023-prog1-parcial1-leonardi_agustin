using System;
namespace BibliotecaDeClases
{
	public class Pago
	{
		public DateTime Fecha { get; set; }
		public int Monto { get; set; }

        public Pago(DateTime fecha, int monto)
        {
            Fecha = fecha;
            Monto = monto;
        }
    }
}

