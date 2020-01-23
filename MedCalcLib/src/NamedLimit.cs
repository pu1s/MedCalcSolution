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
}
