using System.ComponentModel.DataAnnotations;

namespace BlazorServerSyncfusion.Models
{
	public class Customer
	{
		[Required(ErrorMessage = "Id is required")]
		public int Id { get; set; }

		[Required(ErrorMessage = "Name is required"), MaxLength(35, ErrorMessage = "Name must be less than 35 characters")]
		public string Name { get; set; }

		public DateTime DateOfBirth { get; set; }

		[Required(ErrorMessage = "Address is required")]
		public string Address { get; set; }
	}
}
