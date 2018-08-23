using Framework.Domain;

namespace UOM.Domain.Model.Dimensions
{
    public class Dimension : AggregateRoot<long>
    {
        public string Name { get; private set; }
        protected Dimension(){} //For ORM Only
        public Dimension(long id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
