using SuperShop.Data.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShop.Data
{
    public class Repository : IRepository
    {
        private DataContext _context;
        public Repository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProduct()        //busca todos os produtos
        {
            return _context.Products.OrderBy(p => p.Name);
        }

        public Product GetProduct(int id)    //busca apenas um produto
        {
            return _context.Products.Find(id);
        }

        public void AddProduct(Product product)    // adiciona o produto (em memória)
        {
            _context.Products.Add(product);
        }

        public void UpdateProduct(Product product)    // edita 
        {
            _context.Products.Update(product);
        }

        public void RemoveProduct(Product product)     //delete
        {
            _context.Products.Remove(product);
        }

        public async Task<bool> SaveAllAsync()          // faz a gravação da informação correta na base de dados 
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public bool ProductExist(int id)
        {
            return _context.Products.Any(p => p.Id == id);
        }
    }
}
