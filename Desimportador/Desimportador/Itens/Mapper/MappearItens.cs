using Desimportador.Itens.Dtos;
using System.Collections.Generic;
using Desimportador.Itens.Dtos.Desimportador.Itens.Dtos;

namespace Desimportador.Itens.Mapper
{
    public class MappearItens : IMappearItens
    {
        public List<ItemDto> MapearDto(List<ItemJsonDto> content)
        {
            var listaItens = new List<ItemDto>();

            content.ForEach(p =>
            {
                var item = new ItemDto
                {
                    Id = p.Id,
                    Nome = p.name,
                    Descricao = p.description,
                    Unico = p.isUnique,
                    Artefato = p.isArtifact,
                    Escamaluz = p.isElusive,
                    ItemForja = p.isRadiant,
                    BonusForja = p.radiantBonus
                };
            });

            return listaItens;
        }
    }
}
