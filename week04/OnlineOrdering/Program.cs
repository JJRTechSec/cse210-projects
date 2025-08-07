using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        Product product1 = new Product();
        product1.SetProductName("");
        product1.SetProductId(00001);
        product1.SetProductPrice();
        product1.SetProductQuantity();

        Product product2 = new Product();
        product2.SetProductName("");
        product2.SetProductId(00002);
        product2.SetProductPrice();
        product2.SetProductQuantity();

        Product product3 = new Product();
        product3.SetProductName("");
        product3.SetProductId(00003);
        product3.SetProductPrice();
        product3.SetProductQuantity();


        Order order2 = new Order();

        Product product1 = new Product();
        product1.SetProductName("");
        product1.SetProductId();
        product1.SetProductPrice();
        product1.SetProductQuantity();

        Product product2 = new Product();
        product2.SetProductName("");
        product2.SetProductId();
        product2.SetProductPrice();
        product2.SetProductQuantity();
    }
}