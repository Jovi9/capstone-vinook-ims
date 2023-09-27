SELECT * FROM orders_detail;
    
SELECT * FROM orders_detail where transaction_code=222611341521;
select * from orders where transaction_code=222811590820;
    select * from orders order by created_at desc;
    
    select order_date
    from orders 
    order by order_date
    limit 1;
    
alter table orders_detail add unit VARCHAR(100) after quantity;

alter table orders_detail add product_id BIGINT UNSIGNED NOT NULL after warranty_end;
SET sql_safe_updates=0;
update orders_detail set unit='pieces';
SET sql_safe_updates=1;

select concat(orders_detail._name, ' Brand: ', orders_detail.brand) as ProductName, sum(orders_detail.quantity) as TotalSold
from orders_detail
inner join orders on orders_detail.transaction_code=orders.transaction_code
and not orders_detail._data_status='Void'
group by ProductName;

select concat(orders_detail._name) as ProductName, sum(orders_detail.quantity) as TotalSold
from orders_detail
inner join orders on orders_detail.transaction_code=orders.transaction_code;

select orders_detail._name, quantity
from orders_detail;

select orders_detail._name, sum(orders_detail.quantity) as TotalSold
from orders
inner join orders_detail on orders.transaction_code=orders_detail.transaction_code
where order_date between '2019-11-29' and current_timestamp()
and not orders._data_status='void'
group by orders_detail._name
order by TotalSold desc, order_detailID;