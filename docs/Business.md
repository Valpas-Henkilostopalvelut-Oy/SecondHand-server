### Businesses

- **Create a new business**
  - Endpoint: `POST /api/v1/businesses`
  - Description: Create a new business with the provided details.
  - Permissions: Authenticated user
  - Request: `POST /api/v1/businesses`
  - Request Body
  ```json
  {
    "customerId": "5a31406e-3e6f-4fcd-a5a3-5700fe76f1d5",
    "name": "Sample Business",
    "description": "This is a sample business.",
    "websiteUrl": "https://www.samplebusiness.com",
    "logoUrl": "https://www.samplebusiness.com/logo.png",
    "images": [
      "https://www.samplebusiness.com/image1.jpg",
      "https://www.samplebusiness.com/image2.jpg"
    ]
  }
  ```
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "customerId": "5a31406e-3e6f-4fcd-a5a3-5700fe76f1d5",
    "name": "Sample Business",
    "description": "This is a sample business.",
    "websiteUrl": "https://www.samplebusiness.com",
    "logoUrl": "https://www.samplebusiness.com/logo.png",
    "images": [
      "https://www.samplebusiness.com/image1.jpg",
      "https://www.samplebusiness.com/image2.jpg"
    ],
    "createdAt": "2023-11-07T10:00:00Z",
    "lastModifiedAt": null,
    "isDeleted": false,
    "deletedAt": null,
    "createdBy": "a92e7b7c-1aa2-4d4f-bad5-244e9d169a1b",
    "lastModifiedBy": null,
    "deletedBy": null,
    "rowVersion": "AQAAAA==",
    "version": 1
  }
  ```
- **Get a list of all businesses**
  - Endpoint: `GET /api/v1/businesses`
  - Description: Retrieve a list of all businesses.
  - Permissions: Anonymous user, Authenticated user
  - Response Body (Example - Success)
  ```json
  [
    {
      "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
      "customerId": "5a31406e-3e6f-4fcd-a5a3-5700fe76f1d5",
      "name": "Sample Business",
      "description": "This is a sample business.",
      "websiteUrl": "https://www.samplebusiness.com",
      "logoUrl": "https://www.samplebusiness.com/logo.png",
      "images": [
        "https://www.samplebusiness.com/image1.jpg",
        "https://www.samplebusiness.com/image2.jpg"
      ],
      "createdAt": "2023-11-07T10:00:00Z",
      "lastModifiedAt": null,
      "isDeleted": false,
      "deletedAt": null,
      "createdBy": "a92e7b7c-1aa2-4d4f-bad5-244e9d169a1b",
      "lastModifiedBy": null,
      "deletedBy": null,
      "rowVersion": "AQAAAA==",
      "version": 1
    }
    /api/v1// Additional business objects...
  ]
  ```
- **Get details of a specific business**
  - Endpoint: `GET /api/v1/businesses/{business_id}`
  - Description: Retrieve details of a specific business.
  - Permissions: Anonymous user, Authenticated user
  - Request: `GET /api/v1/businesses/{business_id}`
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "customerId": "5a31406e-3e6f-4fcd-a5a3-5700fe76f1d5",
    "name": "Sample Business",
    "description": "This is a sample business.",
    "websiteUrl": "https://www.samplebusiness.com",
    "logoUrl": "https://www.samplebusiness.com/logo.png",
    "images": [
      "https://www.samplebusiness.com/image1.jpg",
      "https://www.samplebusiness.com/image2.jpg"
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
  }
  ```
- **Retrieve opening hours of a specific business**
  - Endpoint: `GET /api/v1/businesses/{business_id}/openinghours`
  - Description: Retrieve the opening hours of a specific business.
  - Permissions: Anonymous user, Authenticated user
  - Request: `GET /api/v1/businesses/{business_id}/openinghours`
  - Response Body (Example - Success)
  ```json
  {
    "businessId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "openingHours": [
      {
        "dayOfWeek": "Monday",
        "openTime": "09:00 AM",
        "closeTime": "05:00 PM",
        "isClosed": false
      },
      {
        "dayOfWeek": "Tuesday",
        "openTime": "09:00 AM",
        "closeTime": "05:00 PM",
        "isClosed": false
      },
      {
        "dayOfWeek": "Wednesday",
        "openTime": "09:00 AM",
        "closeTime": "05:00 PM",
        "isClosed": false
      },
      {
        "dayOfWeek": "Thursday",
        "openTime": "09:00 AM",
        "closeTime": "05:00 PM",
        "isClosed": false
      },
      {
        "dayOfWeek": "Friday",
        "openTime": "09:00 AM",
        "closeTime": "05:00 PM",
        "isClosed": false
      },
      {
        "dayOfWeek": "Saturday",
        "openTime": "09:00 AM",
        "closeTime": "12:00 PM",
        "isClosed": false
      },
      {
        "dayOfWeek": "Sunday",
        "openTime": "Closed",
        "closeTime": "Closed",
        "isClosed": true
      }
    ]
  }
  ```
- **Retrieve contacts of a specific business**
  - Endpoint: `GET /api/v1/businesses/{business_id}/contacts`
  - Description: Retrieve the contacts of a specific business.
  - Permissions: Anonymous user, Authenticated user
  - Request: `GET /api/v1/businesses/{business_id}/contacts``
  - Response Body (Example - Success)
  ```json
  {
    "businessId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "contacts": [
      {
        "contactId": "fae5a02a-6c2b-4e10-a96c-194b9a6d841e",
        "contactName": "John Doe",
        "phone": "+1 (123) 456-7890",
        "email": "johndoe@example.com"
      },
      {
        "contactId": "82c5e11f-76e2-491c-b85d-c98d2d3f6b26",
        "contactName": "Jane Smith",
        "phone": "+1 (987) 654-3210",
        "email": "janesmith@example.com"
      }
    ]
  }
  ```
- **Retrieve locations of a specific business**
  - Endpoint: `GET /api/v1/businesses/{business_id}/locations`
  - Description: Retrieve the locations of a specific business.
  - Permissions: Anonymous user, Authenticated user
  - Request: `GET /api/v1/businesses/{business_id}/locations``
  - Response Body (Example - Success)
  ```json
  {
    "businessId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "locations": [
      {
        "locationId": "ecf1a26b-2d7d-4bfe-8c5e-1c235a53e485",
        "name": "Main Office",
        "driveTo": "123 Main St, City, Country",
        "iframe": "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3...",
        "zipCode": 12345,
        "address": "123 Main St",
        "city": "City",
        "adminName": "John Smith",
        "country": "Country"
      },
      {
        "locationId": "1cb78ac2-0a2a-4db9-9646-8c3f22ebfca7",
        "name": "Branch Office",
        "driveTo": "456 Branch St, City, Country",
        "iframe": "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3...",
        "zipCode": 54321,
        "address": "456 Branch St",
        "city": "City",
        "adminName": "Jane Doe",
        "country": "Country"
      }
    ]
  }
  ```
- **Retrieve categories of a specific business**
  - Endpoint: `GET /api/v1/businesses/{business_id}/categories`
  - Description: Retrieve the categories associated with a specific business.
  - Permissions: Anonymous user, Authenticated user
  - Request: GET /api/v1/businesses/{business_id}/categories
  - Response Body (Example - Success)
  ```json
  {
    "businessId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "categories": [
      {
        "categoryId": "1a5c8d89-fab3-4814-94a8-7d1875d0c9f3",
        "name": "Restaurant",
        "image": "https://www.example.com/images/restaurant.png"
      },
      {
        "categoryId": "b2e3c9f4-7dc6-42e9-8a71-9e1d8ac96bb8",
        "name": "Cafe",
        "image": "https://www.example.com/images/cafe.png"
      }
    ]
  }
  ```
- **Retrieve orders of a specific business**
  - Endpoint: `GET /api/v1/businesses/{business_id}/orders`
  - Description: Retrieve the orders associated with a specific business.
  - Permissions: Customer business owner or Admin role
  - Request: `GET /api/v1/businesses/{business_id}/orders``
  - Response Body (Example - Success)
  ```json
  {
    "businessId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "orders": [
      {
        "orderId": "3d7cf3e6-69bf-4d04-8f09-9505e98f0a8a",
        "customerId": "5a31406e-3e6f-4fcd-a5a3-5700fe76f1d5",
        "orderDate": "2023-11-07T15:30:00Z",
        "status": "Processing",
        "totalPrice": 50.0,
        "totalQuantity": 2,
        "paymentMethod": "Credit Card"
      },
      {
        "orderId": "6a9bd9f8-87ef-46bf-a05f-ced8fc8e7cb7",
        "customerId": "f8c4a48b-8110-4e0a-a4ce-dc6d84757d4a",
        "orderDate": "2023-11-07T16:45:00Z",
        "status": "Delivered",
        "totalPrice": 75.5,
        "totalQuantity": 3,
        "paymentMethod": "PayPal"
      }
    ]
  }
  ```
- **Set business to category**
  - Endpoint: `POST /api/v1/businesses/{business_id}/categories/{category_id}`
  - Description: Set a business to a specific category.
  - Permissions: Admin role
  - Request: `POST /api/v1/businesses/{business_id}/categories/{category_id}`
  - Response Body (Example - Success)
  ```json
  {
    "businessId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "categoryId": "1a5c8d89-fab3-4814-94a8-7d1875d0c9f3"
  }
  ```
- **Update business details**
  - Endpoint: `PUT /api/v1/businesses/{business_id}`
  - Description: Update the details of a specific business.
  - Permissions: Customer business owner or Admin role
  - Request: PUT /api/v1/businesses/{business_id}
  - Request Body
  ```json
  {
    "name": "Updated Business Name",
    "description": "This is the updated description of the business.",
    "websiteUrl": "https://www.updatedbusiness.com",
    "logoUrl": "https://www.updatedbusiness.com/logo.png",
    "images": [
      "https://www.updatedbusiness.com/image1.jpg",
      "https://www.updatedbusiness.com/image2.jpg"
    ]
  }
  ```
  - Response Body (Example - Success)

  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "customerId": "5a31406e-3e6f-4fcd-a5a3-5700fe76f1d5",
    "name": "Updated Business Name",
    "description": "This is the updated description of the business.",
    "websiteUrl": "https://www.updatedbusiness.com",
    "logoUrl": "https://www.updatedbusiness.com/logo.png",
    "images": [
      "https://www.updatedbusiness.com/image1.jpg",
      "https://www.updatedbusiness.com/image2.jpg"
    ],
    "createdAt": "2023-11-07T10:00:00Z",
    "lastModifiedAt": "2023-11-07T17:30:00Z",
    "isDeleted": false,
    "deletedAt": null,
    "createdBy": "a92e7b7c-1aa2-4d4f-bad5-244e9d169a1b",
    "lastModifiedBy": "b5e2b1d1-1c33-4e8a-af2d-8c8b3ec6c6cf",
    "deletedBy": null,
    "rowVersion": "AQAAAA==",
    "version": 3
  }
  ```
- **Delete a business**
  - Endpoint: `DELETE /api/v1/businesses/{business_id}`
  - Description: Delete a specific business.
  - Permissions: Customer business owner or Admin role
  - Request: `DELETE /api/v1/businesses/{business_id}`
  - Response Body (Example - Success)
  ```json
  {
    "message": "Business with ID 7a505a01-5d1f-4df0-9410-4bb56a8a971e has been deleted successfully."
  }
  ```
