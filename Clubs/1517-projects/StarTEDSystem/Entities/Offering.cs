﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StarTEDSystem.Entities;

[Index("ProgramCourseID", Name = "IX_ProgramCourseID")]
public partial class Offering
{
    [Key]
    public int OfferingID { get; set; }

    public int ProgramCourseID { get; set; }

    [Required]
    [StringLength(5)]
    [Unicode(false)]
    public string Semester { get; set; }

    public int Pass { get; set; }

    public short? EnrollmentCap { get; set; }

    public short? MinStudentsPerSection { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EnrollmentCutoffDate { get; set; }

    [InverseProperty("Offering")]
    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

    [InverseProperty("Offering")]
    public virtual ICollection<ClassOffering> ClassOfferings { get; set; } = new List<ClassOffering>();

    [ForeignKey("ProgramCourseID")]
    [InverseProperty("Offerings")]
    public virtual ProgramCourse ProgramCourse { get; set; }

    [ForeignKey("Semester")]
    [InverseProperty("Offerings")]
    public virtual SchoolTerm SemesterNavigation { get; set; }
}