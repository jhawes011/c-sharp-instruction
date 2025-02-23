

using System.Numerics;

namespace joe_hawes_contact_list
{
	public class Contact
	{
		private string firstName;
		private string lastName;
		private string email;
		private string phone;

		public void SetFirstName(string firstname) => this.firstName = firstname;
		public string GetFirstName() => firstName;

		public void SetLastName(string lastname) => this.lastName = lastname;
		public string GetLastName() => lastName;

		public void SetEmail(string email) => this.email = email;
		public string GetEmail() => email;

		public void SetPhone(string phone) => this.phone = phone;
		public string GetPhone() => phone;

		public string DisplayContact()
		{
			return $"--------------------------------------------\n" +
				   $"---- Current Contact -----------------------\n" +
				   $"--------------------------------------------\n" +
				   $"Name: {firstName} {lastName}\n" +
				   $"Email Address: {email}\n" +
				   $"Phone Number: {phone}\n" +
				   $"--------------------------------------------";
		}
	}
}
