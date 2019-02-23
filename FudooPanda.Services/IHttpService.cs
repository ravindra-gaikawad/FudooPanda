using FudooPanda.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FudooPanda.Services
{
    public interface IHttpService
    {
        Task<ResponseModel> Post<T>(string relativeUrl, T model);

        Task<string> Get(string relativeUrl);

        Task<ResponseModel> Put<T>(string relativeUrl, T model);

        Task<ResponseModel> Delete(string relativeUrl);
    }
}
