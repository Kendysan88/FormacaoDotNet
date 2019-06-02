using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.ViewModels
{
    //View de busca de produtos + construtor texto para pesquisa
    public class PesquisaViewModel
    {
        public PesquisaViewModel(IList<Produto> itens, bool localizouResultado)
        {

            Itens = itens;
            LocalizouResultado = localizouResultado;

        }

        public PesquisaViewModel(bool localizouResultado)
        {
            LocalizouResultado = localizouResultado;
        }

        public IList<Produto> Itens { get; }
        public string Pesquisa { get; set; }
        public bool LocalizouResultado { set; get; }


    }
}
