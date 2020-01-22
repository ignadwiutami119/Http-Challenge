using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace _2 {
    class Program {
        static void Main (string[] args) {

            string jsonformat = @"[
  {
    ""id"": 381,
    ""avatar_url"": ""https://randomuser.me/api/portraits/women/47.jpg"",
    ""employee_id"": ""201889291"",
    ""first_name"": ""Sloane Newman"",
    ""last_name"": ""Maynard"",
    ""email"": ""sloane@example.com"",
    ""username"": ""sloane"",
    ""birthday"": ""1992-04-20"",
    ""addresses"": [
      {
        ""label"": ""home"",
        ""address"": ""Jalan Kumis Kucing 10"",
        ""city"": ""DKI Jakarta""
      },
      {
        ""label"": ""parent_house"",
        ""address"": ""Jalan Ketela Gosong A20"",
        ""city"": ""DKI Jakarta""
      }
    ],
    ""phones"": [
      {
        ""label"": ""home"",
        ""phone"": ""0812345678""
      },
      {
        ""label"": ""office"",
        ""phone"": ""0817283939""
      }
    ],
    ""presence_list"": [
      ""2019-09-30"",
      ""2019-10-01"",
      ""2019-10-02"",
      ""2019-10-03"",
      ""2019-10-04"",
      ""2019-10-07"",
      ""2019-10-08"",
      ""2019-10-09"",
      ""2019-10-10"",
      ""2019-10-11"",
      ""2019-10-14"",
      ""2019-10-15"",
      ""2019-10-16"",
      ""2019-10-17"",
      ""2019-10-18"",
      ""2019-10-21"",
      ""2019-10-22"",
      ""2019-10-23"",
      ""2019-10-24"",
      ""2019-10-25"",
      ""2019-10-28"",
      ""2019-10-29"",
      ""2019-10-30"",
      ""2019-10-31"",
      ""2019-10-18""
    ],
    ""salary"": 19300000,
    ""department"": {
      ""name"": ""Research and development""
    },
    ""position"": {
      ""name"": ""VP Engineer""
    }
  },
  {
    ""id"": 408,
    ""avatar_url"": ""https://randomuser.me/api/portraits/men/40.jpg"",
    ""employee_id"": ""201989299"",
    ""first_name"": ""Patterson"",
    ""last_name"": ""Haynes"",
    ""email"": ""haynes@example.com"",
    ""username"": ""haynes"",
    ""birthday"": ""1993-04-03"",
    ""addresses"": [
      {
        ""label"": ""home"",
        ""address"": ""Jalan Jambu Air 302"",
        ""city"": ""DKI Jakarta""
      }
    ],
    ""phones"": [
      {
        ""label"": ""home"",
        ""phone"": ""0812345678""
      },
      {
        ""label"": ""office"",
        ""phone"": ""0817283939""
      }
    ],
    ""presence_list"": [
      ""2019-09-30"",
      ""2019-10-01"",
      ""2019-10-02"",
      ""2019-10-03"",
      ""2019-10-04"",
      ""2019-10-08"",
      ""2019-10-09"",
      ""2019-10-10"",
      ""2019-10-11"",
      ""2019-10-14"",
      ""2019-10-15"",
      ""2019-10-16"",
      ""2019-10-17"",
      ""2019-10-18"",
      ""2019-10-22"",
      ""2019-10-23"",
      ""2019-10-24"",
      ""2019-10-25"",
      ""2019-10-28"",
      ""2019-10-29"",
      ""2019-10-30"",
      ""2019-10-31"",
      ""2019-10-18""
    ],
    ""salary"": 1820000,
    ""department"": {
      ""name"": ""Research and development""
    },
    ""position"": {
      ""name"": ""Lead Engineer""
    }
  },
  {
    ""id"": 381,
    ""avatar_url"": ""https://randomuser.me/api/portraits/women/48.jpg"",
    ""employee_id"": ""202089291"",
    ""first_name"": ""Juan"",
    ""last_name"": ""Garcia"",
    ""email"": ""juan@example.com"",
    ""username"": ""juan"",
    ""birthday"": ""2001-12-20"",
    ""addresses"": [
      {
        ""label"": ""home"",
        ""address"": ""Jalan Sate Ayam B39"",
        ""city"": ""Bogor""
      }
    ],
    ""phones"": [
      {
        ""label"": ""home"",
        ""phone"": ""0812312112""
      }
    ],
    ""presence_list"": [
      ""2019-09-30"",
      ""2019-10-01"",
      ""2019-10-02"",
      ""2019-10-03"",
      ""2019-10-04"",
      ""2019-10-07"",
      ""2019-10-08"",
      ""2019-10-09"",
      ""2019-10-10"",
      ""2019-10-11"",
      ""2019-10-14"",
      ""2019-10-16"",
      ""2019-10-17"",
      ""2019-10-18"",
      ""2019-10-21"",
      ""2019-10-22"",
      ""2019-10-23"",
      ""2019-10-24"",
      ""2019-10-25"",
      ""2019-10-28"",
      ""2019-10-29"",
      ""2019-10-30"",
      ""2019-10-31"",
      ""2019-10-18""
    ],
    ""salary"": 1250000,
    ""department"": {
      ""name"": ""Business and Development""
    },
    ""position"": {
      ""name"": ""Marketing""
    }
  }
]";
            var ObjekList = JsonConvert.DeserializeObject<List<objek>> (jsonformat);
            // List<string> ListName = new List<string>();
            // foreach (var name in json) {
            //     ListName.Add(name.Username);
            // }

            Console.WriteLine ("\nEmployees which have salary more than Rp15.000.000 : ");
            var salary = ObjekList.Where (a => a.Salary > 15000000).Select (a => a.First_Name);
            foreach (var item in salary) {
                Console.WriteLine (item);
            }

            Console.WriteLine ("\nEmployees who life in Jakarta : ");
            var address = from item in ObjekList
            from a in item.Adresses
            where a.City == "DKI Jakarta"
            select (item.Username);
            var get = address.Distinct ();
            foreach (var item in get) {
                Console.WriteLine (item);
            }

            Console.WriteLine ("\nEmployees which birthday on March :");
            var birthday = ObjekList.Where (a => a.Birthday.Month == 3).Select (a => a.Username);
            foreach (var item in birthday) {
                Console.WriteLine (item);
            }

            // Console.WriteLine ("\nEmployees in Research and Development departement :");
            // var dept = from item in ObjekList
            // from a in item.Department
            // where a.Name == "Research and development"
            // select (item.Username);
            // var getName = address.Distinct ();
            // foreach (var item in getName) {
            //     Console.WriteLine (item);
            // }
            // var dept = ObjekList.SelectMany(item => item.Department, (item,art)) => new{address,})
            // .

            Console.WriteLine("\nHow many each employee absences in October 2019 :");
            var absences = from item in ObjekList
            from a in item.Pres_List
            where a.Month == 10 && a.Year == 2019
            select (item.Username);
            var getAbsence = absences.Distinct();
            foreach (var item in getAbsence)
            {
                Console.WriteLine(item);
            }
        }
    }

    class objek {
        [JsonProperty ("id")]
        public int Id { get; set; }

        [JsonProperty ("avatar_url")]
        public string Ava_Url { get; set; }

        [JsonProperty ("employee_id")]
        public string Employee_Id { get; set; }

        [JsonProperty ("first_name")]
        public string First_Name { get; set; }

        [JsonProperty ("last_name")]
        public string Last_Name { get; set; }

        [JsonProperty ("email")]
        public string Email { get; set; }

        [JsonProperty ("username")]
        public string Username { get; set; }

        [JsonProperty ("birthday")]
        public DateTime Birthday { get; set; }

        [JsonProperty ("addresses")]
        public List<Adress> Adresses { get; set; } = new List<Adress> ();

        [JsonProperty ("phones")]
        public List<phone> Phone { get; set; } = new List<phone> ();

        [JsonProperty ("presence_list")]
        public List<DateTime> Pres_List { get; set; } = new List<DateTime> ();
        [JsonProperty ("salary")]
        public int Salary { get; set; }

        [JsonProperty ("department")]
        public department Department { get; set; } = new department();

        [JsonProperty ("position")]
        public position Position { get; set; } = new position();

    }

    class Adress {
        [JsonProperty ("label")]
        public string Label { get; set; }

        [JsonProperty ("address")]
        public string Var_Adress { get; set; }

        [JsonProperty ("city")]
        public string City { get; set; }
    }

    class phone {
        [JsonProperty ("label")]
        public string Label { get; set; }

        [JsonProperty ("phone")]
        public string Phone { get; set; }
    }

    class department {
        [JsonProperty ("name")]
        public string Name { get; set; }
    }
    class position {
        [JsonProperty ("name")]
        public string Name { get; set; }
    }
}