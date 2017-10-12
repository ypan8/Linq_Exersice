<Query Kind="Statements">
  <Connection>
    <ID>dac930bb-7c81-44cf-b850-fd9be256a927</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

var employeeYOE = from x in Employees
select new {
	Name = x.FirstName + " " +  x.LastName,
	YOE = x.EmployeeSkills.Sum(y => y.YearsOfExperience)
};
employeeYOE.Dump();

var MaxYear = employeeYOE.Max(y => y.YOE);
MaxYear.Dump();

var resutls = from x in employeeYOE 
              where x.YOE == MaxYear
			  select new 
                   {
				     Name = x.Name,
					 YOE = x .YOE
				   };
resutls.Dump();