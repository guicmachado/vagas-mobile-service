﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VagasMobileService.Models
{
    public class Vaga
    {
        public int Codigo { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Local { get; set; }

        public string FormaContratacao { get; set; }

        public string Empresa { get; set; }

        public string Data { get; set; }

        public Cargo Cargo { get; set; }
    }
}