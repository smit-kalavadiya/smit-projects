<%-- 
    Document   : AddProduct
    Created on : Apr. 5, 2022, 1:43:09 a.m.
    Author     : KiLLeR
--%>

<%@page import="Entity.User"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <c:set value="${LoginUser}" var="temp" scope="application" ></c:set>
        <h3>Welcome, ${LoginUser.username}</h3>
        
        <% 
            
            User user= (User)session.getAttribute("LoginUser");
            if(user == null)
            {
                RequestDispatcher rd = request.getRequestDispatcher("/index.jsp");
                rd.forward(request, response);
            }
            
        %>
        
        <form method="post" action="ShowProductsServlet">
            <input type="submit" value="Load Data"/>
        </form>
</br>
        <form method="post" action="LogOutServlet">
            <input type="submit" value="Logout"/>
        </form>
    </body>
</html>
