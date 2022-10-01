/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package part2;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

/**
 *
 * @author KiLLeR
 */
public class _2One {
    
    public static void main(String[] args) throws SQLException {
        try(Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/restaurantdb","root","root"))
        {
            
            Scanner scanner = new Scanner(System.in);
            
              //2.1
              
            System.out.println("Enter Item ID:");
            int Itemid = scanner.nextInt();
            
            System.out.println("Enter Item Category ID:");
            String category_id = scanner.next();
            
            System.out.println("Enter Item Description:");
            scanner.nextLine();
            String description = scanner.nextLine();
            
            System.out.println("Enter Item price:");
            int price = scanner.nextInt();
            
            System.out.println("Enter veg(true) or nonveg(false)");
            boolean veg_nonVeg  = scanner.nextBoolean();
            
            String query = "insert into MenuItem values("+Itemid+",'"+category_id+"','"+description+"',"+price+","+veg_nonVeg+")";
            
            Statement statement = con.createStatement();
            statement.executeUpdate(query);
            System.out.println("Record inserted!");
            statement.close();
        }
    }
}
