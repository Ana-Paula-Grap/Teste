using Football;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class FootballStatisticsController : ControllerBase
{
    private const string ApiUrl = "https://jsonmock.hackerrank.com/api/football_matches";

    [HttpGet("goal-statistics")]
    public async Task<IActionResult> GetGoalStatisticsAsync(int year, string team)
    {
        try
        {
            using (HttpClient client = new HttpClient())
            {
                // Formatar a URL da API com os parâmetros necessários
                string apiUrl = $"{ApiUrl}?year={year}&team1={team}&team2={team}";

                // Fazer a requisição à API
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                // Ler os dados da resposta em formato JSON
                FootballMatch[] matches = await response.Content.ReadAsAsync<FootballMatch[]>();

                // Processar os dados e retornar o resultado
                return Ok(matches);
            }
        }
        catch (Exception ex)
        {
            // Tratar erros e retornar uma resposta de erro
            return StatusCode(500, $"Internal Server Error: {ex.Message}");
        }
    }
}
