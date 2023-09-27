SELECT * FROM virtual_inventory.products_detail;
describe products_detail;
alter table products_detail modify date_in DATETIME;

SELECT sum(on_hand) FROM virtual_inventory.products_detail where serial_number='MB63-4665460';
select products_detail.detail_id, products_detail.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products.price, products_detail.serial_number, products_detail.quantity, products_detail.on_hand, products.unit, suppliers.supplier_id, suppliers._name as supplierName, products_detail.at_cost,  products_detail.date_in, products_detail._status
From products inner Join products_detail On products.product_id=products_detail.product_id
                      inner join categories on products.category_id=categories.category_id 
                      inner join suppliers on products_detail.supplier_id=suppliers.supplier_id
                      where detail_id=1;
select count(serial_number) from virtual_inventory.products_detail where serial_number='134020N20001724' and not _status='sold';

select distinct _status from products_detail order by _status;

select detail_id, product_id, serial_number, markup_price, supplier
from products_detail where serial_number='H465460';

select products_detail.detail_id, products_detail.product_id, products._name, products.brand, products.model, products.category, products_detail.serial_number, products_detail.markup_price, products.price, products_detail.on_hand, products_detail.supplier, products_detail.date_in, products_detail._status 
from products inner join products_detail on products.product_id=products_detail.product_id
where serial_number	='123435643';

select products_detail.detail_id, products_detail.product_id, products._name, products.brand, products.model, products.category, products.on_hand as totalOnHand, products_detail.serial_number, products_detail.markup_price, products.price, products_detail.on_hand, products_detail.supplier, products_detail.date_in, products_detail._status
            from products inner join products_detail on products.product_id=products_detail.product_id
            where serial_number='bli' and not products_detail._status='sold' order by date_in;
            
select (on_hand - 12) as qtyRemainder from products_detail where serial_number='bli' and not _status = 'sold' order by date_in;

select products_detail.detail_id, products_detail.product_id, products._name, products.brand, products.model, products.category, products_detail.serial_number, products_detail.quantity, products_detail.on_hand, products_detail.markup_price, products.price,  products_detail.supplier, products_detail.date_in, products_detail._status
from products inner join products_detail on products.product_id=products_detail.product_id
where _name like @name or concat(brand, ' ', model) like @bmodel or serial_number like @serial and category=@category and supplier=@supplier
order by _status, date_in desc, supplier, _name;

select products_detail.detail_id, products_detail.product_id, products_detail.serial_number, products_detail.at_cost, suppliers.supplier_id, suppliers._name
                    from products_detail inner join suppliers on products_detail.supplier_id=suppliers.supplier_id
                    where detail_id=@id and not products_detail._status=@status and (not products_detail._data_status=@dstatus and not suppliers._data_status=@dstatus) order by products_detail.date_in desc;
                    
                    
select products_detail.detail_id, products_detail.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products_detail.serial_number, sum(products_detail.on_hand) as TotalOnHand, products_detail.at_cost, suppliers._name, products_detail.date_in, reference
                      From products inner Join products_detail On products.product_id=products_detail.product_id
                      inner join categories on products.category_id=categories.category_id
                      inner join suppliers on products_detail.supplier_id=suppliers.supplier_id
                      group by serial_number
                      Order By category, brand, model, date_in desc, products._name;

start transaction;
SET SQL_SAFE_UPDATES=0;
update products_detail set serial_number='B003', at_cost='215', supplier_id='1' where reference='20221124110949';
SET SQL_SAFE_UPDATES=1;
commit;

select count(supplier_id) from products_detail where supplier_id=18;

select products_detail.detail_id, products_detail.product_id, products.item_code, products._name as productName, products.brand, products.model, categories.category, products_detail.serial_number, sum(products_detail.on_hand) as on_hand, products.unit, products_detail.at_cost, products.price, suppliers._name as supplier, products_detail.date_in, sum(products_detail.quantity) as quantity
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner Join categories On products.category_id=categories.category_id 
                      inner Join suppliers On products_detail.supplier_id=suppliers.supplier_id 
                      Where (not products._data_status='deleted' and not products_detail._data_status='deleted') 
                      and not _status='sold'
                      group by reference 
                      Order By category, brand, model, date_in desc, products._name;
                      
select sum(quantity)
from products_detail
where date_in between @fromDate and @toDate
and not _data_status=@dstatus;

select date_in, sum(quantity) as Stock
from products_detail
where date_in between '2022-12-01' and current_timestamp()
group by date_in;

select date_in
from products_detail 
order by date_in
limit 1;

select order_date
	from orders 
	order by order_date
	limit 1;
    
    
select order_date, sum(total_amount) as TotalAmount
from orders
where order_date between '2022-12-01' and current_timestamp()
group by order_date;