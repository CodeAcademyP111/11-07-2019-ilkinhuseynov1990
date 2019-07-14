namespace Pharmacy
{
	public class Derman
	{
		private static int _id = 0;

		public int ID { get; set; }

		public string  Dermannovu { get; set; }

		public string Name { get; set; }

		public double price { get; set; }

		public Derman()
		{
			_id++;
			ID = _id;
		}

		public override string ToString()
		{
			return $"{ID} {Name}";
		}
	}
}
