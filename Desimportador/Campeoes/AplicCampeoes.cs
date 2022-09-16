using Desimportador.Base;
using Desimportador.Campeoes.Dtos;
using Desimportador.Campeoes.Mapper;
using Desimportador.Filtros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desimportador.Campeoes
{
    public class AplicCampeoes
    {
        private string _url => "https://hexcore-api.herokuapp.com/";
        private string _set => "set7/";
        static readonly HttpHelper client = new HttpHelper();

        public void DesconverterItens()
        {
            var url = new string($"{_url}{_set}{EnumFiltro.Champions}?");
            var content = client.GetAsync<List<CampeoesJsonDto>>(url);

            var listaCampeoes = new MappearCampeoes().MapearDto(content);

            new Exportador().Exportar(listaCampeoes.Cast<object>().ToList(), EnumFiltro.Champions);
        }
    }
}
