using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models.Customisations.WizardReference
{
    public enum DataBreachImpactManagement
    {
        [Display(Name = "Additional Access Control")]
        AdditionalAccessControl = 0,
        [Display(Name = "Removed Identifiable Data")]
        RemoveIdentifiableData = 1,
        [Display(Name = "Formal DSA on Data Usage")]
        DSAOnDataUsage = 2,
        [Display(Name = "Data Suppression Used")]
        DataSuppressionUsed = 3,
        [Display(Name = "Other")]
        Other = 4 // text input, how to save?
    }
}
