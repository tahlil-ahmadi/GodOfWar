using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Framework.Domain;

namespace UOM.Domain.Model.UnitOfMeasures
{
    public class IsoCode : ValueObject
    {
        public string Value { get;private set; }
        public IsoCode(string value)
        {
            if (value.Length != 2) throw new Exception("Invalid value for IsoCode");
            Value = value.ToUpper();
        }

        protected bool Equals(IsoCode other)
        {
            return string.Equals(Value, other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((IsoCode)obj);
        }

        public override int GetHashCode()
        {
            return (Value != null ? Value.GetHashCode() : 0);
        }

        public static bool operator ==(IsoCode code1, IsoCode code2)
        {
            if (ReferenceEquals(code1, null) || ReferenceEquals(code2, null))
                return false;

            return code1.Value.Equals(code2.Value);
        }

        public static bool operator !=(IsoCode code1, IsoCode code2)
        {
            return !(code1 == code2);
        }
    }
}
