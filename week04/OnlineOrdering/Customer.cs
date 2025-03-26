//Class Customer
using System.Net.Sockets;

public class Customer{
    //Attributes
    private string _name;
    private Address _address;

    //Constructor
    public Customer(string name, Address: address){
        _name = name;
        _address = address;
    }

    //Methods
    public bool LivesInUs(){
        return true;
    }
}//end of class declaration