using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.Customisations.WizardReference
{
    public enum StakeholderAssuranceProtection
    {
        [Display(Name = "DSA")]
        DSA = 0,
        [Display(Name = "XYZ")]
        XYZ = 1,
        [Display(Name = "Contact When Risk Profile Changes")]
        ContactWhenRiskProfileChanges = 2,
        [Display(Name = "p2")]
        placeholder = 3,
        [Display(Name = "p1")]
        placeholder2 = 4
    }
}
