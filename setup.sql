CREATE TABLE cruise(  
    id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
    create_time DATETIME DEFAULT CURRENT_TIMESTAMP  COMMENT 'create time',
    update_time DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP  COMMENT 'update time',
    liner varchar(255) NOT NULL COMMENT 'Name of Cruise Liner',
    passengers int NOT NULL COMMENT 'Number of passengers',
    price int NOT NULL COMMENT 'Price of cruise',
    destination VARCHAR(255) NOT NULL COMMENT 'Area the cruise will be'
) default charset utf8 comment '';
CREATE TABLE trip(  
    id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
    create_time DATETIME DEFAULT CURRENT_TIMESTAMP  COMMENT 'create time',
    update_time DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP  COMMENT 'update time',
    destination varchar(255) NOT NULL comment 'Area of trip',
    price int NOT NULL COMMENT 'Price of trip'
) default charset utf8 comment '';
CREATE TABLE products(  
    id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
    create_time DATETIME DEFAULT CURRENT_TIMESTAMP  COMMENT 'create time',
    update_time DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP  COMMENT 'update time',
    name varchar(255) NOT NULL comment 'name of product',
    price int NOT NULL COMMENT 'price of product',
    quantity int NOT NULL COMMENT 'quantity of product'
) default charset utf8 comment '';