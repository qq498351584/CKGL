﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 厂家
    /// </summary>
    public class Manufacturer
    {

        public string ManufacturerName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ImportStorage> Imports { get; set; }
    }
}
