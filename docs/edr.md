# API Documentation

This document provides an overview of the API endpoints for interacting with the database tables in our application. Please refer to this guide for information on how to use these endpoints.

## Table of Contents

1. [Businesses](#businesses)
2. [Customers](#customers)
3. [Orders](#orders)
4. [Locations](#locations)
5. [Categories](#categories)
6. [Contacts](#contacts)
7. [Ads](#ads)
8. [Evaluations](#evaluations)
9. [Notes](#notes)
10. [Socials](#socials)
11. [Opening Hours](#opening-hours)
12. [Images](#images)
13. [Business-Category Relationship](#business-category)


### Locations

- **Create a new location**
  - Endpoint: `POST /locations`
  - Description: Create a new location with the provided details.
- **Get details of a specific location**
  - Endpoint: `GET /locations/{location_id}`
  - Description: Retrieve details of a specific location.
- **Delete a location**
  - Endpoint: `DELETE /locations/{location_id}`
  - Description: Delete a specific location.

### Business-Category Relationship

- **Add a category to a business**
  - Endpoint: `POST /businesses/{business_id}/categories`
  - Description: Associate a category with a specific business.
- **Remove a category from a business**
  - Endpoint: `DELETE /businesses/{business_id}/categories/{category_id}`
  - Description: Remove the association between a category and a business.

## Authentication and Authorization

Ensure that proper authentication and authorization mechanisms are implemented to secure the API endpoints. Only authorized users should be able to perform specific actions, and sensitive endpoints should be protected.

- **Update business details**
  - Endpoint: `PUT /businesses/{business_id}`
  - Description: Update the details of a specific business.
- **Delete a business**
  - Endpoint: `DELETE /businesses/{business_id}`
  - Description: Delete a specific business.

### Customers

- **Create a new customer**
  - Endpoint: `POST /customers`
  - Description: Create a new customer with the provided details.
- **Get a list of all customers**
  - Endpoint: `GET /customers`
  - Description: Retrieve a list of all customers.
- **Get details of a specific customer**
  - Endpoint: `GET /customers/{customer_id}`
  - Description: Retrieve details of a specific customer.
- **Update customer details**
  - Endpoint: `PUT /customers/{customer_id}`
  - Description: Update the details of a specific customer.
- **Delete a customer**
  - Endpoint: `DELETE /customers/{customer_id}`
  - Description: Delete a specific customer.

### Orders

- **Create a new order**
  - Endpoint: `POST /orders`
  - Description: Create a new order with the provided details.
- **Get a list of all orders**
  - Endpoint: `GET /orders`
  - Description: Retrieve a list of all orders.
- **Get details of a specific order**
  - Endpoint: `GET /orders/{order_id}`
  - Description: Retrieve details of a specific order.
- **Update order details**
  - Endpoint: `PUT /orders/{order_id}`
  - Description: Update the details of a specific order.
- **Delete an order**
  - Endpoint: `DELETE /orders/{order_id}`
  - Description: Delete a specific order.

### Locations

- **Create a new location**
  - Endpoint: `POST /locations`
  - Description: Create a new location with the provided details.
- **Get details of a specific location**
  - Endpoint: `GET /locations/{location_id}`
  - Description: Retrieve details of a specific location.
- **Delete a location**
  - Endpoint: `DELETE /locations/{location_id}`
  - Description: Delete a specific location.

### Business-Category Relationship

- **Add a category to a business**
  - Endpoint: `POST /businesses/{business_id}/categories`
  - Description: Associate a category with a specific business.
- **Remove a category from a business**
  - Endpoint: `DELETE /businesses/{business_id}/categories/{category_id}`
  - Description: Remove the association between a category and a business.

## Authentication and Authorization

Ensure that proper authentication and authorization mechanisms are implemented to secure the API endpoints. Only authorized users should be able to perform specific actions, and sensitive endpoints should be protected.

## Example Requests and Responses

Provide example requests and responses for each endpoint to help developers understand how to interact with the API effectively.

## Error Handling

Document error responses and error codes for different scenarios, and provide guidance on how to handle errors gracefully.

## Conclusion

In this document, we have outlined the API endpoints for our application, providing a clear and organized reference for developers who want to interact with our database tables. Please refer to this document when developing and testing your application's integration with our API.
