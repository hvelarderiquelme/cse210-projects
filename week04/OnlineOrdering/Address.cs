//Class Address
public class Address{
    //Attributes
    private string _streetName;
    private string _streetNumber;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    //Constructor
    public Address(string streetNumber, string streetName, string city, string stateOrProvince, string country){
        _streetName = streetName;
        _streetNumber = streetNumber;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    //Methods
    public string GetAddress(){
        string address = $"{_streetNumber} {_streetName}, {_city}, {_stateOrProvince}, {_country}.";
        return address;
    }

    public bool IsUSAddress(){
        if (_country == "USA"){
            return true;
        }
        else{
            return false;
        }
    }
}