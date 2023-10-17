using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1._4
{
    class manhinh
    {
        public void Innhietdo(object sender, EventArgs e)
        {
            nhietke t = (nhietke)sender;
            Console.WriteLine("Nhiet do moi cua nhiet ke: {0}", t.T);
        }
    }
}
