create database BerserkerDb;
Use BerserkerDb;

CREATE TABLE `Users`(
    Id varchar(50),
    FirstName varchar(20),
	SecondName varchar(20),
    PhoneNumber varchar(14),
    Address varchar(20),
    Email varchar(20),
    Password varchar(20),
    Role_Id varchar(50),
    Cart_Id varchar(50),
    PRIMARY KEY(Id),
    FOREIGN KEY (Role_Id) REFERENCES Roles(Id),
	FOREIGN KEY (Cart_Id) REFERENCES Carts(Id)
);

CREATE TABLE `Roles`(
    Id varchar(50),
    Role_name varchar(20),
    PRIMARY KEY(Id)
);

CREATE TABLE `Carts`(
    Id varchar(50),
    PRIMARY KEY(Id)
);

CREATE TABLE `Product_To_Cart`(
    Cart_Id varchar(50),
    Part_Id varchar(50),
    Quantity int
);

CREATE TABLE `Requests`(
    Id varchar(50),
    Builder_Id varchar(50),
    Client_Id varchar(50),
    Computer_Id varchar(50),
    PRIMARY KEY(Id),
    FOREIGN KEY (Builder_Id) REFERENCES Users(Id),
    FOREIGN KEY (Client_Id) REFERENCES Users(Id),
    FOREIGN KEY (Computer_Id) REFERENCES Computers(Id)
);


CREATE TABLE `Computers`(
    Id varchar(50),
    CPU_Id varchar(50),
    Motherboard_Id varchar(50),
    GPU_Id varchar(50),
	RAM_Id varchar(50),
	RAM_Quantity int,
	PSU_Id varchar(50),
    Storage_Id varchar(50),
    PRIMARY KEY(Id),
    FOREIGN KEY (CPU_Id) REFERENCES CPUs(Id),
    FOREIGN KEY (Motherboard_Id) REFERENCES Motherboards(Id),
    FOREIGN KEY (GPU_Id) REFERENCES GPUs(Id),
    FOREIGN KEY (RAM_Id) REFERENCES RAM(Id),
    FOREIGN KEY (PSU_Id) REFERENCES PSUs(Id),
    FOREIGN KEY (Storage_Id) REFERENCES Storage_Parts(Id)
);


CREATE TABLE `Storage_Parts`(
    Id varchar(50),
    Brand varchar(50),
     Model varchar(20),
    `Type` varchar(50),
	`Capacity` varchar(50),
	`Speed` varchar(50),
    Photo_id varchar(50),
    Powerdraw varchar(50),
    Price double,
    Quantity_Available int,
    PRIMARY KEY(Id)
);
CREATE TABLE `CPUs`(
    Id varchar(50),
    Brand varchar(50),
    `Model` varchar(50),
	`Speed` varchar(50),
	`Cores` varchar(50),
    Photo_id varchar(50),
    Powerdraw varchar(50),
    `Socket` varchar(50),
     Generation varchar(50),
	Quantity_Avalable int,
    Price double,
    PRIMARY KEY(Id)
);
CREATE TABLE `GPUs`(
    Id varchar(50),
    Brand varchar(50),
    `Model` varchar(50),
	`Manufacturer` varchar(50),
	`Core_Speed` varchar(50),
    Memory_Capacity varchar(20),
    `Memory_Speed` varchar(50),
    Photo_id varchar(50),
    Powerdraw varchar(50),
	Quantity_Avalable int,
    Price double,
    PRIMARY KEY(Id)
);

CREATE TABLE `Motherboards`(
    Id varchar(50),
    `Model` varchar(50),
    `Brand` varchar(50),
	`Socket` varchar(50),
	`Ram_Slots` int,
    Supported_CPU_Models varchar(100),
    `Max_Ram_Capacity` int,
    Powerdraw varchar(50),
    Photo_id varchar(50),
	Quantity_Avalable int,
    Price double,
    PRIMARY KEY(Id)
);
CREATE TABLE `RAM`(
    Id varchar(50),
    `Name` varchar(50),
    `Brand` varchar(50),
	`Capacity` varchar(50),
	`Speed` varchar(10),
    Ddr_Gen varchar(100),
    Photo_id varchar(50),
    Powerdraw varchar(50),
	Quantity_Avalable int,
    Price double,
    PRIMARY KEY(Id)
);
CREATE TABLE `PSUs`(
    Id varchar(50),
    `Brand` varchar(50),
     Model varchar(20),
    `Certificate` varchar(50),
	`Max_power` varchar(50), 
    Photo_id varchar(50),
	Quantity_Avalable int,
    Price double,
    PRIMARY KEY(Id)
);

Alter table ram 
drop column  Name;

Alter table  `Requests` 
add  Status varchar(20) after Computer_Id;





