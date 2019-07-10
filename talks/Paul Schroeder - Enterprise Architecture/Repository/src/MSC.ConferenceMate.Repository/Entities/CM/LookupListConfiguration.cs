// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace MSC.ConferenceMate.Repository.Entities.CM
{

    // LookupList
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class LookupListConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<LookupList>
    {
        public LookupListConfiguration()
            : this("dbo")
        {
        }

        public LookupListConfiguration(string schema)
        {
            ToTable("LookupList", schema);
            HasKey(x => x.LookupListId);

            Property(x => x.LookupListId).HasColumnName(@"LookupListId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LanguageTypeId).HasColumnName(@"LanguageTypeId").HasColumnType("int").IsRequired();
            Property(x => x.ForeignKeyTablePkId).HasColumnName(@"ForeignKeyTablePkId").HasColumnType("int").IsRequired();
            Property(x => x.ForeignKeyTableName).HasColumnName(@"ForeignKeyTableName").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.DisplayPriority).HasColumnName(@"DisplayPriority").HasColumnType("int").IsRequired();
            Property(x => x.DisplayText).HasColumnName(@"DisplayText").HasColumnType("nvarchar").IsRequired().HasMaxLength(4000);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(2000);
            Property(x => x.CustomJson).HasColumnName(@"CustomJson").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.DataVersion).HasColumnName(@"DataVersion").HasColumnType("int").IsRequired();
            Property(x => x.CreatedUtcDate).HasColumnName(@"CreatedUtcDate").HasColumnType("datetime2").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.ModifiedUtcDate).HasColumnName(@"ModifiedUtcDate").HasColumnType("datetime2").IsRequired();
            Property(x => x.ModifiedBy).HasColumnName(@"ModifiedBy").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.LanguageType).WithMany(b => b.LookupLists).HasForeignKey(c => c.LanguageTypeId).WillCascadeOnDelete(false); // FK_LookupList_LanguageType
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>