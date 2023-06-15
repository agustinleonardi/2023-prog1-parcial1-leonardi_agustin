using System;
namespace BibliotecaDeClases
{
	public class MotoAuxilio : Seguro
	{
		public int CantidadKmMax { get; set; }
		public int CilindradaMoto { get; set; }
		public int AñoMoto { get; set; }

        public MotoAuxilio(int codigoAutoincremental, string? nombre, string? aseguradora, double monto, DateTime fechaEliminacion, int cantidadKmMax, int cilindradaMoto, int añoMoto):base(codigoAutoincremental,nombre,aseguradora,monto,fechaEliminacion)
        {
            CantidadKmMax = cantidadKmMax;
            CilindradaMoto = cilindradaMoto;
            AñoMoto = añoMoto;
        }
    }
}

