using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionManagementSystem.CmsData
{
	public class WorkerInfo
	{
		List<ConstructionInstruments> assginedItems;
		DepartmentalInfo deptDetails;
		PersonalInfo personalDetails;
		AccessInfo accessDetails;
		ExpertiseInfo expertise;
		List<Responsibility> responsibilities;

		public void GetAssigningHistory()
		{
			throw new NotImplementedException();
		}

		public void GetDetails()
		{
			throw new NotImplementedException();
		}

		public void CheckAccessForItems()
		{
			throw new NotImplementedException();
		}
	}
}
