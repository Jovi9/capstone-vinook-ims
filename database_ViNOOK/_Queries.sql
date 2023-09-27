-- Active: 1668900632386@@localhost@3306
-- CREATE USER 'vnook_merchandise'@'localhost' IDENTIFIED BY 'VNookComputers_200207_Inventory';
-- GRANT ALL PRIVILEGES ON virtual_inventory.* TO 'vnook_merchandise'@'localhost'; 
-- flush privileges;
-- SHOW GRANTS FOR 'vnook_merchandise'@'localhost';
-- show tables;
describe user_accounts;
describe sys_history;
describe units;
describe categories;
describe suppliers;
describe customers;
describe products;
describe products_detail;
describe orders;
describe orders_detail;

SET sql_safe_updates=0;

alter table categories change _data_status deleted tinyint default 0;