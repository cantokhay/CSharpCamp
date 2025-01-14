﻿using System.Collections.Generic;

namespace Bootcamp.EntityLayer.Concrete
{
    public class Category
    {
        //int x; //this is a field

        //public int y { get; set; } //this is a property

        //void MyMethod() //this is a method
        //{
        //    int z; //this is a local variable
        //}

        public int CategoryId { get; set; } //this is primary key and identifier
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; } //this is a navigation property

    }
}
