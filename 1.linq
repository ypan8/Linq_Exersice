<Query Kind="Statements">
  <Connection>
    <ID>5c4ff77d-54dd-4298-9798-6d27defcc0d6</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

var results = from x in Skills
orderby x.Description ascending
select new
     {
         Description = x.Description 
      };
results.Dump();