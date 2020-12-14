using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.Customisations.WizardReference
{
    public enum Specifications
    {
        [Display(Name = "Reduce Data Complexity")]
        ReduceDataComplexity = 0,
        [Display(Name = "Exclude Sensitive Variables")]
        ExcludeSensitiveVariable = 1,
        [Display(Name = "Excluse Detailed Variables")]
        ExcludeDetailedVariables = 2
    }
}
