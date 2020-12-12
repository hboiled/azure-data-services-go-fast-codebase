using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models.Customisations.WizardReference
{
    public enum SuppressionRuleOptions
    {
        Applied = 0,
        NotApplied = 1,
        NA = 2
    }

    public enum PersonalDeIdentified
    {
        Personal = 0,
        DeIdentified = 1
    }

    public enum FormOfData
    {
        Statistics = 0,
        Text = 1
    }

    public enum InformationLevel
    {
        MicroData = 0,
        Aggregated = 1,
        DirectIdentifier = 2,
        IndirectIdentifiers = 3,
        Targets = 4
    }

    public enum OrganisationalRoles // placeholder values
    {
        RoleA = 0,
        RoleB = 1,
        RoleC = 2
    }

    public enum SystemRoles // placeholder values
    {
        RoleA = 0,
        RoleB = 1,
        RoleC = 2
    }
}
