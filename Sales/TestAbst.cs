using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    abstract class TestAbst
    {
        public DateTime birth { get; set; }
        public byte sexType { get; set; }
        public string name { get; set; }
        abstract public void cry();
    }

    class ImplTestAbstHuman : TestAbst
    {
        public override void cry()
        {
            Console.Write("しくしく");
        }
    }
    class ImplTestAbstCat : TestAbst
    {
        public override void cry()
        {
            Console.Write("にゃー");
        }
    }

    //class TestTest
    //{
    //    ImplTestAbstCat a = new ImplTestAbstCat();
    //    ImplTestAbstHuman b = new ImplTestAbstHuman();
    //    TestAbst[] r = { a, b };
    //    for(int i = 0; i < r.length; i++) {
    //        r[i].cry();        
    //}
}
