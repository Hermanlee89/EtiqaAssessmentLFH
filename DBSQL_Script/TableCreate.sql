drop table Users
CREATE TABLE Users (
    Id int IDENTITY (1, 1),
    Username varchar(30) NOT NULL PRIMARY KEY,
    Mail varchar(50),
    PhoneNo varchar(12),
    SkillSets varchar(200),
	Hobby varchar(200),
	CreatedTime datetime2,
	UpdateTime datetime2
);

alter TABLE Users 
--alter column Mail varchar(50);
--alter column PhoneNo varchar(12);
--add CreatedTime datetime;
--add UpdateTime datetime;
