//Class Product
public class Product{
    //Attributes
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    //Constructor
    public Product(string productName, string productId, double price, int quantity){
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    //Methods
    public double CalculateProductTotalCost(){
        double productTotalCost = _price * _quantity;
        return productTotalCost;
    }

    public string GetProductName(){
        string productName = _productName;
        return productName;
    }

    public double GetProductPrice(){
        return _price;
    }

    public int GetQuantity(){
        return _quantity;
    }

}//end of class declaration