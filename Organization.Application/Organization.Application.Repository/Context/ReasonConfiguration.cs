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

using Organization.Application.DTO.Entities;

namespace Organization.Application.Repository.Context
{

    // Reason
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public partial class ReasonConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Reason>
    {
        public ReasonConfiguration()
            : this("dbo")
        {
        }

        public ReasonConfiguration(string schema)
        {
            ToTable("Reason", schema);
            HasKey(x => x.ID);

            Property(x => x.ID).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName(@"Description").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(3000);
            Property(x => x.RoleId).HasColumnName(@"RoleID").IsRequired().HasColumnType("int");
            Property(x => x.ReasonTypeId).HasColumnName(@"ReasonTypeID").IsRequired().HasColumnType("int");

            // Foreign keys
            HasRequired(a => a.ReasonType).WithMany(b => b.Reasons).HasForeignKey(c => c.ReasonTypeId).WillCascadeOnDelete(false); // FK_Reason_ReasonType
            HasRequired(a => a.Role).WithMany(b => b.Reasons).HasForeignKey(c => c.RoleId).WillCascadeOnDelete(false); // FK_Reason_Role
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>