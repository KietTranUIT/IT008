using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._1
{
    public abstract class Shape
    {
        protected string name;
        protected string feature;
        public abstract void Input();
        public abstract double Area();
        public abstract void Draw();
    }
}
