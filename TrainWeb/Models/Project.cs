using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace TrainWeb.Models
{
	public class Project
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Client { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public DateTime CreateDateTime { get; set; }
		public DateTime UpdateDateTime { get; set; }

		public Project(int id, string name, string client, string description, string image)
		{
			Id = id;
			Name = name;
			Client = client;
			Description = description;
			Image = image;
		}
		public Project(int id, string name, string client, string description, string image, DateTime createDateTime, DateTime updateDateTime)
		{
			Id = id;
			Name = name;
			Client = client;
			Description = description;
			Image = image;
			CreateDateTime = createDateTime;
			UpdateDateTime = updateDateTime;
		}
	}
}
