using System;
using ActionExemplo.Entidades;
using System.Collections.Generic;

namespace ActionExemplo {
    class Program {
        static void Main(string[] args) {

            List<Produto> lista = new List<Produto>();

            lista.Add(new Produto("TV", 900.00));
            lista.Add(new Produto("Mouse", 50.00));
            lista.Add(new Produto("Tablet", 350.50));
            lista.Add(new Produto("HD Case", 80.90));

            //função da lista chamada ForEach que recebe um Action
            //do tipo Product, essa função que irá receber tem que 
            //ser do tipo void e que receba um produto
            lista.ForEach(UpdatePreco);  
            foreach (Produto p in lista) {
                Console.WriteLine(p);
            }
            //outro exemplo
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=");             
            Action<Produto> act = UpdatePreco;
            lista.ForEach(act);
            foreach (Produto p in lista) {
                Console.WriteLine(p);
            }
            //com a função lambda
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=");            
            Action<Produto> act2 = p => { p.Preco += p.Preco * 0.1; } ;
            lista.ForEach(act2);
            foreach (Produto p2 in lista) {
                Console.WriteLine(p2);
            }
            //inLine
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=");
            lista.ForEach(p2 => { p2.Preco += p2.Preco * 0.1; } );
            foreach (Produto p2 in lista) {
                Console.WriteLine(p2);
            }
        }
        //função auxiliar para acrescentar 10% sobre o valor de cada produto
        static void UpdatePreco(Produto p) {
            p.Preco += p.Preco * 0.1;
        }
    }
}
