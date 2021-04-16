using System;
 
namespace Person 
{ 
    public class Person 
    { 
        private string name; 

        private string id; 

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    this.name = "Error";
                    //Console.WriteLine("Error en nombre");
                }
                else
                {
                    this.name=value;
                }
            }

        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if(IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
                else
                {
                    this.id="Error";
                    //Console.WriteLine("Error en ID");
                }
            }
        }

        public Person(string Name, string Id) 
        { 
            this.Name = Name; 
            this.Id = Id; 
        } 

        public void IntroduceYourself() 
        { 
            Console.WriteLine( 
                $"Soy {this.name} y mi cédula es {this.id}"); 
        } 
    } 

}