﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebAPI.Models
{
    public class Cliente
    {
        public string Nome { get; set; }

        public Cliente(string texto)
        {
            this.Nome = texto;
        }
    }
}