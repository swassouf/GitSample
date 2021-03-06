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

    // TransportType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public partial class TransportTypeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TransportType>
    {
        public TransportTypeConfiguration()
            : this("dbo")
        {
        }

        public TransportTypeConfiguration(string schema)
        {
            ToTable("TransportType", schema);
            HasKey(x => x.ID);

            Property(x => x.ID).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
