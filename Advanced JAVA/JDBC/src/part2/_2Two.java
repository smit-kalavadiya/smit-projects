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
public class _2Two {
    public static void main(String[] args) throws SQLException {
        //2.2
            try(Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/restaurantdb","root","root"))
        {
            Scanner scanner = new Scanner(System.in);
            System.out.println("Enter Item ID:");
            int id = scanner.nextInt();
            
            System.out.println("Enter Item Category ID:");
            String cat_id = scanner.next();
            
            System.out.println("Enter Item Description:");
            scanner.nextLine();
            String des = scanner.nextLine();
            
            System.out.println("Enter Item price:");
            int pr = scanner.nextInt();
            
            System.out.println("Enter veg(true) or nonveg(false)");
            boolean vegnonVeg  = scanner.nextBoolean();
            
            String insertSQL = "INSERT INTO MenuItem (itemID, itemCategoryID,description,price,vegetarian) VALUES (?, ?,?,?,?)";
            PreparedStatement preparedStatement = con.prepareStatement(insertSQL);
            preparedStatement.setInt(1, id);
            preparedStatement.setString(2, cat_id);
            preparedStatement.setString(3, des);
            preparedStatement.setInt(4, pr);
            preparedStatement.setBoolean(5, vegnonVeg);
            int count = preparedStatement.executeUpdate();
            if(count == 1)
            {
                System.out.println("Record inserted with prepared statement!!");
            }
            preparedStatement.close();
        }
    }
}
