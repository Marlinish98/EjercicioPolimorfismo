public class Forma
{
    public string? Circulo{get; set;}
    public string? Rectangulo{get;set;}

    public virtual double CalcularArea()
    {
        return 0.0;
    }
}