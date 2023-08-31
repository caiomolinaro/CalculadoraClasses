namespace CalculadoraClasses
{
    public class Soma
    {
        public double num1 { get; set; }
        public double num2 { get; set; }

        public virtual void ExibirResultado()
        {
            Console.WriteLine($"O resultado de {num1} + {num2} = {num1 + num2}");
        }
    }

  
}
