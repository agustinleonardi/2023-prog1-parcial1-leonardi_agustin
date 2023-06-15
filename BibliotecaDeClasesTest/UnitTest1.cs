//using System;
//using BibliotecaDeClases;
namespace BibliotecaDeClasesTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
/*
 * public class AgregarProductoOk
	{
		Carpinteria carpinteria = new Carpinteria();
		[SetUp]
		public void SetUp()
		{
			List<Herramienta> herramientas = new();
			List<TrabajosRealizados> trabajosRealizados = new();
		}
		[Test]
		public void TestAgregarProductoOk()
		{
			//act
			DateTime fecha = DateTime.Today;
			HerramientaManual herramienta = new(12,"agu",40.2,fecha);
			Resultado resultado = carpinteria.AgregarPoducto(herramienta);
			//assert
			Assert.That(resultado.Succes,Is.True);
		}
		[Test]
		public void TestAgregarProductoError()
		{
			//act
			Resultado resultado = carpinteria.AgregarPoducto(null);
			//assert
			Assert.That(resultado.Succes,Is.False);
		}
	}
	esto va en la clase "Taller/carpinteria"
	public List<Herramienta> Herramientas { get; set; }
		public List<TrabajosRealizados> TrabajosRealizados { get; set; }
		private int CodigoAutoincrementalHerramienta { get; set; }
		private int CodigoAutoincrementalTrabajo { get; set; }

		public Carpinteria()
        {
            Herramientas = new ();
            TrabajosRealizados = new();
			CodigoAutoincrementalHerramienta = 1;
			CodigoAutoincrementalTrabajo = 1;
        }
 */
