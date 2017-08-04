using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace UserSync.Models
{
    public class MsGraphDrive
    {
        public Createdby createdBy { get; set; }
        public DateTime createdDateTime { get; set; }
        public string eTag { get; set; }
        public string id { get; set; }
        public Lastmodifiedby lastModifiedBy { get; set; }
        public DateTime lastModifiedDateTime { get; set; }
        public string name { get; set; }
        public Parentreference parentReference { get; set; }
        public string webUrl { get; set; }
        public string cTag { get; set; }
        public Filesysteminfo fileSystemInfo { get; set; }
        public Folder folder { get; set; }
        public int size { get; set; }
        public Specialfolder specialFolder { get; set; }
        public string microsoftgraphdownloadUrl { get; set; }
        public File file { get; set; }
        public Image image { get; set; }
    }

    public class Createdby
    {
        public User user { get; set; }
        public Application application { get; set; }
    }

    public class User
    {
        public string id { get; set; }
        public string displayName { get; set; }
    }

    public class Application
    {
        public string id { get; set; }
        public string displayName { get; set; }
    }

    public class Lastmodifiedby
    {
        public User1 user { get; set; }
        public Application1 application { get; set; }
    }

    public class User1
    {
        public string id { get; set; }
        public string displayName { get; set; }
    }

    public class Application1
    {
        public string id { get; set; }
        public string displayName { get; set; }
    }

    public class Parentreference
    {
        public string driveId { get; set; }
        public string id { get; set; }
        public string path { get; set; }
    }

    public class Filesysteminfo
    {
        public DateTime createdDateTime { get; set; }
        public DateTime lastModifiedDateTime { get; set; }
    }

    public class Folder
    {
        public int childCount { get; set; }
    }

    public class Specialfolder
    {
        public string name { get; set; }
    }

    public class File
    {
        public Hashes hashes { get; set; }
    }

    public class Hashes
    {
        public string quickXorHash { get; set; }
    }

    public class Image
    {
    }

    public class MsGraphDriveListResponse
    {
        [JsonProperty(PropertyName = "@odata.context")]
        public string context { get; set; }
        public List<MsGraphDrive> value { get; set; }
    }
}