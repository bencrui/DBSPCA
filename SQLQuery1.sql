INSERT INTO tblAnimals
Values ('Bird', 'Bird', '11/19/2021');

INSERT INTO tblAnimals([Name], [Type] ,[DoB]) Values('Bird', 'Bird', '10/26/2021')

SELECT [Name] FROM tblAnimals WHERE [animalId] = 2;

DELETE FROM tblAnimals
WHERE [Name] = 'Bird';

INSERT INTO tblFeed 
Values (2, '12/17/2015', 70);

UPDATE TblAnimals
SET Name = 'Fluff'
WHERE animalId = 6;

INSERT INTO tblFeed VALUES (2, '10/26/2021', 22);

SELECT tblFeed.Consumption FROM tblFeed INNER JOIN tblAnimals ON tblFeed.FeedId = tblAnimals.animalId WHERE tblAnimals.animalId = 2;