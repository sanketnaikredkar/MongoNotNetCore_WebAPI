/*Technologies used:*/
  1. .Net Core
  2. MongoDB
 ------------------------------------------------------------------------------------------------------------- 
/*Create Mongo DB Script*/
use ProductDB 
db.createCollection('Products')
db.Products.insert({'ProductId':1,'ProductName':'Desktop All in One','Price':43000,'Category':'Electronics'})
db.Products.insert({'ProductId':2,'ProductName':'Desktop All in One','Price':51000,'Category':'Electronics'})
-------------------------------------------------------------------------------------------------------------
/*http request and responce URL*/
https://localhost:44302/api/Product
https://localhost:44302/api/Product/1
-------------------------------------------------------------------------------------------------------------
