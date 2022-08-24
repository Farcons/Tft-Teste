using System.ComponentModel;

namespace Desimportador.Itens.Dtos.Enums
{
    public enum EnumFiltro
    {
        [Description("Champions")]
        Champions = 0,
        [Description("Traits")]
        Traits = 1,
        [Description("Items")]
        Items = 2,
        [Description("Images")]
        Images = 3
    }
}