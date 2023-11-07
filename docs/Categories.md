### Categories

- **Create a new category**
  - Endpoint: `POST /categories`
  - Description: Create a new category with the provided details.
  - Permissions: Admin role
  - Request: `POST /categories`
  - Request Body
  ```json
  {
    "name": "Category 1",
    "description": "Category 1 description"
  }
  ```
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "name": "Category 1",
    "description": "Category 1 description"
  }
  ```
- **Get a list of all categories**
  - Endpoint: `GET /categories`
  - Description: Retrieve a list of all categories.
  - Permissions: All users
  - Request: GET /categories
  - Response Body (Example - Success)
  ```json
  [
    {
      "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
      "name": "Category 1",
      "description": "Category 1 description"
    },
    {
      "id": "d4e1b7c8-5f8a-4d7a-8e3c-a4b6e2f3c4d3",
      "name": "Category 2",
      "description": "Category 2 description"
    }
  ]
  ```
- **Get details of a specific category**
  - Endpoint: `GET /categories/{category_id}`
  - Description: Retrieve details of a specific category.
  - Permissions: All users
  - Request: GET /categories/{category_id}
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "name": "Category 1",
    "description": "Category 1 description"
  }
  ```
- **Get Businesses on category**
  - Endpoint: `GET /categories/{category_id}/businesses`
  - Description: Retrieve a list of all businesses on a specific category.
  - Permissions: All users
  - Request: GET /categories/{category_id}/businesses
  - Response Body (Example - Success)
  ```json
  [
    {
      "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
      "name": "Business 1",
      "description": "Business 1 description"
    },
    {
      "id": "d4e1b7c8-5f8a-4d7a-8e3c-a4b6e2f3c4d3",
      "name": "Business 2",
      "description": "Business 2 description"
    }
  ]
  ```
- **Set category image**
  - Endpoint: `POST /categories/{category_id}/image`
  - Description: Set the image of a specific category.
  - Permissions: Admin role
  - Request: POST /categories/{category_id}/image
  - Request Body
  ```json
  {
    "image": "base64 encoded image"
  }
  ```
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "image": "base64 encoded image"
  }
  ```
- **Set business to category**
  - Endpoint: `POST /categories/{category_id}/businesses/{business_id}`
  - Description: Set a business to a specific category.
  - Permissions: Admin role
  - Request: POST /categories/{category_id}/businesses/{business_id}
  - Response Body (Example - Success)
  ```json
  {
    "categoryId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "businessId": "d4e1b7c8-5f8a-4d7a-8e3c-a4b6e2f3c4d3"
  }
  ```
- **Update category details**
  - Endpoint: `PUT /categories/{category_id}`
  - Description: Update the details of a specific category.
  - Permissions: Admin role
  - Request: PUT /categories/{category_id}
  - Request Body
  ```json
  {
    "name": "Category 1",
    "description": "Category 1 description"
  }
  ```
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "name": "Category 1",
    "description": "Category 1 description"
  }
  ```
- **Delete a category**
  - Endpoint: `DELETE /categories/{category_id}`
  - Description: Delete a specific category.
  - Permissions: Admin role
  - Request: DELETE /categories/{category_id}
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "name": "Category 1",
    "description": "Category 1 description"
  }
  ```
