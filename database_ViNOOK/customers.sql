select * from customers;

insert into customers (_name, address, phone) values ('Joshua', 'Virac', '1234-567-8910');
insert into customers (_name, address, phone) values ('', '', '--');

select count(customer_id) as TotalCustomer
from customers;

select customer_id, _name, address, phone, tinID
from customers 
where not _data_status='deleted'
order by _name;

select distinct _name,
(select count(customer)
from orders
where orders.customer=customers.customer_id) as OrderCount
from customers
inner join orders on customers.customer_id=orders.customer
order by OrderCount desc, order_date
limit 5;

select distinct _name,
(select count(customer)
from orders
where orders.customer=customers.customer_id) as OrderCount
from customers
inner join orders on customers.customer_id=orders.customer

order by OrderCount desc, order_date
limit 5;