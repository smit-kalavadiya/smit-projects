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
import java.util.Scanner;

/**
 *
 * @author KiLLeR
 */
public class _2Three {
    public static void main(String[] args) throws SQLException {
        
        //2.3
            
            try(Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/restaurantdb","root","root"))
        {
            Scanner scanner = new Scanner(System.in);
        
            System.out.println("Enter Item Description:");
            String update_des = scanner.nextLine();
            
            System.out.println("Enter Item price:");
            int update_price = scanner.nextInt();
            
            System.out.println("Enter veg(true) or nonveg(false)");
            boolean update_veg_nonveg  = scanner.nextBoolean();
            
            System.out.println("Enter Item id you want to update:");
            int update_itemID = scanner.nextInt();
            
            String update = "UPDATE menuitem SET description = ?,vegetarian=?,price=? where itemID = ?";
            PreparedStatement updatePreStatement = con.prepareStatement(update);
            updatePreStatement.setString(1, update_des);
            updatePreStatement.setBoolean(2, update_veg_nonveg);
            updatePreStatement.setInt(3, update_price);
            updatePreStatement.setInt(4, update_itemID);
            updatePreStatement.executeUpdate();
            
            System.out.println("Table Updated !!");
            updatePreStatement.close();
        
        }
    }
}
