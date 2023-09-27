select * from orders;

select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name as productName, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.quantity, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end
from orders inner join customers on orders.customer=customers.customer_id 
inner join orders_detail on orders.transaction_code=orders_detail.transaction_code
where (customers._name like @name or orders.transaction_code like @code or invoice_no like @invoice or orders_detail._name like @pname or concat(brand, ' ', model) like @bmodel) and category=@category and (not orders._data_status=@dstatus and not customers._data_status=@dstatus)
order by order_date desc, customers._name;

select order_date, sum(total_amount) as TotalAmount
from orders
where order_date between @fromDate and @toDate
and not _data_status=@dstatus
group by order_date;

set @fromDate = '2022-08-06';
set @toDate = current_timestamp;
set @formatter = '%m%Y';

select order_date, sum(total_amount) as TotalAmount, datediff(@toDate, @fromDate)
                                    from orders
                                    where order_date between @fromDate and @toDate
                                    and not _data_status='deleted'
                                    group by DATE_FORMAT(order_date, @formatter);
                                    
select orders_detail._name, sum(orders_detail.quantity) as TotalSold
from orders
inner join orders_detail on orders.transaction_code=orders_detail.transaction_code
where order_date between @fromDate and @toDate
group by orders_detail._name
order by TotalSold desc
limit 5;

select _name, on_hand
from products
where on_hand < 5
and not _data_status='Deleted';


 select orders_detail.order_detailID, orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, orders_detail.serial_number, orders_detail._name as productName, orders_detail.brand, orders_detail.model, orders_detail.category, orders_detail.supplier, orders_detail.quantity, orders_detail.price, orders_detail.total, orders_detail.warranty_start, orders_detail.warranty_end
                        From orders inner Join customers On orders.customer=customers.customer_id 
                        inner Join orders_detail on orders.transaction_code=orders_detail.transaction_code 
                        where (customers._name Like '%%' Or orders.transaction_code Like '%%' Or invoice_no Like '%%' or serial_number like '%%' Or orders_detail._name Like '%%')
                        and date(order_date)='2022-11-26'
                        and (not orders._data_status='void' and not customers._data_status='void')
                        order by order_date desc, customers._name;
                        
select orders.transaction_code, orders.invoice_no, orders.order_date, customers._name as customerName, customers.address as customerAddress, orders.total_amount, orders.payment_type,
(select count(transaction_code) from orders_detail where orders_detail.transaction_code=orders.transaction_code) as numItems
from orders
inner join customers on orders.customer=customers.customer_id
where not orders._data_status='Void'
order by order_date, customerName;

set @fromDate = '2022-11-22';
set @toDate = current_timestamp();
set @dstatus = 'Void';

select count(distinct(customer)) as TotalCustomers, count(transaction_code) as TotalOrders, sum(total_amount) as TotalSales
from orders
where order_date between @fromDate and @toDate
and not _data_status=@dstatus;

select count(customer) as TotalCustomers
from orders;

select concat(orders_detail._name) as ProductName, sum(orders_detail.quantity) as TotalSold
from orders_detail
inner join orders on orders_detail.transaction_code=orders.transaction_code
where DATE(order_date) between '2019-10-19' and current_timestamp()
and not orders_detail._data_status='Void'
group by ProductName
order by TotalSold desc;