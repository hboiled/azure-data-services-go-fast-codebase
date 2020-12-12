using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.Customisations.WizardReference
{
    public enum Specifications
    {
        [Display(Name = "Reduce Data Complexity")]
        ReduceDataComplexity = 0,
        [Display(Name = "Exclude Sensitive Variables")]
        ExcludeSensitiveVariable = 1,
        [Display(Name = "Excluse Detailed Variables")]
        ExcludeDetailedVariables = 2
    }

    public class SpecificationOption
    {
        public Specifications Option { get; set; }
        public bool IsSelected { get; set; }
    }

    public class SpecificationOutcomes
    {

        public List<SpecificationOption> Options { get; set; } = new List<SpecificationOption>();

        public SpecificationOutcomes()
        {
            foreach (Specifications option in Enum.GetValues(typeof(Specifications)))
            {
                Options.Add(new SpecificationOption
                {
                    Option = option,
                    IsSelected = false
                });
            }
        }
    }
}
