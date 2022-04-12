CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';
CREATE TABLE IF NOT EXISTS trips(
  id INT AUTO_INCREMENT primary key,
  name TEXT NOT NULL,
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update'
) default charset utf8 COMMENT '';
CREATE TABLE IF NOT EXISTS reservations(
  id INT AUTO_INCREMENT PRIMARY KEY,
  type TEXT NOT NULL,
  name TEXT NOT NULL,
  confirmationNumber TEXT NOT NULL,
  address TEXT NOT NULL,
  date DATE NOT NULL,
  notes TEXT NOT NULL,
  cost INT NOT NULL DEFAULT 0,
  tripId INT NOT NULL,
  FOREIGN KEY (tripId) REFERENCES trips(id)
) default charset utf8 COMMENT '';
DROP TABLE trips;
DROP TABLE reservations;
--
-- Trips
INSERT INTO
  trips (name)
VALUES
  ('Maui');
--
  --
SELECT
  *
FROM
  trips;
-- Reservations
INSERT INTO
  reservations (
    type,
    name,
    confirmationNumber,
    address,
    date,
    notes,
    cost,
    tripId
  )
VALUES
  (
    'Flight',
    'Drake',
    '123FGR',
    '1234 13th Street',
    '2022-05-29',
    'This will be fun',
    374,
    1
  );
SELECT
  *
FROM
  reservations;