public class University {
    public string Name {get;}
    public string Address {get;private set;}
    public University(string name, string address) {
        Name = name;
        Address = address;
    }

    public void SetAddress(string address) {
        Address = address;
    }

    public void SetAddress(Address address) {
        Address = address.ToString();
    }

    public void SetAddress(string country, string city, string street, int building) {
        Address = $"{country} {city} {street} {building}";
    }
}

public class Address {
    
}