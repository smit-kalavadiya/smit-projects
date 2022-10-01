/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DB;

import Entity.Products;
import Entity.User;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author KiLLeR
 */
public class DataAccessors {
    
    private static Connection conn = null;
    private static PreparedStatement selectAllStatement =null;
    private static PreparedStatement selectOneStatement =null;
    private static PreparedStatement selectOnerecord =null;
    private static PreparedStatement insertStatement =null;
    private static PreparedStatement insertProduct =null;
    private static PreparedStatement deleteStatement =null;
    private static PreparedStatement updateStatement =null;
    private DataAccessors() {
    }
    
    
    private static void init() throws ClassNotFoundException, SQLException {
        if (conn == null) {
            Class.forName(ConnectionsParametres.DRIVERCLASS);
            conn = ConnectionManager.getConnection(ConnectionsParametres.URL, ConnectionsParametres.USERNAME, ConnectionsParametres.PASSWORD);
            selectAllStatement = conn.prepareStatement("SELECT * FROM products");
            deleteStatement = conn.prepareStatement("delete from products where id = ? ");
            selectOneStatement = conn.prepareStatement("SELECT * FROM users where email= ? ");
            selectOnerecord = conn.prepareStatement("SELECT * FROM products where id= ? ");
            insertStatement = conn.prepareStatement("insert into users (id,username,email,phone,address,Password) values(?,?,?,?,?,?)");
            insertProduct = conn.prepareStatement("insert into products (id,name,description,type,price,quantity,sellername) values(?,?,?,?,?,?,?)");
            updateStatement = conn.prepareStatement("UPDATE products SET name = ?, description = ?, type = ?,price = ?,quantity = ?,sellername = ? WHERE id = ?;");
        }
    }
    
    public static List<Products> getAllProducts() throws ClassNotFoundException, SQLException {
        List<Products> pro = new ArrayList();
        try {
            init();
            ResultSet rs = selectAllStatement.executeQuery();
            while (rs.next()) {
                int id = rs.getInt("id");
                String name = rs.getString("name");
                String description = rs.getString("description");
                String type = rs.getString("type");
                double price = rs.getDouble("price");
                int quantity = Integer.parseInt(rs.getString("quantity"));
                String saller = rs.getString("sellername");

                Products product = new Products(id,name,description,type,price,quantity,saller);
                pro.add(product);
            }
        } catch (SQLException ex) {
            System.err.println(ex);
            pro = new ArrayList();
        }
        return pro;
    }
    
    public static boolean insertItem(User user) throws ClassNotFoundException, SQLException{
    boolean res;
    
    try{
    init();
    
    insertStatement.setInt(1, user.getId());
    insertStatement.setString(2, user.getUsername());
    insertStatement.setString(3, user.getEmail());
    insertStatement.setString(4, user.getPhone());
    insertStatement.setString(5, user.getAddress());
    insertStatement.setString(6, user.getPassword());
    
    int rowCount = insertStatement.executeUpdate();
    res = (rowCount == 1);
    
    }catch(SQLException ex){
     res = false;
    }
    return  res;
    }
    
    public static boolean insertProduct(Products pro) throws ClassNotFoundException, SQLException{
    boolean res;
    
    try{
    init();
    
    insertProduct.setInt(1, pro.getId());
    insertProduct.setString(2, pro.getName());
    insertProduct.setString(3, pro.getDescription());
    insertProduct.setString(4, pro.getType());
    insertProduct.setDouble(5, pro.getPrice());
    insertProduct.setInt(6, pro.getQuantity());
    insertProduct.setString(7, pro.getSellername());
    
    
    int rowCount = insertProduct.executeUpdate();
    res = (rowCount == 1);
    
    }catch(SQLException ex){
     res = false;
    }
    return  res;
    }
    
    public static boolean deleteItem(Products item) throws ClassNotFoundException, SQLException {
    boolean res;
    try{
    init();
    deleteStatement.setInt(1, item.getId());
    
    int rowCount = deleteStatement.executeUpdate();
    res = (rowCount == 1);
    
    }catch(SQLException ex){
      res = false;
    
    }
    return res;
    }
    
    public static boolean deleteItemById(int id) throws ClassNotFoundException, SQLException{
    Products dummy = new Products(id, "dummycategory", "dummyDescription", "dsa",0.0,0,"d");
    return deleteItem(dummy);
    
    }
    
    public static User getItemByEmail(String email) throws SQLException, ClassNotFoundException
    {
        init();
        selectOneStatement.setString(1, email);
        ResultSet rs = selectOneStatement.executeQuery();
        
        User user = null;
        while (rs.next()) {
                int Id = rs.getInt("id");
                String userName = rs.getString("username");
                String Email = rs.getString("email");
                String phone = rs.getString("phone");
                String address = rs.getString("address");
                String Password = rs.getString("Password");
                
                user = new User(Id,userName,Email,phone,address,Password);
            }
        
        return user;
    }
    
    public static Products getItemById(int id) throws SQLException, ClassNotFoundException
    {
        Products product = null;
        init();
        selectOnerecord.setInt(1, id);
        ResultSet rs = selectOnerecord.executeQuery();
        
        while (rs.next()) {
                int idd = rs.getInt("id");
                String name = rs.getString("name");
                String description = rs.getString("description");
                String type = rs.getString("type");
                double price = rs.getDouble("price");
                int quantity = Integer.parseInt(rs.getString("quantity"));
                String saller = rs.getString("sellername");

                product = new Products(idd,name,description,type,price,quantity,saller);
                
            }
        
        return product;
    }
    
    
    public static boolean updateItem(Products pro) throws ClassNotFoundException, SQLException
    {
        boolean result;
        init();
        
        updateStatement.setString(1, pro.getName());
        updateStatement.setString(2, pro.getDescription());
        updateStatement.setString(3, pro.getType());
        updateStatement.setDouble(4, pro.getPrice());
        updateStatement.setInt(5, pro.getQuantity());
        updateStatement.setString(6, pro.getSellername());
        updateStatement.setInt(7, pro.getId());
        
        int count = updateStatement.executeUpdate();
        result = (count == 1);
        return result;
        
    }
    
    
}
