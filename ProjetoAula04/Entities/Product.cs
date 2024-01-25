using System.Text.RegularExpressions;

namespace ProjetoAula04.Entities
{
    public class Product
    {
        #region Attributes
        private Guid? _id;
        private string? _name;
        private decimal? _price;
        private int? _quantity;
        private DateTime? _registryDate;
        #endregion

        #region Properties
        public Guid? Id { get; set; }
        public string? Name
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please type the product name");
                }

                Regex regex = new Regex("^[A-Za-zÀ-Üà-ü0-9\\s]{8,100}$");

                if (!regex.IsMatch(value))
                {
                    throw new ArgumentException("Please type a valid number with 8 to 100 characters.");
                }

                _name = value;
            }
            get => _name;
        }

        public decimal? Price
        {
            set
            {
                if (value < 0)
                    throw new ArgumentException("Please type a price greater than or equal to zero.");

                _price = value;
            }
            get => _price;
        }
        public int? Quantity
        {
            set
            {
                if (value < 0)
                    throw new ArgumentException("Please type a quantity greater than or equal to zero.");

                _quantity = value;
            }

            get => _quantity;
        }
        public DateTime? RegistryDate { get; set; }
        #endregion
    }
}
