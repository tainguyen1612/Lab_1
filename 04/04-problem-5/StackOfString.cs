using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_problem_5
{
    class StackOfString
    {
        private List<string> list;

        public StackOfString()
        {
            this.list = new List<string>();
        }
        public List<string> List
        {
            get { return this.list; }
        }
        public void Push(string item)
        {
            this.list.Add(item);
        }

        public string Pop()
        {
            string item = this.list.Last();
            this.list.Remove(item);
            return item;
        }

        public string Peek()
        {
            string item = this.list.Last();
            return item;
        }

        public bool IsEmpty()
        {
            if (this.list.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
