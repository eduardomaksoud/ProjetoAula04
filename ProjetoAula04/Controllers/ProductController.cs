using ProjetoAula04.Entities;
using ProjetoAula04.Repositories;

namespace ProjetoAula04.Controllers
{
    public class ProductController
    {
        public void RegisterProduct()
        {
            try
            {
                Console.WriteLine("\nRegister Product\n");

                Product product = new Product();
                product.Id = Guid.NewGuid();
                product.RegistryDate = DateTime.Now;

                Console.WriteLine("\nType the product name..: ");
                product.Name = Console.ReadLine();

                Console.WriteLine("\nType the product price..: ");
                product.Price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("\nType the product quantity..: ");
                product.Quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("\nWhere would you like to save the data?");
                Console.Write("Type (1)SQL or (2)JSON");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        var productRepositorySql = new ProductRepositorySql();
                        productRepositorySql.Export(product);
                        Console.WriteLine("\nData stored with success in sql database.");
                        break;
                    case 2:
                        var productRepositoryJson = new ProductRepositoryJson();
                        productRepositoryJson.Export(product);
                        Console.WriteLine("\nJson data stored with success.");
                        break;
                    default:
                        Console.WriteLine("\nInvalid option.");
                        break;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("\nValidation error:" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nFailed while registering the product:" + e.Message);
            }
        }
    }
}
