using Desimportador.Base;
using Desimportador.Filtros;
using Desimportador.Itens.Dtos;
using Desimportador.Itens.Mapper;
using System.Collections.Generic;
using System.Linq;

namespace Desimportador.Itens
{
    public class AplicItem
    {
        private string _url => "https://hexcore-api.herokuapp.com/";
        private string _set => "set7/";
        static readonly HttpHelper client = new HttpHelper();

        public void DesconverterItens()
        {
            var url = new string($"{_url}{_set}{EnumFiltro.Items}?");
            var content = client.GetAsync<List<ItemJsonDto>>(url);

            var listaItens = new MappearItens().MapearDto(content);

            new Exportador().Exportar(listaItens.Cast<object>().ToList(), EnumFiltro.Items);
        }
    }
}