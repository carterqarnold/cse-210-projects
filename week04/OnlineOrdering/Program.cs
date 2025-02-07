using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        ONLINE ORDERING
- What Does Program Do?
 
- What are Candidates for classes?
 
- What are responsibilities of each class?
 

Product:

attributes:
_name: string
_id: int
_quantity: int
_price: double

methods;
TotalCostProduct(): double (unit price * quantity)

 
Customer:

attributes:
_name: string
_address: Address

methods;
GetIsInUSA(): bool
 

Address:

attributes:
_streetAddress: string
_city: string
_state/providence: string
_country: string

methods;
IsInUSA(): bool
DisplayAddress(): string. (Newline characters where appropriate)

 
Order:

attributes:
_products: List<Products>
_customer: string

methods;
TotalPrice(): double (sum of TotalCostProduct() + shipping cost)
    USA $5 else $35
 
GetPackingLabel(): string (name and product ID)
GetShippingLabel(): string (name and address
 
 

Program
Create at least 2 order with 2-3 products each
 
Attributes:
 
Methods:
GetPackingLabel():
 
GetShippingLabel():
 
GetTotalPrice(): (call from Order class)
    }
}

