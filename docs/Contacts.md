### Contacts

- **Create a new contact**

  - Endpoint: `POST /contacts`
  - Description: Create a new contact with the provided details.
  - Permissions: Admin role
  - Request: `POST /contacts`
  - Request Body

  ```json
  {
    "contactName": "John Doe",
    "phone": "123-456-7890",
    "email": "john@example.com"
  }
  ```

  - Response (Example - Success)

  ```json
  {
    "id": "3d7cf3e6-69bf-4d04-8f09-9505e98f0a8a",
    "contactName": "John Doe",
    "phone": "123-456-7890",
    "email": "john@example.com"
  }
  ```

- **Get a list of all contacts**

  - Endpoint: `GET /contacts`
  - Description: Retrieve a list of all contacts.
  - Permissions: Admin role
  - Request: GET /contacts
  - Response (Example - Success)

  ```json
  [
    {
      "id": "3d7cf3e6-69bf-4d04-8f09-9505e98f0a8a",
      "contactName": "John Doe",
      "phone": "123-456-7890",
      "email": "john@example.com"
    },
    {
      "id": "9a4c71e7-1927-4f49-9a33-16c6eaa214c0",
      "contactName": "Jane Smith",
      "phone": "987-654-3210",
      "email": "jane@example.com"
    }
  ]
  ```

- **Get details of a specific contact**

  - Endpoint: `GET /contacts/{contact_id}`
  - Description: Retrieve details of a specific contact.
  - Permissions: Admin role
  - Request: GET /contacts/{contact_id}
  - Response (Example - Success)

  ```json
  {
    "id": "3d7cf3e6-69bf-4d04-8f09-9505e98f0a8a",
    "contactName": "John Doe",
    "phone": "123-456-7890",
    "email": "john@example.com"
  }
  ```

- **Update contact details**

  - Endpoint: `PUT /contacts/{contact_id}`
  - Description: Update the details of a specific contact.
  - Permissions: Admin role
  - Request: PUT /contacts/{contact_id}
  - Request Body

  ```json
  {
    "contactName": "Updated Name",
    "phone": "987-654-3210",
    "email": "updated@example.com"
  }
  ```

  - Response (Example - Success)

  ```json
  {
    "id": "3d7cf3e6-69bf-4d04-8f09-9505e98f0a8a",
    "contactName": "Updated Name",
    "phone": "987-654-3210",
    "email": "updated@example.com"
  }
  ```

- **Delete a contact**

  - Endpoint: `DELETE /contacts/{contact_id}`
  - Description: Delete a specific contact.
  - Permissions: Admin role
  - Request: DELETE /contacts/{contact_id}
  - Response (Example - Success)

  ```json
  {
    "id": "3d7cf3e6-69bf-4d04-8f09-9505e98f0a8a",
    "contactName": "Updated Name",
    "phone": "987-654-3210",
    "email": "updated@example.com"
  }
  ```

### Business Contacts

- **Create a new contact for a business**

  - Endpoint: `POST /businesses/{business_id}/contacts`
  - Description: Create a new contact associated with a specific business.
  - Permissions: Owner of the business
  - Request: `POST /businesses/{business_id}/contacts`

  ```json
  {
    "contactName": "John Doe",
    "phone": "123-456-7890",
    "email": "john@example.com"
  }
  ```

  - Response (Example - Success)

  ```json
  {
    "id": "3d7cf3e6-69bf-4d04-8f09-9505e98f0a8a",
    "contactName": "John Doe",
    "phone": "123-456-7890",
    "email": "john@example.com",
    "businessId": "business_id"
  }
  ```

- **Get contacts of a specific business**

  - Endpoint: `GET /businesses/{business_id}/contacts`
  - Description: Retrieve the contacts associated with a specific business.

- **Get details of a specific contact of a business**

  - Endpoint: `GET /businesses/{business_id}/contacts/{contact_id}`
  - Description: Retrieve details of a specific contact associated with a specific business.

- **Update contact details of a business**

  - Endpoint: `PUT /businesses/{business_id}/contacts/{contact_id}`
  - Description: Update the details of a specific contact associated with a specific business.

- **Delete a contact of a business**
  - Endpoint: `DELETE /businesses/{business_id}/contacts/{contact_id}`
  - Description: Delete a specific contact associated with a specific business.
```
