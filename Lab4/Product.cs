using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lab4
{
    public abstract class Product
    {
        public string name;
        public string type;
        public int sale;
        protected Random rnd = new Random();
    }

    public class Monitor : Product 
    {
        public Monitor(string name) 
        {
            this.name = name;
            this.sale = rnd.Next(1, 100000);
            this.type = "Monitor";
        }
    }

    public class Mouse : Product
    {
        public Mouse(string name)
        {
            this.name = name;
            this.sale = rnd.Next(1, 100000);
            this.type = "Mouse";
        }
    }

    public class Keyboard : Product
    {
        public Keyboard(string name)
        {
            this.name = name;
            this.sale = rnd.Next(1, 100000);
            this.type = "Keyboard";
        }
    }
}
