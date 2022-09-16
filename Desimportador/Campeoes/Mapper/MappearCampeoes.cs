using System.Collections.Generic;
using Desimportador.Campeoes.Dtos;
using System.Linq;

namespace Desimportador.Campeoes.Mapper
{
    public class MappearCampeoes
    {
        public List<CampeoesDto> MapearDto(List<CampeoesJsonDto> content)
        {
            var listaCampeoes = new List<CampeoesDto>();

            content.ForEach(p =>
            {
                var campeao = new CampeoesDto
                {
                    Id = p.id,
                    Nome = p.name,
                    Custo = p.cost,
                    Caracteristica = p.traits.Cast<object>().ToList()
                };

                listaCampeoes.Add(campeao);
            });

            return listaCampeoes;
        }
    }
}