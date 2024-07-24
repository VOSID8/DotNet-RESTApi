# Introduction
Below you will find detailed information about the Project with UML Diagram, Entities and Attributes along with each endpoint available for interacting with categories, countries, owners, Pokemon, reviews, and reviewers.

## UML Diagram
![UMLDiagram2](https://github.com/VOSID8/DotNet-RESTApi/assets/91724657/f2044f7c-3914-4fcf-9b72-ffd3d9119bbb)

## Entities and Attributes

### Pokémon
- `Id`: Unique identifier for each Pokémon.
- `Name`: Name of the Pokémon.
- `BirthDate`: Birthdate of the Pokémon.
- Relationships:
  - Has many `Reviews`.
  - Has many `PokemonOwners` (through a join table).
  - Belongs to many `Categories` (through a join table).

### Owner
- `Id`: Unique identifier for each owner.
- `Name`: Name of the owner.
- `Gym`: Gym associated with the owner.
- `Country`: The country to which the owner belongs.
- Relationships:
  - Has many `PokemonOwners` (through a join table).

### Country
- `Id`: Unique identifier for each country.
- `Name`: Name of the country.
- Relationships:
  - Has many `Owners`.

### Category
- `Id`: Unique identifier for each category.
- `Name`: Name of the category.
- Relationships:
  - Has many `PokemonCategories` (through a join table).

### Review
- `Id`: Unique identifier for each review.
- `Title`: Title of the review.
- `Text`: Text content of the review.
- `Reviewer`: The reviewer who wrote the review.
- `Pokemon`: The Pokémon being reviewed.
- Relationships:
  - Belongs to one `Reviewer`.
  - Belongs to one `Pokemon`.

### Reviewer
- `Id`: Unique identifier for each reviewer.
- `FirstName`: First name of the reviewer.
- `LastName`: Last name of the reviewer.
- Relationships:
  - Has many `Reviews`.

## Join Tables

### PokémonOwner
- `PokemonId`: References the `Id` of the `Pokemon` entity.
- `OwnerId`: References the `Id` of the `Owner` entity.
- Relationships:
  - Belongs to one `Pokemon`.
  - Belongs to one `Owner`.

### PokémonCategory
- `PokemonId`: References the `Id` of the `Pokemon` entity.
- `CategoryId`: References the `Id` of the `Category` entity.
- Relationships:
  - Belongs to one `Pokemon`.
  - Belongs to one `Category`.

## Relationships

- **Pokémon and Review**: One-to-many relationship, where one Pokémon can have multiple reviews.
- **Pokémon and Owner**: Many-to-many relationship through the `PokémonOwner` join table, where one Pokémon can belong to multiple owners and one owner can have multiple Pokémon.
- **Pokémon and Category**: Many-to-many relationship through the `PokémonCategory` join table, where one Pokémon can belong to multiple categories and one category can include multiple Pokémon.
- **Owner and Country**: Many-to-one relationship, where multiple owners can belong to one country.
- **Country and Owner**: One-to-many relationship, where one country can have multiple owners.
- **Reviewer and Review**: One-to-many relationship, where one reviewer can write multiple reviews.


# PokemonReviewApp API Documentation
## Category Endpoints
### Get All Categories
Endpoint: GET /api/Category
Description: Retrieve a list of all categories.
Response: JSON array of categories.
### Create a New Category
Endpoint: POST /api/Category
Description: Create a new category.
Request Body: JSON object representing the category.
Response: The created category object.
### Get Category by ID
Endpoint: GET /api/Category/{categoryId}
Description: Retrieve a specific category by its ID.
Response: JSON object representing the category.
### Update Category by ID
Endpoint: PUT /api/Category/{categoryId}
Description: Update a specific category by its ID.
Request Body: JSON object with updated category data.
Response: The updated category object.
### Delete Category by ID
Endpoint: DELETE /api/Category/{categoryId}
Description: Delete a specific category by its ID.
Response: Success message.
### Get Pokemon by Category ID
Endpoint: GET /api/Category/pokemon/{categoryId}
Description: Retrieve all Pokemon associated with a specific category ID.
Response: JSON array of Pokemon.
## Country Endpoints
Get All Countries
Endpoint: GET /api/Country
Description: Retrieve a list of all countries.
Response: JSON array of countries.
### Create a New Country
Endpoint: POST /api/Country
Description: Create a new country.
Request Body: JSON object representing the country.
Response: The created country object.
### Get Country by ID
Endpoint: GET /api/Country/{countryId}
Description: Retrieve a specific country by its ID.
Response: JSON object representing the country.
### Update Country by ID
Endpoint: PUT /api/Country/{countryId}
Description: Update a specific country by its ID.
Request Body: JSON object with updated country data.
Response: The updated country object.
### Delete Country by ID
Endpoint: DELETE /api/Country/{countryId}
Description: Delete a specific country by its ID.
Response: Success message.
### Get Owner by Country ID
Endpoint: GET /owners/{ownerId}
Description: Retrieve all owners associated with a specific country ID.
Response: JSON array of owners.
## Owner Endpoints
Get All Owners
Endpoint: GET /api/Owner
Description: Retrieve a list of all owners.
Response: JSON array of owners.
### Create a New Owner
Endpoint: POST /api/Owner
Description: Create a new owner.
Request Body: JSON object representing the owner.
Response: The created owner object.
### Get Owner by ID
Endpoint: GET /api/Owner/{ownerId}
Description: Retrieve a specific owner by their ID.
Response: JSON object representing the owner.
### Update Owner by ID
Endpoint: PUT /api/Owner/{ownerId}
Description: Update a specific owner by their ID.
Request Body: JSON object with updated owner data.
Response: The updated owner object.
### Delete Owner by ID
Endpoint: DELETE /api/Owner/{ownerId}
Description: Delete a specific owner by their ID.
Response: Success message.
### Get Pokemon by Owner ID
Endpoint: GET /api/Owner/{ownerId}/pokemon
Description: Retrieve all Pokemon associated with a specific owner ID.
Response: JSON array of Pokemon.
## Pokemon Endpoints
### Get All Pokemon
Endpoint: GET /api/Pokemon
Description: Retrieve a list of all Pokemon.
Response: JSON array of Pokemon.
### Get Pokemon by ID
Endpoint: GET /api/Pokemon/{pokeId}
Description: Retrieve a specific Pokemon by its ID.
Response: JSON object representing the Pokemon.
### Get Pokemon Rating by ID
Endpoint: GET /api/Pokemon/{pokeId}/rating
Description: Retrieve the rating of a specific Pokemon by its ID.
Response: JSON object with rating details.
## Review Endpoints
### Get All Reviews
Endpoint: GET /api/Review
Description: Retrieve a list of all reviews.
Response: JSON array of reviews.
### Create a New Review
Endpoint: POST /api/Review
Description: Create a new review.
Request Body: JSON object representing the review.
Response: The created review object.
### Get Review by ID
Endpoint: GET /api/Review/{reviewId}
Description: Retrieve a specific review by its ID.
Response: JSON object representing the review.
### Update Review by ID
Endpoint: PUT /api/Review/{reviewId}
Description: Update a specific review by its ID.
Request Body: JSON object with updated review data.
Response: The updated review object.
### Delete Review by ID
Endpoint: DELETE /api/Review/{reviewId}
Description: Delete a specific review by its ID.
Response: Success message.
### Get Reviews by Pokemon ID
Endpoint: GET /api/Review/pokemon/{pokeId}
Description: Retrieve all reviews for a specific Pokemon ID.
Response: JSON array of reviews.
### Delete Reviews by Reviewer ID
Endpoint: DELETE /DeleteReviewsByReviewer/{reviewerId}
Description: Delete all reviews by a specific reviewer ID.
Response: Success message.
## Reviewer Endpoints
### Get All Reviewers
Endpoint: GET /api/Reviewer
Description: Retrieve a list of all reviewers.
Response: JSON array of reviewers.
### Create a New Reviewer
Endpoint: POST /api/Reviewer
Description: Create a new reviewer.
Request Body: JSON object representing the reviewer.
Response: The created reviewer object.
### Get Reviewer by ID
Endpoint: GET /api/Reviewer/{reviewerId}
Description: Retrieve a specific reviewer by their ID.
Response: JSON object representing the reviewer.
### Update Reviewer by ID
Endpoint: PUT /api/Reviewer/{reviewerId}
Description: Update a specific reviewer by their ID.
Request Body: JSON object with updated reviewer data.
Response: The updated reviewer object.
### Delete Reviewer by ID
Endpoint: DELETE /api/Reviewer/{reviewerId}
Description: Delete a specific reviewer by their ID.
Response: Success message.
### Get Reviews by Reviewer ID
Endpoint: GET /api/Reviewer/{reviewerId}/reviews
Description: Retrieve all reviews made by a specific reviewer ID.
Response: JSON array of reviews.
