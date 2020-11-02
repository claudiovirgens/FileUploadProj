using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUploadProj.Models
{
    public class FileUploadViewModel
    {
        public List<FileOnFileSystemModel> FileOnFileSystem { get; set; }
        public List<FileOnDatabaseModel> FileOnDatabaseModel { get; set; }
    }
}
