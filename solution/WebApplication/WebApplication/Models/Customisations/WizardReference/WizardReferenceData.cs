using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models.Customisations.WizardReference
{
    public class WizardReferenceData
    {
        public static readonly List<SelectListItem> SuppressionRulesSelect = new List<SelectListItem>
        {
            new SelectListItem { Text = "I have applied this suppression rule", Value = SuppressionRuleOptions.Applied.ToString() },
            new SelectListItem { Text = "I have not applied this suppression rule", Value = SuppressionRuleOptions.NotApplied.ToString() },
            new SelectListItem { Text = "Not Applicable", Value = SuppressionRuleOptions.NA.ToString() }
        };

        public static readonly List<SelectListItem> PersonalDeIdentifiedSelect = new List<SelectListItem>
        {
            new SelectListItem { Text = "Personal", Value = PersonalDeIdentified.Personal.ToString() },
            new SelectListItem { Text = "De-identified", Value = PersonalDeIdentified.DeIdentified.ToString() }
        };
    }
}
