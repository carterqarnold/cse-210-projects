using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
public class Customer{
        private string _customerName {get; set;}
        public bool maybe;

        public Customer(){
        }
        public Customer(string name){
            _customerName = name;
        }
        public class Address{
            private string _streetAddress {get; set;}
            private string _city {get; set;}
            private string _stateOrProvince {get; set;}
            private string _country {get; set;}
            public Address(){
                
            }
            public Address(string country){
                _country = country;
            }
            public Address(string streetAddress, string city, string stateOrProvince, string country){
                _streetAddress = streetAddress;
                _city = city;
                _stateOrProvince = stateOrProvince;
                _country = country;
            }
            public string FullAddress(){
                return $"{_streetAddress} \n{_city}, {_stateOrProvince} \n{_country}";
            }
            public string InUSAOrNot(){
                return _country;               
            }
        }
        public string GetName(){
                return _customerName;
            }
        public bool InUSA(string country){
           if (country.ToLower() == "america" || country.ToLower() == "usa" || country.ToLower() == "united states of america"){
                maybe = true;
           }
            else{
                maybe = false;
            }
            return maybe;
    }
}
