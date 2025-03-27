//Class Customer
using System.Net.Sockets;

public class Customer{
    //Attributes
    private string _customerName;
    private Address _address;

    //Constructor
    public Customer(string customerName, Address address){
        _customerName = customerName;
        _address = address;
    }

    //Methods
    public string GetCustomerInfo(){
        string customerInfo = $"Customer: {_customerName} \nAddress: {_address.GetAddress()}";
        return customerInfo;
    }
    public bool LivesInUSA(){
       bool usAddress= _address.IsUSAddress();
        return usAddress;
    }
}//end of class declaration