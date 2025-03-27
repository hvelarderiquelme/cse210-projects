//Class Order
using System.Reflection.Emit;

public class Order{
    //Attributes
    private List<Product> _products = new List<Product>();
    private List<Customer> _customers = new List<Customer>();
    private string _packingSlip;
    private string _shippingSlip;
    private double _totalCost;
    private bool _inUSA;
    //Constructor
    public Order(List<Customer> customers, List<Product> products, string packingSlip, string shippingSlip){
        _products = products;
        _customers = customers;
        _packingSlip = packingSlip;
        _shippingSlip = shippingSlip;
    }

    //Methods
    public double TotalCostOrder(bool inUSA){
        
        foreach(var product in _products){
            
            _totalCost += product.CalculateProductTotalCost();
            
        }
        Console.WriteLine($"Order subtotal: ${_totalCost}");
        if(inUSA == true){
            Console.WriteLine("Shipping cost: $5.");
            _totalCost = _totalCost + 5;
        }
        else{
            Console.WriteLine("Shipping cost: $35.");
            _totalCost += 35;
        }
        return _totalCost;
    }

    public string PackingLabel(){
        return "label";
    }

    public string ShippingLabel(){
        return "label";
    }

    public void GetOrderInfo(){
        foreach(var customer in _customers){
            
            Console.WriteLine($"********************************  Oder Details  *******************************");
            Console.WriteLine($"{customer.GetCustomerInfo()}");
            Console.WriteLine($"Package Number: {_packingSlip}, Shipping code: {_shippingSlip}");
            _inUSA = customer.LivesInUSA();

            foreach(var product in _products){

                Console.WriteLine($"Item: {product.GetProductName()} ---- Price:{product.GetProductPrice()} *** Quantity: {product.GetQuantity()} *** Subtotal: ${product.CalculateProductTotalCost()}");    

            }
            
            double totalCost = TotalCostOrder(_inUSA);
            Console.WriteLine($"Grand Total: ${totalCost}");
        }
    }

}