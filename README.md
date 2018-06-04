# microservice-with-mssqldb
This is a single .net core API microservice with SQL Server Express on Linux backend as a POC. It is to show how to do a single API around a particular domain with a database that is its own.


## Setup

dotnet new webapi -o peopleapi under .net core 2.1.x

dotnet ef dbcontext scaffold "server=localhost; user id=peopleAPI; password=myP@ssw0rd; Initial Catalog=peopleAPI"  Microsoft.EntityFrameworkCore.SqlServer

dotnet ef migrations add PeopleAPIMigration

dotnet ef database update

## Building Containers

'docker build -t peopleapi-db .'

The database container is built using the Dockerfile in the database directory. It spools up the MS SQL SQL Express Linux container, copies in a create script, runs it, then powers down SQL Express leaving you with a prebuilt database with a horrible password! 

docker run -d -p 1433:1433 --rm --name peopleapi-db peopleapi-db


## API Calls

http://localhost:8080/api/people/ gets back a JSON listing of the Person class.

http://localhost:8080/api/people/71ab7dfc-953f-4821-b221-dcb3cf135068 gets back a JSON listing of the Person class for my record :).

http://localhost:8080/swagger/ gives you the Swagger API documentation generated from the Person Controller where xxxx is the port 5000 or whatever you set it to be.

## DB Structure
