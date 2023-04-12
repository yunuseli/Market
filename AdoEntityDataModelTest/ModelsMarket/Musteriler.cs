﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdoEntityDataModelTest.ModelsMarket;

public partial class Musteriler
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOn { get; set; }

    [Required]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOn { get; set; }

    [StringLength(50)]
    public string LastModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    [Required]
    [StringLength(50)]
    public string Ad { get; set; }

    [Required]
    [StringLength(50)]
    public string Soyad { get; set; }

    [Required]
    [StringLength(50)]
    public string Telefon { get; set; }
}