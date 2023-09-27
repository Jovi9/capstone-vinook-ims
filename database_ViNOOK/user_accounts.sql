select recovery_code from user_accounts where username=@username and recovery_code=@code;

SELECT * FROM virtual_inventory.user_accounts;
alter table user_accounts add column address longtext after email;

  -- recovery_code varchar(255) as (sha2(concat(userpassword, username, first_name, last_name), 512)) stored not null,

insert into virtual_inventory.user_accounts
(first_name, last_name, username, userpassword, email, role, recovery_code)
values
('Virtual', 'Administrator', 'admin', sha2('Virtual4', 512), 'fjbagadiong@gmail.com', '0', '8086e6ab74a443c2c2e7d7bffe9b51c240bc95e6c284f2a823ef4e2bb8558ea3c17d904e738ea6a6aa7fda99d4f4aa7f3a2fe692fa34c99b4be5fb255ada4d9c');

insert into virtual_inventory.user_accounts
(first_name, last_name, username, userpassword, email, role,recovery_code)
values
('Virtual', 'Cashier', 'user', sha2('virtual', 512), 'ariej413@gmail.com', '1', '37c525e6bf35bac73fed0c545b6f092f6046255d6718d92e63b96f0e791c27481c3ddca1121f5a916144fd0833a1b2753d402c1fbb7488212970c7931f7126d6');

select username, concat(first_name, ' ', last_name) as name, phone, email, address, role from user_accounts where username='admin'