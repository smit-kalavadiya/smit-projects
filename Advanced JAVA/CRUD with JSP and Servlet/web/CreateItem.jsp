<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link rel="stylesheet" href="CarsStyleSheet.css">
        <title>Create a new Menu Item</title>
    </head>
    <body>
        <h1>Add a new Item</h1>
        <form action="AddItemServlet" method="post" class="addform">
            
            <label>ID : </label><input type="text" name="id" required id="txt"></p>
            <label>Company Name :</label><input type="text" name="company_name" required id="txt"></P>
            <label>Model Name :</label> <input type="text" name="model_name" required id="txt"><P></P>
            <label> Color : </label><input type="text" name="color" required id="txt"><P></P>
            
             <input type="submit" value="submit">
        </form>
    </body>
</html>
