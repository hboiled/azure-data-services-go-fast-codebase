using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.Customisations.WizardReference
{
    public enum SuppressionRuleOptions
    {
        [Display(Name = "I have applied this suppression rule")]
        Applied = 0,
        [Display(Name = "I have not applied this suppression rule")]
        NotApplied = 1,
        [Display(Name = "Not Applicable")]
        NA = 2
    }
}
