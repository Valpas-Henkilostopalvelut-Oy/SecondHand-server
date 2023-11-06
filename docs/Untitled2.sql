-- Create the Businesses table
CREATE TABLE Businesses (
    business_id UUID PRIMARY KEY,
    business_name VARCHAR(255) NOT NULL,
    business_website VARCHAR(255),
    business_description TEXT,
    business_logo VARCHAR(255),
    business_images VARCHAR(255) [],
    -- Другие столбцы, связанные с предприятиями
    customer_id UUID REFERENCES Customers(customer_id)
);
-- Create the Customers table
CREATE TABLE Customers (
    customer_id UUID PRIMARY KEY,
    customer_name VARCHAR(255) NOT NULL,
    customer_email VARCHAR(255),
    customer_phone VARCHAR(20),
    customer_password VARCHAR(255),
    customer_avatar VARCHAR(255) -- Другие столбцы, связанные с клиентами
);
-- Create the Orders table
CREATE TABLE Orders (
    order_id UUID PRIMARY KEY,
    customer_id UUID REFERENCES Customers(customer_id),
    business_id UUID REFERENCES Businesses(business_id),
    order_date TIMESTAMPTZ DEFAULT NOW(),
    order_status INT,
    order_total_price INT,
    order_total_quantity INT,
    order_payment_method INT -- Другие столбцы, связанные с заказами
);
-- Create the Locations table
CREATE TABLE Locations (
    location_id UUID PRIMARY KEY,
    location_name VARCHAR(255) NOT NULL,
    business_id UUID REFERENCES Businesses(business_id),
    driveto VARCHAR(255),
    iframe VARCHAR(255),
    zip_code INT,
    address VARCHAR(255),
    city VARCHAR(100),
    admin_name VARCHAR(100),
    country VARCHAR(100) -- Другие столбцы, связанные с местоположениями
);
-- Create the Categories table
CREATE TABLE Categories (
    category_id UUID PRIMARY KEY,
    category_name VARCHAR(255) NOT NULL,
    category_image VARCHAR(255) -- Другие столбцы, связанные с категориями
);
-- Create the Contacts table
CREATE TABLE Contacts (
    contact_id UUID PRIMARY KEY,
    business_id UUID REFERENCES Businesses(business_id),
    contact_name VARCHAR(255) NOT NULL,
    phone VARCHAR(20),
    email VARCHAR(255) -- Другие столбцы, связанные с контактами
);
-- Create the Ads table
CREATE TABLE Ads (
    ad_id UUID PRIMARY KEY,
    -- Другие столбцы, связанные с рекламой
    business_id UUID REFERENCES Businesses(business_id),
    ad_title VARCHAR(255),
    ad_image VARCHAR(255),
    ad_description TEXT,
    ad_price INT,
    ad_status INT
);
-- Create the Evaluations table
CREATE TABLE Evaluations (
    evaluation_id UUID PRIMARY KEY,
    evaluation_name VARCHAR(255) NOT NULL,
    evaluation_image VARCHAR(255) -- Другие столбцы, связанные с оценками
);
-- Create the Notes table
CREATE TABLE Notes (
    note_id UUID PRIMARY KEY,
    business_id UUID REFERENCES Businesses(business_id),
    customer_id UUID REFERENCES Customers(customer_id),
    note_text TEXT -- Другие столбцы, связанные с заметками
);
-- Create the Socials table
CREATE TABLE Socials (
    social_id UUID PRIMARY KEY,
    business_id UUID REFERENCES Businesses(business_id),
    facebook VARCHAR(255),
    twitter VARCHAR(255),
    instagram VARCHAR(255),
    youtube VARCHAR(255),
    tiktok VARCHAR(255) -- Другие столбцы, связанные с социальными данными
);
-- Create the Opentimes table
CREATE TABLE OpeningHours (
    opentimes_id UUID PRIMARY KEY,
    business_id UUID REFERENCES Businesses(business_id),
    day INT,
    open_time TIME,
    close_time TIME,
    is_closed BOOLEAN,
    type INT -- Другие столбцы, связанные с рабочим временем
);
-- Create the Images table
CREATE TABLE Images (
    image_id UUID PRIMARY KEY,
    image_originalname VARCHAR(255),
    image_filename VARCHAR(255),
    image_path VARCHAR(255) -- Другие столбцы, связанные с изображениями
);
-- Create the relationships between tables (many-to-many)
-- Create the BusinessCategory table
CREATE TABLE BusinessCategory (
    business_id UUID REFERENCES Businesses(business_id),
    category_id UUID REFERENCES Categories(category_id),
    PRIMARY KEY (business_id, category_id)
);