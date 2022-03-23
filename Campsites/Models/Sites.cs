using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Campsites.Models;

public class Site
{

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]

    public string? Id { get; set; }

    [BsonElement("name")]
    public string? Name { get; set; }

    [BsonElement("description")]
    public string? Description { get; set; }

    [BsonElement("water")]
    public bool Water { get; set; }
    [BsonElement("electrical")]

    public bool Electrical { get; set; }
    [BsonElement("lakeFront")]

    public bool LakeFront { get; set; }

    [BsonElement("bookings")]
    public List<DateTime>? Bookings { get; set; }
}