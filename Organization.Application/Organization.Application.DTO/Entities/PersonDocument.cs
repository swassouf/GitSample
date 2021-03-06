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

    // PersonDocument
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public partial class PersonDocument : IEntity
    {
        public int ID { get; set; } // ID (Primary key)
        public int PersonId { get; set; } // PersonID
        public int DocumentId { get; set; } // DocumentID
        public byte[] DocumentImage { get; set; } // DocumentImage (length: 2147483647)
        public bool IsApproved { get; set; } // IsApproved
        public System.DateTime Created { get; set; } // Created
        public System.DateTime? Modified { get; set; } // Modified

        // Foreign keys
        public virtual Document Document { get; set; } // FK_PersonDocuments_Documents
        public virtual Person Person { get; set; } // FK_PersonDocuments_Person

        public PersonDocument()
        {
            IsApproved = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
