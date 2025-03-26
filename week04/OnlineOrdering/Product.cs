//Class Product
public class Product{
    //Attributes
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    //Constructor
    public Product(string name, string productId, double price, int quantity){
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    //Methods
    public double ProductTotalCost(double price, int quantity){
        return 4.2;
    }

}//end of class declaration