using System;
using System.Collections.Generic;
using System.Text;

namespace VendaJogos.ViewModels
{
    public class JogoViewModel
    {
        public string Nome { get; set; }
        public string Plataforma { get; set; }
        public byte QuantidadeJogadores { get; set; }
        public bool PermiteOnline { get; set; }
        public byte ClassificacaoCensura { get; set; }
        public string MarcaProdutoraEstudio { get; set; }
        public string[] IdiomasAudios { get; set; }
        public string[] IdiomasLegendas { get; set; }
        public string Garantia { get; set; }
        public string[] Generos { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Descricao { get; set; }

    }
}
