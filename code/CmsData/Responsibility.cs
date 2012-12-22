using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionManagementSystem.CmsData
{
	public class Responsibility
	{
		string description;
		int id;
		List<ConstructionInstruments> relatedInstruments;
		List<RawMaterialInfo> relatedRawmaterials;
		List<WorkerInfo> relatedWorkers;
		WorkerInfo releatedSupervisor;

		public int GetStatus()
		{
			throw new NotImplementedException();
		}

		public string GetResponsible()
		{
			throw new NotImplementedException();
		}
	}
}
