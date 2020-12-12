using System;
using System.Collections.Generic;
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

    public class DataModificationOption
    {
        public DataModification Option { get; set; }
        public bool IsSelected { get; set; }
    }

    public class DataModificationOptions
    {

        public List<DataModificationOption> Options { get; set; } = new List<DataModificationOption>();

        public DataModificationOptions()
        {
            foreach (DataModification option in Enum.GetValues(typeof(DataModification)))
            {
                Options.Add(new DataModificationOption
                {
                    Option = option,
                    IsSelected = false
                });
            }
        }
    }
}
