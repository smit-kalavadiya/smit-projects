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
public class Cars {
    
    private int id;
    private String CompanyName;
    private String Model;
    private String Color;

    public Cars(int id,String CompanyName, String Model, String Color) {
        this.id = id;
        this.CompanyName = CompanyName;
        this.Model = Model;
        this.Color = Color;
    }

    public Cars(int id, String dummycategory, String dummyDescription, double d, boolean b) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    
    public int getid() {
        return id;
    }
    public String getCompanyName() {
        return CompanyName;
    }

    public String getModel() {
        return Model;
    }

    public String getColor() {
        return Color;
    }
    
    
    
    
}
