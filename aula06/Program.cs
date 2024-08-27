using System;
public class Program{

    public delegate void ExibirNumero(int num);
    

    public static void ImprimeNumero(int numero){
        Console.WriteLine("O número é: " + numero);
    }

    public static void ExibirQuadrado(int numero){
        Console.WriteLine("O quadrado do número " + numero + " é: " + numero*numero);
    }

    public delegate void VerificarNota(double nota);

    public static void ValidaNota(double nota){
        if(nota >= 60){
            Console.WriteLine("O aluno está aprovado!");
        } else {
            Console.WriteLine("O aluno está reprovado!");
        }
    }

    public static void Main(){
        
        ExibirNumero meuDelegate = ImprimeNumero;

        meuDelegate(10);

        meuDelegate += ExibirQuadrado;
        meuDelegate(2);

        meuDelegate += delegate(int num){
            Console.WriteLine("O dobro do número " + num + " é: " + (num*2));
        };

        meuDelegate(3);

        Pessoa p = new Pessoa("Joaquim", 59);

        VerificarNota novoDelegate = ValidaNota;
        double notaAluno = p.Nota;

        novoDelegate(notaAluno);


    }

}