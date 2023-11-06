-- Create the Businesses table
CREATE TABLE Businesses (
    id UUID PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    website VARCHAR(255),
    description TEXT,
    logo VARCHAR(255),
    images VARCHAR(255) [],
    -- Другие столбцы, связанные с предприятиями
    customer UUID REFERENCES Customers(id)
);
-- Create the Customers table
CREATE TABLE Customers (
    id UUID PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    email VARCHAR(255),
    phone VARCHAR(20),
    password VARCHAR(255),
    avatar VARCHAR(255) -- Другие столбцы, связанные с клиентами
);
-- Create the Orders table
CREATE TABLE Orders (
    id UUID PRIMARY KEY,
    customer UUID REFERENCES Customers(id),
    business UUID REFERENCES Businesses(id),
    date TIMESTAMPTZ DEFAULT NOW(),
    status INT,
    total_price INT,
    total_quantity INT,
    payment_method INT -- Другие столбцы, связанные с заказами
);
-- Create the Locations table
CREATE TABLE Locations (
    id UUID PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    business UUID REFERENCES Businesses(id),
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
    id UUID PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    image VARCHAR(255) -- Другие столбцы, связанные с категориями
);
-- Create the Contacts table
CREATE TABLE Contacts (
    contact_id UUID PRIMARY KEY,
    business UUID REFERENCES Businesses(id),
    contact_name VARCHAR(255) NOT NULL,
    phone VARCHAR(20),
    email VARCHAR(255) -- Другие столбцы, связанные с контактами
);
-- Create the Ads table
CREATE TABLE Ads (
    id UUID PRIMARY KEY,
    -- Другие столбцы, связанные с рекламой
    title VARCHAR(255),
    image VARCHAR(255),
    description TEXT,
    price INT,
    status INT
);
-- Create the Evaluations table
CREATE TABLE Evaluations (
    id UUID PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    image VARCHAR(255) -- Другие столбцы, связанные с оценками
);
-- Create the Notes table
CREATE TABLE Notes (
    note_id UUID PRIMARY KEY,
    business UUID REFERENCES Businesses(id),
    customer UUID REFERENCES Customers(id),
    note_text TEXT -- Другие столбцы, связанные с заметками
);
-- Create the Socials table
CREATE TABLE Socials (
    business UUID REFERENCES Businesses(id),
    facebook VARCHAR(255),
    twitter VARCHAR(255),
    instagram VARCHAR(255),
    youtube VARCHAR(255),
    tiktok VARCHAR(255) -- Другие столбцы, связанные с социальными данными
);
-- Create the Opentimes table
CREATE TABLE OpeningHours (
    opentimes_id UUID PRIMARY KEY,
    business UUID REFERENCES Businesses(id),
    day INT,
    open_time TIME,
    close_time TIME,
    is_closed BOOLEAN,
    type INT -- Другие столбцы, связанные с рабочим временем
);
-- Create the Images table
CREATE TABLE Images (
    id UUID PRIMARY KEY,
    originalname VARCHAR(255),
    filename VARCHAR(255),
    path VARCHAR(255) -- Другие столбцы, связанные с изображениями
);
-- Create the relationships between tables (many-to-many)
-- Create the BusinessCategory table
CREATE TABLE BusinessCategory (
    business UUID REFERENCES Businesses(id),
    category UUID REFERENCES Categories(id),
    PRIMARY KEY (business, category)
);
-- Customer Roles and Permissions
CREATE TABLE CustomerRoles (
    role_id UUID PRIMARY KEY,
    role_name VARCHAR(50) NOT NULL,
    description TEXT
);
CREATE TABLE CustomerPermissions (
    permission_id UUID PRIMARY KEY,
    permission_name VARCHAR(50) NOT NULL,
    description TEXT
);
CREATE TABLE UserRoleMappings (
    mapping_id UUID PRIMARY KEY,
    user_id UUID REFERENCES Customers(id),
    role_id UUID REFERENCES CustomerRoles(role_id)
);
CREATE TABLE RolePermissionMappings (
    mapping_id UUID PRIMARY KEY,
    role_id UUID REFERENCES CustomerRoles(role_id),
    permission_id UUID REFERENCES CustomerPermissions(permission_id)
);