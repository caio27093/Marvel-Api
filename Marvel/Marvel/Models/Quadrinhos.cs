using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

public class Quadrinhos
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    [DataContract ( Name = "textObject" )]
    private class TextObject
    {
        private string type ;
        private string language ;
        private string text ;
        [JsonProperty( "type" )]
        public string Type { get => type; set => type = value; }
        [JsonProperty ( "language" )]
        public string Language { get => language; set => language = value; }
        [JsonProperty ( "text" )]
        public string Text { get => text; set => text = value; }
    }

    [DataContract ( Name = "url" )]
    private class Url
    {
        private string type ;
        private string url ;

        [JsonProperty ( "type" )]
        public string Type { get => type; set => type = value; }
        [JsonProperty ( "url" )]
        public string Urls { get => url; set => url = value; }
    }

    [DataContract ( Name = "series" )]
    private class Series
    {
        private string resourceURI ;
        private string name ;

        [JsonProperty ( "resourceURI" )]
        public string ResourceURI { get => resourceURI; set => resourceURI = value; }
        [JsonProperty ( "name" )]
        public string Name { get => name; set => name = value; }
    }

    [DataContract ( Name = "variant" )]
    private class Variant
    {
        private string resourceURI ;
        private string name ;

        [JsonProperty ( "resourceURI" )]
        public string ResourceURI { get => resourceURI; set => resourceURI = value; }
        [JsonProperty ( "name" )]
        public string Name { get => name; set => name = value; }
    }

    [DataContract ( Name = "collectedIssue" )]
    private class CollectedIssue
    {
        private string resourceURI ;
        private string name ;

        public string ResourceURI { get => resourceURI; set => resourceURI = value; }
        public string Name { get => name; set => name = value; }
    }

    [DataContract ( Name = "dates" )]
    private class Dates
    {
        private string type ;
        private object date ;

        [JsonProperty ( "type" )]
        public string Type { get => type; set => type = value; }
        [JsonProperty ( "date" )]
        public object Date { get => date; set => date = value; }
    }

    [DataContract ( Name = "price" )]
    private class Price
    {
        private string type ;
        private double price ;

        [JsonProperty ( "type" )]
        public string Type { get => type; set => type = value; }
        [JsonProperty ( "price" )]
        public double Prices { get => price; set => price = value; }
    }

    [DataContract ( Name = "thumbnail" )]
    private class Thumbnail
    {
        private string path ;
        private string extension ;

        [JsonProperty ( "path" )]
        public string Path { get => path; set => path = value; }
        [JsonProperty ( "extension" )]
        public string Extension { get => extension; set => extension = value; }
    }

    [DataContract ( Name = "image" )]
    private class Image
    {
        private string path ;
        private string extension ;

        [JsonProperty ( "path" )]
        public string Path { get => path; set => path = value; }
        [JsonProperty ( "extension" )]
        public string Extension { get => extension; set => extension = value; }
    }

    [DataContract ( Name = "items" )]
    private class Item
    {
        private string resourceURI ;
        private string name ;
        private string role ;
        private string type ;

        [JsonProperty ( "resourceURI" )]
        public string ResourceURI { get => resourceURI; set => resourceURI = value; }
        [JsonProperty ( "name" )]
        public string Name { get => name; set => name = value; }
        [JsonProperty ( "role" )]
        public string Role { get => role; set => role = value; }
        [JsonProperty ( "type" )]
        public string Type { get => type; set => type = value; }
    }

    [DataContract ( Name = "creators" )]
    private class Creators
    {
        private int available ;
        private string collectionURI ;
        private List<Item> items ;
        private int returned ;

        [JsonProperty ( "available" )]
        public int Available { get => available; set => available = value; }
        [JsonProperty ( "collectionURI" )]
        public string CollectionURI { get => collectionURI; set => collectionURI = value; }
        [JsonProperty ( "returned" )]
        public int Returned { get => returned; set => returned = value; }
        [JsonProperty ( "items" )]
        private List<Item> Items { get => items; set => items = value; }
    }

    [DataContract ( Name = "characters" )]
    private class Characters
    {
        private int available ;
        private string collectionURI ;
        private List<Item> items ;
        private int returned ;

        [JsonProperty ( "available" )]
        public int Available { get => available; set => available = value; }
        [JsonProperty ( "collectionURI" )]
        public string CollectionURI { get => collectionURI; set => collectionURI = value; }
        [JsonProperty ( "returned" )]
        public int Returned { get => returned; set => returned = value; }
        [JsonProperty ( "items" )]
        private List<Item> Items { get => items; set => items = value; }
    }

    [DataContract ( Name = "stories" )]
    private class Stories
    {
        private int available ;
        private string collectionURI ;
        private List<Item> items ;
        private int returned ;

        [JsonProperty ( "available" )]
        public int Available { get => available; set => available = value; }
        [JsonProperty ( "collectionURI" )]
        public string CollectionURI { get => collectionURI; set => collectionURI = value; }
        [JsonProperty ( "returned" )]
        public int Returned { get => returned; set => returned = value; }
        [JsonProperty ( "items" )]
        private List<Item> Items { get => items; set => items = value; }
    }

    [DataContract ( Name = "events" )]
    private class Events
    {
        private int available ;
        private string collectionURI ;
        private List<object> items ;
        private int returned ;

        [JsonProperty ( "available" )]
        public int Available { get => available; set => available = value; }
        [JsonProperty ( "collectionURI" )]
        public string CollectionURI { get => collectionURI; set => collectionURI = value; }
        [JsonProperty ( "items" )]
        public List<object> Items { get => items; set => items = value; }
        [JsonProperty ( "returned" )]
        public int Returned { get => returned; set => returned = value; }
    }

    [DataContract ( Name = "result" )]
    private class Result
    {
        private int id ;
        private int digitalId ;
        private string title ;
        private int issueNumber ;
        private string variantDescription ;
        private string description ;
        private object modified ;
        private string isbn ;
        private string upc ;
        private string diamondCode ;
        private string ean ;
        private string issn ;
        private string format ;
        private int pageCount ;
        private List<TextObject> textObjects ;
        private string resourceURI ;
        private List<Url> urls ;
        private Series series ;
        private List<Variant> variants ;
        private List<object> collections ;
        private List<CollectedIssue> collectedIssues ;
        private List<Dates> dates ;
        private List<Price> prices ;
        private Thumbnail thumbnail ;
        private List<Image> images ;
        private Creators creators ;
        private Characters characters ;
        private Stories stories ;
        private Events events ;

        [JsonProperty ( "id" )]
        public int Id { get => id; set => id = value; }
        [JsonProperty ( "digitalId" )]
        public int DigitalId { get => digitalId; set => digitalId = value; }
        [JsonProperty ( "title" )]
        public string Title { get => title; set => title = value; }
        [JsonProperty ( "issueNumber" )]
        public int IssueNumber { get => issueNumber; set => issueNumber = value; }
        [JsonProperty ( "variantDescription" )]
        public string VariantDescription { get => variantDescription; set => variantDescription = value; }
        [JsonProperty ( "description" )]
        public string Description { get => description; set => description = value; }
        [JsonProperty ( "modified" )]
        public object Modified { get => modified; set => modified = value; }
        [JsonProperty ( "isbn" )]
        public string Isbn { get => isbn; set => isbn = value; }
        [JsonProperty ( "upc" )]
        public string Upc { get => upc; set => upc = value; }
        [JsonProperty ( "diamondCode" )]
        public string DiamondCode { get => diamondCode; set => diamondCode = value; }
        [JsonProperty ( "ean" )]
        public string Ean { get => ean; set => ean = value; }
        [JsonProperty ( "issn" )]
        public string Issn { get => issn; set => issn = value; }
        [JsonProperty ( "format" )]
        public string Format { get => format; set => format = value; }
        [JsonProperty ( "pageCount" )]
        public int PageCount { get => pageCount; set => pageCount = value; }
        [JsonProperty ( "resourceURI" )]
        public string ResourceURI { get => resourceURI; set => resourceURI = value; }
        [JsonProperty ( "collections" )]
        public List<object> Collections { get => collections; set => collections = value; }
        [JsonProperty ( "textObjects" )]
        private List<TextObject> TextObjects { get => textObjects; set => textObjects = value; }
        [JsonProperty ( "urls" )]
        private List<Url> Urls { get => urls; set => urls = value; }
        [JsonProperty ( "series" )]
        private Series Series { get => series; set => series = value; }
        [JsonProperty ( "variants" )]
        private List<Variant> Variants { get => variants; set => variants = value; }
        [JsonProperty ( "collectedIssues" )]
        private List<CollectedIssue> CollectedIssues { get => collectedIssues; set => collectedIssues = value; }
        [JsonProperty ( "dates" )]
        private List<Dates> Dates { get => dates; set => dates = value; }
        [JsonProperty ( "prices" )]
        private List<Price> Prices { get => prices; set => prices = value; }
        [JsonProperty ( "thumbnail" )]
        private Thumbnail Thumbnail { get => thumbnail; set => thumbnail = value; }
        [JsonProperty ( "images" )]
        private List<Image> Images { get => images; set => images = value; }
        [JsonProperty ( "creators" )]
        private Creators Creators { get => creators; set => creators = value; }
        [JsonProperty ( "characters" )]
        private Characters Characters { get => characters; set => characters = value; }
        [JsonProperty ( "stories" )]
        private Stories Stories { get => stories; set => stories = value; }
        [JsonProperty ( "events" )]
        private Events Events { get => events; set => events = value; }
    }

    [DataContract ( Name = "data" )]
    private class Data
    {
        private int offset ;
        private int limit ;
        private int total ;
        private int count ;
        private List<Result> results ;

        [JsonProperty ( "offset" )]
        public int Offset { get => offset; set => offset = value; }

        [JsonProperty ( "limit" )]
        public int Limit { get => limit; set => limit = value; }
        [JsonProperty ( "total" )]
        public int Total { get => total; set => total = value; }
        [JsonProperty ( "count" )]
        public int Count { get => count; set => count = value; }
        [JsonProperty ( "results" )]
        private List<Result> Results { get => results; set => results = value; }
    }

    private int code ;
    private string status ;
    private string copyright ;
    private string attributionText ;
    private string attributionHTML ;
    private string etag ;
    private Data data ;

    [JsonProperty ( "code" )]
    public int Code { get => code; set => code = value; }
    [JsonProperty ( "status" )]
    public string Status { get => status; set => status = value; }

    [JsonProperty ( "copyright" )]
    public string Copyright { get => copyright; set => copyright = value; }
    [JsonProperty ( "attributionText" )]
    public string AttributionText { get => attributionText; set => attributionText = value; }
    [JsonProperty ( "attributionHTML" )]
    public string AttributionHTML { get => attributionHTML; set => attributionHTML = value; }
    [JsonProperty ( "etag" )]
    public string Etag { get => etag; set => etag = value; }
    [JsonProperty ( "data" )]
    private Data Datas { get => data; set => data = value; }
    


}
