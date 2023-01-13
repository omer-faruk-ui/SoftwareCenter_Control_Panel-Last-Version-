using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace APIHelper.Models
{
    public class Software
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string ExeURL { get; set; } = null!;
        public string SilentCommand { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string IconURL { get; set; } = null!;
        public string UnSilentCommand { get; set; } = null!;

    }
}
