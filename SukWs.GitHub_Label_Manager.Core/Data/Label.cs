namespace SukWs.GitHub_Label_Manager.Core.Data
{
	internal class Label
	{

		public readonly string UUID;

		public string Name;
		public string Color;
		public string Description;
		
		public Label(string name, string color, string description, string uuid)
		{
			UUID = uuid;
			Name = name;
			Color = color;
			Description = description;
		}

		public Label(string name, string color, string description) : this(name, color, description, System.Guid.NewGuid().ToString("D"))
		{ }

		public Label(string name, string color) : this(name, color, null)
		{ }

	}
}
