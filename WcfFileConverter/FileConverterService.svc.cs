using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfFileConverter
{
    public class FileConverterService : IFileConverterService
    {
        public FileModel ConvertToCSV(FileModel file)
        {
            var name = file.Name.Replace(".txt", ".csv");
            var content = file.Content
                .Replace("|", ";")
                .Replace(",", Environment.NewLine);
            return new FileModel
            {
                Name = name,
                Content = content
            };
        }
    }
}
