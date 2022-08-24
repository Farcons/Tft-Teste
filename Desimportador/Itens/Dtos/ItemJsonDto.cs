namespace Desimportador.Itens.Dtos
{
    public class ItemJsonDto
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool isArtifact { get; set; }
        public bool isUnique { get; set; }
        public bool isElusive { get; set; }
        public bool isRadiant { get; set; }
        public string radiantBonus { get; set; }
    }
}