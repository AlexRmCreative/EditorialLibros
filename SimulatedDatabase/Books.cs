public class Books
{
    public List<BookDTO> books = new List<BookDTO>()
    {
        // Ficción
        new BookDTO
        {
            Id = 1,
            Title = "Don Quijote de la Mancha",
            Author = "Miguel de Cervantes",
            PublicationYear = 2022,
            Genre = BookGenre.Ficcion,
            Price = 18.95m
        },

        new BookDTO
        {
            Id = 2,
            Title = "Moby Dick",
            Author = "Herman Melville",
            PublicationYear = 2023,
            Genre = BookGenre.Ficcion,
            Price = 14.34m
        },

        new BookDTO
        {
            Id = 3,
            Title = "Orgullo y prejuicio",
            Author = "Jane Austen",
            PublicationYear = 1797,
            Genre = BookGenre.Ficcion,
            Price = 9.00m
        },

        // Nuevos libros añadidos
        new BookDTO
        {
            Id = 4,
            Title = "Crónica de una muerte anunciada",
            Author = "Gabriel García Márquez",
            PublicationYear = 2003,
            Genre = BookGenre.Fantasia,
            Price = 11.35m
        },

        new BookDTO
        {
            Id = 5,
            Title = "El señor de los anillos",
            Author = "J.R.R. Tolkien",
            PublicationYear = 2022,
            Genre = BookGenre.Fantasia,
            Price = 21.80m
        },

        new BookDTO
        {
            Id = 6,
            Title = "Anna Karenina",
            Author = "León Tolstói",
            PublicationYear = 2019,
            Genre = BookGenre.Novela,
            Price = 18.95m
        },

        // Nuevos libros añadidos
        new BookDTO
        {
            Id = 7,
            Title = "El gran Gatsby",
            Author = "F. Scott Fitzgerald",
            PublicationYear = 2021,
            Genre = BookGenre.Novela,
            Price = 12.30m
        },

        new BookDTO
        {
            Id = 8,
            Title = "El nombre de la rosa",
            Author = "Umberto Eco",
            PublicationYear = 2003,
            Genre = BookGenre.Novela,
            Price = 7.59m
        },

        new BookDTO
        {
            Id = 9,
            Title = "Crimen y castigo",
            Author = "Fiódor Dostoyevski",
            PublicationYear = 2019,
            Genre = BookGenre.Novela,
            Price = 11.35m
        },

new BookDTO
        {
            Id = 10,
            Title = "Las aventuras de Sherlock Holmes",
            Author = "Arthur Conan Doyle",
            PublicationYear = 2018,
            Genre = BookGenre.Novela,
            Price = 15.15m
        },

        // Bienestar y Estilo de Vida
        new BookDTO
        {
            Id = 11,
            Title = "El monje que vendió su Ferrari",
            Author = "Robin Sharma",
            PublicationYear = 2012,
            Genre = BookGenre.BienestarYEstiloDeVida,
            Price = 10.40m
        },

        new BookDTO
        {
            Id = 12,
            Title = "El poder del ahora",
            Author = "Eckhart Tolle",
            PublicationYear = 2007,
            Genre = BookGenre.BienestarYEstiloDeVida,
            Price = 9.50m
        },

        // Organización y Hogar
        new BookDTO
        {
            Id = 13,
            Title = "La magia del orden",
            Author = "Marie Kondo",
            PublicationYear = 2020,
            Genre = BookGenre.BienestarYEstiloDeVida,
            Price = 9.45m
        },

        // Mindfulness
        new BookDTO
        {
            Id = 14,
            Title = "Meditar día a día: 25 lecciones para vivir con mindfulness",
            Author = "Christophe Andre",
            PublicationYear = 2019,
            Genre = BookGenre.BienestarYEstiloDeVida,
            Price = 20.00m
        },

        // Productividad
        new BookDTO
        {
            Id = 15,
            Title = "La semana laboral de 4 horas",
            Author = "Timothy Ferriss",
            PublicationYear = 2016,
            Genre = BookGenre.BienestarYEstiloDeVida,
            Price = 9.49m
        },

        // Memorias de viaje
        new BookDTO
        {
            Id = 16,
            Title = "Come. reza, ama",
            Author = "Elizabeth Gilbert",
            PublicationYear = 2024,
            Genre = BookGenre.BienestarYEstiloDeVida,
            Price = 7.55m
        },

        // Bienestar
        new BookDTO
        {
            Id = 17,
            Title = "El código de la felicidad",
            Author = "Peter T. Lambrou",
            PublicationYear = 2017,
            Genre = BookGenre.BienestarYEstiloDeVida,
            Price = 11.00m
        },

        // Espiritualidad
        new BookDTO
        {
            Id = 18,
            Title = "Vivir con abundancia",
            Author = "Sergio Fernandez",
            PublicationYear = 2015,
            Genre = BookGenre.BienestarYEstiloDeVida,
            Price = 18.05m
        },

        new BookDTO
        {
            Id = 19,
            Title = "El arte de no amargarse la vida",
            Author = "Rafael Santandreu",
            PublicationYear = 2021,
            Genre = BookGenre.BienestarYEstiloDeVida,
            Price = 19.85m
        },

        // Creatividad
        new BookDTO
        {
            Id = 20,
            Title = "El camino del artista",
            Author = "Julia Cameron",
            PublicationYear = 1992,
            Genre = BookGenre.Aventura,
            Price = 18.90m
        },

        // Ciencia, Historia y Actualidad
        new BookDTO
        {
            Id = 21,
            Title = "Breve historia del tiempo",
            Author = "Stephen Hawking",
            PublicationYear = 2014,
            Genre = BookGenre.CienciaHistoriaYActualidad,
            Price = 190.00m
        },

        new BookDTO
        {
            Id = 22,
            Title = "Sapiens: De animales a dioses",
            Author = "Yuval Noah Harari",
            PublicationYear = 2015,
            Genre = BookGenre.CienciaHistoriaYActualidad,
            Price = 18.90m
        },

        new BookDTO
        {
            Id = 23,
            Title = "Guns, Germs, and Steel: The Fates of Human Societies",
            Author = "Jared Diamond",
            PublicationYear = 2011,
            Genre = BookGenre.CienciaHistoriaYActualidad,
            Price = 9.49m
        },

        new BookDTO
        {
            Id = 24,
            Title = "Una breve historia de casi todo",
            Author = "Bill Bryson",
            PublicationYear = 2023,
            Genre = BookGenre.CienciaHistoriaYActualidad,
            Price = 19.00m
        },

        new BookDTO
        {
            Id = 25,
            Title = "Homo Deus: Breve historia del mañana",
            Author = "Yuval Noah Harari",
            PublicationYear = 2022,
            Genre = BookGenre.CienciaHistoriaYActualidad,
            Price = 12.30m
        },

        new BookDTO
        {
            Id = 26,
            Title = "Cosmos",
            Author = "Carl Sagan",
            PublicationYear = 2015,
            Genre = BookGenre.CienciaHistoriaYActualidad,
            Price = 23.74m
        },

        new BookDTO
        {
            Id = 27,
            Title = "21 lecciones para el siglo XXI",
            Author = "Yuval Noah Harari",
            PublicationYear = 2018,
            Genre = BookGenre.CienciaHistoriaYActualidad,
            Price = 20.80m
        },

        new BookDTO
        {
            Id = 28,
            Title = "El gen egoísta",
            Author = "Richard Dawkins",
            PublicationYear = 2017,
            Genre = BookGenre.CienciaHistoriaYActualidad,
            Price = 15.15m
        },

        new BookDTO
        {
            Id = 29,
            Title = "Homo sapiens: Breve historia de la humanidad",
            Author = "Yuval Noah Harari",
            PublicationYear = 2009,
            Genre = BookGenre.CienciaHistoriaYActualidad,
            Price = 12.78m
        },

        new BookDTO
        {
            Id = 30,
            Title = "El origen de las especies",
            Author = "Charles Darwin",
            PublicationYear = 1859,
            Genre = BookGenre.CienciaHistoriaYActualidad,
            Price = 5.70m
        },

        // Infantil y Juvenil
        new BookDTO
        {
            Id = 31,
            Title = "Harry Potter y la piedra filosofal",
            Author = "J.K. Rowling",
            PublicationYear = 1999,
            Genre = BookGenre.Fantasia,
            Price = 16.10m
        },

        new BookDTO
        {
            Id = 32,
            Title = "El principito",
            Author = "Antoine de Saint-Exupéry",
            PublicationYear = 2024,
            Genre = BookGenre.Ficcion,
            Price = 16.10m
        },

        new BookDTO
        {
            Id = 33,
            Title = "Las crónicas de Narnia: El león, la bruja y el armario",
            Author = "C.S. Lewis",
            PublicationYear = 2019,
            Genre = BookGenre.Fantasia,
            Price = 11.35m
        },

        new BookDTO
        {
            Id = 34,
            Title = "Matilda",
            Author = "Roald Dahl",
            PublicationYear = 2016,
            Genre = BookGenre.Fantasia,
            Price = 11.68m
        },

        new BookDTO
        {
            Id = 35,
            Title = "Charlie y la fábrica de chocolate",
            Author = "Roald Dahl",
            PublicationYear = 2016,
            Genre = BookGenre.Fantasia,
            Price = 11.68m
        },

        new BookDTO
        {
            Id = 36,
            Title = "El mago de Oz",
            Author = "L. Frank Baum",
            PublicationYear = 2020,
            Genre = BookGenre.Fantasia,
            Price = 10.40m
        },

        new BookDTO
        {
            Id = 37,
            Title = "Mikecrack",
            Author = "MIKECRACK",
            PublicationYear = 2024,
            Genre = BookGenre.InfantilYJuvenil,
            Price = 18.90m
        },

        new BookDTO
        {
            Id = 38,
            Title = "El libro de la selva",
            Author = "Rudyard Kipling",
            PublicationYear = 2016,
            Genre = BookGenre.Aventura,
            Price = 11.35m
        },

        new BookDTO
        {
            Id = 39,
            Title = "La historia interminable",
            Author = "Michael Ende",
            PublicationYear = 2024,
            Genre = BookGenre.Fantasia,
            Price = 23.70m
        },

        new BookDTO
        {
            Id = 40,
            Title = "Percy Jackson y el ladrón del rayo",
            Author = "Rick Riordan",
            PublicationYear = 2014,
            Genre = BookGenre.Fantasia,
            Price = 13.25m
        }
    };
}