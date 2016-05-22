using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    class Section
    {



        /*
         * properties and getter, setter
         */

        private string _title;
        public string Title
        {
            get{ return _title; }
            set{ _title = value; }

        }

        public byte Id
        {
            get;
            set;
        }




        /*
         * override methods
         */


        /// <summary>
        /// hoge
        /// </summary>
        /// <returns>fuga</returns>
        public override int GetHashCode()
        {
            return Id;
        }
        /**
         * <summary>hoge</summary>
         * <returns>fuga</returns>
         */
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            int a = GetHashCode();
            int b = obj.GetHashCode();
            return (a == b);
        }

        public override string ToString()
        {
            return Title;
        }




        /*
         * override operator
         */

        static public bool operator ==(Section a, Section b)
        {
            if ((object)a == null) return ((object)b == null);
            return a.Equals(b);
        }
        static public bool operator !=(Section a, Section b)
        {
            if ((object)a == null) return !((object)b == null);
            return !a.Equals(b);
        }
    }
}
