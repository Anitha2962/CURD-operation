namespace curd_operations_program.Model
{
    public interface IProductService
    {
        Product GetById(int id);
        IEnumerable<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(int Id);
    }
}
