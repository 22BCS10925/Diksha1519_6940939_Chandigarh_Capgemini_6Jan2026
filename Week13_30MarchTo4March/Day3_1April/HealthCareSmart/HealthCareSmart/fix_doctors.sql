-- Fix existing doctors with UserId = 0 by assigning them to existing users or setting proper UserId

-- First, let's see what doctors exist with UserId = 0
SELECT Id, FullName, UserId FROM Doctors WHERE UserId = 0;

-- Update doctors to have proper UserId values
-- Option 1: If there are existing users without doctors, assign them
UPDATE d
SET d.UserId = u.Id
FROM Doctors d
INNER JOIN Users u ON u.FullName = d.FullName AND u.Role = 'Doctor'
WHERE d.UserId = 0;

-- Option 2: If no matching users, set UserId to NULL temporarily
UPDATE Doctors 
SET UserId = NULL 
WHERE UserId = 0;

-- Option 3: Delete doctors with UserId = 0 if they don't have corresponding users
-- DELETE FROM Doctors WHERE UserId = 0 AND NOT EXISTS (
--     SELECT 1 FROM Users u WHERE u.Id = Doctors.UserId AND u.Role = 'Doctor'
-- );
