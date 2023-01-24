namespace Loops
{

    class Program
    {

        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.ProductName = "Pants";
            product1.ProductPrice = 50;

            Product product2 = new Product();
            product2.ProductName = "Shoes";
            product2.ProductPrice = 80;

            Product product3 = new Product();
            product3.ProductName = "hat";
            product3.ProductPrice = 200;

            Product[] products = new Product[] {product1,product2,product3};

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName+" " + products[i].ProductPrice);
            }

            foreach (var Product in products)
            {
                Console.WriteLine(Product.ProductName + "  " + Product.ProductPrice);
            }

            int j  = 1;

            while (j < 3) 
            {
                Console.WriteLine(products[j].ProductName + " " + products[j].ProductPrice );
                j++;
                


            }

        }
             
    }
    class Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
       
    }
}