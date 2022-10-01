/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package part4;

import java.sql.SQLException;
import javax.sql.rowset.CachedRowSet;
import javax.sql.rowset.RowSetProvider;

/**
 *
 * @author KiLLeR
 */
public class _4Two {

    public static void main(String[] args) throws SQLException {

        try (CachedRowSet row = RowSetProvider.newFactory().createCachedRowSet()) {
            row.setUrl("jdbc:mysql://localhost:3306/restaurantdb");
            row.setUsername("root");
            row.setPassword("root");
            row.setCommand("SELECT MenuItemCategory.itemCategoryDescription, MenuItemCategory.itemCategoryID,MenuItem.description,MenuItem.price FROM MenuItemCategory INNER JOIN MenuItem ON MenuItemCategory.itemCategoryID=MenuItem.itemCategoryID where MenuItem.itemID = 102");
            row.execute();

            while (row.next()) {
                String itemCategoryDescription = row.getString("itemCategoryDescription");
                String itemCategoryID = row.getString("itemCategoryID");
                String desc = row.getString("description");
                float price = row.getFloat("price");

                System.out.printf("%10s %s %10s %5f \n", itemCategoryDescription, itemCategoryID, desc, price);

            }

        }

    }

}
