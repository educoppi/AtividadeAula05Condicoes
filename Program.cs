using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula05Condicoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;

            string endereco;
            string bairro;
            string cidade;
            string estado;

            int viagensAnoPassad;
            int viagensEsseAno;

            string cupomDesconto;
            string promocoesEmail;

            //Etapa 1

            Console.WriteLine("Bem-vindo ao sistema da empresa Viagem e Turismo Brasil");
            Console.WriteLine("Vamos te cadastrar no nosso sistema!");

            Console.Write("Insira seu primeiro nome: ");
            nome = Console.ReadLine();

            Console.Write("Insira seu segundo nome: ");
            sobrenome = Console.ReadLine();

            Console.WriteLine($"Olá Sr(a). {nome} {sobrenome}, vamos continuar seu cadastro...");

            Console.Write("Insira seu Endereço: ");
            endereco = Console.ReadLine();

            Console.Write("Insira seu Bairro: ");
            bairro = Console.ReadLine();

            Console.Write("Insira seu Cidade: ");
            cidade = Console.ReadLine();

            Console.Write("Insira seu Estado: ");
            estado = Console.ReadLine();

            Console.WriteLine($"O Sr(a). {sobrenome} mora na cidade de {cidade}-{estado}, no endereço {endereco}, localizado no bairro {bairro}");

            Console.Write("Insira a quantidade de viagens que você fez no ano passado: ");
            viagensAnoPassad = int.Parse(Console.ReadLine());

            Console.Write("Insira quantas viagens você fez esse ano: ");
            viagensEsseAno = int.Parse(Console.ReadLine());

            int somaViagens = viagensAnoPassad + viagensEsseAno;

            Console.WriteLine($"Parabens! Você ja fez {somaViagens} viagens!");
            if (somaViagens < 10)
            {
                Console.WriteLine($"Faltam {10 - somaViagens} viagens para chegar em 10 viagens ao todo!!!");
            }
            else
            {
                Console.WriteLine("Vamos bater a proxima meta? ;)");
            }

            Console.WriteLine($"\nEm média, você ja fez {somaViagens/2} viagens por ano!");

            Console.WriteLine($"Olha que interessante, estamos vendo aqui que você tem um intervalo em meses entre cada viagem desse ano de {12/viagensEsseAno} meses");

            Console.WriteLine($"Obrigado {nome} {sobrenome}, o seu cadastro foi realizado com sucesso!");

            //Etapa 2

            Console.Write("Digite seu cupom de desconto: ");
            cupomDesconto = Console.ReadLine();

            if (cupomDesconto == "conradito10")
            {
                Console.WriteLine("Parabéns, você recebeu 10% de desconto na sua próxima viagem!");
            }
            else
            {
                Console.WriteLine("Esse cupom não existe!");
            }

            Console.Write("Você gostaria de receber promoções no seu email? -> ");
            promocoesEmail = Console.ReadLine();

            if (promocoesEmail == "sim")
            {
                Console.WriteLine($"Obrigado {nome} por se registrar, você receberá novos e-mails em breve.");
            }
            else
            {
                Console.WriteLine("Ok, você não receberá e-mails de promoções.");
            }

            Console.WriteLine("Obrigado, e volte sempre!");
            Console.ReadKey();
        }
    }
}
