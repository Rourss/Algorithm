using System;
using System.Collections;

namespace Algorithm
{
    public class Stacks
    {
        public Stacks()
        {
        }
        private ArrayList list = new ArrayList();
        private object result;

        public ArrayList Stack()
        {
            return list;
        }
        /// <summary>
        /// 添加到栈顶部
        /// </summary>
        /// <param name="item"></param>
        public void Push(string item)
        {
            foreach (var str in item)
            {
                list.Add(str);
            }
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="o"></param>
        public void EnQueue(object o)
        {
            list.Add(o);
        }
        /// <summary>
        /// 删除顶部项.返回删除项
        /// </summary>
        /// <returns></returns>
        public object Pop()
        {
            if (IsEmpty())
            {
                result = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                return result;
            }
            return "";
        }
        /// <summary>
        /// 删除顶部项
        /// </summary>
        public void RemoveTop()
        {
            if (IsEmpty())
            {
                list.RemoveAt(list.Count - 1);
            }
        }
        /// <summary>
        /// 删除底部项
        /// </summary>
        public void RemoveBack()
        {
            if (IsEmpty())
            {
                list.RemoveAt(0);
            }
        }
        /// <summary>
        /// 返回顶部项
        /// </summary>
        /// <returns></returns>
        public string Peek()
        {
            if (IsEmpty())
            {
                return list[list.Count - 1].ToString();
            }
            return "";
        }
        /// <summary>
        /// 返回底部项
        /// </summary>
        /// <returns></returns>
        public string Back()
        {
            if (IsEmpty())
            {
                return list[0].ToString();
            }
            return "";
        }
        /// <summary>
        /// 是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (list.Count == 0)
            {
                return false;
            }
            return true;
        }

        public int Size()
        {
            return list.Count;
        }
    }
}
