using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyResumeOfWPF.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasicInfos",
                columns: table => new
                {
                    BasicinfoRowId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameColumn = table.Column<string>(type: "TEXT", nullable: false),
                    AddressColumn = table.Column<string>(type: "TEXT", nullable: false),
                    AgeColumn = table.Column<string>(type: "TEXT", nullable: false),
                    EmailColumn = table.Column<string>(type: "TEXT", nullable: false),
                    PhonenumberColumn = table.Column<string>(type: "TEXT", nullable: false),
                    ExperienceColumn = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicInfos", x => x.BasicinfoRowId);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationRowId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SchoolnameColumn = table.Column<string>(type: "TEXT", nullable: false),
                    MajoyColumn = table.Column<string>(type: "TEXT", nullable: false),
                    StartColumn = table.Column<string>(type: "TEXT", nullable: false),
                    PeriodColumn = table.Column<string>(type: "TEXT", nullable: false),
                    StageColumn = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationRowId);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobRowId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompanyNameColumn = table.Column<string>(type: "TEXT", nullable: false),
                    TitleColumn = table.Column<string>(type: "TEXT", nullable: false),
                    DutyColumn = table.Column<string>(type: "TEXT", nullable: false),
                    InputColumn = table.Column<string>(type: "TEXT", nullable: false),
                    OutputColumn = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobRowId);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillRowId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ComponentOneColumn = table.Column<string>(type: "TEXT", nullable: false),
                    ComponentTwoColumn = table.Column<string>(type: "TEXT", nullable: false),
                    ComponentThreeColumn = table.Column<string>(type: "TEXT", nullable: false),
                    ComponentFourColumn = table.Column<string>(type: "TEXT", nullable: false),
                    TopicColumn = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillRowId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasicInfos");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
