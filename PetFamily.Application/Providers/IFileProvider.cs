using CSharpFunctionalExtensions;
using PetFamily.Application.FileProviders;
using PetFamily.Domain.Shared;

namespace PetFamily.Application.Providers
{
    public interface IFileProvider
    {
        public Task<Result<string, Error>> UploadFile(FileData fileData, CancellationToken cancellationToken = default);

        public Task<Result<string, Error>> DeleteFile(FileMetaData fileData, CancellationToken cancellationToken = default);

        public Task<Result<string, Error>> GetFileByName(FileMetaData fileData, CancellationToken cancellationToken = default);
    }
}
