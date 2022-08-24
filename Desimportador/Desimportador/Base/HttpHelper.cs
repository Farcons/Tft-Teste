using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Desimportador.Base
{
    public class HttpHelper
    {
        public T GetAsync<T>(string url)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = client.GetAsync(url).Result;

                    if (!response.IsSuccessStatusCode)
                        throw new Exception("Erro ao tentar recuperar dados da url." + response.Content);

                    try
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<T>(content);
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Erro ao tentar converter o response. "  + e.Message);
                    }
                }
            }
            catch (TimeoutException)
            {
                throw new Exception("Ocorreu um problema na comunicação, verifique a conexão com a internet.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}