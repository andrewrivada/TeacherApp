using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_App
{
    class global_status // this class is used to contain global statuses for application
    {

        private static bool _first_load = true;

        public static bool First_load
        {
            get { return _first_load; }
            set { _first_load = value; }
        }


        private static bool _list_changed = false;

        public static bool List_changed
        {
            get { return _list_changed; }
            set { _list_changed= value; }
        }
    }
}
