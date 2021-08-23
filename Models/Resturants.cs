using System;

namespace Models
{
    public class Resturants
    {
        public Resturants(){

        }
        public Resturants(string name){ 
            this.name = name;
        }
        public Resturants(int id, string name) : this(name) => this.id = id;

        public int id{ get; set;}
        public string name{ get; set;} 
        //public string description{get;set;} //need to review!*/


    }
}
