using Newtonsoft.Json;
using ProjetoAula04.Entities;
using ProjetoAula04.Interfaces;

namespace ProjetoAula04.Repositories
{
    internal class ProductRepositoryJson : IProductRepository
    {
        public void Export(Product product)
        {
            var json = JsonConvert.SerializeObject(product);

            using (var streamWriter = new StreamWriter("c:\\temp\\products.json", true))
            {
                streamWriter.Write(json);
            }

        }
    }
}
