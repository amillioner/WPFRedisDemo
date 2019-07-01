using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfRedisDemo
{
    public class PersonDataModel
    {
        private void InsertBulkStudent()
        {
            var numberOfRecords = 10;
            var cache = RedisConnector.GetRedisInstance();
            for (int i = 1; i <= numberOfRecords; i++)
            {
                cache.StringSet("Person" + i, 
                    JsonConvert.SerializeObject(
                                new Person()
                                {
                                    PersonalID = i
                                                ,
                                    FullName = "Person" + i
                                                ,
                                    Gender = i % 2 == 0 ? "Male" : "Female"
                                                ,
                                    DOB = DateTime.Now.AddYears(i).ToString()
                                }
                                ));
            }
        }
        public List<Person> GetStudentRecords()
        {
            //Insert Student Records
            InsertBulkStudent();

            var studentList = new List<Person>();
            var cache = RedisConnector.GetRedisInstance();
            var numberOfRecords = 10;

            for (int i = 1; i <= numberOfRecords; i++)
            {
                var t = cache.StringGet("Person" + i);
                studentList.Add(JsonConvert.DeserializeObject<Person>(cache.StringGet("Person" + i)));
            }
            return studentList;
        }
    }
}
