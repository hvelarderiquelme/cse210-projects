//Class Address
public class Address{
    //Attributes
    private string _streetName;
    private string _streetNumber;
    private string _city;
    private string _state;
    private string _country;

    //Constructor
    public Address(string streetName, string streetNumber, string city, string state, string country){
        _streetName = streetName;
        _streetNumber = streetNumber;
        _city = city;
        _state = state;
        _country = country;
    }

    //Methods
    public string GetAddress(){
        return "Address";
    }

    public bool IsUsAddress(){
        return true;
    }
}