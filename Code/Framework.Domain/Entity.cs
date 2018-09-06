using System.Collections.Generic;

namespace Framework.Domain
{
    public abstract class Entity<TKey>
    {
        public TKey Id { get; protected set; }

        protected bool Equals(Entity<TKey> other)
        {
            return EqualityComparer<TKey>.Default.Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Entity<TKey>)obj);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<TKey>.Default.GetHashCode(Id);
        }
    }
}
