using System;

namespace Models
{
    public class Users
    {
        public Users(){

        }
        public Users(string name){ 
            this.name = name;
            //Console.WriteLine("Hello "+ name); to delete!
        }
         public Users(int id, string name) : this(name)
        {
            this.id = id;
           
        }

        public int id{ get; set;}
        public string name{ get; set;} 

        //public int userPhoneNumber{get;set;}
        //public int userEmail{get;set;}
        //public string city{ get; set;}

        //public int reviewId{get;set} foreign key.0000000


    }
}
