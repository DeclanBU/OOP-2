-- This script creates a database table Stock with some data in it.

-- Remove existing table Stock 
DROP TABLE Stock;

-- Create Stock table
 CREATE TABLE Stock
 (Stock_No numeric(4),
  Description char(20),
  Cost_Price numeric(5,2),
  Sale_Price numeric(5,2),
  Qty numeric(3),
  CONSTRAINT pk_Stock PRIMARY KEY (Stock_No));
  
-- Populate table Stock
INSERT INTO Stock
VALUES(1,'Levis 501',50,75,100);
INSERT INTO Stock
VALUES(2,'Wrangler Regular',40,65,50);
INSERT INTO Stock
VALUES(3,'Levis 901',80,105,35);
INSERT INTO Stock
VALUES(4,'Pepe Skinny',45,70,20);
INSERT INTO Stock 
VALUES(5,'Levis 601',35,104,12);

COMMIT;