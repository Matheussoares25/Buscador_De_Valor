using Newtonsoft.Json.Linq;

public class CotacaoService
{
    public async Task<(List<string[]> lista, decimal media)> BuscarCotacoes(Cotacao cota)
    {
        string dataini = cota.inicio.ToString("MM-dd-yyyy");
        string datafim = cota.fim.ToString("MM-dd-yyyy");
        string moeda = cota.moeda;

        //URL DA API BANCO CENTRAL
        //Minhas variaveis
        string url = $"https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/" +
                     $"CotacaoMoedaPeriodo(moeda='{moeda}',dataInicial='{dataini}',dataFinalCotacao='{datafim}')?&$format=json";

        using (HttpClient client = new HttpClient())
        {
            //REQUISIÇÂO GET
            //Para Api
            var response = await client.GetAsync(url);


            //TRANSFORMAR EM JSON
            //Retorno da Api transformado em json
            var json = await response.Content.ReadAsStringAsync();
            var obj = JObject.Parse(json);

            var valores = obj["value"];

            var lista = new List<string[]>();


            var filtrado = valores
             .GroupBy(x => DateTime.Parse(x["dataHoraCotacao"].ToString()).Date)
               .Select(g => g.OrderByDescending(x => DateTime.Parse(x["dataHoraCotacao"].ToString())).First())
                .ToList();

            decimal soma = 0;
            int conta = 0;

            foreach (var item in filtrado)
            {
                decimal venda = decimal.Parse(item["cotacaoVenda"].ToString());
                soma += venda;
                conta++;

                lista.Add(new string[]
                {
                    item["dataHoraCotacao"].ToString(),
                    item["cotacaoCompra"].ToString(),
                    item["cotacaoVenda"].ToString()
                });
            }

            decimal media = conta > 0 ? soma / conta : 0;



            return (lista, media);
        }
    }


}