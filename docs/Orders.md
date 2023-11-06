### Orders

- **Create a new order**
  - Endpoint: `POST /api/v1/orders`
  - Description: Create a new order with the provided details.
  - Permissions: Admin role
  - Request: POST /api/v1/orders`
  - Request Body
  ```json
  {
    "customerId": "5a31406e-3e6f-4fcd-a5a3-5700fe76f1d5",
    "businessId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "date": "2023-11-07T14:30:00Z",
    "status": "Processing",
    "totalPrice": 50.0,
    "totalQuantity": 2,
    "paymentMethod": "Credit Card"
  }
  ```
- **Get a list of all orders**
  - Endpoint: `GET /api/v1/orders`
  - Description: Retrieve a list of all orders.
  - Permissions: Admin Role
  - Request: GET /api/v1/orders
  - Response Body (Example - Success)
  ```json
  [
    {
      "orderId": "3d7cf3e6-69bf-4d04-8f09-9505e98f0a8a",
      "customerId": "5a31406e-3e6f-4fcd-a5a3-5700fe76f1d5",
      "businessId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
      "date": "2023-11-07T15:30:00Z",
      "status": "Processing",
      "totalPrice": 50.0,
      "totalQuantity": 2,
      "paymentMethod": "Credit Card"
    },
    {
      "orderId": "6a9bd9f8-87ef-46bf-a05f-ced8fc8e7cb7",
      "customerId": "f8c4a48b-8110-4e0a-a4ce-dc6d84757d4a",
      "businessId": "d4e1b7c8-5f8a-4d7a-8e3c-a4b6e2f3c4d3",
      "date": "2023-11-07T16:45:00Z",
      "status": "Delivered",
      "totalPrice": 75.5,
      "totalQuantity": 3,
      "paymentMethod": "PayPal"
    }
  ]
  ```
- **Get details of a specific order**
  - Endpoint: `GET /api/v1/orders/{order_id}`
  - Description: Retrieve details of a specific order.
  - Permissions: Admin Role
  - Request: GET /api/v1/orders/{order_id}
  - Response Body (Example - Success)
  ```json
  {
    "orderId": "3d7cf3e6-69bf-4d04-8f09-9505e98f0a8a",
    "customerId": "5a31406e-3e6f-4fcd-a5a3-5700fe76f1d5",
    "businessId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "date": "2023-11-07T15:30:00Z",
    "status": "Processing",
    "totalPrice": 50.0,
    "totalQuantity": 2,
    "paymentMethod": "Credit Card"
  }
  ```
- **Update order details**
  - Endpoint: `PUT /api/v1/orders/{order_id}`
  - Description: Update the details of a specific order.
  - Permissions: Admin Role - Request: PUT /api/v1/orders/{order_id}
  - Request Body
  ```json
  {
    "status": "Shipped",
    "totalPrice": 60.0,
    "totalQuantity": 3
  }
  ```
  - Response Body (Example - Success)
  ```json
  {
    "orderId": "3d7cf3e6-69bf-4d04-8f09-9505e98f0a8a",
    "customerId": "5a31406e-3e6f-4fcd-a5a3-5700fe76f1d5",
    "businessId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "date": "2023-11-07T15:30:00Z",
    "status": "Shipped",
    "totalPrice": 60.0,
    "totalQuantity": 3,
    "paymentMethod": "Credit Card"
  }
  ```
- **Delete an order**
  - Endpoint: `DELETE /api/v1/orders/{order_id}`
  - Description: Delete a specific order.
  - Permissions: Admin Role
  - Request: DELETE /api/v1/orders/{order_id}
  - Response Body (Example - Success)
  ```json
  {
    "orderId": "3d7cf3e6-69bf-4d04-8f09-9505e98f0a8a",
    "customerId": "5a31406e-3e6f-4fcd-a5a3-5700fe76f1d5",
    "businessId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "date": "2023-11-07T15:30:00Z",
    "status": "Shipped",
    "totalPrice": 60.0,
    "totalQuantity": 3,
    "paymentMethod": "Credit Card"
  }
  ```
