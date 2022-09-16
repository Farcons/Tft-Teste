using ClosedXML.Excel;
using Desimportador.Campeoes.Dtos;
using Desimportador.Filtros;
using Desimportador.Itens.Dtos.Desimportador.Itens.Dtos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Desimportador.Base
{
    public class Exportador
    {
        public void Exportar(List<object> dto, EnumFiltro filtro)
        {
            var pathName = @"D:\Vinicius\Tft\\PlanilhaTft.xlsx";
            var workbook = new XLWorkbook();

            if (File.Exists(pathName))
                workbook = new XLWorkbook(pathName);

            switch (filtro)
            {
                case EnumFiltro.Champions:
                    var champ = dto.Cast<CampeoesDto>().ToList();
                    ExportarCampeoes(workbook, champ);
                    break;
                case EnumFiltro.Traits:
                    break;
                case EnumFiltro.Items:
                    var itemDto = dto.Cast<ItemDto>().ToList();
                    ExportarItens(workbook, itemDto);
                    break;
                case EnumFiltro.Images:
                    break;
                default:
                    break;
            }

            workbook.SaveAs(pathName);
        }

        #region ExportarItens
        private void ExportarItens(XLWorkbook planilha, List<ItemDto> dto)
        {
            if (planilha.Worksheets.Contains("Itens"))
                planilha.Worksheets.Delete("Itens");

            var sheet = planilha.Worksheets.Add("Itens");

            new FuncoesBase().GerarCabeçalhoPlanilha<ItemDto>(sheet);
            var linha = 2;

            dto.ForEach(item =>
            {
                sheet.Cell("A" + linha).Value = item.Id;
                sheet.Cell("B" + linha).Value = item.Nome;
                sheet.Cell("C" + linha).Value = item.Descricao;
                sheet.Cell("D" + linha).Value = Convert.ToInt32(item.Unico);
                sheet.Cell("E" + linha).Value = Convert.ToInt32(item.Artefato);
                sheet.Cell("F" + linha).Value = Convert.ToInt32(item.Escamaluz);
                sheet.Cell("G" + linha).Value = Convert.ToInt32(item.ItemForja);
                sheet.Cell("H" + linha).Value = item.BonusForja;

                linha++;
            });
        }
        #endregion

        #region ExportarCampeoes
        private void ExportarCampeoes(XLWorkbook planilha, List<CampeoesDto> dto)
        {
            if (planilha.Worksheets.Contains("Campeões"))
                planilha.Worksheets.Delete("Campeões");

            var sheet = planilha.Worksheets.Add("Campeões");

            new FuncoesBase().GerarCabeçalhoPlanilha<CampeoesDto>(sheet);
            var linha = 2;

            dto.ForEach(champ =>
            {
                sheet.Cell("A" + linha).Value = champ.Id;
                sheet.Cell("B" + linha).Value = champ.Nome;
                sheet.Cell("C" + linha).Value = champ.Custo;

                linha++;
            });
        }
        #endregion
    }
}
