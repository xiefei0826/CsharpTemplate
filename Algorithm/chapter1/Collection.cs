using System.Collections;

namespace chapter1
{
    public class Collection : CollectionBase
    {
        public void Add(object item)
        {
            InnerList.Add(item);
        }
        public void Remove(object item)
        {
            InnerList.Remove(item);
        }
        public new void Clear()
        {
            InnerList.Clear();
        }
        public new int Count()
        {
            return InnerList.Count;
        }
        public void Insert(int index, object data)
        {
            InnerList.Insert(index, data);
        }
    }
}
