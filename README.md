### Endpoints

## Cart Endpoints
# Get Cart by ID
GET /api/Cart/{cartId}<br>
Retrieve the details of a cart by its ID.<br>
Parameters: cartId (integer, required)<br>
# Add to Cart
POST /api/Cart/AddToCart<br>
Add a product to the cart.<br>
# Remove from Cart
DELETE /api/Cart/RemoveFromCart<br>
Remove a product from the cart.<br>
## Category Endpoints
# Get Categories
GET /api/Category<br>
Retrieve all categories.<br>
## Product Endpoints
Get Products<br>
GET /api/Product<br>
Retrieve products, optionally filtered by category.<br>
Parameters: category (string, optional)<br>

## User Endpoints
# Get Users
GET /api/User<br>
Retrieve all users.<br>

# Sign In
POST /api/User/signin<br>
Authenticate a user.<br>

# Sign Up
POST /api/User/signup <br>
Register a new user.<br>
