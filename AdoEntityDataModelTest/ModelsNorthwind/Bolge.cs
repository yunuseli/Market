﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdoEntityDataModelTest.ModelsNorthwind;

public partial class Bolge
{
    [Key]
    [Column("BolgeID")]
    public int BolgeId { get; set; }

    [Required]
    [StringLength(50)]
    public string BolgeTanimi { get; set; }

    [InverseProperty("Bolge")]
    public virtual ICollection<Bolgeler> Bolgeler { get; } = new List<Bolgeler>();
}