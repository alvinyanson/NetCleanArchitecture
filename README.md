
# Clone my repository

Open your terminal and run the following command to clone the repository:

    git clone https://github.com/alvinyanson/NetCleanArchitecture


## Run Migration

After cloning the repo, run the migration by running the command below in your terminal. 

Make sure you are on **NetCleanArchitecture.Infrastructure** project when you execute this command.

    update-database


## Run the application

Run the command below

Make sure you are on **NetCleanArchitecture.API** project when you execute this command as this is the presentation layer.


    dotnet watch run


## Crud Operations

The following are the functionalities covered in this application.

- Get All records
- Get single record by Id
- Add new record
- Update the record
- Delete the record

## Technologies Used

- Asp.Net Core Web API
- Entity Framework Core
- LocalDB
- CQRS (MediatR)
- Clean Architecture
