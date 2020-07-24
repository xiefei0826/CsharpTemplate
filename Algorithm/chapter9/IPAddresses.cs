using System.Collections;

namespace chapter9
{
    public class IPAddresses : DictionaryBase
    {
        public IPAddresses()
        {
        }
        public void Add(string name, string ip)
        {
            InnerHashtable.Add(name, ip);
        }
        public string Item(string name)
        {
            return InnerHashtable[name].ToString();
        }
        public void Remove(string name)
        {
            InnerHashtable.Remove(name);
        }
    }
}
