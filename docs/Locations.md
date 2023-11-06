### Locations

- **Create a new location**
  - Endpoint: `POST /api/v1/locations`
  - Description: Create a new location with the provided details.
  - Permissions: Customer business owner or Admin role
  - Request: `POST /api/v1/locations`
  - Request Body
  ```json
  {
    "name": "New Location",
    "businessId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "driveto": "123 Main Street, City",
    "iframe": "<iframe src='https://maps.example.com/location'></iframe>",
    "zipCode": 12345,
    "address": "123 Main Street",
    "city": "City",
    "adminName": "John Doe",
    "country": "Country"
  }
  ```
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "name": "New Location",
    "businessId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "driveto": "123 Main Street, City",
    "iframe": "<iframe src='https://maps.example.com/location'></iframe>",
    "zipCode": 12345,
    "address": "123 Main Street",
    "city": "City",
    "adminName": "John Doe",
    "country": "Country"
  }
  ```
- **Get details of a specific location**
  - Endpoint: `GET /api/v1/locations/{location_id}`
  - Description: Retrieve details of a specific location.
  - Permissions: Customer business owner or Admin role
  - Request: `GET /api/v1/locations/{location_id}`
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "name": "New Location",
    "businessId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "driveto": "123 Main Street, City",
    "iframe": "<iframe src='https://maps.example.com/location'></iframe>",
    "zipCode": 12345,
    "address": "123 Main Street",
    "city": "City",
    "adminName": "John Doe",
    "country": "Country"
  }
  ```
- **Update location details**
  - Endpoint: `PUT /api/v1/locations/{location_id}`
  - Description: Update the details of a specific location.
  - Permissions: Customer business owner or Admin role
  - Request: `PUT /api/v1/locations/{location_id}`
  - Request Body
  ```json
  {
    "name": "New Location",
    "businessId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "driveto": "123 Main Street, City",
    "iframe": "<iframe src='https://maps.example.com/location'></iframe>",
    "zipCode": 12345,
    "address": "123 Main Street",
    "city": "City",
    "adminName": "John Doe",
    "country": "Country"
  }
  ```
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "name": "New Location",
    "businessId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "driveto": "123 Main Street, City",
    "iframe": "<iframe src='https://maps.example.com/location'></iframe>",
    "zipCode": 12345,
    "address": "123 Main Street",
    "city": "City",
    "adminName": "John Doe",
    "country": "Country"
  }
  ```
- **Delete a location**
  - Endpoint: `DELETE /api/v1/locations/{location_id}`
  - Description: Delete a specific location.
  - Permissions: Customer business owner or Admin role
  - Request: `DELETE /api/v1/locations/{location_id}`
  - Response Body (Example - Success)
  ```json
  {
    "id": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "name": "New Location",
    "businessId": "7a505a01-5d1f-4df0-9410-4bb56a8a971e",
    "driveto": "123 Main Street, City",
    "iframe": "<iframe src='https://maps.example.com/location'></iframe>",
    "zipCode": 12345,
    "address": "123 Main Street",
    "city": "City",
    "adminName": "John Doe",
    "country": "Country"
  }
  ```
