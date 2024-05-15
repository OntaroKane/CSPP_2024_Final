using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Imdb_API.Models.Entities;

public partial class name_basic
{
    [Key]
    [StringLength(10)]
    public string nconst { get; set; } = null!;

    [StringLength(256)]
    public string? primaryname { get; set; }

    [StringLength(4)]
    public string? birthyear { get; set; }

    [StringLength(4)]
    public string? deathyear { get; set; }
}
