using System;
namespace Algorithm
{
    interface IQueue
    {
        void Init(Byte[] soucs);
        void EnQueue(object o);
        object DeQueue();
        bool IsEmpty();
        int Size();
    }

}
