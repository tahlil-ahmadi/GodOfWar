namespace ProductManagement.Domain.Model.Product
{
    public class GenericProduct : Product
    {
        public GenericProduct(string name, Product parent) : base(name, parent)
        {
        }
    }
}
