﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoIOT.Models
{
    public class Luz
    {
        public int id { get; set; }
        public string nome { get; set; }
        public bool luz { get; set; }
        public bool status { get; set; }
    }
}