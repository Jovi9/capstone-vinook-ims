select * from categories;

insert into categories (category) values ('LAPTOP');

select categories.category_id, categories.category,
(select count(category_id) from products
inner join products_detail on products.product_id=products_detail.product_id
where products.category_id=categories.category_id
and not _status='Sold') as availableStock
from categories
order by categories.category;

select category_id, category from categories order by category;

select categories.category,
(select count(category_id) from products
inner join products_detail on products.product_id=products_detail.product_id
where products.category_id=categories.category_id
and not products_detail._data_status='Deleted') as TotalStock
from categories
order by TotalStock desc
limit 5;

select categories.category,
(select count(category_id) from products
inner join products_detail on products.product_id=products_detail.product_id
where products.category_id=categories.category_id
and not products_detail._data_status='deleted') as TotalStock
from categories
order by TotalStock desc
limit 5;