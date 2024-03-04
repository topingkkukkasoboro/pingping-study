CREATE TABLE `follows` (
  `following_user_id` integer,
  `followed_user_id` integer,
  `created_at` timestamp
);

CREATE TABLE `users` (
  `id` integer PRIMARY KEY,
  `username` varchar(255),
  `role` varchar(255),
  `created_at` timestamp
);

CREATE TABLE `posts` (
  `id` integer PRIMARY KEY,
  `title` varchar(255),
  `body` text COMMENT 'Content of the post',
  `user_id` integer,
  `status` varchar(255),
  `created_at` timestamp
);

CREATE TABLE `cart` (
  `cart_id` bigint PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `reg_time` datetime(6) DEFAULT NULL,
  `update_time` datetime(6) DEFAULT NULL,
  `created_by` varchar(255) DEFAULT NULL,
  `modified_by` varchar(255) DEFAULT NULL,
  `member_id` bigint DEFAULT NULL
);

CREATE TABLE `cart_item` (
  `cart_item_id` bigint PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `reg_time` datetime(6) DEFAULT NULL,
  `update_time` datetime(6) DEFAULT NULL,
  `created_by` varchar(255) DEFAULT NULL,
  `modified_by` varchar(255) DEFAULT NULL,
  `count` int NOT NULL,
  `cart_id` bigint DEFAULT NULL,
  `item_id` bigint DEFAULT NULL
);

CREATE TABLE `item` (
  `item_id` bigint PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `reg_time` datetime(6) DEFAULT NULL,
  `update_time` datetime(6) DEFAULT NULL,
  `created_by` varchar(255) DEFAULT NULL,
  `modified_by` varchar(255) DEFAULT NULL,
  `item_detail` tinytext NOT NULL,
  `item_nm` varchar(50) NOT NULL,
  `item_sell_status` ENUM ('SELL', 'SOLD_OUT') DEFAULT NULL,
  `price` int NOT NULL,
  `stock_number` int NOT NULL
);

CREATE TABLE `item_img` (
  `item_img_id` bigint PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `reg_time` datetime(6) DEFAULT NULL,
  `update_time` datetime(6) DEFAULT NULL,
  `created_by` varchar(255) DEFAULT NULL,
  `modified_by` varchar(255) DEFAULT NULL,
  `img_name` varchar(255) DEFAULT NULL,
  `img_url` varchar(255) DEFAULT NULL,
  `ori_img_name` varchar(255) DEFAULT NULL,
  `repimg_yn` varchar(255) DEFAULT NULL,
  `item_id` bigint DEFAULT NULL
);

CREATE TABLE `member` (
  `member_id` bigint PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `reg_time` datetime(6) DEFAULT NULL,
  `update_time` datetime(6) DEFAULT NULL,
  `created_by` varchar(255) DEFAULT NULL,
  `modified_by` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `role` ENUM ('ADMIN', 'USER') DEFAULT NULL
);

CREATE TABLE `orders` (
  `order_id` bigint PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `reg_time` datetime(6) DEFAULT NULL,
  `update_time` datetime(6) DEFAULT NULL,
  `created_by` varchar(255) DEFAULT NULL,
  `modified_by` varchar(255) DEFAULT NULL,
  `order_date` datetime(6) DEFAULT NULL,
  `order_status` ENUM ('CANCEL', 'ORDER') DEFAULT NULL,
  `member_id` bigint DEFAULT NULL
);

CREATE TABLE `order_item` (
  `order_item_id` bigint PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `reg_time` datetime(6) DEFAULT NULL,
  `update_time` datetime(6) DEFAULT NULL,
  `created_by` varchar(255) DEFAULT NULL,
  `modified_by` varchar(255) DEFAULT NULL,
  `count` int NOT NULL,
  `order_price` int NOT NULL,
  `item_id` bigint DEFAULT NULL,
  `order_id` bigint DEFAULT NULL
);

CREATE TABLE `todo` (
  `idx` int PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `할일` varchar(50) DEFAULT NULL,
  `상태` varchar(50) DEFAULT NULL
);

CREATE UNIQUE INDEX `cart_member_index1` ON `cart` (`member_id`);

CREATE INDEX `cart_item_cart_fk1` ON `cart_item` (`cart_id`);

CREATE INDEX `cart_item_item_fk2` ON `cart_item` (`item_id`);

CREATE INDEX `item_img_fk1` ON `item_img` (`item_id`);

CREATE UNIQUE INDEX `member_index1` ON `member` (`email`);

CREATE INDEX `order_member_fk1` ON `orders` (`member_id`);

ALTER TABLE `posts` ADD FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);

ALTER TABLE `follows` ADD FOREIGN KEY (`following_user_id`) REFERENCES `users` (`id`);

ALTER TABLE `follows` ADD FOREIGN KEY (`followed_user_id`) REFERENCES `users` (`id`);

ALTER TABLE `cart` ADD CONSTRAINT `cart_member_fk1` FOREIGN KEY (`member_id`) REFERENCES `member` (`member_id`);

ALTER TABLE `cart_item` ADD CONSTRAINT `cart_item_cart_fk1` FOREIGN KEY (`cart_id`) REFERENCES `cart` (`cart_id`);

ALTER TABLE `cart_item` ADD CONSTRAINT `cart_item_item_fk2` FOREIGN KEY (`item_id`) REFERENCES `item` (`item_id`);

ALTER TABLE `item_img` ADD CONSTRAINT `item_img_fk1` FOREIGN KEY (`item_id`) REFERENCES `item` (`item_id`);

ALTER TABLE `orders` ADD CONSTRAINT `order_member_fk1` FOREIGN KEY (`member_id`) REFERENCES `member` (`member_id`);

ALTER TABLE `item` ADD FOREIGN KEY (`item_id`) REFERENCES `order_item` (`item_id`);
