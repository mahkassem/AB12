[![license](https://img.shields.io/badge/License-MIT-purple.svg?style=?style=flat-square)](LICENSE) [![framework](https://img.shields.io/badge/-9.0-gray.svg?style=?style=flat-square&logo=dotnet)](FRAMEWORK) [![database](https://img.shields.io/badge/-8.0-white.svg?style=?style=flat-square&logo=mysql)](DATABASE) [![database](https://img.shields.io/badge/Build-Success-brightgreen.svg?style=?style=flat-square&logo=appveyor&logo=mysql)](BUILD)

# AB12 (Test)

This is an API project built with dotnet 6 to be used to test developers.

## Environment

- .Net framework version: 9.0
- Database: MySql 8

## Requirements

Create an API that allows users to create, read, update, and delete orders.

### Project Rubric

Detailed criteria available [here](PROJECT_RUBRIC.md).  

### Project Architecture

The project follows the Domain-Driven Design (DDD) architecture.

Overview available [here](ARCHITECTURE.md).

### Database Schema

The database schema consists of the following tables:

- Users
- Products
- Orders
- OrderItems

Detailed schema available [here](DATABASE.md).

### Bonus Challenge

- Use AutoMapper.
- Implement Pagination for List Results.
- Add Image for products.

## Installation

1. Clone the repository.
2. Navigate to the project directory.
3. Restore dependencies:
   ```
   dotnet restore
   ```

## Running the Project

### Regular Run
- Build and run the API:
   ```
   dotnet run --project AB12
   ```

### Using Docker Compose (Optional)

- Ensure Docker is installed.
- Start MySQL (and any other required services) with:
   ```
   docker compose up -d
   ```

### Using Makefile (Optional)

- Run the following command to start the API:
   ```
   make dev
   ```