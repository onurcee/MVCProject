﻿using DataLayerAccess.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
	public class CategoryManager
	{

		GenericRepository <Category> repo = new GenericRepository<Category>();

		public List<Category> GetAllBL()
		{
			return repo.List();
		}


		public void CategoryAddBL(Category P)
		{
			if(P.CategoryName == "" || P.CategoryName.Length<=3 || P.CategoryDescription == "" || P.CategoryName.Length>=51)
			{
				//hata mesajı
			}
			else
			{
				repo.Insert(P);
			}
		}
	}
}
