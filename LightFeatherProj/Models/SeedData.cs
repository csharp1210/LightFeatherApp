using Microsoft.EntityFrameworkCore;

namespace LightFeatherProj.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SupervisorContext(serviceProvider.GetRequiredService<DbContextOptions<SupervisorContext>>()))
            {
                // Look for any supervisors.
                if (context.Supervisors.Any())
                {
                    return;   // DB has been seeded
                }
                context.Supervisors.AddRange( 
                    new Supervisor
                    {
                        ID = 1,
                        PhoneNumber = "204-798-9969",
                        Jurisdiction = 'u',
                        IdentificationNumber = "d4900a18-a304-42c6-a8e5-a6c8c3f17bc0",
                        FirstName = "Karson",
                        LastName = "Olson"
                    },
                    new Supervisor
                    {
                        ID = 2,
                        PhoneNumber = "792.910.1754",
                        Jurisdiction = '9',
                        IdentificationNumber = "96188a56-1f92-4876-8df3-d8761ea5162f",
                        FirstName = "Robbie",
                        LastName = "Heller"
                    },
                    new Supervisor
                    {
                        ID = 3,
                        PhoneNumber = "(255) 885-3433",
                        Jurisdiction = 'u',
                        IdentificationNumber = "3e662eb4-4434-499a-a64e-dc5ca9da87e5",
                        FirstName = "Lavon",
                        LastName = "Deckow"
                    },
                    new Supervisor
                    {
                        ID = 4,
                        PhoneNumber = "727-659-7861",
                        Jurisdiction = 'b',
                        IdentificationNumber = "7d8a9ed8-685f-4408-92f1-e13a7c118d97",
                        FirstName = "Elijah",
                        LastName = "Cremin"
                    },
                    new Supervisor
                    {
                        ID = 5,
                        PhoneNumber = "(964) 512-1445",
                        Jurisdiction = '8',
                        IdentificationNumber = "93fd04ee-655a-47c2-832b-d83056d29e1e",
                        FirstName = "Kieran",
                        LastName = "Torphy"
                    },
                    new Supervisor
                    {
                        ID = 6,
                        PhoneNumber = "(996) 727-6579 x89731",
                        Jurisdiction = '5',
                        IdentificationNumber = "1140519f-8de2-4e84-ad75-34c07028a205",
                        FirstName = "Lulu",
                        LastName = "Jacobi"
                    },
                    new Supervisor
                    {
                        ID = 7,
                        PhoneNumber = "783-577-5485",
                        Jurisdiction = '6',
                        IdentificationNumber = "95a0ce59-d3c4-4d9b-a66a-2a376a9ef14b",
                        FirstName = "Kellen",
                        LastName = "Bayer"
                    },
                    new Supervisor
                    {
                        ID = 8,
                        PhoneNumber = "939-905-7522 x3185",
                        Jurisdiction = '8',
                        IdentificationNumber = "41fac424-a63b-4f00-94af-73ffa3840db6",
                        FirstName = "Jesus",
                        LastName = "Heathcote"
                    },
                    new Supervisor
                    {
                        ID = 9,
                        PhoneNumber = "238-953-3665 x25792",
                        Jurisdiction = '0',
                        IdentificationNumber = "7dad9bc7-13b4-462d-b0f6-c003ae2d8ca2",
                        FirstName = "Erwin",
                        LastName = "Rodriguez"
                    },
                    new Supervisor
                    {
                        ID = 10,
                        PhoneNumber = "800.768.4032 x7410",
                        Jurisdiction = 'x',
                        IdentificationNumber = "f3fa46a5-816c-4704-8159-195d88e8d4f3",
                        FirstName = "Maribel",
                        LastName = "D'Amore"
                    },
                    new Supervisor
                    {
                        ID = 11,
                        PhoneNumber = "462-704-5779",
                        Jurisdiction = '7',
                        IdentificationNumber = "eb20bfec-7aba-49a9-9834-d54c5b224f0b",
                        FirstName = "Norwood",
                        LastName = "Conroy"
                    },
                    new Supervisor
                    {
                        ID = 12,
                        PhoneNumber = "(770) 738-8996 x876",
                        Jurisdiction = 't',
                        IdentificationNumber = "771f6af3-357b-4c8b-b2b6-6304059bb90c",
                        FirstName = "Garnett",
                        LastName = "Lockman"
                    },
                    new Supervisor
                    {
                        ID = 13,
                        PhoneNumber = "1-206-231-3800 x686",
                        Jurisdiction = 'l',
                        IdentificationNumber = "5b6a4232-c6ec-4cad-8b1e-a8ae3f1572d4",
                        FirstName = "Dorothea",
                        LastName = "McLaughlin"
                    },
                    new Supervisor
                    {
                        ID = 14,
                        PhoneNumber = "(369) 886-4293 x407",
                        Jurisdiction = 'g',
                        IdentificationNumber = "a99c5bb7-de6e-413e-b833-8ec43aba1444",
                        FirstName = "Clifton",
                        LastName = "Ziemann"
                    },
                    new Supervisor
                    {
                        ID = 15,
                        PhoneNumber = "846.840.9245",
                        Jurisdiction = 'h',
                        IdentificationNumber = "9d7d713f-1d19-42c5-84a7-80b0fc6dac63",
                        FirstName = "Lisa",
                        LastName = "Hoppe"
                    },
                    new Supervisor
                    {
                        ID = 16,
                        PhoneNumber = "384.235.3768 x8963",
                        Jurisdiction = 'q',
                        IdentificationNumber = "a1cef699-d046-4122-bbb7-f331c78e6b17",
                        FirstName = "Ezequiel",
                        LastName = "Collier"
                    },
                    new Supervisor
                    {
                        ID = 17,
                        PhoneNumber = "(443) 454-5443 x68365",
                        Jurisdiction = 'd',
                        IdentificationNumber = "db8b0e59-21bc-46b9-87c0-da87e4699b83",
                        FirstName = "Ida",
                        LastName = "Braun"
                    },
                    new Supervisor
                    {
                        ID = 18,
                        PhoneNumber = "(337) 222-2549 x5061",
                        Jurisdiction = 'b',
                        IdentificationNumber = "68667498-aebf-483f-ab4e-f5a8babb2fbf",
                        FirstName = "Terrell",
                        LastName = "Tremblay"
                    },
                    new Supervisor
                    {
                        ID = 19,
                        PhoneNumber = "(873) 264-1831",
                        Jurisdiction = 'b',
                        IdentificationNumber = "135a738d-fa9b-4b48-aa99-b59f26ff918d",
                        FirstName = "Kobe",
                        LastName = "Denesik"
                    },
                    new Supervisor
                    {
                        ID = 20,
                        PhoneNumber = "208-574-0616",
                        Jurisdiction = 'e',
                        IdentificationNumber = "8fd5cdc7-16d7-4e10-a605-845d8b555e31",
                        FirstName = "Donny",
                        LastName = "Zieme"
                    },
                    new Supervisor
                    {
                        ID = 21,
                        PhoneNumber = "646-909-0085",
                        Jurisdiction = '2',
                        IdentificationNumber = "a6e47300-0ddb-42fa-a5fe-41753e9393f5",
                        FirstName = "Zion",
                        LastName = "Von"
                    },
                    new Supervisor
                    {
                        ID = 22,
                        PhoneNumber = "1-739-541-5867",
                        Jurisdiction = 'x',
                        IdentificationNumber = "2230ff81-99ac-44be-add6-bd6a859f9075",
                        FirstName = "Lydia",
                        LastName = "Schamberger"
                    },
                    new Supervisor
                    {
                        ID = 23,
                        PhoneNumber = "1-973-629-0572 x92988",
                        Jurisdiction = '5',
                        IdentificationNumber = "4d3b4d36-a65f-4270-86f7-aed8b9929eca",
                        FirstName = "Mertie",
                        LastName = "Gulgowski"
                    },
                    new Supervisor
                    {
                        ID = 24,
                        PhoneNumber = "1-996-968-2619",
                        Jurisdiction = 'l',
                        IdentificationNumber = "e532425b-6195-43df-882c-91e944d88b27",
                        FirstName = "Rodrick",
                        LastName = "Gutmann"
                    },
                    new Supervisor
                    {
                        ID = 25,
                        PhoneNumber = "1-353-333-7341 x45622",
                        Jurisdiction = '9',
                        IdentificationNumber = "f77d40d7-3548-495e-ac7b-8333fcf3e695",
                        FirstName = "Brett",
                        LastName = "Mohr"
                    },
                    new Supervisor
                    {
                        ID = 26,
                        PhoneNumber = "(614) 469-7214 x5928",
                        Jurisdiction = '0',
                        IdentificationNumber = "549f1832-d1df-4e22-845e-5adc2d39c73b",
                        FirstName = "Jaren",
                        LastName = "Hickle"
                    },
                    new Supervisor
                    {
                        ID = 27,
                        PhoneNumber = "767.865.4584 x59664",
                        Jurisdiction = 'b',
                        IdentificationNumber = "f030dc3a-78d7-44ea-9543-6e54c01dc604",
                        FirstName = "Jaquan",
                        LastName = "Gerhold"
                    },
                    new Supervisor
                    {
                        ID = 28,
                        PhoneNumber = "(281) 928-5046 x77931",
                        Jurisdiction = 'i',
                        IdentificationNumber = "b7c08b1b-e035-42a7-8b61-9e96e69cf841",
                        FirstName = "Kathlyn",
                        LastName = "Hane"
                    },
                    new Supervisor
                    {
                        ID = 29,
                        PhoneNumber = "(362) 870-5006 x14100",
                        Jurisdiction = 'x',
                        IdentificationNumber = "7e47f986-ff97-40db-8960-7b57c9bcc85e",
                        FirstName = "Zena",
                        LastName = "Brakus"
                    },
                    new Supervisor
                    {
                        ID = 30,
                        PhoneNumber = "702-213-9844 x70167",
                        Jurisdiction = 't',
                        IdentificationNumber = "16e35b7b-32ce-4738-9d94-9358c7ad905a",
                        FirstName = "Jett",
                        LastName = "Volkman"
                    },
                    new Supervisor
                    {
                        ID = 31,
                        PhoneNumber = "224-725-6364 x4150",
                        Jurisdiction = 'i',
                        IdentificationNumber = "14cc9675-c705-4206-9fb2-458df372796a",
                        FirstName = "Bruce",
                        LastName = "Bechtelar"
                    },
                    new Supervisor
                    {
                        ID = 32,
                        PhoneNumber = "(388) 861-0894",
                        Jurisdiction = 'k',
                        IdentificationNumber = "be5f9476-bb46-42f9-9200-cab4edf5a8da",
                        FirstName = "Lucious",
                        LastName = "Jacobi"
                    },
                    new Supervisor
                    {
                        ID = 33,
                        PhoneNumber = "909.665.7247 x193",
                        Jurisdiction = 'z',
                        IdentificationNumber = "411488f2-2e5b-4de6-8f0b-16e812fc1cef",
                        FirstName = "Ricky",
                        LastName = "Oberbrunner"
                    },
                    new Supervisor
                    {
                        ID = 34,
                        PhoneNumber = "571.377.1305",
                        Jurisdiction = 'm',
                        IdentificationNumber = "70f47079-da10-4e9a-8dde-247e9d01656a",
                        FirstName = "Lavern",
                        LastName = "Huels"
                    },
                    new Supervisor
                    {
                        ID = 35,
                        PhoneNumber = "(840) 732-8176 x309",
                        Jurisdiction = 'p',
                        IdentificationNumber = "36f4d165-5a5f-4d96-a32a-ab8f2c8ec43b",
                        FirstName = "Kirsten",
                        LastName = "Wyman"
                    },
                    new Supervisor
                    {
                        ID = 36,
                        PhoneNumber = "1-420-610-9903 x2181",
                        Jurisdiction = 'e',
                        IdentificationNumber = "2adef844-c25a-4a23-aceb-44a514af681f",
                        FirstName = "Pascale",
                        LastName = "Raynor"
                    },
                    new Supervisor
                    {
                        ID = 37,
                        PhoneNumber = "424.448.9247",
                        Jurisdiction = 'u',
                        IdentificationNumber = "b5f5fc03-6dad-4e88-afbf-4c9544030c73",
                        FirstName = "Dolores",
                        LastName = "Beer"
                    },
                    new Supervisor
                    {
                        ID = 38,
                        PhoneNumber = "(757) 405-9114",
                        Jurisdiction = 'n',
                        IdentificationNumber = "2cc2b4a0-afda-4808-82d6-09d92fd39d33",
                        FirstName = "Cali",
                        LastName = "Schulist"
                    },
                    new Supervisor
                    {
                        ID = 39,
                        PhoneNumber = "488.417.9722 x52225",
                        Jurisdiction = '8',
                        IdentificationNumber = "484df5b4-d2a4-456e-943d-4465b113143e",
                        FirstName = "Jordon",
                        LastName = "Windler"
                    },
                    new Supervisor
                    {
                        ID = 40,
                        PhoneNumber = "678-950-7204",
                        Jurisdiction = '1',
                        IdentificationNumber = "463eec69-b449-4f66-974d-e24bc2e74202",
                        FirstName = "Nicolas",
                        LastName = "Maggio"
                    },
                    new Supervisor
                    {
                        ID = 41,
                        PhoneNumber = "(481) 244-4289",
                        Jurisdiction = 'i',
                        IdentificationNumber = "f3dba247-9766-4196-9691-7c2ab4c1419e",
                        FirstName = "Angelina",
                        LastName = "Bartell"
                    },
                    new Supervisor
                    {
                        ID = 42,
                        PhoneNumber = "(442) 723-4251 x4573",
                        Jurisdiction = '1',
                        IdentificationNumber = "a0e2504a-1677-4682-815a-b57247c2819e",
                        FirstName = "Jean",
                        LastName = "Becker"
                    },
                    new Supervisor
                    {
                        ID = 43,
                        PhoneNumber = "1-315-651-5894 x54185",
                        Jurisdiction = 'c',
                        IdentificationNumber = "6e8bc7af-005a-47af-b88c-3650363c3dde",
                        FirstName = "Laverna",
                        LastName = "Hermiston"
                    },
                    new Supervisor
                    {
                        ID = 44,
                        PhoneNumber = "(327) 382-9141 x1705",
                        Jurisdiction = 'y',
                        IdentificationNumber = "53c29122-b17f-4003-b251-656287cfc976",
                        FirstName = "Rashad",
                        LastName = "Sauer"
                    },
                    new Supervisor
                    {
                        ID = 45,
                        PhoneNumber = "(405) 705-2778",
                        Jurisdiction = 'q',
                        IdentificationNumber = "5586c6fd-aff6-4dc4-8ffd-0cb07e68b99b",
                        FirstName = "Makayla",
                        LastName = "Larson"
                    },
                    new Supervisor
                    {
                        ID = 46,
                        PhoneNumber = "857-856-9699",
                        Jurisdiction = 'r',
                        IdentificationNumber = "86293e2a-898f-4c15-b71c-b37473a7e281",
                        FirstName = "River",
                        LastName = "Runolfsson"
                    },
                    new Supervisor
                    {
                        ID = 47,
                        PhoneNumber = "1-809-366-5227",
                        Jurisdiction = '5',
                        IdentificationNumber = "52f0fb92-dd4d-4526-abd4-d4da7e01dd2a",
                        FirstName = "Mafalda",
                        LastName = "Prosacco"
                    },
                    new Supervisor
                    {
                        ID = 48,
                        PhoneNumber = "(770) 219-1058",
                        Jurisdiction = 'j',
                        IdentificationNumber = "16793dc9-732e-4dd6-bbc0-a79a68725433",
                        FirstName = "Gunner",
                        LastName = "Wisozk"
                    },
                    new Supervisor
                    {
                        ID = 49,
                        PhoneNumber = "(891) 932-8826 x32453",
                        Jurisdiction = 'l',
                        IdentificationNumber = "f60b3b80-af11-40b0-93bd-dfa86dc17540",
                        FirstName = "Anastacio",
                        LastName = "Becker"
                    },
                    new Supervisor
                    {
                        ID = 50,
                        PhoneNumber = "414.861.1516",
                        Jurisdiction = 'u',
                        IdentificationNumber = "f430b6d0-a1b1-4e26-8d22-ce969d15fdab",
                        FirstName = "Magdalena",
                        LastName = "Lehner"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
