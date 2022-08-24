using Desimportador.Itens.Dtos;
using Desimportador.Itens.Dtos.Desimportador.Itens.Dtos;
using System.Collections.Generic;

namespace Desimportador.Itens.Mapper
{
    public interface IMappearItens
    {
        List<ItemDto> MapearDto(List<ItemJsonDto> content);
    }
}