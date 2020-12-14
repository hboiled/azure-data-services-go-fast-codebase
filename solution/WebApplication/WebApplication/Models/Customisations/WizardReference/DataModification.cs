using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.Customisations.WizardReference
{
    public enum DataModification
    {
        [Display(Name = "De-Identify")]
        DeIdentify = 0,
        Suppress = 1,
        Anonymise = 2,
        Aggregate = 3,
        [Display(Name = "Delete Certain Fields")]
        DeleteCertainFields = 4
    }
}
