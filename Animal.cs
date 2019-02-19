using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
	public class Animal
	{
		[DisplayName("Название: ")]
		[Description("наименование животного.")]
		public string AName { get; set; }

		[DisplayName("Латин. название: ")]
		[Description("название животного на латыни.")]
		public string ALatName { get; set; }

		[DisplayName("Класс: ")]
		[Description("к какому классу относится животное.")]
		public string AClass { get; set; }

		[DisplayName("Средний вес: ")]
		[Description("средний вес животного в граммах.")]
		public double AWeight { get; set; }
	}
}


