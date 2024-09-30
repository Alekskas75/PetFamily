using CSharpFunctionalExtensions;

using PetFamily.Application.FileProviders;
using PetFamily.Application.Providers;
using PetFamily.Domain.Shared;

namespace PetFamily.Infrastructure.Providers
{
    public class MinioProvider : IFileProvider
    {
        public Task<Result<string, Error>> DeleteFile(FileMetaData fileData, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string, Error>> GetFileByName(FileMetaData fileData, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Result<string, Error>> UploadFile(FileData fileData, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
