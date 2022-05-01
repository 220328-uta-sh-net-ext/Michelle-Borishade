
    CREATE TABLE Restaurants (
        RestaurantID int PRIMARY KEY,
        RestaurantName varchar(255),
        RestaurantAddress varchar(255),
        RestaurantCity varchar(255),
        RestaurantState varchar(255),
        RestaurantZipCode varchar(255),
        RestaurantCountry varchar(255),
        RestaurantWebsite varchar(255),
        RestaurantEmail varchar(255)
);
SELECT* FROM Restaurants
ALTER TABLE Restaurants
ADD RestaurantPhoneNumber varchar(255);

CREATE TABLE Users (
        UserID int PRIMARY KEY,
        UserFirstName varchar(255),
        UserLastName varchar(255),
        UserAddress varchar(255),
        UserCity varchar(255),
        UserState varchar(255),
        UserZipCode varchar(255),
        UserPhoneNumber varchar(255),
        UserCountry varchar(255),
        UserWebsite varchar(255),
        UserEmail varchar(255),
        UserFacebookName varchar(255)
);
SELECT* FROM Users
ALTER TABLE Users
ADD UserAccess varchar(255);
);

CREATE TABLE Reviews (
    ReviewID int PRIMARY KEY,
    RestaurantID int FOREIGN KEY REFERENCES Restaurants(RestaurantID),
    UserID int FOREIGN KEY REFERENCES Users(UserID),
    AtmoshereScore int, 
    ServiceScore int,
    QualityScore int,
    OverallScore int
);

