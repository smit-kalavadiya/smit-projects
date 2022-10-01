<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link rel="stylesheet" href="CarsStyleSheet.css">
        <title>Show Car Items</title>
    </head>
    <body>
        <h1>Cars Items</h1>
        <form action="CreateItem.jsp">
            <button type="submit" class="addbtn">Add a new Car Item</button>
            
        </form>
        
        <table class="styled-table">
            <thead>
                <tr><th>ID</th> <th>Manufacture Name</th><th>Model Name</th><th>Color</th><th></th><th></th></tr>
            </thead>
            
            
            <c:forEach items="${theCarsItems}" var="temp">
                <tr>
                    <td>${temp.getid()}</td>
                    <td>${temp.getCompanyName()}</td>
                    <td>${temp.getModel()}</td>
                    <td>${temp.getColor()}</td>
                    <td>
                    <form action="DeleteItem">
                        <input type="hidden" name="id" value="${temp.getid()}">
                        <button type="submit" class="delbtn">Delete</button>
                    </form>
                    </td>
                    <td>
                        <form action="BuildItem">
                        <input type="hidden" name="id" value="${temp.getid()}">
                        <button type="submit" class="updbtn">Update</button>
                        </form>
                    </td>
                    </tr>
                    
                    
            </c:forEach>
            
        </table>
    </body>
</html>
