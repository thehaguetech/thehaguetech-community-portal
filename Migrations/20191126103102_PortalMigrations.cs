using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace thehaguetech_community_portal.Migrations
{
    public partial class PortalMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    contactPerson = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profiles", x => x.profileID);
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    roomID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: false),
                    number = table.Column<int>(nullable: false),
                    capacity = table.Column<int>(nullable: false),
                    equipment = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.roomID);
                });

            migrationBuilder.CreateTable(
                name: "profileRelationships",
                columns: table => new
                {
                    ProfileRelationShipID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    profileFKIDprofileID = table.Column<int>(nullable: false),
                    profileConnectionFKIDprofileID = table.Column<int>(nullable: false),
                    connectionDate = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profileRelationships", x => x.ProfileRelationShipID);
                    table.ForeignKey(
                        name: "FK_profileRelationships_profiles_profileConnectionFKIDprofileID",
                        column: x => x.profileConnectionFKIDprofileID,
                        principalTable: "profiles",
                        principalColumn: "profileID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_profileRelationships_profiles_profileFKIDprofileID",
                        column: x => x.profileFKIDprofileID,
                        principalTable: "profiles",
                        principalColumn: "profileID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "socialLinks",
                columns: table => new
                {
                    linkID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    profileFKIDprofileID = table.Column<int>(nullable: true),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_socialLinks", x => x.linkID);
                    table.ForeignKey(
                        name: "FK_socialLinks_profiles_profileFKIDprofileID",
                        column: x => x.profileFKIDprofileID,
                        principalTable: "profiles",
                        principalColumn: "profileID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "events",
                columns: table => new
                {
                    eventID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: false),
                    address = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: false),
                    picture = table.Column<string>(nullable: true),
                    capacity = table.Column<int>(nullable: false),
                    creatorprofileID = table.Column<int>(nullable: false),
                    roomID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_events", x => x.eventID);
                    table.ForeignKey(
                        name: "FK_events_profiles_creatorprofileID",
                        column: x => x.creatorprofileID,
                        principalTable: "profiles",
                        principalColumn: "profileID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_events_rooms_roomID",
                        column: x => x.roomID,
                        principalTable: "rooms",
                        principalColumn: "roomID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "roombookings",
                columns: table => new
                {
                    roomBookingID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    roomFKIDroomID = table.Column<int>(nullable: false),
                    profileFKIDprofileID = table.Column<int>(nullable: false),
                    timeStart = table.Column<DateTime>(type: "Date", nullable: false),
                    timeEnd = table.Column<DateTime>(type: "Date", nullable: false),
                    registrationDate = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roombookings", x => x.roomBookingID);
                    table.ForeignKey(
                        name: "FK_roombookings_profiles_profileFKIDprofileID",
                        column: x => x.profileFKIDprofileID,
                        principalTable: "profiles",
                        principalColumn: "profileID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_roombookings_rooms_roomFKIDroomID",
                        column: x => x.roomFKIDroomID,
                        principalTable: "rooms",
                        principalColumn: "roomID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "eventAttends",
                columns: table => new
                {
                    eventAttendID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    eventFKIDeventID = table.Column<int>(nullable: true),
                    profileFKIDprofileID = table.Column<int>(nullable: true),
                    registrationDate = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eventAttends", x => x.eventAttendID);
                    table.ForeignKey(
                        name: "FK_eventAttends_events_eventFKIDeventID",
                        column: x => x.eventFKIDeventID,
                        principalTable: "events",
                        principalColumn: "eventID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_eventAttends_profiles_profileFKIDprofileID",
                        column: x => x.profileFKIDprofileID,
                        principalTable: "profiles",
                        principalColumn: "profileID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_eventAttends_eventFKIDeventID",
                table: "eventAttends",
                column: "eventFKIDeventID");

            migrationBuilder.CreateIndex(
                name: "IX_eventAttends_profileFKIDprofileID",
                table: "eventAttends",
                column: "profileFKIDprofileID");

            migrationBuilder.CreateIndex(
                name: "IX_events_creatorprofileID",
                table: "events",
                column: "creatorprofileID");

            migrationBuilder.CreateIndex(
                name: "IX_events_roomID",
                table: "events",
                column: "roomID");

            migrationBuilder.CreateIndex(
                name: "IX_profileRelationships_profileConnectionFKIDprofileID",
                table: "profileRelationships",
                column: "profileConnectionFKIDprofileID");

            migrationBuilder.CreateIndex(
                name: "IX_profileRelationships_profileFKIDprofileID",
                table: "profileRelationships",
                column: "profileFKIDprofileID");

            migrationBuilder.CreateIndex(
                name: "IX_roombookings_profileFKIDprofileID",
                table: "roombookings",
                column: "profileFKIDprofileID");

            migrationBuilder.CreateIndex(
                name: "IX_roombookings_roomFKIDroomID",
                table: "roombookings",
                column: "roomFKIDroomID");

            migrationBuilder.CreateIndex(
                name: "IX_socialLinks_profileFKIDprofileID",
                table: "socialLinks",
                column: "profileFKIDprofileID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eventAttends");

            migrationBuilder.DropTable(
                name: "profileRelationships");

            migrationBuilder.DropTable(
                name: "roombookings");

            migrationBuilder.DropTable(
                name: "socialLinks");

            migrationBuilder.DropTable(
                name: "events");

            migrationBuilder.DropTable(
                name: "profiles");

            migrationBuilder.DropTable(
                name: "rooms");
        }
    }
}
