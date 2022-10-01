/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Entity;

/**
 *
 * @author KiLLeR
 */
public class Products {
    
    int id;
    String name;
    String description;
    String type;
    double price;
    int quantity;
    String sellername;

    public Products(int id, String name, String description, String type, double price, int quantity, String sellername) {
        this.id = id;
        this.name = name;
        this.description = description;
        this.type = type;
        this.price = price;
        this.quantity = quantity;
        this.sellername = sellername;
    }

    public int getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    public String getDescription() {
        return description;
    }

    public String getType() {
        return type;
    }

    public double getPrice() {
        return price;
    }

    public int getQuantity() {
        return quantity;
    }

    public String getSellername() {
        return sellername;
    }
    
    
    
    
}
