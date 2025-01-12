﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StarTEDSystem.Entities;

public partial class Student
{
    [Key]
    public int StudentNumber { get; set; }

    [Required]
    [StringLength(20)]
    [Unicode(false)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(20)]
    [Unicode(false)]
    public string LastName { get; set; }

    [Required]
    [StringLength(20)]
    [Unicode(false)]
    public string DisplayName { get; set; }

    [Required]
    [StringLength(2)]
    [Unicode(false)]
    public string CountryCode { get; set; }

    [Required]
    [StringLength(1)]
    [Unicode(false)]
    public string Gender { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime BirthDate { get; set; }

    [InverseProperty("StudentNumberNavigation")]
    public virtual ICollection<ClassMember> ClassMembers { get; set; } = new List<ClassMember>();

    [InverseProperty("StudentNumberNavigation")]
    public virtual ICollection<ClubMember> ClubMembers { get; set; } = new List<ClubMember>();

    [ForeignKey("CountryCode")]
    [InverseProperty("Students")]
    public virtual Country CountryCodeNavigation { get; set; }

    [InverseProperty("StudentNumberNavigation")]
    public virtual ICollection<Renter> Renters { get; set; } = new List<Renter>();

    [InverseProperty("Student")]
    public virtual ICollection<StudentAddress> StudentAddresses { get; set; } = new List<StudentAddress>();

    [InverseProperty("StudentNumberNavigation")]
    public virtual ICollection<StudentPayment> StudentPayments { get; set; } = new List<StudentPayment>();
}