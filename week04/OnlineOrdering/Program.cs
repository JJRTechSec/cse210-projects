using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        Product order1Product1 = new Product();
        order1Product1.SetProductName("Nike Alphafly 3");
        order1Product1.SetProductId(11111);
        order1Product1.SetProductPrice(299.99);
        order1Product1.SetProductQuantity(5);
        order1.products.Add(order1Product1);

        Product order1Product2 = new Product();
        order1Product2.SetProductName("Saucony Endorphin Pro 4");
        order1Product2.SetProductId(22222);
        order1Product2.SetProductPrice(244.49);
        order1Product2.SetProductQuantity(2);
        order1.products.Add(order1Product2);

        Product order1Product3 = new Product();
        order1Product3.SetProductName("Adidas Pro Evo 4");
        order1Product3.SetProductId(33333);
        order1Product3.SetProductPrice(320.99);
        order1Product3.SetProductQuantity(1);
        order1.products.Add(order1Product3);

        order1.DisplayPackingLabel();

        Address address1 = new Address();
        address1.SetStreetAddress("221B Baker Street");
        address1.SetCity("London");
        address1.SetState("London");
        address1.SetCountry("United Kingdom");
        address1.GetDomesticOrNot();


        Order order2 = new Order();

        Product order2Product1 = new Product();
        order2Product1.SetProductName("Blueberry Muffin");
        order2Product1.SetProductId(12345);
        order2Product1.SetProductPrice(0.95);
        order2Product1.SetProductQuantity(15);
        order2.products.Add(order2Product1);

        Product order2Product2 = new Product();
        order2Product2.SetProductName("Birthday Cake");
        order2Product2.SetProductId(24358);
        order2Product2.SetProductPrice(12.57);
        order2Product2.SetProductQuantity(3);
        order2.products.Add(order2Product2);

        order2.DisplayPackingLabel();
    }
}