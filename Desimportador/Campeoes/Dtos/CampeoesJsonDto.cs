using System.Collections.Generic;

namespace Desimportador.Campeoes.Dtos
{
    public class CampeoesJsonDto
    {
        public string id { get; set; }
        public string name { get; set; }
        public int cost { get; set; }
        public List<string> traits { get; set; }
    }
}