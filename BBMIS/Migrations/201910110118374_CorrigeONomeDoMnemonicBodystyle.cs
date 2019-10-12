namespace BBMIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrigeONomeDoMnemonicBodystyle : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Derivation", name: "Mnemonic_Bodystyle_Year", newName: "Mnemonic_Bodystyle");
            RenameIndex(table: "dbo.Derivation", name: "IX_Mnemonic_Bodystyle_Year", newName: "IX_Mnemonic_Bodystyle");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Derivation", name: "IX_Mnemonic_Bodystyle", newName: "IX_Mnemonic_Bodystyle_Year");
            RenameColumn(table: "dbo.Derivation", name: "Mnemonic_Bodystyle", newName: "Mnemonic_Bodystyle_Year");
        }
    }
}
