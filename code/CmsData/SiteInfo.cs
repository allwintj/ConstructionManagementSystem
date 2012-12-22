using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionManagementSystem.CmsData
{
	public class SiteInfo
	{
		string name;
		string location;
		string customerName;
		double valuation;
		DesignInfo design;
		List<Responsibility> responsibilities;
		WorkerInfo superViser;
	}
}
