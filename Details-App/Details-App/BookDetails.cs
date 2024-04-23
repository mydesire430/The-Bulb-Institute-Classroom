using System;
using System.Collections.Generic;
using System.Text;

namespace Details_App
{
    public class BookDetails
    {

        //Fields are just properties without get and set... They can be used to set the values of properties
        private string _title;
        private string _description;
        private int _price;

        //Constructor {With parameter} : The constructor is what allows you to create a class
        //structure - Access Modifier, Contructor Name{which is the same name as the class name}
        public BookDetails(string title, string description, int price) 
        {
            _title = title;
            _description = description;
            _price = price;
        }

        //Properties: These are like attributes
        //Structure - Access Modifier, Datatype, Property {get; set;}
        public string Title { get { return _title; } }
        public string Description { get { return _description; } }
        public int Price { get { return _price; } }


        //Method
        //Structure - Access Modifier, Datatype, Method-name
        public string ReturnDetails()
        {
            return $"Title: {Title} \nDescription: {Description} \nPrice:{Price}";
        }


    }
}
