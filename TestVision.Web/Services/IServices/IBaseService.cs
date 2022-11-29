using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestVision.Web.Models;

namespace TestVision.Web.Services.IServices
{
    public interface IBaseService: IDisposable
    {
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
