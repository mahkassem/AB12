# Project Rubric

## Requirements

### Build the following APIs

- Create Order.
- Get All Orders.
- Get Order By Id.
- Update Order.
- Delete Order.

## Your project has to meet the following criteria:

### 1. Code Quality

- Comments: write comments to explain the code. Explain any code that is difficult to understand.
- Naming conventions: use meaningful names for variables, functions, classes, etc.

### 2. Functionality

- Order Controller: create an order controller with the following endpoints:
  - **Create Order:** create an order with the following fields:
    - `ClientName` -> string
    - `Rating` -> nullable int
    - `UserID` -> string UUID
    - `Status` -> Enum(OrderStatus)
    - `OrderItems` -> List of OrderItem
      - `ProductID` -> string UUID
      - `Quantity` -> int
  - **Get All Orders:** get all orders: return a list of orders with the following fields:
    - `OrderID` -> string UUID
    - `ClientName` -> string
    - `Rating` -> nullable int
    - `UserID` -> string UUID
    - `Status` -> Enum(OrderStatus)
    - `OrderItems` -> List of OrderItem
      - `ProductID` -> string UUID
      - `Quantity` -> int
  - **Get Order:** get an order by `OrderID`: return an order with the following fields:
    - `OrderID` -> string UUID
    - `ClientName` -> string
    - `Rating` -> nullable int
    - `UserID` -> string UUID
    - `Status` -> Enum(OrderStatus)
    - `OrderItems` -> List of OrderItem
      - `ProductID` -> string UUID
      - `Quantity` -> int
  - **Delete Order:** delete an order by `OrderID`: return a message indicating the order was deleted.
  - **Update Order:** update an order with the following fields:
    - `OrderID` -> string UUID
    - `ClientName` -> string
    - `Rating` -> nullable int
    - `UserID` -> string UUID
    - `Status` -> Enum(OrderStatus)
    - `OrderItems` -> List of OrderItem
      - `ProductID` -> string UUID
      - `Quantity` -> int

## Bonus Challenge

- Use AutoMapper: use AutoMapper to map the entities to DTOs and vice versa.
- Implement Pagination for List Results: implement pagination for the `Get All Orders` endpoint.
- Add Image for products: add an image field to the `Product` entity and display the image in the response.
