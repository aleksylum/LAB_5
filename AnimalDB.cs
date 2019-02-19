using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

///Лабораторная работа №5 Кравцоваой А. В.///
///Пример заполненной базы можно загрузить: Файл -> Загрузить XML///

namespace lab_5
{
	public class AnimalDB
	{
		public BindingList<Animal> animalList;
		////binding list - структура поддерж databinding
		public AnimalDB()
		{
			animalList = new BindingList<Animal>();
		}
	}
}
