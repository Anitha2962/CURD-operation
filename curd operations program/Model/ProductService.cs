namespace curd_operations_program.Model
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products;
        public ProductService()
        {
            _products = new List<Product>
                 {
            new Product { Id = 1, Name = "Product 1", Price = 10.99M },
            new Product { Id = 2, Name = "Product 2", Price = 20.99M }
        };
        }
        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
        public IEnumerable<Product> GetAll()
        {
            return _products;
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }
        public void Update(Product product)
        {
            var existingProduct = GetById(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
            }
        }
        public void Delete(int id)
        {
            var productToRemove = GetById(id);
            if (productToRemove != null)
            {
                _products.Remove(productToRemove);
            }
        }
    }
}

