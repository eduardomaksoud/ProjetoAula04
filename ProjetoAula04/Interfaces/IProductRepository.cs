using ProjetoAula04.Entities;

namespace ProjetoAula04.Interfaces
{
    /// <summary>
    /// Interface for a product repository.
    /// </summary>
    public interface IProductRepository
    {
        void Export(Product product);
    }
}
