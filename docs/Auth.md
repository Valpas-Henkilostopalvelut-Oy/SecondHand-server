### Auth

- **Register a new user**
  - Endpoint: `POST /api/v1/auth/register`
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
  - Endpoint: `POST /api/v1/auth/login`
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
- **RefreshToken**
  - Endpoint: `POST /api/v1/auth/refresh-token`
  - Description: Refresh the token of the authenticated user.
- **User update password**
  - Endpoint: `POST /api/v1/auth/update-password`
  - Description: Update the password of the authenticated user.
  - Request body:
  ```json
  {
    "email": "john@mail.com",
    "oldPassword": "password123",
    "newPassword": "newpassword123"
  }
  ```
  - Response:
  ```json
  {
    "message": "Password updated successfully."
  }
  ```
- **Get user profile**
  - Endpoint: `GET /api/v1/auth/profile`
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
  - Endpoint: `PUT /api/v1/auth/profile`
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
  - Endpoint: `DELETE /api/v1/auth/profile`
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
