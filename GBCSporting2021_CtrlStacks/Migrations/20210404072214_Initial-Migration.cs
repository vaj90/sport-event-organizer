using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GBCSporting2021_CtrlStacks.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    YearlyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Technicians",
                columns: table => new
                {
                    TechnicianId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicians", x => x.TechnicianId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    IncidentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TechnicianId = table.Column<int>(type: "int", nullable: true),
                    DateOpened = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateClosed = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.IncidentId);
                    table.ForeignKey(
                        name: "FK_Incidents_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Technicians_TechnicianId",
                        column: x => x.TechnicianId,
                        principalTable: "Technicians",
                        principalColumn: "TechnicianId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "AF", "Afghanistan" },
                    { 157, "NZ", "New Zealand" },
                    { 158, "NI", "Nicaragua" },
                    { 159, "NE", "Niger" },
                    { 160, "NG", "Nigeria" },
                    { 161, "NU", "Niue" },
                    { 162, "NF", "Norfolk Island" },
                    { 163, "MP", "Northern Mariana Islands" },
                    { 164, "NO", "Norway" },
                    { 165, "OM", "Oman" },
                    { 166, "PK", "Pakistan" },
                    { 167, "PW", "Palau" },
                    { 168, "PS", "Palestinian Territory, Occupied" },
                    { 156, "NC", "New Caledonia" },
                    { 169, "PA", "Panama" },
                    { 171, "PY", "Paraguay" },
                    { 172, "PE", "Peru" },
                    { 173, "PH", "Philippines" },
                    { 174, "PN", "Pitcairn" },
                    { 175, "PL", "Poland" },
                    { 176, "PT", "Portugal" },
                    { 177, "PR", "Puerto Rico" },
                    { 178, "QA", "Qatar" },
                    { 179, "RE", "Reunion" },
                    { 180, "RO", "Romania" },
                    { 181, "RU", "Russian Federation" },
                    { 182, "RW", "RWANDA" },
                    { 170, "PG", "Papua New Guinea" },
                    { 155, "AN", "Netherlands Antilles" },
                    { 154, "NL", "Netherlands" },
                    { 153, "NP", "Nepal" },
                    { 125, "LY", "Libyan Arab Jamahiriya" },
                    { 126, "LI", "Liechtenstein" },
                    { 127, "LT", "Lithuania" },
                    { 129, "MO", "Macao" },
                    { 130, "MK", "Macedonia, The Former Yugoslav Republic of" },
                    { 131, "MG", "Madagascar" },
                    { 132, "MW", "Malawi" },
                    { 133, "MY", "Malaysia" },
                    { 134, "MV", "Maldives" },
                    { 135, "ML", "Mali" },
                    { 136, "MT", "Malta" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Code", "Name" },
                values: new object[,]
                {
                    { 137, "MH", "Marshall Islands" },
                    { 138, "MQ", "Martinique" },
                    { 139, "MR", "Mauritania" },
                    { 140, "MU", "Mauritius" },
                    { 141, "YT", "Mayotte" },
                    { 142, "MX", "Mexico" },
                    { 143, "FM", "Micronesia, Federated States of" },
                    { 144, "MD", "Moldova, Republic of" },
                    { 145, "MC", "Monaco" },
                    { 146, "MN", "Mongolia" },
                    { 147, "MS", "Montserrat" },
                    { 148, "MA", "Morocco" },
                    { 149, "MZ", "Mozambique" },
                    { 150, "MM", "Myanmar" },
                    { 151, "NA", "Namibia" },
                    { 152, "NR", "Nauru" },
                    { 183, "SH", "Saint Helena" },
                    { 124, "LR", "Liberia" },
                    { 184, "KN", "Saint Kitts and Nevis" },
                    { 186, "PM", "Saint Pierre and Miquelon" },
                    { 218, "TK", "Tokelau" },
                    { 219, "TO", "Tonga" },
                    { 220, "TT", "Trinidad and Tobago" },
                    { 221, "TN", "Tunisia" },
                    { 222, "TR", "Turkey" },
                    { 223, "TM", "Turkmenistan" },
                    { 224, "TC", "Turks and Caicos Islands" },
                    { 225, "TV", "Tuvalu" },
                    { 226, "UG", "Uganda" },
                    { 227, "UA", "Ukraine" },
                    { 228, "AE", "United Arab Emirates" },
                    { 229, "GB", "United Kingdom" },
                    { 217, "TG", "Togo" },
                    { 230, "US", "United States" },
                    { 232, "UY", "Uruguay" },
                    { 233, "UZ", "Uzbekistan" },
                    { 234, "VU", "Vanuatu" },
                    { 235, "VE", "Venezuela" },
                    { 236, "VN", "Viet Nam" },
                    { 237, "VG", "Virgin Islands, British" },
                    { 238, "VI", "Virgin Islands, U.S." },
                    { 239, "WF", "Wallis and Futuna" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Code", "Name" },
                values: new object[,]
                {
                    { 240, "EH", "Western Sahara" },
                    { 241, "YE", "Yemen" },
                    { 242, "ZM", "Zambia" },
                    { 243, "ZW", "Zimbabwe" },
                    { 231, "UM", "United States Minor Outlying Islands" },
                    { 216, "TL", "Timor-Leste" },
                    { 215, "TH", "Thailand" },
                    { 214, "TZ", "Tanzania, United Republic of" },
                    { 187, "VC", "Saint Vincent and the Grenadines" },
                    { 188, "WS", "Samoa" },
                    { 189, "SM", "San Marino" },
                    { 190, "ST", "Sao Tome and Principe" },
                    { 191, "SA", "Saudi Arabia" },
                    { 192, "SN", "Senegal" },
                    { 193, "CS", "Serbia and Montenegro" },
                    { 194, "SC", "Seychelles" },
                    { 195, "SL", "Sierra Leone" },
                    { 196, "SG", "Singapore" },
                    { 197, "SK", "Slovakia" },
                    { 198, "SI", "Slovenia" },
                    { 199, "SB", "Solomon Islands" },
                    { 200, "SO", "Somalia" },
                    { 201, "ZA", "South Africa" },
                    { 202, "GS", "South Georgia and the South Sandwich Islands" },
                    { 203, "ES", "Spain" },
                    { 204, "LK", "Sri Lanka" },
                    { 205, "SD", "Sudan" },
                    { 206, "SR", "Suriname" },
                    { 207, "SJ", "Svalbard and Jan Mayen" },
                    { 208, "SZ", "Swaziland" },
                    { 209, "SE", "Sweden" },
                    { 210, "CH", "Switzerland" },
                    { 211, "SY", "Syrian Arab Republic" },
                    { 212, "TW", "Taiwan, Province of China" },
                    { 213, "TJ", "Tajikistan" },
                    { 185, "LC", "Saint Lucia" },
                    { 123, "LS", "Lesotho" },
                    { 128, "LU", "Luxembourg" },
                    { 121, "LV", "Latvia" },
                    { 33, "BN", "Brunei Darussalam" },
                    { 34, "BG", "Bulgaria" },
                    { 35, "BF", "Burkina Faso" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Code", "Name" },
                values: new object[,]
                {
                    { 36, "BI", "Burundi" },
                    { 37, "KH", "Cambodia" },
                    { 38, "CM", "Cameroon" },
                    { 39, "CA", "Canada" },
                    { 40, "CV", "Cape Verde" },
                    { 41, "KY", "Cayman Islands" },
                    { 42, "CF", "Central African Republic" },
                    { 43, "TD", "Chad" },
                    { 44, "CL", "Chile" },
                    { 45, "CN", "China" },
                    { 46, "CX", "Christmas Island" },
                    { 47, "CC", "Cocos (Keeling) Islands" },
                    { 48, "CO", "Colombia" },
                    { 49, "KM", "Comoros" },
                    { 50, "CG", "Congo" },
                    { 51, "CD", "Congo, The Democratic Republic of the" },
                    { 52, "CK", "Cook Islands" },
                    { 53, "CR", "Costa Rica" },
                    { 54, "CI", "Cote D\"Ivoire" },
                    { 55, "HR", "Croatia" },
                    { 122, "LB", "Lebanon" },
                    { 57, "CY", "Cyprus" },
                    { 58, "CZ", "Czech Republic" },
                    { 59, "DK", "Denmark" },
                    { 32, "IO", "British Indian Ocean Territory" },
                    { 60, "DJ", "Djibouti" },
                    { 31, "BR", "Brazil" },
                    { 29, "BW", "Botswana" },
                    { 2, "AX", "Aland Islands" },
                    { 3, "AL", "Albania" },
                    { 4, "DZ", "Algeria" },
                    { 5, "AS", "American Samoa" },
                    { 6, "AD", "AndorrA" },
                    { 7, "AO", "Angola" },
                    { 8, "AI", "Anguilla" },
                    { 9, "AQ", "Antarctica" },
                    { 10, "AG", "Antigua and Barbuda" },
                    { 11, "AR", "Argentina" },
                    { 12, "AM", "Armenia" },
                    { 13, "AW", "Aruba" },
                    { 14, "AU", "Australia" },
                    { 15, "AT", "Austria" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Code", "Name" },
                values: new object[,]
                {
                    { 16, "AZ", "Azerbaijan" },
                    { 17, "BS", "Bahamas" },
                    { 18, "BH", "Bahrain" },
                    { 19, "BD", "Bangladesh" },
                    { 20, "BB", "Barbados" },
                    { 21, "BY", "Belarus" },
                    { 22, "BE", "Belgium" },
                    { 23, "BZ", "Belize" },
                    { 24, "BJ", "Benin" },
                    { 25, "BM", "Bermuda" },
                    { 26, "BT", "Bhutan" },
                    { 27, "BO", "Bolivia" },
                    { 28, "BA", "Bosnia and Herzegovina" },
                    { 30, "BV", "Bouvet Island" },
                    { 61, "DM", "Dominica" },
                    { 56, "CU", "Cuba" },
                    { 63, "EC", "Ecuador" },
                    { 95, "HM", "Heard Island and Mcdonald Islands" },
                    { 96, "VA", "Holy See (Vatican City State)" },
                    { 97, "HN", "Honduras" },
                    { 62, "DO", "Dominican Republic" },
                    { 99, "HU", "Hungary" },
                    { 100, "IS", "Iceland" },
                    { 101, "IN", "India" },
                    { 102, "ID", "Indonesia" },
                    { 103, "IR", "Iran, Islamic Republic Of" },
                    { 104, "IQ", "Iraq" },
                    { 105, "IE", "Ireland" },
                    { 106, "IM", "Isle of Man" },
                    { 94, "HT", "Haiti" },
                    { 107, "IL", "Israel" },
                    { 109, "JM", "Jamaica" },
                    { 110, "JP", "Japan" },
                    { 111, "JE", "Jersey" },
                    { 112, "JO", "Jordan" },
                    { 113, "KZ", "Kazakhstan" },
                    { 114, "KE", "Kenya" },
                    { 115, "KI", "Kiribati" },
                    { 116, "KP", "Korea, Democratic People\"S Republic of" },
                    { 117, "KR", "Korea, Republic of" },
                    { 118, "KW", "Kuwait" },
                    { 119, "KG", "Kyrgyzstan" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Code", "Name" },
                values: new object[,]
                {
                    { 120, "LA", "Lao People\"S Democratic Republic" },
                    { 108, "IT", "Italy" },
                    { 93, "GY", "Guyana" },
                    { 98, "HK", "Hong Kong" },
                    { 91, "GN", "Guinea" },
                    { 64, "EG", "Egypt" },
                    { 65, "SV", "El Salvador" },
                    { 66, "GQ", "Equatorial Guinea" },
                    { 67, "ER", "Eritrea" },
                    { 68, "EE", "Estonia" },
                    { 69, "ET", "Ethiopia" },
                    { 70, "FK", "Falkland Islands (Malvinas)" },
                    { 92, "GW", "Guinea-Bissau" },
                    { 72, "FJ", "Fiji" },
                    { 73, "FI", "Finland" },
                    { 74, "FR", "France" },
                    { 75, "GF", "French Guiana" },
                    { 76, "PF", "French Polynesia" },
                    { 71, "FO", "Faroe Islands" },
                    { 78, "GA", "Gabon" },
                    { 90, "GG", "Guernsey" },
                    { 77, "TF", "French Southern Territories" },
                    { 88, "GU", "Guam" },
                    { 87, "GP", "Guadeloupe" },
                    { 86, "GD", "Grenada" },
                    { 85, "GL", "Greenland" },
                    { 89, "GT", "Guatemala" },
                    { 83, "GI", "Gibraltar" },
                    { 82, "GH", "Ghana" },
                    { 81, "DE", "Germany" },
                    { 80, "GE", "Georgia" },
                    { 79, "GM", "Gambia" },
                    { 84, "GR", "Greece" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Code", "Name", "ReleaseDate", "YearlyPrice" },
                values: new object[,]
                {
                    { 7, "DRAFT20", "Draft Manager 2.0", new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.99m },
                    { 6, "TRNY20", "Tournament Master 2.0", new DateTime(2018, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.99m },
                    { 5, "TEAM10", "Team Manager 1.0", new DateTime(2017, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.99m },
                    { 3, "LEAGD10", "League Scheduler Deluxe 1.0", new DateTime(2016, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.99m },
                    { 2, "LEAG10", "League Scheduler 1.0", new DateTime(2016, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.99m },
                    { 1, "TRNY10", "Tournament Master 1.0", new DateTime(2015, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.99m },
                    { 4, "DRAFT10", "Draft Manager 1.0", new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.99m }
                });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "TechnicianId", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 4, "gunter@sportsprosoftware.com", "Gunter Wendt", "800-55-0400" },
                    { 1, "alison@sportsprosoftware.com", "Alison Diaz", "800-55-0443" }
                });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "TechnicianId", "Email", "Name", "Phone" },
                values: new object[] { 2, "awilson@sportsprosoftware.com", "Andew Wilson", "800-55-0449" });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "TechnicianId", "Email", "Name", "Phone" },
                values: new object[] { 3, "gfiori@sportsprosoftware.com", "Gina Fiori", "800-55-0459" });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "TechnicianId", "Email", "Name", "Phone" },
                values: new object[] { 5, "jsaon@sportsprosoftware.com", "Jason Lee", "800-55-0444" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CountryId",
                table: "Customers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_CustomerId",
                table: "Incidents",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ProductId",
                table: "Incidents",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_TechnicianId",
                table: "Incidents",
                column: "TechnicianId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Technicians");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
