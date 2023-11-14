Tables:

- Businesses (many categories, many locations, many contacts, many notes, one Social, many opentimes, many images)
- Auth
- Customers (many business, many orders, one image)
- Orders
- Locations
- Categories (many businesses, one image)
- Contacts
- Ads
- Eveluations (one image)
- Notes
- Socials
- Opentimes
- Images

### File structure

```plaintext
/SecondHand
|-- src
|   |-- SecondHand.Application
|   |   |-- Authentification
|   |   |   |-- AuthenticationHelper.cs
|   |   |   +-- AuthenticationService.cs
|   |   +-- Interfaces
|   |       +-- IAuthenticationService.cs
|   |-- SecondHand.Domain
|   |   |-- Entities
|   |   |   |-- BaseEntity.cs
|   |   |   |-- Customers.cs
|   |   |   |-- ... (other entities)
|   |   +-- Interfaces
|   |       +-- IRepository.cs
|   |       +-- IUnitOfWork.cs
|   |-- SecondHand.Infrastructure
|   |   |-- Data
|   |   |   |-- ApplicationDbContext.cs
|   |   |   +-- Repositories
|   |   |       +-- YourEntityRepository.cs
|   |   +-- Interfaces
|   |       +-- IYourEntityRepository.cs
|   |       +-- IUnitOfWork.cs
|   |   +-- YourEntityRepository.cs
|   +-- SecondHand.WebApi
|       |-- Controllers
|       |   |-- AuthController.cs
|       |   |-- YourEntityController.cs
|       +-- Startup.cs
|-- tests
|   |-- SecondHand.Tests
|       +-- YourEntityTests.cs
|-- SecondHand.sln
```

In this structure:

- `SecondHand.Application` contains application-specific logic, such as authentication services.
- `SecondHand.Domain` contains domain entities and interfaces defining repositories and unit of work.
- `SecondHand.Infrastructure` contains data-related implementations, such as database context, repositories, and unit of work.
- `SecondHand.WebApi` contains the web API controllers.
- `tests` directory holds your test projects.
