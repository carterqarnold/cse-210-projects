classDiagram
    class Video {
        - title: string
        - duration: int
        - genre: string
        + get_title(): string
        + get_duration()int
        + get_genre(): string
    }

 
YouTube VIDEOS
- What Does Program Do?
Keep track videos and comments on each video
 
- What are Candidates for classes?
Video
Comment
Program
 
- What are responsibilities of each class?
Video
 
 
 
 
Video:


attributes:
_title: string
_author: string
_length: double (for seconds)
_comments: List<Comment>


methods;
NumberComments(): int. (List.Count())
DisplayComment(): void
 
 
 
 
Comment:


attributes:
_name: string
_text: string


methods;
Display Comment(): void
 
 
 
 
program:
Needs to create 3-4 videos
Set values
For each value add a list of 3-4 comments


attributes:
_videos: List<Video>


methods;
DisplayCommentInfo(): string (call other display methods)


 
 
 
 
 
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