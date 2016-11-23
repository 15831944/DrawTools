using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ClassParent
    {
        public ClassParent(int index, string name)
        {
        }
    }

    class ClassChild : ClassParent
    {
        public ClassChild() : this(10)
        {
      
        }
        public ClassChild(int index) : base(index, "")
        {
        }
            
        }
    }

