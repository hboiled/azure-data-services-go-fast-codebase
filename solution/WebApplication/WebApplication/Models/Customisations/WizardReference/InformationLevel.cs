using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.Customisations.WizardReference
{
    public enum InformationLevel
    {
        [Display(Name = "Micro-Data")]
        MicroData = 0,
        Aggregated = 1,
        [Display(Name = "Direct Identifiers")]
        DirectIdentifier = 2,
        [Display(Name = "Indirect Identifiers")]
        IndirectIdentifiers = 3,
        Targets = 4
    }
}
