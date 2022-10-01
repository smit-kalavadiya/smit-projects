/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Part1;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 *
 * @author KiLLeR
 */
public class part1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws SQLException, ClassNotFoundException {
        // TODO code application logic here
        
        Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/restaurantdb","root","root");
        System.out.println("Connection done!");
        con.close();
        
    }
    
}
