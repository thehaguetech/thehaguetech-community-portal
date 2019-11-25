using Microsoft.EntityFrameworkCore.Migrations;

namespace thehaguetech_community_portal.Migrations
{
    public partial class ModelChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "events",
                columns: table => new
                {
                    eventID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_events", x => x.eventID);
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    roomID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.roomID);
                });

            migrationBuilder.CreateTable(
                name: "profiles",
                columns: table => new
                {
                    profileID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    memberSince = table.Column<int>(nullable: false),
                    expertise = table.Column<string>(nullable: true),
                    picture = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    profileID1 = table.Column<int>(nullable: true),
                    roomID = table.Column<int>(nullable: true),
                    companyID = table.Column<int>(nullable: true),
                    contactPerson = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profiles", x => x.profileID);
                    table.ForeignKey(
                        name: "FK_profiles_profiles_profileID1",
                        column: x => x.profileID1,
                        principalTable: "profiles",
                        principalColumn: "profileID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_profiles_rooms_roomID",
                        column: x => x.roomID,
                        principalTable: "rooms",
                        principalColumn: "roomID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "socialLinks",
                columns: table => new
                {
                    socialLinkID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    profileID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_socialLinks", x => x.socialLinkID);
                    table.ForeignKey(
                        name: "FK_socialLinks_profiles_profileID",
                        column: x => x.profileID,
                        principalTable: "profiles",
                        principalColumn: "profileID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_profiles_profileID1",
                table: "profiles",
                column: "profileID1");

            migrationBuilder.CreateIndex(
                name: "IX_profiles_roomID",
                table: "profiles",
                column: "roomID");

            migrationBuilder.CreateIndex(
                name: "IX_socialLinks_profileID",
                table: "socialLinks",
                column: "profileID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "events");

            migrationBuilder.DropTable(
                name: "socialLinks");

            migrationBuilder.DropTable(
                name: "profiles");

            migrationBuilder.DropTable(
                name: "rooms");
        }
    }
}
