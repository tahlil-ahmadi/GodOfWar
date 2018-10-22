using NHibernate;
using ProductManagement.Domain.Model.Product;

namespace ProductManagement.Persistence.NH.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ISession _session;

        public ProductRepository(ISession session)
        {
            this._session = session;
        }

        public void Create(Product product)
        {
            _session.Save(product);
        }
    }
}
