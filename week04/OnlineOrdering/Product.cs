using System;
using System.Numerics;
public class Product{
        private string _name {get; set;}
        private string _productId {get; set;}
        private double _price {get; set;}
        private double _quantity {get; set;}
        public Product(string productName, string productId, double price, double quantity){
            _name = productName;
            _productId = productId;
            _price = price;
            _quantity = quantity;
        }
        public double TotalProductPrice(){
            return _price * _quantity;
        }
        public string ProductString(){
            return $"- {_name} (ID: {_productId})";
        }
    }