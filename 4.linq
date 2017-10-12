<Query Kind="Statements">
  <Connection>
    <ID>dac930bb-7c81-44cf-b850-fd9be256a927</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

var results = from x in Employees
              where x.EmployeeSkills.Count() > 1
			  select new
			      {
				     Name = x.FirstName + " " + x.LastName,
					 Skills = from y in EmployeeSkills
					          where x.EmployeeID == y.EmployeeID
							  select new 
							     {
								    Description = y.Skill.Description,
									 Level = y.Level == 0? "Novice":
									         y.Level == 1? "Proficient":
											 "Expert",
									YearsExperience = y.YearsOfExperience
								  }
				  };
			  
results.Dump();