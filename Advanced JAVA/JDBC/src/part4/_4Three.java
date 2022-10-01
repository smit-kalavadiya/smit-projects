/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package part4;

import java.sql.SQLException;
import java.util.Scanner;
import javax.sql.RowSet;
import javax.sql.rowset.FilteredRowSet;
import javax.sql.rowset.Predicate;
import javax.sql.rowset.RowSetProvider;


class PriceAndVegPredicate implements Predicate{
 private float price;
 private boolean veg;

    public PriceAndVegPredicate(float price,boolean veg) {
        this.price = price;
        this.veg = veg;
    }
    public boolean evaluate(RowSet rs) {
        try {
            return rs.getFloat("price") > this.price && rs.getBoolean("vegetarian");

        } catch (Exception ex) {

            return false;
        }
    }
    @Override
    public boolean evaluate(Object o, int i) throws SQLException {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public boolean evaluate(Object o, String string) throws SQLException {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }
 
}


public class _4Three {
    
    public static void main(String[] args) throws SQLException {
        
        try(FilteredRowSet fs = RowSetProvider.newFactory().createFilteredRowSet()){
        fs.setUrl("jdbc:mysql://localhost:3306/restaurantdb");
        fs.setUsername("root");
        fs.setPassword("root");
        fs.setCommand("SELECT * from menuItem");
        fs.execute();
        
            Scanner scan = new Scanner(System.in);
            
            while(true){
                System.out.println("Enter price [prees 0 to stop execution]");
                float price = scan.nextFloat();
                if(price == 0)
                    break;
            
                 fs.setFilter(new PriceAndVegPredicate(price,true));
                 fs.beforeFirst();
                 while(fs.next()){
                 
                     System.out.printf("%-30s %1.1f %1.1b \n", fs.getString("description"), fs.getFloat("price"),fs.getBoolean("vegetarian"));
                 
                 }
            
            }
        
        }
    }
}
