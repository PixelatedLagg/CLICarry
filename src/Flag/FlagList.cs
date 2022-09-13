using System;
using System.Collections.Generic;

namespace CLICarry
{
    /// <summary>Store a list of Flags.</summary>
    public sealed class FlagList : List<Flag>
    {
        /// <summary>Find a Flag contained in the FlagList by name.</summary>
        /// <param name="name">The Flag name.</param>
        public Flag this[string name]
        {
            get
            {
                foreach (Flag flag in this)
                {
                    if (flag.Name == name)
                    {
                        return flag;
                    }
                }
                throw new Exception();
            }
        }

        /// <summary>Check if the FlagList has a Flag by name.</summary>
        /// <param name="name">The Flag name.</param>
        public bool HasFlag(string name)
        {
            foreach (Flag flag in this)
            {
                if (flag.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>Check if the FlagList has multiple Flags by name.</summary>
        /// <param name="names">The Flag names.</param>
        public bool HasFlags(params string[] names)
        {
            bool hasFlag = false;
            foreach (string name in names)
            {
                foreach (Flag flag in this)
                {
                    if (flag.Name == name)
                    {
                        hasFlag = true;
                        break;
                    }
                }
                if (hasFlag)
                {
                    hasFlag = false;
                    continue;
                }
                return false;
            }
            return true;
        }
    }
}