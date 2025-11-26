using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    // model wpisu do bazy danych do tabeli 
    public class DiaryEntry
    {   // each one will be separete column in the database

        //[Key] it is covered 
        public int Id { get; set; } // it should be "Id" to be converted by .net core or DiaryEntryId (only these two options)
        [Required] // title has to have a value - we have nulable true so this is important here
        [StringLength(100, MinimumLength = 3, ErrorMessage = "The title is too short! (min 3 chars)")] // max is 100 - client side validation
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        [Required]
        public string Created { get; set; } // init of this value with current time is not working
    }
}
