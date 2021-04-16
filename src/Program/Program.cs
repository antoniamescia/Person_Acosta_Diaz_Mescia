using System;

namespace Person
{
     class Program 
    { 
        static void Main(string[] args) 
        { 
            Person john = new Person("John Doe", "1.234.567-8"); 
            Person jane = new Person("Jane Doe", "8.765.432-1");
            Person antonia = new Person("Antonia Mescia","4.930.196-0");
            antonia.Id = "4.930.196-1";
            Person luciana = new Person("Luciana Díaz", "5.029.496-6"); 
            john.IntroduceYourself(); 
            jane.IntroduceYourself();
            antonia.IntroduceYourself();
            luciana.IntroduceYourself();
            
        } 
    } 
}