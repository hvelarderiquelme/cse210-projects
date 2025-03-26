//Class Order
using System.Reflection.Emit;

public class Order{
    //Attributes
    private List<Product> _products;
    private List<Customer> _customers;
    private string _packingSlip;
    private string _shippingSlip;

    //Constructor
    public Order(List<Product> products, List<Customer> customers, string packingSlip, string shippingSlip){
        _products = products;
        _customers = customers;
        _packingSlip = packingSlip;
        _shippingSlip = shippingSlip;
    }

    //Methods
    public double TotalCostOrder(double ProductTotalCost(double price, int quantity), Customer customer){
        return 4.3;
    }

    public string PackingLabel(){
        return "label";
    }

    public string ShippingLabel(){
        return "label";
    }

}