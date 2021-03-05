﻿using GRUBSCHOOL.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GRUBSCHOOL.Infra.Data.Seeds
{
    public static class CursoTipoSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var cursoTipos = new List<CursoTipo>
            {
                new CursoTipo("Técnico"),
                new CursoTipo("Saúde"),
                new CursoTipo("PUNIV")
            };

            modelBuilder.Entity<CursoTipo>().HasData(cursoTipos);

        }
    }
}
