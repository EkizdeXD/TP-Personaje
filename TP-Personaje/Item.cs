﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Personaje
{
    public class Item : Inventario
    {
        public Inventario? Inventario { get; set; }
    }
}
