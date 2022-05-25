using System;

namespace _307_AdditionalTask
{
	[AttributeUsageAttribute(AttributeTargets.Class, AllowMultiple = false)]
	class AccessLevelAttribute : Attribute
	{
		string accessLevel = null;

		public AccessLevelAttribute(string accessLevel)
		{
			this.accessLevel = accessLevel;
		}

		public string AccessLevel
		{
			get { return accessLevel; }
		}
	}
}
