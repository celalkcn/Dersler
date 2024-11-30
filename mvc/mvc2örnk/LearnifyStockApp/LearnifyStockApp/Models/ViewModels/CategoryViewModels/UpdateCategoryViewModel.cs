using System;

namespace LearnifyStockApp.Models.ViewModels.CategoryViewModels;

public class UpdateCategoryViewModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool IsDeleted { get; set; }
}
