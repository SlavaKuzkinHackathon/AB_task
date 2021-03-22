# AB_task
#netcoreapp3.1
ID=postgres;Password=**********;
dotnet ef migrations add Initial
dotnet ef database update
dotnet watch run


https://localhost:5001/
https://localhost:5001/swagger/index.html




dotnet ef database drop --force
dotnet ef database drop --force
dotnet ef migrations remove
