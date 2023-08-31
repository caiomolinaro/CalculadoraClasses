namespace CalculadoraClasses
{
    public class Multiplicacao : Soma
    {
        public override void ExibirResultado()
        {
            Console.WriteLine($"O resultado de {num1} X {num2} = {num1 * num2}");
        }
    }
}
