﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyMovieBankApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyMovieBank_DBContext : DbContext
    {
        public MyMovieBank_DBContext()
            : base("name=MyMovieBank_DBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Directors> Directors { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<MovieGenres> MovieGenres { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
    }
}