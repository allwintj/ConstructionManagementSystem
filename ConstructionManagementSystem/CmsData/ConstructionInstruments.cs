using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionManagementSystem.CmsData
{
	public class ConstructionInstruments
	{
		string itemName;
        string itemId;
		List<string> itemTags;
        string itemDescription;
		ConstructionInstrumentsTypeEnum itemType;
		List<WorkerInfo> itemUsers;
        List<RawMaterialInfo> rawMaterialSupportedList;

		public void ItemGetUsage()
		{
			throw new NotImplementedException();
		}

        public List<RawMaterialInfo> GetRawMaterialList()
		{
			throw new NotImplementedException();
		}
	}
}
