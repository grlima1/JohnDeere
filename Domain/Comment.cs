using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Comment
    {
        public Rootobject rootobject { get; set; }
        public Author author { get; set; }

        public class Rootobject
        {
            public string id { get; set; }
            public string body { get; set; }
            public int postId { get; set; }
            public Author author { get; set; }
            public DateTime createdAt { get; set; }
        }

        public class Author
        {
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public Profile profile { get; set; }
        }

        public class Profile
        {
            public int age { get; set; }
            public string bio { get; set; }
            public Sociallinks socialLinks { get; set; }
        }

        public class Sociallinks
        {
            public string twitter { get; set; }
            public string github { get; set; }

            public override string ToString()
            {
                return $"Twitter: {twitter} | Github: {github}";
            }
        }

    }
}
