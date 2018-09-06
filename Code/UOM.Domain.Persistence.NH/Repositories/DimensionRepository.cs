using NHibernate;
using UOM.Domain.Model.Dimensions;

namespace UOM.Persistence.NH.Repositories
{
    public class DimensionRepository : IDimensionRepository
    {
        private readonly ISession _session;
        public DimensionRepository(ISession session)
        {
            this._session = session;
        }

        public void Add(Dimension dimension)
        {
            //TODO: move transaction to unit of work
            _session.Transaction.Begin();
            _session.Save(dimension);
            _session.Transaction.Commit();
        }
    }
}
