<%-- 
    Document   : EditItem
    Created on : Apr. 1, 2022, 12:49:34 a.m.
    Author     : KiLLeR
--%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <form action="UpdateItem" method="post" class="addform">
            <c:set value="${updateCar}" var="temp" scope="page" ></c:set>
            
            <label> ID : </label><input type="text" name="id" required id="txt" value="${temp.getid()}" ><P></P>
            <label> Company Name : </label><input type="text" name="company_name" required id="txt" value="${temp.getCompanyName()}" ><P></P>
            <label>Model Name :</label> <input type="text" name="model_name" required id="txt" value="${temp.getModel()}" ><P></P>
            <label> Color : </label><input type="text" name="color" required id="txt"value="${temp.getColor()}"><P></P>
            
             <input type="submit" value="submit">
        </form>
    </body>
</html>
