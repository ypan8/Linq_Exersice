<Query Kind="Statements">
  <Connection>
    <ID>dac930bb-7c81-44cf-b850-fd9be256a927</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

var results = from x in Shifts
              where x.PlacementContract.Location.Name.Equals("NAIT Centre for Applied Technologies")
              group x by x.DayOfWeek into dayofweek
              select new
			     {
				    Day = dayofweek.Key == 1?"Mon":
					      dayofweek.Key == 2?"Tue":
						  dayofweek.Key == 3?"Wed":
						  dayofweek.Key == 4?"Thu":
						  dayofweek.Key == 5?"Fri":
						  dayofweek.Key == 6?"Sat":
						  "Sun",
	                NumberOFEmployees = dayofweek.Sum(y=>y.NumberOfEmployees)
				 };
results.Dump();

