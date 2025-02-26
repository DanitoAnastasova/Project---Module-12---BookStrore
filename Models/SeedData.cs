namespace BookStore.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreContext>>()))
            {
                if (context.Books.Any())    // Check if database contains any books
                {
                    return;     // Database contains books already
                }

                context.Books.AddRange(
                    new Book
                    {
                        Title = "Силоз (Силоз 1)",
                        Language = "Български",
                        ISBN = "9786191933099",
                        DatePublished = DateTime.Parse("2012-1-27"),
                        Price = 30,
                        Author = "Хю Хауи",
                        ImageUrl = "\"C:\\Users\\dania\\OneDrive\\Документи\\Programming projects\\Images for BookStore projects\\siloz-siloz-1-30.jpg\""
                    },

                    new Book
                    {
                        Title = "Смъртоносна игра",
                        Language = "Български",
                        ISBN = "9786190215417",
                        DatePublished = DateTime.Parse("2024-12-6"),
                        Price = 24,
                        Author = "Майкъл Кейн",
                        ImageUrl = "\"C:\\Users\\dania\\OneDrive\\Документи\\Programming projects\\Images for BookStore projects\\smartonosna-igra-maykal-keyn-30.jpg\""
                    },

                    new Book
                    {
                        Title = "Основи на биткойн и блокчейн. Въведение в криптовалутите и технологията, която ги движи",
                        Language = " Български",
                        ISBN = "\t9786197080360",
                        DatePublished = DateTime.Parse("2023"),
                        Price = 25,
                        Author = "Антъни Луис",
                        ImageUrl = "\"C:\\Users\\dania\\OneDrive\\Документи\\Programming projects\\Images for BookStore projects\\osnovi-na-bitkoyn-i-blokcheyn-vavedenie-v-kriptovalutite-i-tehnologiyata--koyato-gi-dvizhi-30.jpg\""
                    },

                    new Book
                    {
                        Title = "Ерата на изкуствения интелект и нашето човешко бъдеще",
                        Language = "Български",
                        ISBN = "9789543988334",
                        DatePublished = DateTime.Parse("2024-6-14"),
                        Price = 45,
                        Author = "Даниел Хутенлохер, Ерик Шмит, Хенри Кисинджър",
                        ImageUrl = "\"C:\\Users\\dania\\OneDrive\\Документи\\Programming projects\\Images for BookStore projects\\erata-na-izkustveniya-intelekt-i-nasheto-choveshko-badeshte-30.jpg\""
                    },

                    new Book
                    {
                        Title = "Marvel: Супер истории - том 1",
                        Language = "Български",
                        ISBN = "9786197733310",
                        DatePublished = DateTime.Parse("2024"),
                        Price = 22,
                        Author = "Колектив",
                        ImageUrl = "\"C:\\Users\\dania\\OneDrive\\Документи\\Programming projects\\Images for BookStore projects\\marvel--super-istorii---tom-1-30.jpg\""
                    },

                    new Book
                    {
                        Title = "Ефективно програмиране със C#",
                        Language = "Български",
                        ISBN = "9789546564528",
                        DatePublished = DateTime.Parse("2022"),
                        Price = 22,
                        Author = "Бил Уогнър",
                        ImageUrl = "\"C:\\Users\\dania\\OneDrive\\Документи\\Programming projects\\Images for BookStore projects\\efektivno-programirane-sas-c-30.jpg\""
                    }
                );

                context.SaveChanges();
            }
            
        }
    }
}
