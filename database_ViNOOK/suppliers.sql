select * from suppliers;

insert into suppliers (_name, address, phone) values ('Joshua', 'Virac', '1234-567-8910');
insert into suppliers (_name, address, phone) values ('', '', '--');

select count(supplier_id) as TotalSuppliers from suppliers;
select count(product_id) as TotalProducts from products;

select sum(on_hand) as TotalStockAvailable from products;

select count(transaction_code) as TotalOrders from orders where (order_date between @fromDate and @toDate) and not _data_status=@dstatus;

select _name, 
(select count(quantity) from products_detail
where products_detail.supplier_id=suppliers.supplier_id
and not products_detail._data_status='Deleted') as numProducts
from suppliers 
order by numProducts desc
limit 5;