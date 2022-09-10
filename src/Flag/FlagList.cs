namespace CLICarry
{
    public sealed class FlagList : List<Flag>
    {
        public Flag this[string s]
        {
            get
            {
                foreach (Flag flag in this)
                {
                    if (flag.Name == s)
                    {
                        return flag;
                    }
                }
                throw new Exception();
            }
        }
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
        public bool HasFlags(params string[] names)
        {
            foreach (string name in names)
            {
                foreach (Flag flag in this)
                {
                    if (flag.Name == name)
                    {
                        continue;
                    }
                }
                return false;
            }
            return false;
        }
    }
}