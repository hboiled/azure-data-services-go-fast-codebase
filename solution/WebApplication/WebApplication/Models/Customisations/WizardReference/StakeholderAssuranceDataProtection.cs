using System;
using System.Collections.Generic;
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

    public class StakeholderAssuranceProtectionOption
    {
        public StakeholderAssuranceProtection Option { get; set; }
        public bool IsSelected { get; set; }
    }

    public class StakeholderAssuranceDataProtection
    {
        
        public List<StakeholderAssuranceProtectionOption> Options { get; set; } = new List<StakeholderAssuranceProtectionOption>();

        public StakeholderAssuranceDataProtection()
        {
            foreach (StakeholderAssuranceProtection protection in Enum.GetValues(typeof(StakeholderAssuranceProtection)))
            {
                Options.Add(new StakeholderAssuranceProtectionOption
                {
                    Option = protection,
                    IsSelected = false
                });
            }
        }
    }
}
