// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.61
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using Organization.Application.DTO.Interface;

namespace Organization.Application.DTO.Entities
{

    // CountryPhoneCode
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public partial class CountryPhoneCode : IEntity
    {
        public int ID { get; set; } // ID (Primary key)
        public string Country { get; set; } // Country (length: 50)
        public string Abbreviation { get; set; } // Abbreviation (length: 50)
        public string PhoneCode { get; set; } // PhoneCode (length: 50)

        public CountryPhoneCode()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
