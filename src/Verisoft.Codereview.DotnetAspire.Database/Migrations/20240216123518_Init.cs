using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Verisoft.Codereview.DotnetAspire.Database.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    FirstName = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    LastName = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    Email = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    Description = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Description", "Email", "FirstName", "LastName", "Name" },
                values: new object[,]
                {
                    { new Guid("00683601-0eb1-f107-cf71-b984b184320c"), null, "Sofronie.Waltrova16@atlas.cz", "Sofronie", "Waltrová", "Sofronie.Waltrova11" },
                    { new Guid("017556a4-6f74-d940-0639-606c3fa16603"), null, null, "Konstance", "Krupková", "Konstance94" },
                    { new Guid("0544b5cf-effa-a0a1-6ea9-9991dc002bc0"), null, null, "Konstantin", "Krupa", "Konstantin59" },
                    { new Guid("07f55226-879e-a9a7-a552-8c8333cf99d8"), null, null, "Vadim", "Kubánek", "Vadim_Kubanek" },
                    { new Guid("13712058-787e-1073-984d-662f8d057898"), "This product works certainly well. It perfectly improves my tennis by a lot.", null, "Smil", "Bouček", "Smil_Boucek99" },
                    { new Guid("1603d0ec-966e-9fe4-8b44-fabebf72587e"), "I tried to vomit it but got bonbon all over it.", null, "Koloman", "Černík", "Koloman_Cernik" },
                    { new Guid("1748aa58-0504-55a3-8cae-3897046adeee"), null, "Babeta_Richtrova@centrum.cz", "Babeta", "Richtrová", "Babeta.Richtrova0" },
                    { new Guid("23ebfa4b-83ac-3926-8578-6e8aa2acef4b"), "I tried to electrocute it but got sweetmeat all over it.", null, "Dominik", "Koudelka", "Dominik12" },
                    { new Guid("34531f20-4a76-1c61-c5f2-ca6552955546"), "I tried to maim it but got nectarine all over it.", null, "Bela", "Žďárská", "Bela94" },
                    { new Guid("39c94d28-ccc4-6bf8-4d01-17aabd077878"), "My demon loves to play with it.", null, "Felicie", "Šafránková", "Felicie_Safrankova53" },
                    { new Guid("3c80b953-9f33-80fe-cade-c95378b67f9a"), null, null, "Felix", "Winkler", "Felix48" },
                    { new Guid("43ff4694-d01c-1634-3863-7b19b5a1207c"), "one of my hobbies is sailing. and when i'm sailing this works great.", null, "Jarolíma", "Wagnerová", "Jarolima.Wagnerova" },
                    { new Guid("50ccd97f-fc46-a70c-e695-2c6dd5993817"), "I saw one of these in Juan de Nova Island and I bought one.", null, "Magda", "Neumannová", "Magda.Neumannova60" },
                    { new Guid("53e962af-7a6c-67af-a8d3-55ad840d9f74"), null, "Edmund73@seznam.cz", "Edmund", "Anděl", "Edmund.Andel85" },
                    { new Guid("57cc98cd-91e9-4e92-b320-cabd18ab67fd"), null, null, "Julius", "Bečvář", "Julius92" },
                    { new Guid("64055392-3011-fc60-a447-eaaf0596d03c"), "The box this comes in is 3 light-year by 5 meter and weights 10 ounce!", "Otomar_Rehacek88@seznam.cz", "Otomar", "Řeháček", "Otomar_Rehacek2" },
                    { new Guid("68d39499-2253-7592-dcec-ca10025dcb73"), null, "Vojmir77@centrum.cz", "Vojmír", "Krejčí", "Vojmir11" },
                    { new Guid("6ec37119-cadf-bedd-7e05-eaed4b405607"), "one of my hobbies is theater. and when i'm acting this works great.", null, "Verner", "Prchal", "Verner40" },
                    { new Guid("7098a8a2-f284-64ba-22ce-8f6963c4781e"), null, null, "Arnolda", "Zoubková", "Arnolda_Zoubkova6" },
                    { new Guid("73ceb62f-2bb1-9878-10d2-7deed37850bc"), "talk about pleasure!", "Lola87@seznam.cz", "Lola", "Ferencová", "Lola6" },
                    { new Guid("7632ce15-8d19-f6ac-4119-5fca0da208a7"), null, null, "Eunika", "Kupková", "Eunika_Kupkova" },
                    { new Guid("7b222fb7-9e47-f987-2b5a-d816c4594077"), null, null, "Alexandr", "Kubica", "Alexandr42" },
                    { new Guid("7db295c2-d59a-d12f-1719-4a77e33a3d1b"), "My neighbor Krista has one of these. She works as a salesman and she says it looks soapy.", "Gajana87@atlas.cz", "Gajana", "Smolíková", "Gajana.Smolikova15" },
                    { new Guid("7e380398-303f-a49a-60ac-698434bddb66"), null, null, "Herta", "Bártová", "Herta.Bartova" },
                    { new Guid("80b4de82-5b6c-66b9-e751-dd7c725b4ccd"), "i use it from now on when i'm in my safehouse.", "Kristan.Michal@atlas.cz", "Křišťan", "Michal", "Kristan_Michal" },
                    { new Guid("8597e764-825b-0a22-a1d7-12920c2a435b"), null, null, "Věra", "Samková", "Vera.Samkova" },
                    { new Guid("89197b6d-1186-1784-95b7-9ed8517940ea"), null, null, "Milada", "Zimová", "Milada28" },
                    { new Guid("89eee224-ad60-2668-6711-6c26256e5d2d"), null, "Bernard_Schejbal31@centrum.cz", "Bernard", "Schejbal", "Bernard5" },
                    { new Guid("8daab965-44ad-f078-cd55-14f9a2e3a272"), null, "Bela96@volny.cz", "Bela", "Jansová", "Bela.Jansova70" },
                    { new Guid("98a55ab1-8f9e-34ac-25a0-8293a3a5f9d1"), "This product works really well. It sympathetically improves my baseball by a lot.", "Zinaida.Adamova0@seznam.cz", "Zinaida", "Adamová", "Zinaida.Adamova" },
                    { new Guid("9ff60a81-a76d-5f3a-fd04-5043fdbc21ea"), "one of my hobbies is toy collecting. and when i'm collecting toys this works great.", null, "Nona", "Frydrychová", "Nona58" },
                    { new Guid("a1331be4-7f6f-0de7-5081-fcf93deabc8b"), null, null, "Alina", "Čápová", "Alina_Capova59" },
                    { new Guid("a6382d69-d2e1-f8bc-643a-a4a0726a3519"), null, "Kleopatra.Pelikanova@seznam.cz", "Kleopatra", "Pelikánová", "Kleopatra.Pelikanova57" },
                    { new Guid("a916d7d6-eed8-e536-0112-a9291b2a1174"), null, "Chranislava_Kurkova94@gmail.com", "Chranislava", "Kurková", "Chranislava_Kurkova46" },
                    { new Guid("ac782d87-aa29-14d0-b2a0-58fb4879ef91"), null, null, "Herbert", "Červinka", "Herbert84" },
                    { new Guid("acb9fbd4-74f9-7db2-fd8d-a3b10df4fa4e"), "heard about this on songo radio, decided to give it a try.", null, "Una", "Dušková", "Una_Duskova" },
                    { new Guid("c4e5baf9-25fc-15a7-e4a8-0ebc1e20a251"), "This product works considerably well. It recklessly improves my basketball by a lot.", null, "Selma", "Rácová", "Selma56" },
                    { new Guid("c5387b51-a85d-3ccb-8cb6-9de27b0bac76"), null, "Benedikta.Vaculikova62@centrum.cz", "Benedikta", "Vaculíková", "Benedikta_Vaculikova" },
                    { new Guid("cc0b865b-6f73-2894-a1f6-1524a5881a42"), null, null, "Taras", "Prchal", "Taras92" },
                    { new Guid("d3e9e8f9-a643-4a0c-b4dd-4bd7765f25b7"), "My neighbor Frona has one of these. She works as a gambler and she says it looks bearded.", null, "Lucius", "Fišer", "Lucius.Fiser" },
                    { new Guid("d736e495-fe53-db50-04ab-c3df3205cd48"), null, null, "Mahulena", "Skácelová", "Mahulena.Skacelova0" },
                    { new Guid("d81ba010-6c22-0bdb-9b22-fa633c9f5104"), "It only works when I'm Nepal.", "Tiberius60@seznam.cz", "Tiberius", "Michal", "Tiberius_Michal" },
                    { new Guid("e29ae6d2-6a26-ec04-b692-5c5cd8ad264a"), "i use it every Tuesday when i'm in my pub.", null, "Bertram", "Hovorka", "Bertram_Hovorka" },
                    { new Guid("e746b2db-d3c3-b4fa-8c78-67476c4be551"), null, "Horymira_Rysava37@gmail.com", "Horymíra", "Ryšavá", "Horymira_Rysava7" },
                    { new Guid("e80189c0-6d94-8e61-9234-7ec918bf146a"), null, "Inocenc_Nedoma@seznam.cz", "Inocenc", "Nedoma", "Inocenc.Nedoma" },
                    { new Guid("ebcb49ba-6011-c2ed-ff8c-7ed4dec8571a"), null, null, "Darina", "Šafářová", "Darina.Safarova" },
                    { new Guid("ec9653cf-c3a1-e3d4-15e8-586c32b18a56"), "i use it once a week when i'm in my firetruck.", null, "Bohuna", "Šimáková", "Bohuna91" },
                    { new Guid("f68c447f-14b8-cf49-b2bc-a7c05dcb8613"), "I tried to annihilate it but got bonbon all over it.", null, "Virginie", "Zelenková", "Virginie.Zelenkova" },
                    { new Guid("f6b2b031-3fb6-6af3-0d00-4ac25a8f24fa"), "My co-worker Matthew has one of these. He says it looks gigantic.", null, "Virgin", "Motl", "Virgin_Motl11" },
                    { new Guid("f75f517c-f46a-9487-97ba-d45594ac18d0"), "The box this comes in is 5 light-year by 6 foot and weights 17 megaton!!!", "Johana_Karlikova@volny.cz", "Johana", "Karlíková", "Johana_Karlikova54" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
