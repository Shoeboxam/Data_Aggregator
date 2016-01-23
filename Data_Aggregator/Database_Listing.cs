using System;
using System.Collections.Generic;

using Newtonsoft.Json;

//Class structure to deserialize query results into
namespace Data_Aggregator
{
    public class Database_Listing
    {
        public string help { get; set; }
        public Boolean success { get; set; }
        public Result_Parent result { get; set; }

    }

    public class Result_Parent
    {
        public int count { get; set; }
        public List<Result_Child> results { get; set; }
    }

    public class Result_Child
    {
        public string owner_org { get; set; }
        public string maintainer { get; set; }
        public List<int> relationships_as_object { get; set; }
        public Boolean _private { get; set; }
        public string maintainer_email { get; set; }
        public int num_tags { get; set; }
        public string id { get; set; }
        public string metadata_created { get; set; }
        public string metadata_modified { get; set; }
        public string author { get; set; }
        public string author_email { get; set; }
        public string state { get; set; }
        public string version { get; set; }
        public string license_id { get; set; }
        public string type { get; set; }
        [JsonProperty("resources")]
        public List<Resources> resources { get; set; }
        public int num_resources { get; set; }
        public List<Tag> tags { get; set; }
        public string title { get; set; }
        public Dictionary<string, int> tracking_summary { get; set; }
        public List<Groups> groups { get; set; }
        public List<int> relationships_as_subject { get; set; }
        public string revision_timestamp { get; set; }
        public string name { get; set; }
        public Boolean isopen { get; set; }
        public string url { get; set; }
        public string notes { get; set; }
        public string license_title { get; set; }
        public List<Extra> extras { get; set; }
        public Dictionary<string, string> organization { get; set; }
        public string revision_id { get; set; }

    }

    public class Tag
    {
        public string vocabulary_id { get; set; }
        public string display_name { get; set; }
        public string name { get; set; }
        public string revision_timestamp { get; set; }
        public string state { get; set; }
        public string id { get; set; }
    }

    public class Resources
    {
        public string resource_group_id { get; set; }
        public string cache_last_updated { get; set; }
        public string revision_timestamp { get; set; }
        public string webstore_last_updated { get; set; }
        public string id { get; set; }
        public string size { get; set; }
        public string state { get; set; }
        public string hash { get; set; }
        public string description { get; set; }
        public string format { get; set; }
        public Dictionary<string, int> tracking_summary { get; set; }
        public string mimetype_inner { get; set; }
        public string mimetype { get; set; }
        public string cache_url { get; set; }
        public string name { get; set; }
        public string created { get; set; }
        public string url { get; set; }
        public string webstore_url { get; set; }
        public string last_modified { get; set; }
        public int position { get; set; }
        public string revision_id { get; set; }
        public string resource_type { get; set; }
    }
    public class Groups
    {
        public string capacity { get; set; }
        public string description { get; set; }
        public string created { get; set; }
        public string title { get; set; }
        public string name { get; set; }
        public Boolean is_organization { get; set; }
        public string state { get; set; }
        public string image_url { get; set; }
        public string revision_id { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public string approval_status { get; set; }
    }

    public class Extra
    {
        public string key { get; set; }
        public object value { get; set; }
        public string state { get; set; }
        public string package_id { get; set; }
        public string revision_timestamp { get; set; }
        public string revision_id { get; set; }
        public string id { get; set; }
    }
}
