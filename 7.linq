<Query Kind="Statements">
  <Connection>
    <ID>dac930bb-7c81-44cf-b850-fd9be256a927</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

var results = from x in Employees
              where x.Schedules.Any(y => y.Day.Month == 11)
			  orderby x.LastName ascending , x.FirstName ascending
			  select new
			      {
				      Name = x.FirstName + " " + x.LastName 
				  };
results.Dump();