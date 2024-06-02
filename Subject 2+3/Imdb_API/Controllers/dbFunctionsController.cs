using Imdb_API.Data;
using Imdb_API.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Runtime.CompilerServices;

namespace Imdb_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class dbFunctionsController : ControllerBase
    {
        private readonly ImdbDbContext _context;

        public dbFunctionsController(ImdbDbContext context)
        {
            _context = context;
        }

        [HttpGet("f1/{search}")]
        public async Task<IActionResult> SearchMovies(string search)
        {

            string connectionString = "Host=localhost;Port=5432;Database=imdb;Username=postgres;Password=123456";

            try
            {
                await using (var connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await using (var command = new NpgsqlCommand($"SELECT * FROM string_search('%{search}%')", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            List<object[]> rows = new List<object[]>();
                            while (await reader.ReadAsync())
                            {
                                var row = new object[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = reader.GetValue(i);
                                }
                                rows.Add(row);
                            }

                            if (rows.Count > 0)
                            {
                                return Ok(rows); // Return OK status with all matching rows
                            }
                            else
                            {
                                Console.WriteLine("No result returned.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return NotFound();

        }

        [HttpGet("f2/{searchactor}")]
        public async Task<IActionResult> SearchActor(string searchactor)
        {

            string connectionString = "Host=localhost;Port=5432;Database=imdb;Username=postgres;Password=123456";

            try
            {
                await using (var connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await using (var command = new NpgsqlCommand($"SELECT * FROM search_actor('%{searchactor}%')", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            List<object[]> rows = new List<object[]>();
                            while (await reader.ReadAsync())
                            {
                                var row = new object[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = reader.GetValue(i);
                                }
                                rows.Add(row);
                            }

                            if (rows.Count > 0)
                            {
                                return Ok(rows); // Return OK status with all matching rows
                            }
                            else
                            {
                                Console.WriteLine("No result returned.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return NotFound();

        }


        [HttpGet("f3/{similarmovies}")]
        public async Task<IActionResult> SimilarMovies(string similarmovies)
        {

            string connectionString = "Host=localhost;Port=5432;Database=imdb;Username=postgres;Password=123456";

            try
            {
                await using (var connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await using (var command = new NpgsqlCommand($"SELECT * FROM similarmovies('%{similarmovies}%')", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            List<object[]> rows = new List<object[]>();
                            while (await reader.ReadAsync())
                            {
                                var row = new object[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = reader.GetValue(i);
                                }
                                rows.Add(row);
                            }

                            if (rows.Count > 0)
                            {
                                return Ok(rows); // Return OK status with all matching rows
                            }
                            else
                            {
                                Console.WriteLine("No result returned.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return NotFound();

        }

        [HttpGet("f4/{searchcostar}")]
        public async Task<IActionResult> SearchCostar(string searchcostar)
        {

            string connectionString = "Host=localhost;Port=5432;Database=imdb;Username=postgres;Password=123456";

            try
            {
                await using (var connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await using (var command = new NpgsqlCommand($"SELECT * FROM search_actor('%{searchcostar}%')", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            List<object[]> rows = new List<object[]>();
                            while (await reader.ReadAsync())
                            {
                                var row = new object[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = reader.GetValue(i);
                                }
                                rows.Add(row);
                            }

                            if (rows.Count > 0)
                            {
                                return Ok(rows); // Return OK status with all matching rows
                            }
                            else
                            {
                                Console.WriteLine("No result returned.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return NotFound();

        }

        [HttpGet("f5/{fk}/{sk?}")]
        public async Task<IActionResult> wtw_query(string fk, string sk)
        {

            string connectionString = "Host=localhost;Port=5432;Database=imdb;Username=postgres;Password=123456";

            try
            {
                await using (var connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await using (var command = new NpgsqlCommand($"SELECT * FROM wtw_query('%{fk}%','%{sk}%')", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            List<object[]> rows = new List<object[]>();
                            while (await reader.ReadAsync())
                            {
                                var row = new object[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = reader.GetValue(i);
                                }
                                rows.Add(row);
                            }

                            if (rows.Count > 0)
                            {
                                return Ok(rows); // Return OK status with all matching rows
                            }
                            else
                            {
                                Console.WriteLine("No result returned.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return NotFound();

        }

        [HttpGet("f6/{movietitle}/{plot?}/{year?}/{person?}")]
        public async Task<IActionResult> search_4values(string movietitle, string plot, string year, string person)
        {

            string connectionString = "Host=localhost;Port=5432;Database=imdb;Username=postgres;Password=123456";

            try
            {
                await using (var connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await using (var command = new NpgsqlCommand($"SELECT * FROM search_4values('%{movietitle}%','%{plot}%','%{year}%','%{person}%')", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            List<object[]> rows = new List<object[]>();
                            while (await reader.ReadAsync())
                            {
                                var row = new object[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = reader.GetValue(i);
                                }
                                rows.Add(row);
                            }

                            if (rows.Count > 0)
                            {
                                return Ok(rows); // Return OK status with all matching rows
                            }
                            else
                            {
                                Console.WriteLine("No result returned.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return NotFound();

        }

        [HttpGet("f7/{personid}/{movieid}/{rating}")]
        public async Task<IActionResult> rate_movie(int personid, string movieid, int rating)
        {

            string connectionString = "Host=localhost;Port=5432;Database=imdb;Username=postgres;Password=123456";

            try
            {
                await using (var connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await using (var command = new NpgsqlCommand($"SELECT * FROM rate_movie('{personid}','%{movieid}%','{rating}')", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            List<object[]> rows = new List<object[]>();
                            while (await reader.ReadAsync())
                            {
                                var row = new object[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = reader.GetValue(i);
                                }
                                rows.Add(row);
                            }

                            if (rows.Count > 0)
                            {
                                return Ok(rows); // Return OK status with all matching rows
                            }
                            else
                            {
                                Console.WriteLine("No result returned.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return NotFound();

        }

        [HttpGet("f8/popular_actors")]
        public async Task<IActionResult> popular_actors()
        {

            string connectionString = "Host=localhost;Port=5432;Database=imdb;Username=postgres;Password=123456";

            try
            {
                await using (var connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await using (var command = new NpgsqlCommand($"SELECT * FROM popular_actors()", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            List<object[]> rows = new List<object[]>();
                            while (await reader.ReadAsync())
                            {
                                var row = new object[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = reader.GetValue(i);
                                }
                                rows.Add(row);
                            }

                            if (rows.Count > 0)
                            {
                                return Ok(rows); // Return OK status with all matching rows
                            }
                            else
                            {
                                Console.WriteLine("No result returned.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return NotFound();

        }

        [HttpGet("f9/{nconst}")]
        public async Task<IActionResult> name_rating(string nconst)
        {

            string connectionString = "Host=localhost;Port=5432;Database=imdb;Username=postgres;Password=123456";

            try
            {
                await using (var connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await using (var command = new NpgsqlCommand($"SELECT * FROM name_rating('%{nconst}%')", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            List<object[]> rows = new List<object[]>();
                            while (await reader.ReadAsync())
                            {
                                var row = new object[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = reader.GetValue(i);
                                }
                                rows.Add(row);
                            }

                            if (rows.Count > 0)
                            {
                                return Ok(rows); // Return OK status with all matching rows
                            }
                            else
                            {
                                Console.WriteLine("No result returned.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return NotFound();

        }

        [HttpGet("f10/{movien}/{genre}/{actor}/{moviek}/{moviek2}")]
        public async Task<IActionResult> index_search(string movien, string genre, string actor, string moviek, string moviek2)
        {

            string connectionString = "Host=localhost;Port=5432;Database=imdb;Username=postgres;Password=123456";

            try
            {
                await using (var connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await using (var command = new NpgsqlCommand($"SELECT * FROM index_search('%{movien}%','%{genre}%','%{actor}%','%{moviek}%','%{moviek2}%')", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            List<object[]> rows = new List<object[]>();
                            while (await reader.ReadAsync())
                            {
                                var row = new object[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = reader.GetValue(i);
                                }
                                rows.Add(row);
                            }

                            if (rows.Count > 0)
                            {
                                return Ok(rows); // Return OK status with all matching rows
                            }
                            else
                            {
                                Console.WriteLine("No result returned.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return NotFound();

        }

        [HttpGet("f11/{movie}/{genre}")]
        public async Task<IActionResult> exact_search(string movie, string genre)
        {

            string connectionString = "Host=localhost;Port=5432;Database=imdb;Username=postgres;Password=123456";

            try
            {
                await using (var connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await using (var command = new NpgsqlCommand($"SELECT * FROM exact_search('%{movie}%','%{genre}%')", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            List<object[]> rows = new List<object[]>();
                            while (await reader.ReadAsync())
                            {
                                var row = new object[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = reader.GetValue(i);
                                }
                                rows.Add(row);
                            }

                            if (rows.Count > 0)
                            {
                                return Ok(rows); // Return OK status with all matching rows
                            }
                            else
                            {
                                Console.WriteLine("No result returned.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return NotFound();

        }

        [HttpGet("f12/{movien}/{genre}/{actor}/{moviek}/{moviek2}")]
        public async Task<IActionResult> best_search(string movien, string genre, string actor, string moviek, string moviek2)
        {

            string connectionString = "Host=localhost;Port=5432;Database=imdb;Username=postgres;Password=123456";

            try
            {
                await using (var connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await using (var command = new NpgsqlCommand($"SELECT * FROM best_search('%{movien}%','%{genre}%','%{actor}%','%{moviek}%','%{moviek2}%')", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            List<object[]> rows = new List<object[]>();
                            while (await reader.ReadAsync())
                            {
                                var row = new object[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = reader.GetValue(i);
                                }
                                rows.Add(row);
                            }

                            if (rows.Count > 0)
                            {
                                return Ok(rows); // Return OK status with all matching rows
                            }
                            else
                            {
                                Console.WriteLine("No result returned.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return NotFound();

        }

        [HttpGet("f13/{movien}/{genre}/{actor}/{moviek}/{moviek2}")]
        public async Task<IActionResult> best2_search(string movien, string genre, string actor, string moviek, string moviek2)
        {

            string connectionString = "Host=localhost;Port=5432;Database=imdb;Username=postgres;Password=123456";

            try
            {
                await using (var connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await using (var command = new NpgsqlCommand($"SELECT * FROM best2_search('%{movien}%','%{genre}%','%{actor}%','%{moviek}%','%{moviek2}%')", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            List<object[]> rows = new List<object[]>();
                            while (await reader.ReadAsync())
                            {
                                var row = new object[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = reader.GetValue(i);
                                }
                                rows.Add(row);
                            }

                            if (rows.Count > 0)
                            {
                                return Ok(rows); // Return OK status with all matching rows
                            }
                            else
                            {
                                Console.WriteLine("No result returned.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return NotFound();

        }

        [HttpGet("f14/{userid}/{tconst}")]
        public async Task<IActionResult> moviebookmark(int userid, string tconst)
        {

            string connectionString = "Host=localhost;Port=5432;Database=imdb;Username=postgres;Password=123456";

            try
            {
                await using (var connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await using (var command = new NpgsqlCommand($"SELECT * FROM movie_bookmark('{userid}','%{tconst}%')", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            List<object[]> rows = new List<object[]>();
                            while (await reader.ReadAsync())
                            {
                                var row = new object[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = reader.GetValue(i);
                                }
                                rows.Add(row);
                            }

                            if (rows.Count > 0)
                            {
                                return Ok(rows); // Return OK status with all matching rows
                            }
                            else
                            {
                                Console.WriteLine("No result returned.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return NotFound();

        }

        [HttpGet("f15/{userid}/{nconst}")]
        public async Task<IActionResult> actorbookmark(int userid, string nconst)
        {

            string connectionString = "Host=localhost;Port=5432;Database=imdb;Username=postgres;Password=123456";

            try
            {
                await using (var connection = new NpgsqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await using (var command = new NpgsqlCommand($"SELECT * FROM actor_bookmark('{userid}','%{nconst}%')", connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            List<object[]> rows = new List<object[]>();
                            while (await reader.ReadAsync())
                            {
                                var row = new object[reader.FieldCount];
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row[i] = reader.GetValue(i);
                                }
                                rows.Add(row);
                            }

                            if (rows.Count > 0)
                            {
                                return Ok(rows); // Return OK status with all matching rows
                            }
                            else
                            {
                                Console.WriteLine("No result returned.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return NotFound();

        }

    }
}
