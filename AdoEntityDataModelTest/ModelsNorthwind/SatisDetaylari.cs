﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdoEntityDataModelTest.ModelsNorthwind;

[PrimaryKey("SatisId", "UrunId")]
[Table("Satis Detaylari")]
[Index("SatisId", Name = "SatisID")]
[Index("SatisId", Name = "SatislarOrder_Details")]
[Index("UrunId", Name = "UrunID")]
[Index("UrunId", Name = "UrunlerOrder_Details")]
public partial class SatisDetaylari
{
    [Key]
    [Column("SatisID")]
    public int SatisId { get; set; }

    [Key]
    [Column("UrunID")]
    public int UrunId { get; set; }

    [Column(TypeName = "money")]
    public decimal BirimFiyati { get; set; }

    public short Miktar { get; set; }

    public float İndirim { get; set; }

    [ForeignKey("SatisId")]
    [InverseProperty("SatisDetaylari")]
    public virtual Satislar Satis { get; set; }

    [ForeignKey("UrunId")]
    [InverseProperty("SatisDetaylari")]
    public virtual Urunler Urun { get; set; }
}