# Database Schema and Relationships

## Tables

### Users
- **ID:** Primary Key (varchar(255))
- **FirstName:** varchar(100)
- **LastName:** varchar(100)
- **Email:** string (unique, not null)
- **Password:** string (hashed)
- **Relationships:** Has many Orders

### Orders
- **ID:** Primary Key (varchar(255))
- **ClientName:** varchar(100)
- **Rating:** Nullable int
- **UserID:** Foreign Key to Users(ID)
- **Status:** Enum (New, InProgress, Completed)
- **Relationships:**
  - Belongs to a User
  - Has many OrderItems

### OrderItems
- **ID:** Primary Key (varchar(255))
- **ProductID:** Foreign Key to Products(ID)
- **OrderID:** Foreign Key to Orders(ID)
- **Quantity:** int
- **Relationships:**
  - Belongs to an Order
  - Belongs to a Product

### Products
- **ID:** Primary Key (varchar(255))
- **Name:** string
- **Description:** text
- **Price:** decimal
- **Quantity:** int
- **Relationships:** Has many OrderItems

## Relationships Summary

- **Users to Orders:** One-to-Many (A user can have multiple orders).
- **Orders to OrderItems:** One-to-Many (An order can contain multiple order items).
- **Products to OrderItems:** One-to-Many (A product can appear in multiple order items).
- **OrderItems:** Serves as a junction between Orders and Products.
