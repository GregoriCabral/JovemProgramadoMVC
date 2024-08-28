﻿using JovenProgramadorMVC.Data.Mapeamento;
using JovenProgramadorMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace JovenProgramadorMVC.Data
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMapeamento());
        }

        public DbSet<Aluno> Aluno { get; set; }

    }
}
