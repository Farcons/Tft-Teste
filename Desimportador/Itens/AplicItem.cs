using Desimportador.Base;
using Desimportador.Itens.Dtos;
using Desimportador.Itens.Dtos.Enums;
using Desimportador.Itens.Exportadores;
using Desimportador.Itens.Mapper;
using System.Collections.Generic;

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

            new Exportador().ExportarItens(listaItens);
        }
    }
}