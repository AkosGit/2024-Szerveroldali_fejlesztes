using System.ComponentModel.DataAnnotations;

namespace Calander.Viewmodels
{
	public class task
	{
        [Required]
        public string taskname { get; set; }
        [Required]
        [Range(1, 24, ErrorMessage = "value can be between 1 and 24")]
        public int timespan { get; set; }
		[Required]
        [Range(1, 24, ErrorMessage = "value can be between 1 and 24")]
        public int finishtime { get; set; }
	}
}
