using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public class Operand
    {
        private string data = "";
        public void update(string num) 
        {
            data += num;    
        }
        public double getData()
        {
            if (data == "") return 0;
            return Convert.ToDouble(data);
        }
        public string getRaw() 
        {
            return data;
        }
        public void clear() 
        {
            data= null;
        }
    }
}
