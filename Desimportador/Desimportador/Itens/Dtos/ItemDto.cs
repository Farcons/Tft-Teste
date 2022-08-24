namespace Desimportador.Itens.Dtos
{
    namespace Desimportador.Itens.Dtos
    {
        public class ItemDto
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public bool Unico { get; set; }
            public bool Artefato { get; set; }
            public bool Escamaluz { get; set; }
            public bool ItemForja { get; set; }
            public string BonusForja { get; set; }
        }
    }
}