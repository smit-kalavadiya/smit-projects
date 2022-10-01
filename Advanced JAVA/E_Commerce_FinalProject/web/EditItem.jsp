<%-- 
    Document   : EditItem
    Created on : Apr. 6, 2022, 12:56:30 a.m.
    Author     : KiLLeR
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link rel="stylesheet" href="style.css">
        <title>JSP Page</title>
    </head>
    <body>
        <c:set value="${updatePro}" var="temp" scope="page" ></c:set>
        
        <h2>Edit Product</h2><br>    
        <div class="login">    
            <form id="login" method="post" action="EditServlet">    
                
                <label><b>ID<br>     
                    </b>    
                </label>    
                <input readonly type="text" required name="id" id="id" value="${temp.getId()}"> 
                <br><br>
                
                <label><b>Product Name<br>     
                    </b>    
                </label>    
                <input type="text" name="pname" id="Uname" value="${temp.getName()}"> 
                <br><br>    

                <label><b>Description<br>     
                    </b>    
                </label>    
                <input type="text" name="desc" id="email" value="${temp.getDescription()}">    
                <br><br>

                <label><b>Category<br>     
                    </b>    
                </label>    
                <input type="text" name="cat" id="phone" value="${temp.getType()}">    
                <br><br>

                <label><b>Price<br>     
                    </b>    
                </label>    
                <input type="text" name="price" id="Address" value="${temp.getPrice()}">    
                <br><br>
                
                <label><b>Quantity     
                    </b>    
                </label>    
                <input type="text" name="qua" id="Pass" value="${temp.getQuantity()}">    
                <br><br>    
                
                <label><b>Seller Name     
                    </b>    
                </label>    
                <input type="text" name="seller" id="Pass" value="${temp.getSellername()}">    
                <br><br>    
                <input type="submit" name="reg" id="reg" value="Edit">       
            </form>     
        </div>    
    </body> 
</html>
