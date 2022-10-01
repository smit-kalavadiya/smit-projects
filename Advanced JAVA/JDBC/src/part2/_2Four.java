/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package part2;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;

/**
 *
 * @author KiLLeR
 */
public class _2Four {
    public static void main(String[] args) throws SQLException {
        //2.4
        
        try(Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/restaurantdb","root","root"))
        {
              String delete = "Delete from menuitem where itemID = 311";
              PreparedStatement deletePreStatement = con.prepareStatement(delete);
              deletePreStatement.executeUpdate();
              System.out.println("Record has been deleted!");
        }
    }
    
}
