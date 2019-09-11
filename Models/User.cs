using System;

namespace ViewModelFun.Models
{
    public class User
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public User(string first, string last){
            this.FirstName=first;
            this.LastName=last;
        }
    }
}