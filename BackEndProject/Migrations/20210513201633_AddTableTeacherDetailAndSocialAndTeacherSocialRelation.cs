using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndProject.Migrations
{
    public partial class AddTableTeacherDetailAndSocialAndTeacherSocialRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Socials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutMe = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: true),
                    Exprience = table.Column<string>(nullable: true),
                    Hobbies = table.Column<string>(nullable: true),
                    Faculty = table.Column<string>(nullable: true),
                    MailMe = table.Column<string>(nullable: true),
                    MakeACall = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    TeamLeader = table.Column<string>(nullable: true),
                    Development = table.Column<string>(nullable: true),
                    Design = table.Column<string>(nullable: true),
                    Innovation = table.Column<string>(nullable: true),
                    Communication = table.Column<string>(nullable: true),
                    Skype = table.Column<string>(nullable: true),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherDetails_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherSocial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(nullable: false),
                    SocialId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSocial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherSocial_Socials_SocialId",
                        column: x => x.SocialId,
                        principalTable: "Socials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherSocial_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherDetails_TeacherId",
                table: "TeacherDetails",
                column: "TeacherId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSocial_SocialId",
                table: "TeacherSocial",
                column: "SocialId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSocial_TeacherId",
                table: "TeacherSocial",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherDetails");

            migrationBuilder.DropTable(
                name: "TeacherSocial");

            migrationBuilder.DropTable(
                name: "Socials");
        }
    }
}
