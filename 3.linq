<Query Kind="Program">
  <Connection>
    <ID>dac930bb-7c81-44cf-b850-fd9be256a927</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

var results = from x in Skills
	              where x.RequiresTicket == true
				  select new
				  {
				     Description = x.Description,
					 Employees = from y in EmployeeSkills
				                 where x.SkillID == y.SkillID
								 orderby y.YearsOfExperience ascending
								 select new
					                 {
									   Name = y.Employee.FirstName + " "+ y.Employee.LastName,
			  					       Level = y.Level == 0? "Novice":
									           y.Level == 1? "Proficient":
											   "Expert",
									   YearsExperience = y.YearsOfExperience
									 }
					
					 
				  };
results.Dump();			  
				  


// Define other methods and classes here