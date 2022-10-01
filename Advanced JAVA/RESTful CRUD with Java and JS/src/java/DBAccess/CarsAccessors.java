/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DBAccess;

import Entity.Cars;
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
public class CarsAccessors {
    
    private static Connection conn = null;
    private static PreparedStatement selectAllStatement =null;
    private static PreparedStatement selectOneStatement =null;
    private static PreparedStatement insertStatement =null;
    private static PreparedStatement deleteStatement =null;
    private static PreparedStatement updateStatement =null;
    private CarsAccessors() {
    }
    
    
    private static void init() throws ClassNotFoundException, SQLException {
        if (conn == null) {
            Class.forName(ConnectionsParametres.DRIVERCLASS);
            conn = ConnectionManager.getConnection(ConnectionsParametres.URL, ConnectionsParametres.USERNAME, ConnectionsParametres.PASSWORD);
            selectAllStatement = conn.prepareStatement("SELECT * FROM cars");
            deleteStatement = conn.prepareStatement("delete from cars where id = ? ");
            selectOneStatement = conn.prepareStatement("SELECT * FROM cars where id= ? ");
            insertStatement = conn.prepareStatement("insert into cars (CompanyName,Model,Color) values(?,?,?)");
            updateStatement = conn.prepareStatement("UPDATE cars SET CompanyName = ?, Model = ?, Color = ? WHERE id = ?;");
        }
    }
    
    public static List<Cars> getAllCarsItems() throws ClassNotFoundException, SQLException {
        List<Cars> items = new ArrayList();
        try {
            init();
            ResultSet rs = selectAllStatement.executeQuery();
            while (rs.next()) {
                int id = rs.getInt("id");
                String name = rs.getString("CompanyName");
                String model = rs.getString("Model");
                String color = rs.getString("Color");

                Cars item = new Cars(id,name,model,color);
                items.add(item);
            }
        } catch (SQLException ex) {
            System.err.println(ex);
            items = new ArrayList();
        }
        return items;
    }
    
    public static boolean insertItem(Cars item) throws ClassNotFoundException, SQLException{
    boolean res;
    
    try{
    init();
    
    insertStatement.setString(1, item.getCompanyName());
    insertStatement.setString(2, item.getModel());
    insertStatement.setString(3, item.getColor());
    
    int rowCount = insertStatement.executeUpdate();
    res = (rowCount == 1);
    
    }catch(SQLException ex){
    
     res = false;
    }
    return  res;
    }
    
    public static boolean deleteItem(Cars item) throws ClassNotFoundException, SQLException {
    boolean res;
    try{
    init();
    deleteStatement.setInt(1, item.getid());
    
    int rowCount = deleteStatement.executeUpdate();
    res = (rowCount == 1);
    
    }catch(SQLException ex){
      res = false;
    
    }
    return res;
    }
    
    public static boolean deleteItemById(int id) throws ClassNotFoundException, SQLException{
    Cars dummy = new Cars(id, "dummycategory", "dummyDescription", "dsa");
    return deleteItem(dummy);
    
    }
    
    public static Cars getItemById(int id) throws SQLException, ClassNotFoundException
    {
        init();
        selectOneStatement.setInt(1, id);
        ResultSet rs = selectOneStatement.executeQuery();
        
        Cars item = null;
        while (rs.next()) {
                int Id = rs.getInt("id");
                String name = rs.getString("CompanyName");
                String model = rs.getString("Model");
                String color = rs.getString("Color");

                item = new Cars(Id,name,model,color);
            }
        
        return item;
    }
    
    public static boolean updateItem(Cars car) throws ClassNotFoundException, SQLException
    {
        boolean result;
        init();
        updateStatement.setString(1, car.getCompanyName());
        updateStatement.setString(2, car.getModel());
        updateStatement.setString(3, car.getColor());
        updateStatement.setInt(4, car.getid());
        
        int count = updateStatement.executeUpdate();
        result = (count == 1);
        return result;
        
    }
    
    
}
