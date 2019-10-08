using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfFileConverter
{

    [ServiceContract]
    public interface IFileConverterService
    {

        [OperationContract]
        FileModel ConvertToCSV(FileModel file);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class FileModel
    {

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Content { get; set; }
    }
}
