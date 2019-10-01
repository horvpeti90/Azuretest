using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azuretestproject.Services
{
    public interface IImageService
    {
        Task<CloudBlobContainer> GetBlobContainer();
        Task UploadAsync(IFormFileCollection files);
    }
}
