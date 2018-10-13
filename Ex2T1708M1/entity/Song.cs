using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2T1708M1.entity
{
    class Song
    {
        private string _name, _thumbnail;

        public string name { get => _name; set => _name = value; }
        public string thumbnail { get => _thumbnail; set => _thumbnail = value; }
    }
}
