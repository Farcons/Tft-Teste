using Desimportador.Itens;
using Desimportador.Itens.Mapper;
using System;

namespace Desimportador
{
    public class Program
    {
        static void Main()
        {
            SequenceItens();
        }

        private static void SequenceItens()
        {
            new AplicItem().DesconverterItens();
        }
    }
}