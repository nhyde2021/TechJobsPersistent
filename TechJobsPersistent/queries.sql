--Part 1
Columns:	Datatype:
Id			INT
Name		LONGTEXT
EmployerId	INT

--Part 2
SELECT name FROM employers WHERE location = "St.Louis City";

--Part 3
SELECT name, description
FROM skills
INNER JOIN jobs ON skills.Id = jobs.Id
WHERE jobs.name IS NOT NULL
ORDER BY jobs.name;
