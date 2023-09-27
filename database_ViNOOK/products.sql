SELECT * FROM virtual_inventory.products where concat(brand, ' ', model) like '%Asus rog%';
SELECT * FROM virtual_inventory.products;
SELECT * FROM virtual_inventory.products where product_id=6;
SELECT sum(quantity) as TotalProducts FROM virtual_inventory.products;

insert into products (product_id, item_code, _name, brand, model, category_id, unit, price)
values
(1, 'ITEM-A1', 'Headset', 'Logitech',  'M1', 1, 'pieces', 570);	

-- no deleteion	
select products.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products.on_hand, products.unit, products.price
from products inner join categories on products.category_id=categories.category_id
where (item_code like '%%' and _name like '%%' and concat(brand, ' ', model) like '%%') and (not products._data_status='deleted' and not categories._data_status='deleted');

select products.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products.quantity, products.on_hand, products.unit, products.price
from products inner join categories on products.category_id=categories.category_id
where product_id=@id;

select products_detail.detail_id, products_detail.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products_detail.serial_number, products_detail.quantity, products_detail.on_hand, products_detail.at_cost, products.price,  suppliers._name, products_detail.date_in, products_detail._status
				From products inner Join products_detail On products.product_id=products_detail.product_id
                  inner join categories on products.category_id=categories.category_id
                  inner join suppliers on products_detail.supplier_id=suppliers.supplier_id;
                  
update products set quantity=quantity + 15, on_hand=on_hand + 15 where product_id=4;

update products set on_hand=on_hand - 10 where product_id=4;

select products.product_id, products._name, products.brand, products.model, products.category, products.on_hand, products.unit, products.price from products inner join products_detail on products.product_id=products_detail.product_id where products._name like '%%' or products_detail.serial_number like '';
select products_detail.serial_number, products._name, products.brand, products.model, products.category, products_detail.quantity, products.unit, products.price, products_detail.markup_price, products_detail.supplier, products_detail.other_details;

SELECT 
    SUM(price)
FROM
    virtual_inventory.products;

select products_detail.detail_id, products.product_id, products._name, products.brand, products.model, products.category, products_detail.on_hand, products.unit, products_detail.serial_number, products_detail.markup_price, products.price, products_detail.date_in, products_detail._status
from products inner join products_detail on products.product_id=products_detail.product_id
where (products._name like '%%' and products.category='laptop') and products_detail.supplier='asus';

select products_detail.detail_id, products.product_id, products._name, products.brand, products.model, products.category, products_detail.on_hand, products.unit, products_detail.serial_number, products_detail.markup_price, products.price, products_detail.date_in, products_detail._status
                from products inner join products_detail on products.product_id=products_detail.product_id
                where products._name like '%%' and products_detail.supplier='sandisk';
                
select * from products inner join products_detail on products.product_id=products_detail.product_id;

select detail.detail_id, product.product_id, product._name, product.brand, product.model, product.category, detail.on_hand, product.unit, detail.serial_number, detail.markup_price, product.price, detail.date_in, detail._status
                from products as product inner join products_detail as detail on product.product_id=detail.product_id
                where product._name like @name and detail.supplier=@supplier;
	
select products_detail.detail_id, products_detail.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products_detail.serial_number, products_detail.quantity, products_detail.on_hand, products_detail.at_cost, products.price,  suppliers._name, products_detail.date_in, products_detail._status
                  From products inner Join products_detail On products.product_id=products_detail.product_id
                  inner join categories on products.category_id=categories.category_id
                  inner join suppliers on products_detail.supplier_id=suppliers.supplier_id
				-- Where (item_code like @code or products._name like @name Or concat(brand, ' ', model) like @bmodel or serial_number like @serial) and (not products._data_status=@dstatus and not products_detail._data_status=@dstatus)
				Where item_code='ax123'
                Order By date_in desc, products._name, _status;
                
             select products.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products.quantity, products.on_hand, products.unit, products.price
                        from products inner join categories on products.category_id=categories.category_id
                        where (item_code like @code or _name like @name or concat(brand, ' ', model) like @bmodel);
                        
select _name, brand, model, categories.category, on_hand
from products
inner join categories on products.category_id=categories.category_id
where on_hand < 5
and not products._data_status='Deleted'
order by on_hand, _name;

select count(on_hand) as TotalAvailable
from products
where on_hand < 5;

select _name, on_hand
from products
where on_hand < 5
and not _data_status='Deleted'
order by on_hand, _name
limit 5;

select products_detail.detail_id, products_detail.product_id, products.item_code, products._name, products.brand, products.model, categories.category, products.price, products_detail.serial_number, sum(products_detail.quantity) as quantity, sum(products_detail.on_hand) as on_hand, products.unit, suppliers.supplier_id, suppliers._name as supplierName, products_detail.at_cost,  products_detail.date_in, products_detail._status, reference
                      From products inner Join products_detail On products.product_id=products_detail.product_id 
                      inner join categories on products.category_id=categories.category_id 
                      inner join suppliers on products_detail.supplier_id=suppliers.supplier_id
                      where reference=20221128211651
                      group by reference;
                      
select products._name as ProductName, sum(products_detail.quantity) as TotalStock,  sum(products_detail.quantity) - sum(products_detail.on_hand) as TotalSold, sum(products_detail.on_hand) as TotalAvailable
from products
inner join products_detail
on products.product_id=products_detail.product_id
where date_in between '2022-11-29' and current_timestamp()
and not products._data_status='Deleted'
group by ProductName;