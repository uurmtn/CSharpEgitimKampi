using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-- Create Read Update Delete
            Console.WriteLine("********** Menü Sipariş İşlem Paneli **********");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            #region Karegori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz Kategori Adını Giriniz: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Kategori Başarılı Bir Şekilde Eklendi");
            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün Ekleme Başarılı");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select* From TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("------------------------------------------------------");
            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi
            //Console.Write("Silmek İstediğiniz Ürünün İd'sini Giriniz: ");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme işlemi yapıldı");
            #endregion

            #region Güncelleme İşlemleri

            Console.Write("Güncellenecek Ürün Id Giriniz: ");
            int productId = int.Parse(Console.ReadLine());
            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();
            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice  Where ProductId=@productId", connection);
            command.Parameters.AddWithValue("@productName",productName);
            command.Parameters.AddWithValue("@productPrice",productPrice);
            command.Parameters.AddWithValue("@productId",productId);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Güncelleme Başarılı");

            #endregion


            Console.Read();
        }
    }
}
