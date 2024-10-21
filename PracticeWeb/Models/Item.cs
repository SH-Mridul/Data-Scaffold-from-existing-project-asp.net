using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PracticeWeb.Models;

[Table("items")]
public partial class Item
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;
}
