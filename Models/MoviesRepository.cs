namespace EpicCinema.Models
{
	public class MoviesRepository
	{
		private static List<Category> _categories = new List<Category>()
		{
			new Category {Id = 1, Name = "Hollywood", Description = "Hollywood movies"},
			new Category {Id = 2, Name = "Nollywood", Description = "Nollywood movies"},
			new Category {Id = 3, Name = "Bollywood", Description = "Bollywood movies"}
		};
		//create new category
		public static void AddCategory(Category category)
		{
			//get last id
			var maxId = _categories.Max(c => c.Id);
			category.Id = maxId + 1;
			_categories.Add(category);
		}
		//view/read categories
		public static List<Category> ReadCategories() 
		{  
			return _categories; 
		}

		//get category by id
		public static Category? GetCategoryById(int id)
		{
			var category = _categories.FirstOrDefault(c => c.Id == id);
			if (category != null)
			{
				return new Category
				{
					Id = category.Id,
					Name = category.Name,
					Description = category.Description,
				};
			}
			return null;
		}
		//update categories

		public static void UpdateCategory(int id, Category category)
		{
			if (id != category.Id)
				return;
			var categoryToUpdate = GetCategoryById(id);
			if (categoryToUpdate != null)
			{
				categoryToUpdate.Name = category.Name;
				categoryToUpdate.Description = category.Description;
			}
		}
		//delete category
		public static void DeleteCategory(int Id)
		{
			var category = _categories.FirstOrDefault(c => c.Id == Id);
			if (category != null)
			{
				_categories.Remove(category);
			}
		}

	}
}
