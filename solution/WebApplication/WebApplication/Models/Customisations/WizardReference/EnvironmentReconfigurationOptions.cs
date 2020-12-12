using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.Customisations.WizardReference
{
    public enum EnvironmentReconfigurations
    {
        [Display(Name = "Specify People Access")]
        SpecifyPeopleAccess = 0,
        [Display(Name = "Specify Requisite Security Level")]
        SpecifyRequisiteSecurityLevel = 1,
        [Display(Name = "Allow Access Only Within Own Secure Environment")]
        AllowAccessOnlyWithinOwnSecureEnvironment = 2,
        [Display(Name = "Specify All Analytics Be Checked Before Publishing")]
        SpecifyAllAnalyticsBeCheckedBeforePublish = 3,
        [Display(Name = "Make Use of Data Agreements")]
        MakeUseOfDataAgreements = 4
    }

    public class EnvironmentReconfigurationOption
    {
        public EnvironmentReconfigurations Option { get; set; }
        public bool IsSelected { get; set; }
    }

    public class EnvironmentReconfigurationOptions
    {

        public List<EnvironmentReconfigurationOption> Options { get; set; } = new List<EnvironmentReconfigurationOption>();

        public EnvironmentReconfigurationOptions()
        {
            foreach (EnvironmentReconfigurations option in Enum.GetValues(typeof(EnvironmentReconfigurations)))
            {
                Options.Add(new EnvironmentReconfigurationOption
                {
                    Option = option,
                    IsSelected = false
                });
            }
        }
    }
}
