using ClosedXML.Excel;
using Desimportador.Itens.Dtos.Desimportador.Itens.Dtos;
using System;
using System.Collections.Generic;
using System.IO;

namespace Desimportador.Itens.Exportadores
{
    public class Exportador
    {
        public void ExportarItens(List<ItemDto> dto)
        {
            var pathName = @"D:\Vinicius\Tft\\PlanilhaTft.xlsx";
            if (File.Exists(pathName))
                File.Delete(pathName);

            var workbook = new XLWorkbook();

            var planilha = workbook.Worksheets.Add("Itens");
            GerarCabeçalhoItem(planilha);
            var linha = 2;

            dto.ForEach(item => 
            {
                planilha.Cell("A" + linha).Value = item.Id;
                planilha.Cell("B" + linha).Value = item.Nome;
                planilha.Cell("C" + linha).Value = item.Descricao;
                planilha.Cell("D" + linha).Value = Convert.ToInt32(item.Unico);
                planilha.Cell("E" + linha).Value = Convert.ToInt32(item.Artefato);
                planilha.Cell("F" + linha).Value = Convert.ToInt32(item.Escamaluz);
                planilha.Cell("G" + linha).Value = Convert.ToInt32(item.ItemForja);
                planilha.Cell("H" + linha).Value = item.BonusForja;

                linha++;
            });

            workbook.SaveAs(pathName);
        }

        #region GerarCabeçalhoItem
        public void GerarCabeçalhoItem(IXLWorksheet worksheet)
        {
            var nomes = typeof(ItemDto).GetProperties();
            var i = 1;
            foreach (var nome in nomes)
            {
                worksheet.Cell(TransformarNumeroAlfabeto(i) + "1").Value = nome.Name;
                i++;
            }
        } 
        #endregion

        #region TransformarNumeroAlfabeto
        public string TransformarNumeroAlfabeto(int id)
        {
            switch (id)
            {
                case 1:
                    return "A";
                case 2:
                    return "B";
                case 3:
                    return "C";
                case 4:
                    return "D";
                case 5:
                    return "E";
                case 6:
                    return "F";
                case 7:
                    return "G";
                case 8:
                    return "H";
                case 9:
                    return "I";
                case 10:
                    return "J";
                case 11:
                    return "K";
                case 12:
                    return "L";
                case 13:
                    return "M";
                case 14:
                    return "N";
                case 15:
                    return "O";
                case 16:
                    return "P";
                case 17:
                    return "Q";
                case 18:
                    return "R";
                case 19:
                    return "S";
                case 20:
                    return "T";
                case 21:
                    return "U";
                case 22:
                    return "V";
                case 23:
                    return "W";
                case 24:
                    return "X";
                case 25:
                    return "Y";
                case 26:
                    return "Z";
                default:
                    throw new Exception($"Não foi encontrado letra referente ao número {id}");
            }
        } 
        #endregion
    }
}
