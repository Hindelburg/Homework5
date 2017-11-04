CREATE TABLE dbo.Addresses(
	id			 int			IDENTITY NOT NULL PRIMARY KEY CLUSTERED (ID ASC),	
	customerNum	 int			NOT NULL,
	dob			 date			NOT NULL,
	currentDate	 date			NOT NULL,
	fullName	 varchar(100)	NOT NULL,
	city		 varchar(100)	NOT NULL,
	st			 varchar(100)	NOT NULL,
	zip			 int			NOT NULL,	 
	street		 varchar(100)	NOT NULL
);

INSERT INTO dbo.Addresses (customerNum, dob, currentDate, fullName, city, st, zip, street) VALUES
	(120, '01/10/1915', '1/1/1999', 'test', 'here', 'WA', 3753, 'streename')
GO
