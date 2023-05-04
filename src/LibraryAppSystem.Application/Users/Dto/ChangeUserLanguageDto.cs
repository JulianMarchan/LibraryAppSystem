using System.ComponentModel.DataAnnotations;

namespace LibraryAppSystem.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}