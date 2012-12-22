using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionManagementSystem.CmsData
{
	public class RawMaterialInfo
	{
		string itemName;
		int itemId;
		List<string> itemTags;
		int itemDescription;
		RawMaterialTypeEnum itemType;
		List<WorkerInfo> itemUsers;

		public void ItemGetUsage()
		{
			throw new NotImplementedException();
		}
	}
}
