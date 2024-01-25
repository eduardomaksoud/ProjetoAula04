using Dapper;
using ProjetoAula04.Entities;
using ProjetoAula04.Interfaces;
using System.Data.SqlClient;

namespace ProjetoAula04.Repositories
{
    public class ProductRepositorySql : IProductRepository
    {
        public void Export(Product product)
        {
            using (var connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDAula04;Integrated Security=True;"))
            {
                connection.Execute(@"
                    INSERT INTO PRODUCT(ID,NAME,PRICE,QUANTITY,REGISTERDATE)
                    VALUES(@Id,@Name,@Price,@Quantity, @RegisterDate)
                ",
                new
                {
                    @Id = product.Id,
                    @Name = product.Name,
                    @Price = product.Price,
                    @Quantity = product.Quantity,
                    @RegisterDate = product.RegistryDate,
                });
            }
        }
    }
}
