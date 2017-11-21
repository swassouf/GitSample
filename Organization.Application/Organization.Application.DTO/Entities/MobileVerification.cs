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

    // MobileVerification
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public partial class MobileVerification : IEntity
    {
        public int ID { get; set; } // ID (Primary key)
        public int? PersonId { get; set; } // PersonID
        public int? VerificationCode { get; set; } // VerificationCode
        public System.DateTime? Created { get; set; } // Created

        // Foreign keys
        public virtual Person Person { get; set; } // FK_MobileVerification_Person

        public MobileVerification()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>