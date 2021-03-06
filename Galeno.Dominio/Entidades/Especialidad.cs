﻿using System;
using System.Collections.Generic;
using System.Text;
using Galeno.Infraestructura.Repositorio;

namespace Galeno.Dominio.Entidades
{
    public class Especialidad : EntityBase
    {
        public string Descripcion { get; set; }
        
        public virtual ICollection<PrestadorEspecialidad> PrestadorEspecialidades { get; set; }
    }
}
