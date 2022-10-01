<%-- 
    Document   : ShowProducts
    Created on : Apr. 5, 2022, 9:50:53 p.m.
    Author     : KiLLeR
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        
        <title>Show Products</title>
        <link rel="stylesheet" href="cardcss.css">
    </head>
    <body>
        
        <form action="AddNewProduct.jsp">
            <input id="newpro" type="submit" class="buttons" value="Add Product">
        </form>
        
        <c:forEach items="${products}" var="temp">
            <div class="card">
                <div class="container">
                    <h2><b>${temp.getId()}.  ${temp.getName()} <span id="price"> $${temp.getPrice()} </span> </b></h2> 
                    <p>${temp.getDescription()}</p> 
                    <p>Category:  ${ temp.getType() }</p>
                    <p>Seller:    ${ temp.getSellername() }</p>
                    <p>In Stock:  ${ temp.getQuantity() }</p>
                    <div class="buttons">
                        <div class="action_btn">
                            <form action="BuildItem" method="post" style="display: inline;">
                                <input name="updateid" type="hidden" value="${temp.getId()}"   />
                                <input id="edit" type="submit" value="Edit" class="buttons" />
                            </form> 
                    
                            <form method="post" action="DeleteProduct" style="display: inline;">
                                <input name="deleteid" type="hidden" value="${temp.getId()}"   />
                                <input id="delete" type="submit" value="Delete" class="buttons" />
                            </form> 
                        </div>
                    </div>
                    
                </div>
            </div>
        </c:forEach>
    </body>
</html>
