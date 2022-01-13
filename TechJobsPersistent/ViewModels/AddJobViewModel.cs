using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }
        public Employer Employer { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }
    }
}
