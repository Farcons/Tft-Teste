using Desimportador.Base;
using Desimportador.Filtros;
using Desimportador.Itens.Dtos;
using Desimportador.Itens.Mapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desimportador.Itens
{
    public class AplicItem
    {
        private string _url => "https://hexcore-api.herokuapp.com/";
        private string _set => "set7/";
        static readonly HttpHelper client = new HttpHelper();
        private readonly IMappearItens _mappearItens;

        public AplicItem(IMappearItens mappearItens)
        {
            _mappearItens = mappearItens;
        }

        public void DesconverterItens()
        {
            var url = new string($"{_url}{_set}{EnumFiltro.Items}?");
            var content = client.GetAsync<List<ItemJsonDto>>(url);

            var listaItens = _mappearItens.MapearDto(content);


        }
    }
}
