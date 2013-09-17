using System;
using System.Collections.Generic;

namespace JeanRichard.Xbmc.Lib.JsonRpc
{
    public abstract class FlagsBase
    {
        private readonly HashSet<string> _values = new HashSet<string>();

        public HashSet<string> Values
        {
            get { return _values; }
        }

        public override string ToString()
        {
            return string.Join(", ", Values);
        }
    }

    public class FlagsBase<TFlagType> : FlagsBase where TFlagType : FlagsBase<TFlagType>, new()
    {
        protected static TFlagType Combine(params FlagsBase<TFlagType>[] flags)
        {
            TFlagType newFlags = new TFlagType();
            foreach (TFlagType flag in flags)
            {
                foreach (string value in flag.Values)
                {
                    newFlags.Values.Add(value);
                }
            }
            return newFlags;
        }

        public static TFlagType operator |(FlagsBase<TFlagType> left, FlagsBase<TFlagType> right)
        {
            if (left == null)
            {
                throw new ArgumentNullException("left");
            }
            if (right == null)
            {
                throw new ArgumentNullException("right");
            }

            return Combine(right, left);
        }

        protected FlagsBase(string value)
        {
            Values.Add(value);
        }

        protected FlagsBase()
        {}
    }
}