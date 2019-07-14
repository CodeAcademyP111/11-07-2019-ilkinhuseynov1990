using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
	public class Aptek
	{
		private static int _id = 0;

		public int ID { get; set; }

		public string Name { get; set; }

		private List<Derman> dermanlar;

		public Aptek(string Name)
		{
			_id++;
			ID = _id;
			this.Name = Name;
			dermanlar = new List<Derman>()
			{
				new Derman{Name="Spazmagon",Dermannovu ="Agrikesici", price=1.4},
				new Derman{Name="Novaposit",Dermannovu ="Sakitlesdirici", price=10},
				new Derman{Name="Tera-Flyu",Dermannovu ="Agrikesici", price=1.4},
				new Derman{Name="Nospa",Dermannovu ="Agrikesici", price=1.4},
			};
		}


		public List<Derman> GetDerman()
		{
			return dermanlar;
		}


		public void AddMedicine(Derman derman) {
			dermanlar.Add(derman);
		}

		public void DeleteMedicine(int index)
		{
			for (int i = 0; i < dermanlar.Count; i++)
			{
				if (index == dermanlar[i].ID) {
					dermanlar.RemoveAt(i);
				}
			}
		}

		public Derman GetDerman(int index)
		{
			Derman result = null;
			for (int i = 0; i < dermanlar.Count; i++)
			{
				if (index == dermanlar[i].ID)
				{
					result = dermanlar[i];
				}

			}
			return result;

		}

		public void Update(int id, string tipi, string name, double price)
		{
			Derman derman = GetDerman(id);

			derman.Dermannovu = tipi;
			derman.Name = name;
			derman.price = price;


		}
	}
}
