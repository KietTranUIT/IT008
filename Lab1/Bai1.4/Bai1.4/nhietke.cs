using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._4
{
    class nhietke
    {
        private int t;
        public int T
         {
            get
            {
                return t;
            }
            set
            {
                t = value; 
                iftchanged();
            }
        }
        public event EventHandler tchanged;

        protected virtual void iftchanged()
        {
            tchanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
