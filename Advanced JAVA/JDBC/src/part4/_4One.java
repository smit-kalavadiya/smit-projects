/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package part4;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;
import java.sql.ResultSet;

/**
 *
 * @author KiLLeR
 */
public class _4One {
    public static void main(String[] args) throws SQLException {
        
        try(Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/restaurantdb","root","root"))
        {
            
            Statement st = con.createStatement();
            ResultSet rs = st.executeQuery("select  ItemID, ItemCategoryID, description,price from menuitem");
            
            while(rs.next())
            {
                System.err.printf("%-10s %-10s %-10s %50f \n",rs.getString("ItemID"),rs.getString("ItemCategoryID"),rs.getString("description"),Float.parseFloat( rs.getString("price")));
            }
            
        }
        
    }
    
}
