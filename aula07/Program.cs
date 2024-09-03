public class Program{

    public static void MostrarMensagem(string mensagem){
        Console.WriteLine("Mensagem: " + mensagem);
    }

    public static int Somar(int a, int b){
        return a+ b;
    }
    public static void Main(string[] args){
        Action<string> action = MostrarMensagem;

        action("Hello World!!!!!");

        Func<int, int, int> operacao = Somar;
        Console.WriteLine("Soma: " + operacao(2, 3));

        Action<int, int> exibirOperacoes = (x, y) => {
            Console.WriteLine("Soma: " + (x + y));
            Console.WriteLine("Mutiplicação: " + (x * y));
        };

        exibirOperacoes(2, 3);

        Func<int, int> calcularQuadrado = (x) => x*x;

        Func<int, int, int> executarOperacao = (x, y) => {
            return calcularQuadrado(x) + calcularQuadrado(y);
        };

        Console.WriteLine("Quadrado de 5 é: " + calcularQuadrado(5));
        Console.WriteLine("Resultado da operação: " + executarOperacao(4, 6));
    }
}
