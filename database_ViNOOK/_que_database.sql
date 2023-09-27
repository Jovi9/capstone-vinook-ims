drop database virtual_inventory;
create database virtual_inventory;
use virtual_inventory;

CREATE TABLE user_accounts (
    user_id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100) NOT NULL,
    phone VARCHAR(20) UNIQUE NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL,
    address LONGTEXT,
    username VARCHAR(100) UNIQUE NOT NULL,
    userpassword CHAR(128) NOT NULL,
    role INT(2) NOT NULL,
    recovery_code VARCHAR(255),
    code_expire DATETIME DEFAULT CURRENT_TIMESTAMP,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    last_login_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    deleted tinyint default 0
);

CREATE TABLE sys_history (
    id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(100) NOT NULL,
    _action VARCHAR(100) NOT NULL,
    title VARCHAR(100) NOT NULL,
    content LONGTEXT NOT NULL,
    newContent LONGTEXT,
    _date DATETIME DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT FK_History_Useres FOREIGN KEY (username)
        REFERENCES user_accounts (username)
        ON UPDATE CASCADE ON DELETE RESTRICT
);

CREATE TABLE units (
    id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    units VARCHAR(100) UNIQUE NOT NULL,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    deleted tinyint default 0
);

CREATE TABLE categories (
    category_id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    category VARCHAR(255) NOT NULL,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    deleted tinyint default 0
);

CREATE TABLE suppliers (
    supplier_id INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    _name VARCHAR(255) NOT NULL,
    address VARCHAR(255) NOT NULL,
    phone VARCHAR(20),
    email VARCHAR(100),
    other_details LONGTEXT,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    deleted tinyint default 0
);

CREATE TABLE customers (
    customer_id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    _name VARCHAR(255) NOT NULL,
    address VARCHAR(255) NOT NULL,
    phone VARCHAR(20),
    tinID VARCHAR(20),
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    deleted tinyint default 0
);

CREATE TABLE products (
    product_id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    item_code VARCHAR(255) NOT NULL,
    _name VARCHAR(255),
    brand VARCHAR(100),
    model VARCHAR(100),
    category_id INT UNSIGNED NOT NULL,
    quantity BIGINT UNSIGNED DEFAULT 0,
    on_hand BIGINT UNSIGNED DEFAULT 0,
    unit VARCHAR(50),
    price DECIMAL(14 , 2 ) DEFAULT 0,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    deleted tinyint default 0,
    CONSTRAINT FK_Products_Category FOREIGN KEY (category_id)
        REFERENCES categories (category_id)
        ON UPDATE CASCADE ON DELETE RESTRICT
);

CREATE TABLE products_detail (
    detail_id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    product_id BIGINT UNSIGNED NOT NULL,
    serial_number VARCHAR(255) NOT NULL,
    at_cost DECIMAL(14 , 2 ) DEFAULT 0,
    quantity BIGINT UNSIGNED DEFAULT 1,
    on_hand BIGINT DEFAULT 1,
    date_in DATETIME,
    supplier_id INT UNSIGNED NOT NULL,
    _status VARCHAR(50),
    sold_to VARCHAR(20),
    reference VARCHAR(20) NOT NULL,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    deleted tinyint default 0,
    CONSTRAINT FK_ProductsDetail_Products FOREIGN KEY (product_id)
        REFERENCES products (product_id)
        ON UPDATE CASCADE ON DELETE RESTRICT,
    CONSTRAINT FK_ProductsDetail_Supplier FOREIGN KEY (supplier_id)
        REFERENCES suppliers (supplier_id)
        ON UPDATE CASCADE ON DELETE RESTRICT
);

CREATE TABLE orders (
    transaction_code BIGINT UNSIGNED NOT NULL PRIMARY KEY,
    invoice_no BIGINT UNSIGNED NOT NULL,
    order_date DATETIME,
    customer BIGINT UNSIGNED NOT NULL,
    total_amount DECIMAL(14 , 0 ) DEFAULT 0,
    balance DECIMAL(14 , 0 ) DEFAULT 0,
    received_amount DECIMAL(14 , 0 ) DEFAULT 0,
    _change DECIMAL(14 , 0 ) DEFAULT 0,
    payment_type VARCHAR(50),
    cheque_no Varchar(50),
    pay_status VARCHAR(50),
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    deleted tinyint default 0,
    CONSTRAINT FK_Order_Customer FOREIGN KEY (customer)
        REFERENCES customers (customer_id)
        ON UPDATE CASCADE ON DELETE RESTRICT
);

CREATE TABLE orders_detail (
    order_detailID BIGINT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    transaction_code BIGINT UNSIGNED NOT NULL,
    serial_number VARCHAR(255) NOT NULL,
    _name VARCHAR(255),
    brand VARCHAR(100),
    model VARCHAR(100),
    category VARCHAR(255),
    supplier VARCHAR(255),
    quantity BIGINT UNSIGNED DEFAULT 0,
    unit VARCHAR(100),
    price DECIMAL(14 , 2 ) DEFAULT 0,
    total DECIMAL(14 , 2 ) DEFAULT 0,
    warranty_start DATE,
    warranty_end DATE,
    product_id BIGINT UNSIGNED NOT NULL,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    deleted tinyint default 0,
    CONSTRAINT FK_OrderDetail_Orders FOREIGN KEY (transaction_code)
        REFERENCES orders (transaction_code)
        ON UPDATE CASCADE ON DELETE RESTRICT,
    CONSTRAINT FK_OrderDetail_Product FOREIGN KEY (product_id)
        REFERENCES products (product_id)
        ON UPDATE CASCADE ON DELETE RESTRICT    
);