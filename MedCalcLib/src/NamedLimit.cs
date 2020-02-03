using System;

namespace MedCalc
{ 
    #region Именованный предел
  
    public class NamedLimit
    {
        public Limit Limit { get; private set; }
        public string Name { get; private set; }
        public long Key { get; private set; }

        
        public NamedLimit()
        {
            
            Limit = new Limit();
            Name = "Unnamed";
            Key = InitKey();
        }

        
        public NamedLimit(Limit limit, string name = "") : this()
        {
            Limit = limit;
            if(!string.IsNullOrEmpty(name)) Name = name;
        }

        
        public NamedLimit(float lower, float upper, string name = "") : this(new Limit(lower, upper), name)
        {
            float lval, uval;
            var type = typeof(NamedLimit).GetCustomAttributes(false);
            foreach (LimitDataAttribute attr in type)
            {
                lval = attr.LowerValue;
                uval = attr.UpperValue;
            }
        }

        private static long InitKey()
        {
            Random random = new Random();
            long tick = DateTime.Now.Ticks;
            long result = tick * random.Next(0, 1);
            return result;
        }

        public override bool Equals(object obj)
        {
            return this.Key == ((NamedLimit)obj).Key;
        }

        public override int GetHashCode()
        {
            return (int)Key;
        }
    }
    #endregion

    public class LimitDataAttribute : Attribute
    {
        public LimitDataAttribute()
        {
            _defaultLowerValue = 0;
            _defaultUpperValue = 0;
        }

        public LimitDataAttribute(float lowerValue = 0, float upperValue = 100) : this()
        {
            _defaultLowerValue = lowerValue;
            _defaultUpperValue = upperValue;
        }
        private float _defaultLowerValue;

        private float _defaultUpperValue;

        public float LowerValue => _defaultLowerValue;

        public float UpperValue => _defaultUpperValue;
    }
}
