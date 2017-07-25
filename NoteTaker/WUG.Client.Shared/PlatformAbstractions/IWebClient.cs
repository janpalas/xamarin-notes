using System;
using System.Threading.Tasks;

namespace WUG.Client.Shared.PlatformAbstractions
{
    public interface IWebClient
    {
        Task<string> GetStringAsync(Uri uri);
    }
}
