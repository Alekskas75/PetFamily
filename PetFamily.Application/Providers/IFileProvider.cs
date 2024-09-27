using CSharpFunctionalExtensions;

using PetFamily.Application.FileProviders;
using PetFamily.Domain.Shared;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PetFamily.Application.Providers
{
    public interface IFileProvider
    {
        public Task<Result<string, Error>> UploadFile(FileData fileData, CancellationToken cancellationToken = default);

        public Task<Result<string, Error>> DeleteFile(FileMetaData fileData, CancellationToken cancellationToken = default);

        public Task<Result<string, Error>> GetFileByName(FileMetaData fileData, CancellationToken cancellationToken = default);
    }
}
