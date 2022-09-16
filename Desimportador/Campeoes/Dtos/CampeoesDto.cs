using System.Collections.Generic;

namespace Desimportador.Campeoes.Dtos
{
    public class CampeoesDto
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public int Custo { get; set; }
        public List<object> Caracteristica { get; set; }
    }
}