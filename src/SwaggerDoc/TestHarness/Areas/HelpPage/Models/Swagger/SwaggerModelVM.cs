using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestHarness.Areas.HelpPage.Models.Swagger
{

public class Oauth2
{
    public string scope { get; set; }
    public string description { get; set; }
}

public class Authorizations
{
    public List<Oauth2> oauth2 { get; set; }
}

public class Parameter
{
    public string name { get; set; }
    public string description { get; set; }
    public bool required { get; set; }
    public string type { get; set; }
    public string paramType { get; set; }
    public bool allowMultiple { get; set; }
    public string defaultValue { get; set; }
    public List<string> @enum { get; set; }
    public string format { get; set; }
    public string minimum { get; set; }
    public string maximum { get; set; }
}

public class ResponseMessage
{
    public int code { get; set; }
    public string message { get; set; }
}

public class Items
{
    public string type { get; set; }
}

public class Operation
{
    public string method { get; set; }
    public string summary { get; set; }
    public string notes { get; set; }
    public string type { get; set; }
    public string nickname { get; set; }
    public Authorizations authorizations { get; set; }
    public List<Parameter> parameters { get; set; }
    public List<ResponseMessage> responseMessages { get; set; }
    public List<string> consumes { get; set; }
    public Items items { get; set; } //???
    public string deprecated { get; set; } //"true", "false"
    public List<string> produces { get; set; }
}

public class Api
{
    public string path { get; set; }
    public List<Operation> operations { get; set; }
}

public class Id
{
    public string type { get; set; }
    public string format { get; set; }
}

public class Name
{
    public string type { get; set; }
}

public class Properties
{
    public Id id { get; set; }
    public Name name { get; set; }
}

public class Tag
{
    public string id { get; set; }
    public Properties properties { get; set; }
}

public class Id2
{
    public string type { get; set; }
    public string format { get; set; }
    public string description { get; set; }
    public string minimum { get; set; }
    public string maximum { get; set; }
}

public class Category
{
    [JsonProperty(PropertyName="$ref")]
    public string reference { get; set; }
}

public class Name2
{
    public string type { get; set; }
}


public class PhotoUrls
{
    public string type { get; set; }
    public Items items { get; set; }
}

public class Tags
{
    public string type { get; set; }
    public Items items { get; set; }
}

public class Status
{
    public string type { get; set; }
    public string description { get; set; }
    public List<string> @enum { get; set; }
}

public class Properties2
{
    public Id2 id { get; set; }
    public Category category { get; set; }
    public Name2 name { get; set; }
    public PhotoUrls photoUrls { get; set; }
    public Tags tags { get; set; }
    public Status status { get; set; }
}

public class Pet
{
    public string id { get; set; }
    public List<string> required { get; set; }
    public Properties2 properties { get; set; }
}

public class Id3
{
    public string type { get; set; }
    public string format { get; set; }
}

public class Name3
{
    public string type { get; set; }
}

public class Properties3
{
    public Id3 id { get; set; }
    public Name3 name { get; set; }
}

public class Category2
{
    public string id { get; set; }
    public Properties3 properties { get; set; }
}

public class Models
{
    public Tag Tag { get; set; }
    public Pet Pet { get; set; }
    public Category2 Category { get; set; }
}

public class SwaggerDocVm
{
    public string apiVersion { get; set; }
    public string swaggerVersion { get; set; }
    public string basePath { get; set; }
    public string resourcePath { get; set; }
    public List<string> produces { get; set; }
    public List<Api> apis { get; set; }
    public Models models { get; set; }
}

}