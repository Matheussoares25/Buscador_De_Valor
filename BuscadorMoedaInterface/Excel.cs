using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Permissions;

namespace BuscadorMoedaInterface
{
    internal class Excel
    {

        /*
          public void GeraExcel(List<string[]> dados, decimal media)
        {

            

            using (var package = new ExcelPackage())
            {



                var sheet = package.Workbook.Worksheets.Add("Cotacao");

                sheet.Cells[1, 1].Value = "Data";
                sheet.Cells[1, 2].Value = "Compra";
                sheet.Cells[1, 3].Value = "Venda";
                sheet.Cells[1, 4].Value = "Media";

                int linha = 2;

                foreach (var item in dados)
                {
                    sheet.Cells[linha, 1].Value = item[0];
                    sheet.Cells[linha, 2].Value = item[1];
                    sheet.Cells[linha, 3].Value = item[2];
                    linha++;

                   
                }

                sheet.Cells[linha, 4].Value = media;


                string caminho = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                 "cotacoes.xlsx");

                File.WriteAllBytes(caminho, package.GetAsByteArray());

                
            }


        }
        */

        
        public void ProcessarExcel(List<string[]> dados, string moeda, string caminhoenv)
        {
            

            string caminho = Path.Combine(caminhoenv,"Cotações.xlsx");

            var fileInfo = new FileInfo(caminho);
            bool arquivoExiste = File.Exists(caminho);



            using (var package = arquivoExiste ? new ExcelPackage(fileInfo) : new ExcelPackage())
            {
                var sheet = package.Workbook.Worksheets["Cotacao"];

                if (sheet == null)
                {
                    sheet = package.Workbook.Worksheets.Add("Cotacao");

                    sheet.Cells[1, 1].Value = "Moeda";
                    sheet.Cells[1, 2].Value = "Data";
                    sheet.Cells[1, 3].Value = "Compra";
                    sheet.Cells[1, 4].Value = "Venda";
                    sheet.Cells[1, 5].Value = "Média";

                    var header = sheet.Cells[1, 1, 1, 5];
                    header.Style.Font.Bold = true;
                    header.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    header.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    header.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkSlateGray);
                    header.Style.Font.Color.SetColor(System.Drawing.Color.White);

                    header.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    header.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    header.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    header.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                }

                int linhaInicial = sheet.Dimension?.End.Row + 2 ?? 2;
                int linhaAtual = linhaInicial;

           
                    foreach (var item in dados)
                    {
                        sheet.Cells[linhaAtual, 1].Value = moeda;
                        sheet.Cells[linhaAtual, 2].Value = item[0];
                        sheet.Cells[linhaAtual, 3].Value = decimal.Parse(item[1]);
                        sheet.Cells[linhaAtual, 4].Value = decimal.Parse(item[2]);


                    sheet.Cells[ linhaAtual, 4].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    sheet.Cells[ linhaAtual, 4].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);


                    var linhaRange = sheet.Cells[linhaAtual, 1, linhaAtual, 5];

                    linhaRange.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    linhaRange.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    linhaRange.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    linhaRange.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;



                    linhaAtual++;
                    }

                    int linhaFinal = linhaAtual - 1;


                //FAÇO A MESCLAGEM DAS 3 LINHAS NA COLUNA 5
                sheet.Cells[linhaInicial, 5, linhaFinal, 5].Merge = true;

                //DEFINIR O RANGE ONDE MESCLO AS CELULAR COM A MEDIA
                var rangeMedia = sheet.Cells[linhaInicial, 5, linhaFinal, 5];

                //DEFINO A VARIAVEL PARA PODER TRATAR DE TUDO RELACIONADO AO RANGE (FORMLAS,ESTILIZAÇÂO)
                var cell = sheet.Cells[linhaInicial, 5];

                //FORMULA PARA CALCULAR MEDIA
                cell.Formula = $"AVERAGE(D{linhaInicial}:D{linhaFinal})";

                //ESTILIZAÇÂO DO CAMPO DE MEDIA
                cell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                cell.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                cell.Style.Font.Bold = true;

                rangeMedia.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                rangeMedia.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGoldenrodYellow);




                switch (moeda)
                {
                    case "USD":
                        rangeMedia.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        rangeMedia.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Beige);
                        break;
                    case "EUR":
                        rangeMedia.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        rangeMedia.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Aqua);
                        break;

                }




                if (arquivoExiste)
                    package.Save();


                else
                    package.SaveAs(fileInfo);

            }
        }
    }
    }

