using acervo_hqs_frontend.Model;

namespace acervo_hqs_frontend.Services
{
    public class AcervoHQService
    {
        private readonly HttpClient _httpClient;

        public AcervoHQService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<EditoraModel>> GetAllEditoras()
        {
            var response = await _httpClient.GetAsync("https://localhost:7154/api/Editora/ObterTodasEditoras");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<EditoraModel>>();
        }
    }
}
