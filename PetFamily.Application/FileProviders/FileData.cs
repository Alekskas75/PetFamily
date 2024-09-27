using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Application.FileProviders
{
    public record FileData(Stream Stream, FileMetaData FileMetaData);
}
