<%-- 
    Document   : Register
    Created on : Apr. 4, 2022, 6:43:51 p.m.
    Author     : KiLLeR
--%>

<%@page import="java.util.Random"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>

    <head>
        
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link rel="stylesheet" href="style.css">
        <title>Register Page</title>
    </head>
    <body>
        <h2>Welcome To E-commerce</h2><br>    
        <div class="login">    
            <form id="login" method="post" action="RegisterServlet">    
                
                <label><b>ID<br>     
                    </b>    
                </label>    
                <input type="text" required name="id" id="id" placeholder="ID"> 
                <br><br>
                
                <label><b>UserName<br>     
                    </b>    
                </label>    
                <input type="text" name="Uname" id="Uname" placeholder="Username"> 
                <br><br>    

                <label><b>Email<br>     
                    </b>    
                </label>    
                <input type="email" name="email" id="email" placeholder="Email">    
                <br><br>

                <label><b>Phone<br>     
                    </b>    
                </label>    
                <input type="number" name="phone" id="phone" placeholder="Phone">    
                <br><br>

                <label><b>Address<br>     
                    </b>    
                </label>    
                <input type="text"  name="Address" id="Address" placeholder="Address">    
                <br><br>
                
                <label><b>Password     
                    </b>    
                </label>    
                <input type="Password" name="Pass" id="Pass" placeholder="Password">    
                <br><br>    
                <input type="submit" name="reg" id="reg" value="Register">       
            </form>     
        </div>    
    </body>  

