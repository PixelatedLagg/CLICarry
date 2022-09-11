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