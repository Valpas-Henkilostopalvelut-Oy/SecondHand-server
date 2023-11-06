### Auth

- **Register a new user**
  - Endpoint: `POST /auth/register`
  - Description: Register a new user with the provided details.
  - Request body:
  ```json
  {
    "name": "John Doe",
    "email": "johndoe@example.com",
    "password": "password123"
  }
  ```
  - Response:
  ```json
  {
    "id": 123,
    "name": "John Doe",
    "email": "johndoe@example.com"
  }
  ```
- **Login**
  - Endpoint: `POST /auth/login`
  - Description: Authenticate a user and generate a token for subsequent requests.
  - Request body:
  ```json
  {
    "email": "user@example.com",
    "password": "password123"
  }
  ```
  - Response:
  ```json
  {
    "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c"
  }
  ```
- **Get user profile**
  - Endpoint: `GET /auth/profile`
  - Description: Retrieve the profile of the authenticated user.
  - Request headers:
  ```json
  {
    "Authorization": "Bearer <token>"
  }
  ```
  - Response:
  ```json
  {
    "id": 123,
    "name": "John Doe",
    "email": "johndoe@example.com"
  }
  ```
- **Update user profile**
  - Endpoint: `PUT /auth/profile`
  - Description: Update the profile of the authenticated user.
  - Request headers:
  ```json
  {
    "Authorization": "Bearer <token>"
  }
  ```
  - Request body:
  ```json
  {
    "name": "Jane Doe",
    "email": "janedoe@example.com"
  }
  ```
  - Response:
  ```json
  {
    "id": 123,
    "name": "Jane Doe",
    "email": "janedoe@example.com"
  }
  ```
- **Delete user profile**
  - Endpoint: `DELETE /auth/profile`
  - Description: Delete the profile of the authenticated user.
  - Request headers:
  ```json
  {
    "Authorization": "Bearer <token>"
  }
  ```
  - Response:
  ```json
  {
    "message": "User profile deleted successfully."
  }
  ```
