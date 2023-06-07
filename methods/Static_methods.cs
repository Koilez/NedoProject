using MongoDB.Driver;
using Project.model_data;

namespace Project.methods
{
    public class Static_methods
    {
        public static string PersonData(Person person)
        {
            string result = $"Name: {person.FirstName}, surname: {person.Lastname}, age: {person.Age}";
            int quantity = 1;

            foreach (var address in person.AddressesList)
            {
                result += $"    Address {quantity}: {address.City}, ul.{address.Street} {address.HouseNumber}";
            }

            return result;
        }


        public static void AddDataToDB(IMongoCollection<Person>? collection, Person person)
        {
            collection.InsertOne(person);
        }

        public static void UpdateToDB(IMongoCollection<Person>? collection, Person personToUpdate, Person updateData)
        {
            var filter = Builders<Person>.Filter.Eq(p => p.Id, personToUpdate.Id);
            var update = Builders<Person>.Update
                .Set(p => p.FirstName, updateData.FirstName)
                .Set(p => p.Lastname, updateData.Lastname)
                .Set(p => p.Age, updateData.Age)
                .Set(p => p.IsAlive, updateData.IsAlive)
                .Set(p => p.AddressesList, updateData.AddressesList);


            collection.UpdateOne(filter, update);
        }

        public static void DeleteData(IMongoCollection<Person>? collection, string Id)
        {
            var filter = Builders<Person>.Filter.Eq(p => p.Id, Id);
            collection.DeleteOne(filter);

        }

    }
}
