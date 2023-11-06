-- Create the Businesses table
CREATE TABLE Businesses (
  business_id UUID PRIMARY KEY,
  business_name VARCHAR(255) NOT NULL,
  -- Add other business-related columns here
  customer_id INT REFERENCES Customers(customer_id),
  category_id UUID REFERENCES Categories(category_id),
  business_images UUID REFERENCES Images(image_id),
  business_website VARCHAR(255),
  business_description TEXT,
  business_logo VARCHAR(255)
);
-- Create the OpeningHours table (many-to-one)
CREATE TABLE OpeningHours (
  opening_hours_id UUID PRIMARY KEY,
  business_id UUID REFERENCES Businesses(business_id),
  -- Add other opening_hours-related columns here
  day INT,
  open_time TIME,
  close_time TIME,
  is_closed BOOLEAN,
  type int
);
-- Create  the social table
CREATE TABLE Social (
  business_id UUID REFERENCES Businesses(business_id) UNIQUE,
  facebook VARCHAR(255),
  twitter VARCHAR(255),
  instagram VARCHAR(255),
  youtube VARCHAR(255),
  tiktok VARCHAR(255),
  PRIMARY KEY (business_id)
);
-- Create the Customers table
CREATE TABLE Customers (
  customer_id UUID PRIMARY KEY,
  customer_name VARCHAR(255) NOT NULL,
  -- Add other customer-related columns here
  customer_email VARCHAR(255),
  customer_phone VARCHAR(20),
  customer_password VARCHAR(255),
  customer_role INT,
  customer_status INT,
  customer_token VARCHAR(255),
  customer_avatar VARCHAR(255)
);
-- Create the Orders table
CREATE TABLE Orders (
  order_id UUID PRIMARY KEY,
  customer_id UUID REFERENCES Customers(customer_id) -- Add other order-related columns here
);
-- Create the Locations table
CREATE TABLE Locations (
  location_id UUID PRIMARY KEY,
  location_name VARCHAR(255) NOT NULL,
  -- Add other location-related columns here
  business_id UUID REFERENCES Businesses(business_id),
  driveto VARCHAR(255),
  iframe VARCHAR(255),
  zip_code INT,
  address VARCHAR(255),
  city VARCHAR(100),
  admin_name VARCHAR(100),
  country VARCHAR(100)
);
-- Create the Categories table
CREATE TABLE Categories (
  category_id UUID PRIMARY KEY,
  category_name VARCHAR(255) NOT NULL,
  -- Add other category-related columns here
  created_at TIMESTAMPTZ DEFAULT NOW(),
  created_by UUID REFERENCES Customers(customer_id)
);
-- Create the Contacts table
CREATE TABLE Contacts (
  contact_id UUID PRIMARY KEY,
  contact_name VARCHAR(255) NOT NULL,
  -- Add other contact-related columns here
  business_id UUID REFERENCES Businesses(business_id),
  phone VARCHAR(20),
  email VARCHAR(255)
);
-- Create the Evaluations table
CREATE TABLE Evaluations (
  evaluation_id UUID PRIMARY KEY,
  -- Add other evaluation-related columns here
  evaluation_name VARCHAR(255) NOT NULL,
  email VARCHAR(255),
  phone VARCHAR(20),
  description TEXT,
  category_id UUID REFERENCES Categories(category_id),
  type INT
);
-- Create the Notes table
CREATE TABLE Notes (
  note_id UUID PRIMARY KEY,
  business_id UUID REFERENCES Businesses(business_id),
  customer_id UUID REFERENCES Customers(customer_id),
  -- Add other note-related columns here
  note_text TEXT
);
-- Create the Images table
CREATE TABLE Images (
  image_id UUID PRIMARY KEY,
  -- Add other image-related columns here
  image_originalname VARCHAR(255),
  image_filename VARCHAR(255),
  image_path VARCHAR(255)
);
-- Create the relationships between tables (many-to-many)
-- Business to Category (many-to-many)
CREATE TABLE BusinessCategory (
  business_id UUID REFERENCES Businesses(business_id),
  category_id UUID REFERENCES Categories(category_id),
  PRIMARY KEY (business_id, category_id)
);