using System;
using System.Net.Http;
using System.Threading.Tasks;
using WUG.Client.Shared.PlatformAbstractions;

namespace WUG.Client.Droid.PlatformSpecific
{
    public class DroidHttpClient : IWebClient
    {
        private readonly HttpClient _client = new HttpClient();

        public async Task<string> GetStringAsync(Uri uri)
        {
            try
            {
                return await _client.GetStringAsync(uri);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}