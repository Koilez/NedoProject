using MongoDB.Bson.Serialization.Attributes;

namespace Project.model_data
{
    public class Person
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string FirstName { get; set; }


        [BsonElement("surname")]
        public string Lastname { get; set; }


        [BsonElement("age")]
        public int Age { get; set; }

        [BsonElement("isAlive")]
        public bool IsAlive { get; set; }

        [BsonElement("Addresses")]
        public List<Address> AddressesList { get; set; }
    }


    public class Address
    {
        [BsonElement("city")]
        public string City { get; set; }

        [BsonElement("street")]
        public string Street { get; set; }

        [BsonElement("houseNumber")]
        public int HouseNumber { get; set; }
    }

    public class PersonUnwind
    {

        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string FirstName { get; set; }


        [BsonElement("surname")]
        public string Lastname { get; set; }


        [BsonElement("age")]
        public int Age { get; set; }

        [BsonElement("isAlive")]
        public bool IsAlive { get; set; }

        [BsonElement("Addresses")]
        public Address Addresses { get; set; }
    }


}
