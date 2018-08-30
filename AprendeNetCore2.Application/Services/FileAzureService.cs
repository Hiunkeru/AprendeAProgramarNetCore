using AprendeNetCore2.Services.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeNetCore2.Application.Services
{
    public class FileAzureService : IFileAzureService
    {

        private readonly IConfiguration _configuration;

        public FileAzureService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> GetText()
        {

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(_configuration.GetConnectionString("StorageAccount"));

            CloudFileClient fileClient = storageAccount.CreateCloudFileClient();

            CloudFileShare share = fileClient.GetShareReference(_configuration.GetSection("FileConfig:Folder").Value);

            if(await share.ExistsAsync())
            {
                CloudFileDirectory rootDir = share.GetRootDirectoryReference();

                CloudFile file = rootDir.GetFileReference(_configuration.GetSection("FileConfig:Filename").Value);

                if(await file.ExistsAsync())
                {
                    var result = file.DownloadTextAsync().Result;

                }
                
            }

            return string.Empty;
        }

    }
}
