# **ProductRepository** #
 
This repository contains operations performed on Product Details

Operations Performed:
* Select
* Insert
* Update
* Filter
* Delete

#### The Application is developed using ASP.Net MVC, SQL and Dapper for database connection. In MVC (Model View Controller) request is sent to the Controller which returns a View as an ActionResult response. ####

#### Table Name : Products
#### Attributes : ProductId, SKU, ProductName, Features, Price, Stock, warranty, Rating, VendorId
#### Primary Key : SKU
#### Foreign Key : VendorId

### ASP.Net Filters used ###
* Authorization
* Action filter
* Result filter
* Exception
  
### ASP.Net attributes included ###
* [Required] for MVC Validation
* [Authorize] attribute to limit access to the authenticated user
* [Route] to specify the specific action and limits the size of route template
* [Cache] to hold the response messages for a specific duration of time
* [HttpGet] and [HttpPost] are used to send user data from the forms to the server.

1.Login page
<br/>
<img src="Pictures/login.png" style=" width:450px ; height:450px ">
<br/>
<br/>
2.Display Products table
<img src="Pictures\view.png" style=" width:500px ; height:500px ">
<br/>
<br/>
3.Insert a new record into the table
<img src="Pictures\insert.png" style=" width:500px ; height:500px ">
<br/>
<br/>
4.Read a single value from the table
<img src="Pictures\read.png" style=" width:500px ; height:500px ">
<br/>
<br/>
5.Update data
<img src="Pictures\update.png" style=" width:500px ; height:500px ">
<br/>
<br/>
6.Delete Product detail
<img src="Pictures\delete.png" style=" width:500px ; height:500px ">
<br/>
<br/>
