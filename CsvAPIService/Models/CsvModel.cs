using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CsvAPIService.Models
{
    public class CsvModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string Path { get; set; }
        [BsonExtraElements]
        public Dictionary<string, int> Count { get; set; }
        [BsonExtraElements]
        public Dictionary<string, object>? Values { get; set; }


    }
}
