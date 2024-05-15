using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Imdb_API.Models.Entities;

public partial class title_basic
{
    [Key]
    [StringLength(10)]
    public string tconst { get; set; } = null!;

    [StringLength(20)]
    public string? titletype { get; set; }

    public string? primarytitle { get; set; }
}
