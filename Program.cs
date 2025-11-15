Circulo circulo = new Circulo();
Rectangulo rectangulo = new Rectangulo();

// Informacion Circulo
circulo.Radio = 90;

// Informacion Rectangulo
rectangulo.Alto = 342;
rectangulo.Ancho = 392;

List<Forma> formas = new List<Forma>();
formas.Add(circulo);
formas.Add(rectangulo);

foreach(var forma in formas)
{
    Console.WriteLine($"Area del {forma.GetType().Name}: {forma.CalcularArea()}");
}