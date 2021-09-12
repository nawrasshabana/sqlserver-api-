using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myuser.models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string date { get; set; }

        //  public Post Posts { get; set; }
        /*
        List<Post> Lst = new List<Post>();
        public List<Post> GetSetPost
        {
            get
            {
                return Lst;
            }
            set
            {
                Lst = value;
            }
        }
    }
        */
    }
}
