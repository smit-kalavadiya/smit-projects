<%-- 
    Document   : newjsp
    Created on : Apr. 4, 2022, 6:00:47 p.m.
    Author     : KiLLeR
--%>

<%@page import="Entity.User"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <link rel="stylesheet" href="style.css">
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Login Page</title>
    </head>
    <body>    
    <h2>Welcome To E-commerce</h2><br>    
    <div class="login">    
        
    <form id="login" method="post" action="LoginServlet">
        <% 
            
            User user= (User)session.getAttribute("LoginUser");
            if(user != null)
            {
                RequestDispatcher rd = request.getRequestDispatcher("/Welcome.jsp");
                rd.forward(request, response);
            }
        
        %>
        
        <label><b>Email</br>     
        </b>    
        </label>    
        <input type="email" required name="email" id="email" placeholder="Email">    
        <br><br>    
        <label><b>Password     
        </b>    
        </label>    
        <input type="Password" required name="Pass" id="Pass" placeholder="Password">    
        <br><br>    
        <input type="submit"  name="log" id="log" value="Log In Here">       
        <br><br>     
        <a href="Register.jsp">Don't have an account!</a>
         
    </form>     
</div>    
</body>  
</html>
