using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models.Customisations.WizardReference
{
    public enum SuppressionRuleOptions
    {
        [Display(Name = "I have applied this suppression rule")]
        Applied = 0,
        [Display(Name = "I have not applied this suppression rule")]
        NotApplied = 1,
        [Display(Name = "Not Applicable")]
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

    public enum Properties
    {
        Age = 0,
        Gender = 1,
        Quality = 2,
        [Display(Name = "Indigenous Stats")]
        IndigenousStats = 3,
        Location = 4,
        NA = 5
    }
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

    public enum Specifications
    {
        [Display(Name = "Reduce Data Complexity")]
        ReduceDataComplexity = 0,
        [Display(Name = "Exclude Sensitive Variables")]
        ExcludeSensitiveVariable = 1,
        [Display(Name = "Excluse Detailed Variables")]
        ExcludeDetailedVariables = 2
    }
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
    public enum DataBreachPlan
    {
        [Display(Name = "Robust Audit Trail")]
        RobustAuditTrail = 0,
        [Display(Name = "Crisis Management Policy")]
        CrisisManagementPolicy = 1,
        [Display(Name = "Notify Of Data Breach Process")]
        NotifyDataBreachProcess = 2,
        [Display(Name = "Trained Staff")]
        TrainedStaff = 3,
        [Display(Name = "Other")]
        Other = 4
    }
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
