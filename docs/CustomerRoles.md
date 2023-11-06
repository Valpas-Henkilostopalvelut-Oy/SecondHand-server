### CustomerRoles

- **Create a new customer role**
  - Endpoint: `POST /api/v1/customer-roles`
  - Description: Create a new customer role with the provided details.
  - Permissions: Admin role
  - Request: `POST /api/v1/customer-roles`
  - Request Body
  ```json
  {
    "name": "Customer",
    "description": "Customer role"
  }
  ```
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "name": "Customer",
    "description": "Customer role"
  }
  ```
- **Get a list of all customer roles**
  - Endpoint: `GET /api/v1/customer-roles`
  - Description: Retrieve a list of all customer roles.
  - Permissions: Admin role
  - Request: GET /api/v1/customer-roles
  - Response Body (Example - Success)
  ```json
  [
    {
      "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
      "name": "Customer",
      "description": "Customer role"
    },
    {
      "id": "d4e1b7c8-5f8a-4d7a-8e3c-a4b6e2f3c4d3",
      "name": "Admin",
      "description": "Admin role"
    }
  ]
  ```
- **Get details of a specific customer role**
  - Endpoint: `GET /api/v1/customer-roles/{role_id}`
  - Description: Retrieve details of a specific customer role.
  - Permissions: Admin role
  - Request: GET /api/v1/customer-roles/{role_id}
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "name": "Customer",
    "description": "Customer role"
  }
  ```
- **Update customer role details**
  - Endpoint: `PUT /api/v1/customer-roles/{role_id}`
  - Description: Update the details of a specific customer role.
  - Permissions: Admin role
  - Request: PUT /api/v1/customer-roles/{role_id}
  - Request Body
  ```json
  {
    "name": "Customer",
    "description": "Customer role"
  }
  ```
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "name": "Customer",
    "description": "Customer role"
  }
  ```
- **Delete a customer role**
  - Endpoint: `DELETE /api/v1/customer-roles/{role_id}`
  - Description: Delete a specific customer role.
  - Permissions: Admin role
  - Request: DELETE /api/v1/customer-roles/{role_id}
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "name": "Customer",
    "description": "Customer role"
  }
  ```

### CustomerRoleMappings

- **Assign a role to a customer**
  - Endpoint: `POST /api/v1/customer-roles/assign`
  - Description: Assign a customer role to a specific customer.
  - Permissions: Admin role
  - Request: `POST /api/v1/customer-roles/assign`
  - Request Body
  ```json
  {
    "customerId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "roleId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e"
  }
  ```
  - Response Body (Example - Success)
  ```json
  {
    "customerId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "roleId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e"
  }
  ```
- **Get roles of a specific customer**
  - Endpoint: `GET /api/v1/customers/{customer_id}/customer-roles`
  - Description: Retrieve the roles assigned to a specific customer.
  - Permissions: Admin role
  - Request: GET /api/v1/customers/{customer_id}/customer-roles
  - Response Body (Example - Success)
  ```json
  [
    {
      "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
      "name": "Customer",
      "description": "Customer role"
    },
    {
      "id": "d4e1b7c8-5f8a-4d7a-8e3c-a4b6e2f3c4d3",
      "name": "Admin",
      "description": "Admin role"
    }
  ]
  ```
- **Revoke a role from a customer**
  - Endpoint: `DELETE /api/v1/customer-roles/revoke`
  - Description: Revoke a customer role from a specific customer.
  - Permissions: Admin role
  - Request: DELETE /api/v1/customer-roles/revoke
  - Request Body
  ```json
  {
    "customerId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "roleId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e"
  }
  ```
  - Response Body (Example - Success)
  ```json
  {
    "customerId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "roleId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e"
  }
  ```

### CustomerPermissions

- **Create a new customer permission**
  - Endpoint: `POST /api/v1/customer-permissions`
  - Description: Create a new customer permission with the provided details.
  - Permissions: Admin role
  - Request: `POST /api/v1/customer-permissions`
  - Request Body
  ```json
  {
    "name": "Create Customer",
    "description": "Create a new customer"
  }
  ```
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "name": "Create Customer",
    "description": "Create a new customer"
  }
  ```
- **Get a list of all customer permissions**
  - Endpoint: `GET /api/v1/customer-permissions`
  - Description: Retrieve a list of all customer permissions.
  - Permissions: Admin role
  - Request: GET /api/v1/customer-permissions
  - Response Body (Example - Success)
  ```json
  [
    {
      "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
      "name": "Create Customer",
      "description": "Create a new customer"
    },
    {
      "id": "d4e1b7c8-5f8a-4d7a-8e3c-a4b6e2f3c4d3",
      "name": "Update Customer",
      "description": "Update an existing customer"
    }
  ]
  ```
- **Get details of a specific customer permission**
  - Endpoint: `GET /api/v1/customer-permissions/{permission_id}`
  - Description: Retrieve details of a specific customer permission.
  - Permissions: Admin role
  - Request: GET /api/v1/customer-permissions/{permission_id}
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "name": "Create Customer",
    "description": "Create a new customer"
  }
  ```
- **Update customer permission details**
  - Endpoint: `PUT /api/v1/customer-permissions/{permission_id}`
  - Description: Update the details of a specific customer permission.
  - Permissions: Admin role
  - Request: PUT /api/v1/customer-permissions/{permission_id}
  - Request Body
  ```json
  {
    "name": "Create Customer",
    "description": "Create a new customer"
  }
  ```
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "name": "Create Customer",
    "description": "Create a new customer"
  }
  ```
- **Delete a customer permission**
  - Endpoint: `DELETE /api/v1/customer-permissions/{permission_id}`
  - Description: Delete a specific customer permission.
  - Permissions: Admin role
  - Request: DELETE /api/v1/customer-permissions/{permission_id}
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "name": "Create Customer",
    "description": "Create a new customer"
  }
  ```

### RolePermissionMappings

- **Assign a permission to a role**
  - Endpoint: `POST /api/v1/customer-roles/permissions/assign`
  - Description: Assign a customer permission to a specific customer role.
  - Permissions: Admin role
  - Request: `POST /api/v1/customer-roles/permissions/assign`
  - Request Body
  ```json
  {
    "roleId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "permissionId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e"
  }
  ```
  - Response Body (Example - Success)
  ```json
  {
    "roleId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "permissionId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e"
  }
  ```
- **Get permissions of a specific role**
  - Endpoint: `GET /api/v1/customer-roles/{role_id}/permissions`
  - Description: Retrieve the permissions assigned to a specific customer role.
  - Permissions: Admin role
  - Request: GET /api/v1/customer-roles/{role_id}/permissions
  - Response Body (Example - Success)
  ```json
  [
    {
      "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
      "name": "Create Customer",
      "description": "Create a new customer"
    },
    {
      "id": "d4e1b7c8-5f8a-4d7a-8e3c-a4b6e2f3c4d3",
      "name": "Update Customer",
      "description": "Update an existing customer"
    }
  ]
  ```
- **Revoke a permission from a role**
  - Endpoint: `DELETE /api/v1/customer-roles/permissions/revoke`
  - Description: Revoke a customer permission from a specific customer role.
  - Permissions: Admin role
  - Request: DELETE /api/v1/customer-roles/permissions/revoke
  - Request Body
  ```json
  {
    "roleId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "permissionId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e"
  }
  ```
  - Response Body (Example - Success)
  ```json
  {
    "roleId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "permissionId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e"
  }
  ```
