using System;

namespace e_commerce{
    class Program{
        static void Main(string[] args){
            Livro l = new Livro();

            l.Codigo = 789123456520;
            l.Valor = 50;
            l.Titulo = "O Senhor dos Aneis";
            l.Autor = "J.K Tolkiens";

            System.Console.WriteLine(l.GetDescricao());
        }
    }
}
