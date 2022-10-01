/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Part3;

import java.sql.BatchUpdateException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

/**
 *
 * @author KiLLeR
 */
public class _3One {

    public static void main(String[] args) throws SQLException {

        try (Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/restaurantdb", "root", "root")) {
            con.setAutoCommit(false);

            Statement stmt = con.createStatement();

            try {

                stmt.addBatch("insert into menuitemcategory values('DRI','Drinks')");
                stmt.addBatch("insert into MenuItem values(313,'DRI','Coke',2,true);");
                stmt.addBatch("insert into MenuItem values(314,'DRI','7UP',2,true);");
                stmt.addBatch("insert into MenuItem values(315,'DRI','Corona',5,true);");
                stmt.addBatch("insert into MenuItem values(316,'DRI','Lemonade',2,true);");
                stmt.executeBatch();//executing the batch  

                con.commit();
                con.close();

            } catch (BatchUpdateException ex) {
                System.out.println("Error in batch :" + ex.getMessage());
                con.rollback();

            }

        }

    }

}
