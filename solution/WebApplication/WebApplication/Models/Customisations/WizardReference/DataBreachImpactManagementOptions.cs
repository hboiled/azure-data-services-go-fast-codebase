using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

    public class DataBreachImpactManagementOption
    {
        public DataBreachImpactManagement Option { get; set; }
        public bool IsSelected { get; set; }
    }

    public class DataBreachImpactManagementOptions
    {

        public List<DataBreachImpactManagementOption> Options { get; set; } = new List<DataBreachImpactManagementOption>();

        public DataBreachImpactManagementOptions()
        {
            foreach (DataBreachImpactManagement management in Enum.GetValues(typeof(DataBreachImpactManagement)))
            {
                Options.Add(new DataBreachImpactManagementOption
                {
                    Option = management,
                    IsSelected = false
                });
            }
        }
    }
}
