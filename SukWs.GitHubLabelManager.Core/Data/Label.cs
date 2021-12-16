namespace SukWs.GitHub_Label_Manager.Core.Data
{
	internal class Label
	{

		public readonly string uuid;

		public string name;
		public string color;
		public string description;

		public Label(string name, string color, string description, string uuid)
		{
			this.uuid = uuid;
			this.name = name;
			this.color = color;
			this.description = description;
		}

		public Label(string name, string color, string description) : this(name, color, description, System.Guid.NewGuid().ToString("D"))
		{ }

		public Label(string name, string color) : this(name, color, null)
		{ }

	}
}
