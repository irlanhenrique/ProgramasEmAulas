using System;
using VendaJogos.ViewModels;

namespace VendaJogos
{
    class Program
    {
        static void Main(string[] args)
        {
            var gta = new JogoViewModel();

            //Console.WriteLine("Qual é o nome do jogo");
            //var nomeJogo = Console.ReadLine();
            //gta.Nome = nomeJogo;

            //Console.WriteLine("Informe a classificação do jogo");

            //var classificacaoPreenchida = false;

            //while (!classificacaoPreenchida)
            //{
            //    var classificacaoQueVemDaTelaEmTexto = Console.ReadLine();

            //    if (byte.TryParse(classificacaoQueVemDaTelaEmTexto, out byte classicacaoQueVemDaTelaEmByte))
            //    {
            //        gta.ClassificacaoCensura = classicacaoQueVemDaTelaEmByte;
            //        classificacaoPreenchida = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Valor invalido, por favor, informe apenas nmeros");
            //    }
            //}


            //gta.DataLancamento = new DateTime(2022, 1, 30);
            //gta.Descricao = "Jogo do GTA";
            //gta.Garantia = "Pode trocar em até 3 meses da data da compra";
            byte i=0;
            Console.WriteLine("Deseja adicionar um categoria? Sim ou Não");
            var opcao = Console.ReadLine();
           
                while (opcao == "Sim")
                {
                    gta.Generos[i] = Console.ReadLine();
                    
                    Console.WriteLine("Deseja adcionar mais categorias : Sim ou Não");
                    opcao = Console.ReadLine();
                    i++;
            }   
        

            
            //gta.Generos = new string[]
            //{
            //    "Ação",
            //    "Tiro",
            //    "Aventura"
            //};
            //gta.IdiomasAudios = new string[] 
            //{
            //    "Português",
            //    "Inglês"
            //};
            //gta.IdiomasLegendas = new string[]
            //{
            //    "Português",
            //    "Inglês"

            //};
            gta.MarcaProdutoraEstudio = "Rockstar";
            gta.PermiteOnline = true;
            gta.Plataforma = "àlystation";
            gta.QuantidadeJogadores = 1;
        }
    }
}
