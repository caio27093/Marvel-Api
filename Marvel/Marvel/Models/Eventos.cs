using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class Eventos
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Urls
    {
        [JsonProperty ( "type" )]
        public string Type { get; set; }

        [JsonProperty ( "url" )]
        public string Url { get; set; }
    }

    public class Thumbnail
    {
        [JsonProperty ( "path" )]
        public string Path { get; set; }

        [JsonProperty ( "extension" )]
        public string Extension { get; set; }
    }

    public class Item
    {
        [JsonProperty ( "resourceURI" )]
        public string ResourceURI { get; set; }

        [JsonProperty ( "name" )]
        public string Name { get; set; }

        [JsonProperty ( "role" )]
        public string Role { get; set; }

        [JsonProperty ( "type" )]
        public string Type { get; set; }
    }

    public class Creators
    {
        [JsonProperty ( "available" )]
        public int Available { get; set; }

        [JsonProperty ( "collectionURI" )]
        public string CollectionURI { get; set; }

        [JsonProperty ( "items" )]
        public List<Item> Items { get; set; }

        [JsonProperty ( "returned" )]
        public int Returned { get; set; }
    }

    public class Characters
    {
        [JsonProperty ( "available" )]
        public int Available { get; set; }

        [JsonProperty ( "collectionURI" )]
        public string CollectionURI { get; set; }

        [JsonProperty ( "items" )]
        public List<Item> Items { get; set; }

        [JsonProperty ( "returned" )]
        public int Returned { get; set; }
    }

    public class Stories
    {
        [JsonProperty ( "available" )]
        public int Available { get; set; }

        [JsonProperty ( "collectionURI" )]
        public string CollectionURI { get; set; }

        [JsonProperty ( "items" )]
        public List<Item> Items { get; set; }

        [JsonProperty ( "returned" )]
        public int Returned { get; set; }
    }

    public class Comics
    {
        [JsonProperty ( "available" )]
        public int Available { get; set; }

        [JsonProperty ( "collectionURI" )]
        public string CollectionURI { get; set; }

        [JsonProperty ( "items" )]
        public List<Item> Items { get; set; }

        [JsonProperty ( "returned" )]
        public int Returned { get; set; }
    }

    public class Series
    {
        [JsonProperty ( "available" )]
        public int Available { get; set; }

        [JsonProperty ( "collectionURI" )]
        public string CollectionURI { get; set; }

        [JsonProperty ( "items" )]
        public List<Item> Items { get; set; }

        [JsonProperty ( "returned" )]
        public int Returned { get; set; }
    }

    public class Next
    {
        [JsonProperty ( "resourceURI" )]
        public string ResourceURI { get; set; }

        [JsonProperty ( "name" )]
        public string Name { get; set; }
    }

    public class Previous
    {
        [JsonProperty ( "resourceURI" )]
        public string ResourceURI { get; set; }

        [JsonProperty ( "name" )]
        public string Name { get; set; }
    }

    public class Result
    {
        [JsonProperty ( "id" )]
        public int Id { get; set; }

        [JsonProperty ( "title" )]
        public string Title { get; set; }

        [JsonProperty ( "description" )]
        public string Description { get; set; }

        [JsonProperty ( "resourceURI" )]
        public string ResourceURI { get; set; }

        [JsonProperty ( "urls" )]
        public List<Urls> Urls { get; set; }

        [JsonProperty ( "modified" )]
        public DateTime Modified { get; set; }

        [JsonProperty ( "start" )]
        public string Start { get; set; }

        [JsonProperty ( "end" )]
        public string End { get; set; }

        [JsonProperty ( "thumbnail" )]
        public Thumbnail Thumbnail { get; set; }

        [JsonProperty ( "creators" )]
        public Creators Creators { get; set; }

        [JsonProperty ( "characters" )]
        public Characters Characters { get; set; }

        [JsonProperty ( "stories" )]
        public Stories Stories { get; set; }

        [JsonProperty ( "comics" )]
        public Comics Comics { get; set; }

        [JsonProperty ( "series" )]
        public Series Series { get; set; }

        [JsonProperty ( "next" )]
        public Next Next { get; set; }

        [JsonProperty ( "previous" )]
        public Previous Previous { get; set; }
    }

    public class Data
    {
        [JsonProperty ( "offset" )]
        public int Offset { get; set; }

        [JsonProperty ( "limit" )]
        public int Limit { get; set; }

        [JsonProperty ( "total" )]
        public int Total { get; set; }

        [JsonProperty ( "count" )]
        public int Count { get; set; }

        [JsonProperty ( "results" )]
        public List<Result> Results { get; set; }
    }

    public class Root
    {
        [JsonProperty ( "code" )]
        public int Code { get; set; }

        [JsonProperty ( "status" )]
        public string Status { get; set; }

        [JsonProperty ( "copyright" )]
        public string Copyright { get; set; }

        [JsonProperty ( "attributionText" )]
        public string AttributionText { get; set; }

        [JsonProperty ( "attributionHTML" )]
        public string AttributionHTML { get; set; }

        [JsonProperty ( "etag" )]
        public string Etag { get; set; }

        [JsonProperty ( "data" )]
        public Data Data { get; set; }
    }


}
