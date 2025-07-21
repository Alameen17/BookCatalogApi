# Book Catalog API

A simple RESTful API for managing a book catalog built with ASP.NET Core and Entity Framework Core.

## Features

- **CRUD Operations**: Create, Read, Update, and Delete books
- **In-Memory Database**: Uses Entity Framework Core with In-Memory database for development
- **Swagger Documentation**: Interactive API documentation and testing
- **Automatic Data Seeding**: Populates database with sample books on startup

## Technologies Used

- ASP.NET Core 6.0+
- Entity Framework Core
- In-Memory Database Provider
- Swagger/OpenAPI

## Getting Started

### Prerequisites

- .NET 6.0 SDK or later
- Visual Studio, VS Code, or any preferred IDE

### Installation

1. Clone the repository:
```bash
git clone https://github.com/yourusername/book-catalog-api.git
cd book-catalog-api
```

2. Restore NuGet packages:
```bash
dotnet restore
```

3. Install required Entity Framework In-Memory package:
```bash
dotnet add package Microsoft.EntityFrameworkCore.InMemory
```

4. Run the application:
```bash
dotnet run
```

5. The API will be available at:
   - HTTP: `http://localhost:5145`
   - Swagger UI: `http://localhost:5145/swagger`

## API Endpoints

### Books

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/Books` | Get all books |
| GET | `/Books/{id}` | Get a specific book by ID |
| POST | `/Books` | Create a new book |
| PUT | `/Books/{id}` | Update an existing book |
| DELETE | `/Books/{id}` | Delete a book |

### Book Model

```json
{
  "id": 1,
  "title": "string",
  "author": "string",
  "year": 0
}
```

## Usage Examples

### Get All Books
```bash
curl -X GET "http://localhost:5145/Books" -H "accept: application/json"
```

### Get Book by ID
```bash
curl -X GET "http://localhost:5145/Books/1" -H "accept: application/json"
```

### Create a New Book
```bash
curl -X POST "http://localhost:5145/Books" \
  -H "accept: application/json" \
  -H "Content-Type: application/json" \
  -d '{
    "title": "The Hobbit",
    "author": "J.R.R. Tolkien",
    "year": 1937
  }'
```

### Update a Book
```bash
curl -X PUT "http://localhost:5145/Books/1" \
  -H "accept: application/json" \
  -H "Content-Type: application/json" \
  -d '{
    "title": "Updated Title",
    "author": "Updated Author",
    "year": 2024
  }'
```

### Delete a Book
```bash
curl -X DELETE "http://localhost:5145/Books/1" -H "accept: application/json"
```

## Project Structure

```
BookCatalogApi/
├── Controllers/
│   └── BooksController.cs      # API endpoints
├── Data/
│   └── BookContext.cs          # Entity Framework context
├── Models/
│   └── Book.cs                 # Book model
├── Properties/
│   └── launchSettings.json     # Development settings
├── Program.cs                  # Application entry point
└── BookCatalogApi.csproj       # Project file
```

## Sample Data

The application automatically seeds the database with the following books on startup:
- The Great Gatsby by F. Scott Fitzgerald (1925)
- 1984 by George Orwell (1949)
- To Kill a Mockingbird by Harper Lee (1960)

## Development

### Running Tests
```bash
dotnet test
```

### Building for Production
```bash
dotnet publish -c Release
```

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

alameenadekunle029@gmail.com

Project Link: [https://github.com/yourusername/book-catalog-api](https://github.com/Alameen17/BookCatalogApi)
