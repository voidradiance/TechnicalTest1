// Buat console apps yang menjelaskan tentang perbedaan antara reference type dan value type di .NET.

namespace TechnicalTest1
{
    /*
        Sebelumnya di C# terdapat 2 jenis tipe data, yaitu value type dan reference type.
        1. Value Type
           Data akan disimpan langsung dalam memori setelah di deklarasikan.
           Tipe data ini berukuran kecil dan lebih efisien dalam hal penggunaan memori dibandingkan reference type.
           Contoh value type : int, long, float, double, decimal, bool, char, Enums, 
                               dan struct (tipe yang memiliki field dan method, mirip dengan class tapi diperuntukan untuk data yang kecil).
        2. Reference Type
           Tidak seperti value type, setelah variable di deklarasikan maka memori akan dialokasikan untuk menyimpan referensi ke lokasi memori tempat data disimpan.
           Contoh reference type : class, interface, delegated, string (referensi bawaan), object, dan record.
            
    */
    public struct ValueTypeExample // Value Type
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerCity { get; set; }

        public CustomerOrder DetailOrder { get; set; }

        public void PlaceOrder()
        {
            Console.WriteLine($"{CustomerName} memesan {DetailOrder.ProductOrder} sebanyak {DetailOrder.Quantity}");
        }
    }

    public class CustomerOrder // Reference Type
    {
        public string ProductOrder { get; set; }
        public int Quantity { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var firstOrder = new ValueTypeExample
            {
                CustomerName = "Agung Setiawan",
                CustomerEmail = "qwerty@gmail.com",
                CustomerCity = "Jakarta",
                DetailOrder = new CustomerOrder()
                {
                    ProductOrder = "Penggaris",
                    Quantity = 2
                }
            };

            var secondOrder = firstOrder;
            secondOrder.CustomerName = "Bobby Prayoga";
            secondOrder.CustomerEmail = "bbbqqq@gmail.com";
            secondOrder.CustomerCity = "Bandung";
            secondOrder.DetailOrder = new CustomerOrder()
            {
                ProductOrder = "Tusuk Sate",
                Quantity = 100
            };

            Console.WriteLine("Pesanan pertama ->");
            firstOrder.PlaceOrder();
            Console.WriteLine("Pesanan kedua ->");
            secondOrder.PlaceOrder();

        }
    }
}

