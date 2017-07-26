using System;
using System.Threading.Tasks;
using WUG.Client.Forms.Droid.PlatformSpecific;
using WUG.Client.Shared.PlatformAbstractions;

[assembly: Xamarin.Forms.Dependency(typeof(HttpClient))]
namespace WUG.Client.Forms.Droid.PlatformSpecific
{
    
    public class HttpClient : IWebClient
    {
        public async Task<string> GetStringAsync(Uri uri)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                return await client.GetStringAsync(uri);
            }
        }
    }
}