<%-- 
    Document   : AddNewProduct
    Created on : Apr. 5, 2022, 11:44:07 p.m.
    Author     : KiLLeR
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Add new Product Page</title>
        <link rel="stylesheet" href="style.css">
    </head>
    <body>
        <h2>Add new Products</h2><br>    
        <div class="login">    
            <form id="login" method="post" action="AddNewProductServlet">    
                
                <label><b>ID<br>     
                    </b>    
                </label>    
                <input type="text" required name="id" id="id" placeholder="ID"> 
                <br><br>
                
                <label><b>Product Name<br>     
                    </b>    
                </label>    
                <input type="text" name="pname" id="Uname" placeholder="Product Name"> 
                <br><br>    

                <label><b>Description<br>     
                    </b>    
                </label>    
                <input type="text" name="desc" id="email" placeholder="Description">    
                <br><br>

                <label><b>Category<br>     
                    </b>    
                </label>    
                <input type="text" name="cat" id="phone" placeholder="Category">    
                <br><br>

                <label><b>Price<br>     
                    </b>    
                </label>    
                <input type="text" name="price" id="Address" placeholder="Price">    
                <br><br>
                
                <label><b>Quantity     
                    </b>    
                </label>    
                <input type="text" name="qua" id="Pass" placeholder="Quantity">    
                <br><br>    
                
                <label><b>Seller Name     
                    </b>    
                </label>    
                <input type="text" name="seller" id="Pass" placeholder="Seller Name">    
                <br><br>    
                <input type="submit" name="reg" id="reg" value="Add">       
            </form>     
        </div>    
    </body> 
</html>
