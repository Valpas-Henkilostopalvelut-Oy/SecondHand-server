### Customers

- **Create a new customer**
  - Endpoint: `POST /api/v1/customers`
  - Description: Admin can create user with temp password and email.
  - Request: `POST /api/v1/customers`
  - Request Body
  ```json
  {
    "name": "John Doe",
    "email": "johndoe@example.com",
    "phone": "+1 (123) 456-7890",
    "password": "temporaryPassword123",
    "avatar": "https://www.example.com/avatars/johndoe.png"
  }
  ```
- **Get a list of all customers**
  - Endpoint: `GET /api/v1/customers`
  - Description: Retrieve a list of all customers.
  - Request: GET /api/v1/customers
  - Response Body (Example - Success)
  ```json
  [
    {
      "id": "5a31406e-3e6f-4fcd-a5a3-5700fe76f1d5",
      "name": "John Doe",
      "email": "johndoe@example.com",
      "phone": "+1 (123) 456-7890",
      "avatar": "https://www.example.com/avatars/johndoe.png"
    },
    {
      "id": "f8c4a48b-8110-4e0a-a4ce-dc6d84757d4a",
      "name": "Jane Smith",
      "email": "janesmith@example.com",
      "phone": "+1 (987) 654-3210",
      "avatar": "https://www.example.com/avatars/janesmith.png"
    }
  ]
  ```
- **Get details of a specific customer**
  - Endpoint: `GET /api/v1/customers/{customer_id}`
  - Description: Retrieve details of a specific customer.
  - Request: GET /api/v1/customers/{customer_id}
  - Response Body (Example - Success)
  ```json
  {
    "id": "5a31406e-3e6f-4fcd-a5a3-5700fe76f1d5",
    "name": "John Doe",
    "email": "johndoe@example.com",
    "phone": "+1 (123) 456-7890",
    "avatar": "https://www.example.com/avatars/johndoe.png"
  }
  ```
- **Get Details of businesses owned by a specific customer**

  - Endpoint: GET /api/v1/customers/{customer_id}/businesses
  - Description: Retrieve the details of businesses owned by a specific customer.
  - Request: GET /api/v1/customers/{customer_id}/businesses
  - Response Body (Example - Success)

  ```json
  [
    {
      "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
      "name": "John's Cafe",
      "description": "A cozy cafe with a variety of coffee and pastries.",
      "website": "https://www.johnscafe.com",
      "logo": "https://www.johnscafe.com/logo.png",
      "images": [
        "https://www.johnscafe.com/image1.jpg",
        "https://www.johnscafe.com/image2.jpg"
      ],
      "createdAt": "2023-11-07T10:00:00Z",
      "lastModifiedAt": "2023-11-07T14:30:00Z",
      "isDeleted": false,
      "deletedAt": null,
      "createdBy": "a92e7b7c-1aa2-4d4f-bad5-244e9d169a1b",
      "lastModifiedBy": "b5e2b1d1-1c33-4e8a-af2d-8c8b3ec6c6cf",
      "deletedBy": null,
      "rowVersion": "AQAAAA==",
      "version": 2
    },
    {
      "id": "f8c4a48b-8110-4e0a-a4ce-dc6d84757d4a",
      "name": "Jane's Bookstore",
      "description": "A bookstore with a wide selection of books and magazines.",
      "website": "https://www.janesbookstore.com",
      "logo": "https://www.janesbookstore.com/logo.png",
      "images": [
        "https://www.janesbookstore.com/image1.jpg",
        "https://www.janesbookstore.com/image2.jpg"
      ],
      "createdAt": "2023-11-07T11:00:00Z",
      "lastModifiedAt": "2023-11-07T15:45:00Z",
      "isDeleted": false,
      "deletedAt": null,
      "createdBy": "c7b5e6a9-2d3f-4a0e-9f8c-5d1f4f3e6bf7",
      "lastModifiedBy": "d8e7f6c5-1f2e-4c8d-9b1a-3e4b6f5e6ba6",
      "deletedBy": null,
      "rowVersion": "BQAAAA==",
      "version": 3
    }
  ]
  ```

- **Get Notes of a specific customer**
  - Request: `GET /api/v1/customers/{customer_id}/notes`
  - Response Body (Example - Success)
  ```json
  [
    {
      "noteId": "3d7cf3e6-69bf-4d04-8f09-9505e98f0a8a",
      "noteText": "This is a customer note 1."
    },
    {
      "noteId": "6a9bd9f8-87ef-46bf-a05f-ced8fc8e7cb7",
      "noteText": "This is a customer note 2."
    }
  ]
  ```
- **Get Orders of a specific customer**
  - Request: `GET /api/v1/customers/{customer_id}/orders`
  - Response Body (Example - Success)
  ```json
  [
    {
      "orderId": "3d7cf3e6-69bf-4d04-8f09-9505e98f0a8a",
      "date": "2023-11-07T15:30:00Z",
      "status": "Processing",
      "totalPrice": 50.0,
      "totalQuantity": 2,
      "paymentMethod": "Credit Card"
    },
    {
      "orderId": "6a9bd9f8-87ef-46bf-a05f-ced8fc8e7cb7",
      "date": "2023-11-07T16:45:00Z",
      "status": "Delivered",
      "totalPrice": 75.5,
      "totalQuantity": 3,
      "paymentMethod": "PayPal"
    }
  ]
  ```
- **Update customer details**
  - Endpoint: `PUT /api/v1/customers/{customer_id}`
  - Description: Update the details of a specific customer.
  - Request: PUT /api/v1/customers/{customer_id}
  - Request Body
  ```json
  {
    "name": "Updated Customer Name",
    "email": "updatedemail@example.com",
    "phone": "+1 (987) 654-3210",
    "avatar": "https://www.example.com/avatars/updatedavatar.png"
  }
  ```
  - Response Body (Example - Success)
  ```json
  {
    "id": "5a31406e-3e6f-4fcd-a5a3-5700fe76f1d5",
    "name": "Updated Customer Name",
    "email": "updatedemail@example.com",
    "phone": "+1 (987) 654-3210",
    "avatar": "https://www.example.com/avatars/updatedavatar.png"
  }
  ```
- **Delete a customer**
  - Endpoint: `DELETE /api/v1/customers/{customer_id}`
  - Description: Delete a specific customer.
  - Request: DELETE /api/v1/customers/{customer_id}
  - Response Body (Example - Success)
  ```json
  {
    "message": "Customer with ID 5a31406e-3e6f-4fcd-a5a3-5700fe76f1d5 has been deleted successfully."
  }
  ```
