﻿namespace PizzaShopWebApp.models
{
    public class PizzaMenu
    {
       public int Id { get; set; }
       public string PizzaName { get; set; }
        public string Availability {  get; set; }
        public int Price { get; set; }
        public int QuantityInStock { get; set; }
    }
}
