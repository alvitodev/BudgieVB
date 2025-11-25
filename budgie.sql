-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 25, 2025 at 02:48 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `budgie`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `name` varchar(50) NOT NULL,
  `currency_code` varchar(3) DEFAULT NULL,
  `balance` decimal(15,2) DEFAULT 0.00,
  `color_hex` varchar(10) DEFAULT '#000000',
  `created_at` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`id`, `user_id`, `name`, `currency_code`, `balance`, `color_hex`, `created_at`) VALUES
(1, 1, 'Dompet Tunai', 'IDR', -134217.00, '#2ECC71', '2025-11-24 19:30:53'),
(2, 1, 'Bank BCA', 'IDR', 0.00, '#3498DB', '2025-11-24 19:30:53'),
(3, 2, 'Dompet Tunai', 'IDR', 67082340.00, '#2ECC71', '2025-11-25 10:52:54'),
(4, 2, 'Bank BCA', 'IDR', 0.00, '#3498DB', '2025-11-25 10:52:54'),
(5, 2, 'Bank BTN', 'IDR', 1002000000.00, '#F0B01C', '2025-11-25 14:32:26'),
(6, 2, 'Test lengkap', 'IDR', 25840000.00, '#FF0080', '2025-11-25 14:48:52'),
(7, 2, 'gacor', 'EUR', 2500.00, '#8000FF', '2025-11-25 14:52:52'),
(8, 2, 'jepunn', 'JPY', 175200.00, '#FFFFFF', '2025-11-25 14:53:20'),
(9, 3, 'Dompet Tunai', 'IDR', 0.00, '#2ECC71', '2025-11-25 15:09:37'),
(10, 3, 'Bank BCA', 'IDR', 0.00, '#3498DB', '2025-11-25 15:09:37'),
(11, 4, 'Dompet Tunai', 'IDR', 0.00, '#2ECC71', '2025-11-25 17:40:13'),
(12, 4, 'Bank BCA', 'IDR', 0.00, '#3498DB', '2025-11-25 17:40:13'),
(13, 4, 'BTC', 'IDR', 41780000.00, '#FF8000', '2025-11-25 17:41:35'),
(14, 4, 'Jepun', 'JPY', 120.00, '#FF0000', '2025-11-25 17:59:54');

-- --------------------------------------------------------

--
-- Table structure for table `budgets`
--

CREATE TABLE `budgets` (
  `id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `name` varchar(100) DEFAULT NULL,
  `amount_limit` decimal(15,2) DEFAULT NULL,
  `period` enum('Monthly','Weekly','Custom') DEFAULT NULL,
  `start_date` date DEFAULT NULL,
  `end_date` date DEFAULT NULL,
  `color_hex` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `budgets`
--

INSERT INTO `budgets` (`id`, `user_id`, `name`, `amount_limit`, `period`, `start_date`, `end_date`, `color_hex`) VALUES
(1, 1, 'tyu', 7.00, 'Monthly', '2025-11-25', NULL, NULL),
(2, 1, 'makan', 500000.00, 'Monthly', '2025-11-25', NULL, NULL),
(3, 1, 'wer', 520.00, 'Monthly', '2025-11-25', NULL, NULL),
(4, 1, 'twww', 23332.00, 'Monthly', '2025-11-25', NULL, NULL),
(5, 1, 'test', 2.00, 'Monthly', '2025-11-25', NULL, NULL),
(6, 2, 'jajan', 100000.00, 'Monthly', '2025-11-25', NULL, NULL),
(7, 2, 'Modif sound horeg', 3000000.00, 'Monthly', '2025-11-25', NULL, NULL),
(8, 2, 'kuliah', 1500000.00, 'Monthly', '2025-11-25', NULL, NULL),
(9, 4, 'Makanan Bulanan', 500000.00, 'Monthly', '2025-11-25', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `name` varchar(50) NOT NULL,
  `type` enum('Income','Expense','Transfer') NOT NULL,
  `icon_name` varchar(50) DEFAULT NULL,
  `color_hex` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`id`, `user_id`, `name`, `type`, `icon_name`, `color_hex`) VALUES
(1, NULL, 'Makan & Minum', 'Expense', NULL, '#FF5733'),
(2, NULL, 'Transportasi', 'Expense', NULL, '#33FF57'),
(3, NULL, 'Belanja', 'Expense', NULL, '#3357FF'),
(4, NULL, 'Tagihan', 'Expense', NULL, '#FF33A1'),
(5, NULL, 'Gaji', 'Income', NULL, '#33FFF5'),
(6, NULL, 'Hadiah', 'Income', NULL, '#F5FF33'),
(7, NULL, 'Transfer', 'Transfer', NULL, '#888888');

-- --------------------------------------------------------

--
-- Table structure for table `currencies`
--

CREATE TABLE `currencies` (
  `code` varchar(3) NOT NULL,
  `name` varchar(50) DEFAULT NULL,
  `symbol` varchar(5) DEFAULT NULL,
  `exchange_rate_to_idr` decimal(15,2) DEFAULT 1.00
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `currencies`
--

INSERT INTO `currencies` (`code`, `name`, `symbol`, `exchange_rate_to_idr`) VALUES
('EUR', 'Euro', '€', 16500.00),
('GBP', 'British Pound', '£', 19500.00),
('IDR', 'Indonesian Rupiah', 'Rp', 1.00),
('JPY', 'Japanese Yen', '¥', 105.00),
('USD', 'US Dollar', '$', 15500.00);

-- --------------------------------------------------------

--
-- Table structure for table `goals`
--

CREATE TABLE `goals` (
  `id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `name` varchar(100) DEFAULT NULL,
  `type` enum('Income','Expense') DEFAULT NULL,
  `target_amount` decimal(15,2) DEFAULT NULL,
  `current_amount` decimal(15,2) DEFAULT 0.00,
  `target_date` date DEFAULT NULL,
  `color_hex` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `goals`
--

INSERT INTO `goals` (`id`, `user_id`, `name`, `type`, `target_amount`, `current_amount`, `target_date`, `color_hex`) VALUES
(1, 1, 'ip', 'Income', 200.00, 0.00, '2025-11-26', NULL),
(2, 2, 'nabung mercy', 'Income', 1500000.00, 0.00, '2025-11-26', NULL),
(3, 2, 'Umroh', 'Income', 15000000.00, 0.00, '2025-11-26', NULL),
(4, 2, 'Naik haji', 'Income', 40000000.00, 0.00, '2025-12-16', NULL),
(5, 4, 'Naik Haji', 'Income', 40000000.00, 0.00, '2025-12-17', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `account_id` int(11) DEFAULT NULL,
  `category_id` int(11) DEFAULT NULL,
  `budget_id` int(11) DEFAULT NULL,
  `goal_id` int(11) DEFAULT NULL,
  `amount` decimal(15,2) DEFAULT NULL,
  `transaction_date` datetime DEFAULT NULL,
  `note` text DEFAULT NULL,
  `related_transaction_id` int(11) DEFAULT NULL,
  `created_at` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`id`, `user_id`, `account_id`, `category_id`, `budget_id`, `goal_id`, `amount`, `transaction_date`, `note`, `related_transaction_id`, `created_at`) VALUES
(1, 1, 1, 1, NULL, NULL, -3500.00, '2025-11-24 19:45:47', 'jajan', NULL, '2025-11-24 19:46:26'),
(2, 1, 1, 2, 3, NULL, -670.00, '2025-11-25 03:32:25', 'weew', NULL, '2025-11-25 03:32:35'),
(3, 1, 1, 1, 2, NULL, -250000.00, '2025-11-25 03:32:48', 'jajaja', NULL, '2025-11-25 03:33:03'),
(4, 1, 1, 4, 1, NULL, -5.00, '2025-11-25 03:34:11', '3r3', NULL, '2025-11-25 03:34:19'),
(5, 1, 1, 4, NULL, 1, -67.00, '2025-11-25 04:15:01', 'cd', NULL, '2025-11-25 04:15:17'),
(6, 1, 1, 4, NULL, 1, -67.00, '2025-11-25 04:15:43', '-32', NULL, '2025-11-25 04:16:06'),
(7, 1, 1, 5, NULL, 1, 25.00, '2025-11-25 09:30:12', 'belii', NULL, '2025-11-25 09:31:00'),
(8, 1, 1, 6, NULL, 1, 67.00, '2025-11-25 09:31:12', 'fgesgse', NULL, '2025-11-25 09:31:22'),
(9, 1, 1, 6, 2, NULL, 120000.00, '2025-11-25 09:32:04', 'deded', NULL, '2025-11-25 09:32:20'),
(11, 2, 3, 6, NULL, 2, 67200000.00, '2025-11-25 14:32:59', 'beli ', NULL, '2025-11-25 14:33:26'),
(13, 2, 6, 2, 7, NULL, -400000.00, '2025-11-25 14:49:59', 'beli skok', NULL, '2025-11-25 14:50:19'),
(14, 2, 6, 2, 7, NULL, -120000.00, '2025-11-23 14:50:43', 'beli stiker', NULL, '2025-11-25 14:51:01'),
(15, 2, 3, 4, 7, NULL, -50000.00, '2025-11-21 14:51:25', 'servis ban dalam', NULL, '2025-11-25 14:51:43'),
(16, 2, 6, 3, 7, NULL, -640000.00, '2025-11-12 14:51:47', 'servis velg', NULL, '2025-11-25 14:52:10'),
(17, 2, 8, 1, NULL, NULL, -67000.00, '2025-11-04 14:53:33', 'beli scoop', NULL, '2025-11-25 14:53:52'),
(18, 2, 5, 6, NULL, 4, 2000000.00, '2025-10-23 15:07:36', 'nabung haji', NULL, '2025-11-25 15:08:24'),
(19, 2, 3, 4, NULL, NULL, -67660.00, '2025-11-25 16:04:43', 'rest', NULL, '2025-11-25 16:05:01'),
(21, 4, 13, 1, 9, NULL, -340000.00, '2025-11-24 17:47:24', 'Risol', NULL, '2025-11-25 17:47:49'),
(22, 4, 13, 5, NULL, 5, 5000000.00, '2025-11-25 17:47:58', 'Nabung haji', NULL, '2025-11-25 17:48:23'),
(23, 4, 13, 5, NULL, 5, 37000000.00, '2026-01-01 17:49:07', 'nyicil haji lagi', NULL, '2025-11-25 17:49:38'),
(24, 4, 13, 3, 9, NULL, -210000.00, '2025-10-23 17:49:52', 'Padang', NULL, '2025-11-25 17:50:24'),
(25, 4, 13, 3, 9, NULL, -670000.00, '2025-11-19 17:50:42', 'padang', NULL, '2025-11-25 17:51:08');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password_hash` varchar(255) NOT NULL,
  `full_name` varchar(100) DEFAULT NULL,
  `created_at` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password_hash`, `full_name`, `created_at`) VALUES
(1, 'alvito', '123', 'Muhammad Alvito', '2025-11-24 19:30:53'),
(2, 'nova', '4297F44B13955235245B2497399D7A93', 'nova', '2025-11-25 10:52:54'),
(3, 'fufufafa', '4297F44B13955235245B2497399D7A93', 'fufufafa', '2025-11-25 15:09:37'),
(4, 'deva', '4297F44B13955235245B2497399D7A93', 'Deva', '2025-11-25 17:40:13');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `currency_code` (`currency_code`);

--
-- Indexes for table `budgets`
--
ALTER TABLE `budgets`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `currencies`
--
ALTER TABLE `currencies`
  ADD PRIMARY KEY (`code`);

--
-- Indexes for table `goals`
--
ALTER TABLE `goals`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `account_id` (`account_id`),
  ADD KEY `category_id` (`category_id`),
  ADD KEY `budget_id` (`budget_id`),
  ADD KEY `goal_id` (`goal_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `budgets`
--
ALTER TABLE `budgets`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `goals`
--
ALTER TABLE `goals`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `accounts`
--
ALTER TABLE `accounts`
  ADD CONSTRAINT `accounts_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `accounts_ibfk_2` FOREIGN KEY (`currency_code`) REFERENCES `currencies` (`code`);

--
-- Constraints for table `budgets`
--
ALTER TABLE `budgets`
  ADD CONSTRAINT `budgets_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);

--
-- Constraints for table `categories`
--
ALTER TABLE `categories`
  ADD CONSTRAINT `categories_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);

--
-- Constraints for table `goals`
--
ALTER TABLE `goals`
  ADD CONSTRAINT `goals_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`);

--
-- Constraints for table `transactions`
--
ALTER TABLE `transactions`
  ADD CONSTRAINT `transactions_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `transactions_ibfk_2` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`id`),
  ADD CONSTRAINT `transactions_ibfk_3` FOREIGN KEY (`category_id`) REFERENCES `categories` (`id`),
  ADD CONSTRAINT `transactions_ibfk_4` FOREIGN KEY (`budget_id`) REFERENCES `budgets` (`id`),
  ADD CONSTRAINT `transactions_ibfk_5` FOREIGN KEY (`goal_id`) REFERENCES `goals` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
