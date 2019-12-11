using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCalc
{
    #region Limit
    /// <summary>
    /// 
    /// </summary>
    public class Limit : IEquatable<Limit>
    {
        public static readonly Limit Empty = new Limit();
        public string LimitName { get; private set; }
        private readonly int _hashCode;
        public Limit()
        {
            _hashCode = GenerateHashCode();
            LimitName = string.Empty;
            Lower = 0f;
            Upper = 0f;
        }
        public Limit(string limitName = "", float lower = 0.0f, float upper = 0.0f) : this()
        {
            LimitName = limitName;
            Lower = lower;
            Upper = upper;
        }
        public float Lower { get; private set; }
        public float Upper { get; private set; }
        public bool IsTry => _IsTry();
        public bool IsEmpty => _IsEmpty();
        private bool _IsTry()
        {
            return (Lower < Upper) && (Lower != 0f || Upper != 0f);
        }
        private bool _IsEmpty()
        {
            return (Lower == 0f && Upper == 0f) && (Lower == Upper);
        }

        private static int GenerateHashCode()
        {
            return DateTime.Now.Millisecond * DateTime.Now.Minute * DateTime.Now.Hour * DateTime.Now.Day;
        }
        public override int GetHashCode()
        {
            return _hashCode;
        }
        public static bool operator ==(Limit left, Limit right) => left.GetHashCode() == right.GetHashCode();

        public static bool operator !=(Limit left, Limit right) => left.GetHashCode() != right.GetHashCode();

        public override string ToString()
        {
            return
                 "Limit Name: " + LimitName + '\n' +
                 "Limit Hash Code: " + GetHashCode().ToString() + '\n' +
                 "Lower Value: " + Lower.ToString() + '\n' +
                 "Upper Value: " + Upper.ToString() + '\n';
        }



        public override bool Equals(object obj)
        {
            return Equals(obj as Limit);
        }

        public bool Equals(Limit other)
        {
            return other != null &&
                   LimitName == other.LimitName &&
                   _hashCode == other._hashCode &&
                   Lower == other.Lower &&
                   Upper == other.Upper;
        }
    }
    #endregion
}
