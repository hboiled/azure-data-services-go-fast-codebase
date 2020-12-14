using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.Customisations.WizardReference
{
    public enum Properties
    {
        Age = 0,
        Gender = 1,
        Quality = 2,
        [Display(Name = "Indigenous Stats")]
        IndigenousStats = 3,
        Location = 4,
        NA = 5
    }
}
