using ClosedXML.Excel;
using Desimportador.Itens.Dtos.Desimportador.Itens.Dtos;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

namespace Desimportador.Itens.Exportadores
{
    public class Exportador
    {
        public void ExportarItens(List<ItemDto> dto)
        {
            var workbook = new XLWorkbook();

            var planilha = workbook.Worksheets.Add("Itens");

            
        }

        public void GerarCabeçalhoItem(IXLWorksheet worksheet)
        {
            var nomes = typeof(ItemDto).GetProperties();

            foreach (var nome in nomes)
            {
                worksheet.Cell("").Value = nome.Name;
            }

            
        }
    }
}
