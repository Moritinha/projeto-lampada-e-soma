using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    class Lanterna
    {
        public string status { get; set; }

        public Bateria bateria { get; set; }

        public Lanterna() { this.status = "DESLIGADO";
            this.bateria = new Bateria();

        }
    }
}
