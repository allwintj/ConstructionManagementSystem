using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionManagementSystem.CmsData
{
	public class AccessInfo
	{
		string Password;
		string UserId;
		bool IsRememberPassword;
		int UniqueId;
		string emailId;

		public void ValidateUserString(string userString)
		{
			throw new NotImplementedException();
		}

		public void AuthenticateUser(string username, string password)
		{
			throw new NotImplementedException();
		}

		public void RetrieveForgetPassword(string username, string password)
		{
			throw new NotImplementedException();
		}
	}
}
