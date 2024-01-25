using ProjetoAula04.Controllers;

public class Program
{
    public static void Main(string[] args)
    {
        ProductController controller = new ProductController();
        controller.RegisterProduct();

        Console.ReadKey();
    }
}