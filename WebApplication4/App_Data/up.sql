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
	(1200, '01/10/1998', '1/1/1999', 'April Thew', 'Seattle', 'WA', 23687, 'Mountainton Drive'),
	(4370, '01/09/1973', '1/1/1999', 'Alyssa Watts', 'Monmouth', 'OR', 348774, 'Sampal Street'),
	(5489, '01/11/1920', '1/1/1999', 'Leroy Brown', 'Monmouth', 'OR', 346733, 'Heilk Road'),
	(5893, '01/02/1989', '1/1/1999', 'Zachariah Comstock', 'Columbia', 'NA', 854434, 'Comstock Drive'),
	(8342, '01/12/2001', '1/1/1999', 'Booker Dewitt', 'Rapture', 'NA', 000000, 'Webster Road')
GO
