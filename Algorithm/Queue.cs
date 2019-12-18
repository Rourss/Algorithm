using System;
using System.Collections;

namespace Algorithm
{
    public class Que:IQueue
    {
        private ArrayList list = new ArrayList();
        private object result;

        public void Init(Byte[] soucs)
        {
            foreach (var item in soucs)
            {
                list.Add(item);
            }
        }

        public void EnQueue(object o)
        {
            list.Add(o);
        }
        public object DeQueue()
        {
            if (this.IsEmpty())
            {
                result = list[0];
                list.RemoveAt(0);
                return result;
            }
            return null;
        }

        public string Peek()
        {
            return list[list.Count].ToString();
        }
        public bool IsEmpty()
        {
            return this.list.Count == 0;
        }

        public int Size()
        {
            return list.Count;
        }
    }
}
