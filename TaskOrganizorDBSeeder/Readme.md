## Run docker command  

`docker build .`

## Run dotnet-ef command

* Create script from migrations  
`dotnet ef migrations script -o file.sql -i`
  
* Add migrations  
`dotnet ef migrations add migrationName`  
  
* Remove latest migrations  
`dotnet ef migrations remove`