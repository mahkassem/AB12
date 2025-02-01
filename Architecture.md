# Domain-Driven Design (DDD) Architecture

The project structure is organized into modules, which contain related application logic, such as commands and queries. Each module has its own set of commands and queries, which are used to perform operations on the domain model.

The domain model consists of entities and value objects, which represent the data and behavior of the application. The infrastructure layer contains repositories, which are used to interact with the database.

The service layer contains application services, which contain the business logic of the application. The controllers layer contains API controllers, which handle HTTP requests and responses.

## Project Structure

```
AB12/
├── Application/
│   ├── [Module]/
├── Controllers/
├── Domain/
│   ├── Base/
│   │   ├── Common/
│   │   ├── Schema/
│   ├── Persistence/
│   │   ├── Configuration/
├── Infrastructure/
│   ├── Components/
│   │   ├── Common/
├── Services/
│   ├── Application/
│   │   ├── Mappings/
│   ├── Components/
```

## Directory Descriptions

- `AB12/Application`: Contains application logic.
  - `Module`: Contains [module]-related application logic.
    - `Commands`: Contains commands for [module]-related operations.
    - `Results`: Contains result models for [module]-related operations.
- `AB12/Controllers`: Contains API controllers.
- `AB12/Domain`: Contains domain models and persistence: entities, value objects, and repositories.
  - `Base`: Contains base domain models: common base classes and database schema.
    - `Common`: Contains common domain models: base classes used across the application.
    - `Schema`: Contains schema domain models: database schema.
  - `Persistence`: Contains persistence logic: entity configurations and data seeding.
    - `Configuration`: Contains entity configurations: database entity mappings. (relationships, indexes, etc.)
- `AB12/Infrastructure`: Contains infrastructure components: repositories and utilities.
  - `Components`: Contains infrastructure components: repositories.
    - `Common`: Contains common infrastructure components: base repository classes: interfaces and methods, etc.
- `AB12/Services`: Contains service layer: application services and mapping data.
  - `Application`: Contains application services: business logic.
    - `Mappings`: Contains mapping profiles: mapping data between domain and application models.
  - `Components`: Contains service components: base service classes: interfaces and methods, etc.
- `Migrations`: Contains database migrations: database schema changes, produced by Entity Framework Core.

## Project Architecture

The project follows the Domain-Driven Design (DDD) architecture, which is a design pattern that focuses on the domain model and domain logic. The DDD architecture consists of the following layers:

- **Application Layer**: Contains application logic, such as commands and queries.
- **Domain Layer**: Contains domain models and domain logic, such as entities and value objects.
- **Infrastructure Layer**: Contains infrastructure components, such as repositories and utilities.
- **Services Layer**: Contains service layer components, such as application services and mapping data.
- **Controllers Layer**: Contains API controllers, which handle HTTP requests and responses.

Read more about the [DDD architecture](https://en.wikipedia.org/wiki/Domain-driven_design).
