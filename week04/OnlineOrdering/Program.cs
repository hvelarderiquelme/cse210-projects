using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Product product1 = new Product("Wallet","wal23L", 89.99, 1);
        Product product2 = new Product("Jeans Blue","BJ3432", 67.89,2);
        Product product3 = new Product("T-shirt cotton","TCM01", 24.95,3);
        Address address1 = new Address("133", "East Glen Dr. SE","Medicine Hat","AB","Canada");
        Customer customer1 = new Customer("Horacio Velarde", address1);
        Order order1 = new Order([customer1],[product1,product2,product3],"ORD00013P","123RGDSEAB");

        Product product4 = new Product("Speaker 8in","SPK8", 99.99, 5);
        Product product5 = new Product("Guitar String Metal 6 pack","StrMe6", 34.79,4);
        Address address2 = new Address("12", "3rd Street N","Springfield","OH","USA");
        Customer customer2 = new Customer("Julian Walker", address2);
        Order order2 = new Order([customer2],[product4,product5],"ORD00013P","123RGDSEAB");

        Product product6 = new Product("Screws 3in 100 pack","Scr3in", 45.99, 2);
        Product product7 = new Product("Nails Galvanized 2in 300 pack","NGvz2in", 100,2);
        Product product8 = new Product("Finish nails 18ga box","18ga3000", 14.65,3);
        Product product9 = new Product("4x8 Maple 19mm","194x8Plw", 95.95,4);
        Address address3 = new Address("134", "4th Street S","Stirling","ON","United Kingdom");
        Customer customer3 = new Customer("Nigel Smith", address3);
        Order order3 = new Order([customer3],[product6,product7,product8,product9],"ORD00013P","123RGDSEAB");

        orders.Add(order1);
        orders.Add(order2);
        orders.Add(order3);
        
        foreach(var order in orders){
            order.GetOrderInfo();
        }
    }
}