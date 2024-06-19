# Introduction
Below you will find detailed information about each endpoint available for interacting with categories, countries, owners, Pokemon, reviews, and reviewers.

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
