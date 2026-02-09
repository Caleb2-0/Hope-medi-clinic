-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Oct 18, 2023 at 04:18 AM
-- Server version: 5.7.36
-- PHP Version: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hope_medi_clinic`
--

-- --------------------------------------------------------

--
-- Table structure for table `appointments`
--

DROP TABLE IF EXISTS `appointments`;
CREATE TABLE IF NOT EXISTS `appointments` (
  `app_id` varchar(20) NOT NULL,
  `staff_id` varchar(20) DEFAULT NULL,
  `client_id` varchar(20) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `time` time DEFAULT NULL,
  `state` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`app_id`)
) ENGINE=MyISAM DEFAULT CHARSET=hp8;

--
-- Dumping data for table `appointments`
--

INSERT INTO `appointments` (`app_id`, `staff_id`, `client_id`, `date`, `time`, `state`) VALUES
('APMT:5T1dXM6U0x', '', 'CLT-GT5hol6aeb', '2023-10-12', '05:00:00', 'Active'),
('APMT:PPNJhJzAsx', '', 'CLT-GT5hol6aeb', '2023-10-12', '08:00:00', 'Active'),
('APMT:A6MoEmYKTk', 'STF-fkj3WaJ7gn', 'CLT-GT5hol6aeb', '2023-10-12', '09:00:00', 'Active'),
('APMT:feq16b7sXl', 'STF-fkj3WaJ7gn', 'CLT-GT5hol6aeb', '2023-10-13', '08:00:00', 'Active'),
('APMT:A6qaOA2pdb', 'STF-byvuwL38B6', 'CLT-GT5hol6aeb', '2023-10-17', '07:00:00', 'Cancelled'),
('APMT:9sLakJAdGS', 'STF-fkj3WaJ7gn', 'CLT-8rn8XfdLTr', '2023-10-17', '00:00:00', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

DROP TABLE IF EXISTS `cart`;
CREATE TABLE IF NOT EXISTS `cart` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `order_id` varchar(50) NOT NULL,
  `invent_id` varchar(50) NOT NULL,
  `supplier_id` varchar(50) NOT NULL,
  `quantity` int(3) NOT NULL,
  `cost` float NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=hp8;

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
CREATE TABLE IF NOT EXISTS `clients` (
  `client_id` varchar(20) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `date_of_birth` date NOT NULL,
  `age` int(3) NOT NULL,
  `past_conditions` varchar(256) DEFAULT 'NONE',
  `address` varchar(50) NOT NULL,
  `phone_number` varchar(30) NOT NULL,
  `email` varchar(128) NOT NULL,
  PRIMARY KEY (`client_id`)
) ENGINE=MyISAM DEFAULT CHARSET=hp8;

--
-- Dumping data for table `clients`
--

INSERT INTO `clients` (`client_id`, `first_name`, `last_name`, `gender`, `date_of_birth`, `age`, `past_conditions`, `address`, `phone_number`, `email`) VALUES
('CLT-GT5hol6aeb', 'Caleb', 'Namvula', 'Male', '1999-09-29', 24, 'NONE', 'No.1 Chilinde', '0992247334', 'namvulacaleb@gmail.com'),
('CLT-8rn8XfdLTr', 'debora', 'chikafa', 'Female', '2003-07-15', 20, 'NONE', 'Area 25 A', '0992247334', 'debora@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `diagonosis`
--

DROP TABLE IF EXISTS `diagonosis`;
CREATE TABLE IF NOT EXISTS `diagonosis` (
  `diagonosis_id` varchar(45) NOT NULL,
  `app_id` varchar(50) DEFAULT NULL,
  `symptoms` varchar(1000) DEFAULT NULL,
  `test` varchar(256) DEFAULT NULL,
  `result` varchar(45) DEFAULT NULL,
  `date` date DEFAULT NULL,
  PRIMARY KEY (`diagonosis_id`)
) ENGINE=MyISAM DEFAULT CHARSET=hp8;

--
-- Dumping data for table `diagonosis`
--

INSERT INTO `diagonosis` (`diagonosis_id`, `app_id`, `symptoms`, `test`, `result`, `date`) VALUES
('DGNS:8mkbu9atdb', 'APMT:8wWTNo3EgB', 'Fever', 'Malaria', 'Positive', '2023-10-11'),
('DGNS:EHljoz5M9G', 'APMT:EHljoz5M9G', 'Headache', 'Mindgrains', 'Positive', '2023-10-12'),
('DGNS:8HHqK5K9bI', 'APMT:8HHqK5K9bI', 'Nausea', 'Malaria', 'Positive', '2023-10-12'),
('DGNS:hB7NbqBRuT', 'APMT:5T1dXM6U0x', 'Fever', 'Malaria', 'Positive', '2023-10-12'),
('DGNS:rNwNRx1as9', 'APMT:5T1dXM6U0x', 'fever', 'malaria', 'Positive', '2023-10-17'),
('DGNS:sGiPBHVgEG', 'APMT:9sLakJAdGS', 'nausesa', 'malaria', NULL, '2023-10-17');

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

DROP TABLE IF EXISTS `inventory`;
CREATE TABLE IF NOT EXISTS `inventory` (
  `invent_id` varchar(50) NOT NULL,
  `name` varchar(128) NOT NULL,
  `unit` varchar(50) NOT NULL,
  `cost_price` float NOT NULL,
  `selling_price` float NOT NULL,
  `quantity` int(3) NOT NULL,
  PRIMARY KEY (`invent_id`)
) ENGINE=MyISAM DEFAULT CHARSET=hp8;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`invent_id`, `name`, `unit`, `cost_price`, `selling_price`, `quantity`) VALUES
('IVENT-HwufXWBBMK', 'Panado', 'Bottle', 10000, 100, 496),
('INVENT', 'Null', 'btl', 35, 35, 2),
('IVENT-cmvkt8zJSk', 'Lonart', 'box', 20000, 4000, 200);

-- --------------------------------------------------------

--
-- Table structure for table `inventory_supplier`
--

DROP TABLE IF EXISTS `inventory_supplier`;
CREATE TABLE IF NOT EXISTS `inventory_supplier` (
  `invent_id` varchar(50) NOT NULL,
  `supplier_id` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=hp8;

--
-- Dumping data for table `inventory_supplier`
--

INSERT INTO `inventory_supplier` (`invent_id`, `supplier_id`) VALUES
('IVENT-HwufXWBBMK', 'SPLRnPI4SgH08z'),
('IVENT-cmvkt8zJSk', 'SPLRnPI4SgH08z'),
('IVENT-HwufXWBBMK', 'SPLRxOn4XGXWNC');

-- --------------------------------------------------------

--
-- Table structure for table `logs`
--

DROP TABLE IF EXISTS `logs`;
CREATE TABLE IF NOT EXISTS `logs` (
  `serial` int(100) NOT NULL AUTO_INCREMENT,
  `staff_id` varchar(50) NOT NULL,
  `login_time` varchar(50) NOT NULL,
  `logout_time` varchar(50) DEFAULT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`serial`)
) ENGINE=MyISAM AUTO_INCREMENT=88 DEFAULT CHARSET=hp8;

--
-- Dumping data for table `logs`
--

INSERT INTO `logs` (`serial`, `staff_id`, `login_time`, `logout_time`, `date`) VALUES
(1, 'STF-L2RaBSLbUB', '9:33:17 am', '10:10:03 am', '2023-10-11'),
(2, 'STF-L2RaBSLbUB', '9:38:30 am', '10:10:03 am', '2023-10-11'),
(3, 'STF-L2RaBSLbUB', '9:39:45 am', '10:10:03 am', '2023-10-11'),
(4, 'STF-L2RaBSLbUB', '9:51:52 am', '10:10:03 am', '2023-10-11'),
(5, 'STF-L2RaBSLbUB', '9:58:29 am', '10:10:03 am', '2023-10-11'),
(6, 'STF-fkj3WaJ7gn', '10:00:34 am', '10:11:19 am', '2023-10-11'),
(7, 'STF-Lg9VtDTzFK', '10:01:23 am', '10:01:48 am', '2023-10-11'),
(8, 'STF-fkj3WaJ7gn', '10:02:04 am', '10:11:19 am', '2023-10-11'),
(9, '[value-1]', '10:03:04 am', '10:12:18 am', '2023-10-11'),
(10, 'STF-fkj3WaJ7gn', '10:04:50 am', '10:11:19 am', '2023-10-11'),
(11, 'STF-L2RaBSLbUB', '10:05:45 am', '10:10:03 am', '2023-10-11'),
(12, 'STF-fkj3WaJ7gn', '10:10:10 am', '10:11:19 am', '2023-10-11'),
(13, '[value-1]', '10:11:50 am', '10:12:18 am', '2023-10-11'),
(14, '[value-1]', '10:12:23 am', NULL, '2023-10-11'),
(15, '[value-1]', '10:14:24 am', NULL, '2023-10-11'),
(16, '[value-1]', '10:18:15 am', NULL, '2023-10-11'),
(17, '[value-1]', '10:20:07 am', NULL, '2023-10-11'),
(18, 'STF-L2RaBSLbUB', '8:54:51 pm', NULL, '2023-10-11'),
(19, 'STF-L2RaBSLbUB', '9:30:43 pm', NULL, '2023-10-11'),
(20, '[value-1]', '9:35:05 pm', NULL, '2023-10-11'),
(21, '[value-1]', '9:35:52 pm', NULL, '2023-10-11'),
(22, 'STF-L2RaBSLbUB', '9:41:49 pm', NULL, '2023-10-11'),
(23, '[value-1]', '10:19:38 pm', NULL, '2023-10-11'),
(24, '[value-1]', '10:21:51 pm', NULL, '2023-10-11'),
(25, '[value-1]', '10:24:30 pm', NULL, '2023-10-11'),
(26, '[value-1]', '10:27:35 pm', NULL, '2023-10-11'),
(27, '[value-1]', '10:49:26 pm', NULL, '2023-10-11'),
(28, '[value-1]', '10:51:56 pm', NULL, '2023-10-11'),
(29, '[value-1]', '10:54:40 pm', NULL, '2023-10-11'),
(30, '[value-1]', '5:06:40 am', '9:32:04 am', '2023-10-12'),
(31, '[value-1]', '5:10:09 am', '9:32:04 am', '2023-10-12'),
(32, '[value-1]', '5:11:42 am', '9:32:04 am', '2023-10-12'),
(33, '[value-1]', '5:14:40 am', '9:32:04 am', '2023-10-12'),
(34, '[value-1]', '5:18:31 am', '9:32:04 am', '2023-10-12'),
(35, 'STF-fkj3WaJ7gn', '5:26:33 am', '9:30:03 am', '2023-10-12'),
(36, 'STF-Lg9VtDTzFK', '5:27:22 am', '9:26:34 am', '2023-10-12'),
(37, 'STF-fkj3WaJ7gn', '5:27:52 am', '9:30:03 am', '2023-10-12'),
(38, 'STF-L2RaBSLbUB', '5:29:29 am', '9:28:44 am', '2023-10-12'),
(39, 'STF-fkj3WaJ7gn', '5:33:08 am', '9:30:03 am', '2023-10-12'),
(40, 'STF-L2RaBSLbUB', '5:33:49 am', '9:28:44 am', '2023-10-12'),
(41, '[value-1]', '5:34:41 am', '9:32:04 am', '2023-10-12'),
(42, 'STF-Lg9VtDTzFK', '5:38:34 am', '9:26:34 am', '2023-10-12'),
(43, 'STF-L2RaBSLbUB', '5:38:43 am', '9:28:44 am', '2023-10-12'),
(44, '[value-1]', '5:39:47 am', '9:32:04 am', '2023-10-12'),
(45, 'STF-fkj3WaJ7gn', '5:46:35 am', '9:30:03 am', '2023-10-12'),
(46, 'STF-L2RaBSLbUB', '5:47:33 am', '9:28:44 am', '2023-10-12'),
(47, 'STF-fkj3WaJ7gn', '5:48:17 am', '9:30:03 am', '2023-10-12'),
(48, 'STF-Lg9VtDTzFK', '5:49:16 am', '9:26:34 am', '2023-10-12'),
(49, 'STF-fkj3WaJ7gn', '5:49:42 am', '9:30:03 am', '2023-10-12'),
(50, 'STF-L2RaBSLbUB', '5:51:18 am', '9:28:44 am', '2023-10-12'),
(51, '[value-1]', '5:52:11 am', '9:32:04 am', '2023-10-12'),
(52, '[value-1]', '5:57:02 am', '9:32:04 am', '2023-10-12'),
(53, '[value-1]', '6:00:05 am', '9:32:04 am', '2023-10-12'),
(54, '[value-1]', '7:41:38 am', '9:32:04 am', '2023-10-12'),
(55, '[value-1]', '7:47:03 am', '9:32:04 am', '2023-10-12'),
(56, '[value-1]', '7:50:04 am', '9:32:04 am', '2023-10-12'),
(57, '[value-1]', '7:51:30 am', '9:32:04 am', '2023-10-12'),
(58, '[value-1]', '7:52:56 am', '9:32:04 am', '2023-10-12'),
(59, '[value-1]', '7:54:17 am', '9:32:04 am', '2023-10-12'),
(60, '[value-1]', '7:56:00 am', '9:32:04 am', '2023-10-12'),
(61, '[value-1]', '7:58:36 am', '9:32:04 am', '2023-10-12'),
(62, '[value-1]', '8:06:02 am', '9:32:04 am', '2023-10-12'),
(63, '[value-1]', '8:09:04 am', '9:32:04 am', '2023-10-12'),
(64, '[value-1]', '8:51:44 am', '9:32:04 am', '2023-10-12'),
(65, '[value-1]', '9:18:16 am', '9:32:04 am', '2023-10-12'),
(66, 'STF-fkj3WaJ7gn', '9:25:20 am', '9:30:03 am', '2023-10-12'),
(67, 'STF-Lg9VtDTzFK', '9:26:08 am', '9:26:34 am', '2023-10-12'),
(68, 'STF-fkj3WaJ7gn', '9:26:39 am', '9:30:03 am', '2023-10-12'),
(69, 'STF-L2RaBSLbUB', '9:27:25 am', '9:28:44 am', '2023-10-12'),
(70, 'STF-fkj3WaJ7gn', '9:28:49 am', '9:30:03 am', '2023-10-12'),
(71, '[value-1]', '9:30:09 am', '9:32:04 am', '2023-10-12'),
(72, '[value-1]', '9:56:16 am', '1:02:57 pm', '2023-10-17'),
(73, '[value-1]', '11:11:02 am', '1:02:57 pm', '2023-10-17'),
(74, '[value-1]', '11:17:55 am', '1:02:57 pm', '2023-10-17'),
(75, '[value-1]', '11:19:45 am', '1:02:57 pm', '2023-10-17'),
(76, '[value-1]', '11:23:09 am', '1:02:57 pm', '2023-10-17'),
(77, '[value-1]', '11:25:27 am', '1:02:57 pm', '2023-10-17'),
(78, '[value-1]', '11:27:33 am', '1:02:57 pm', '2023-10-17'),
(79, 'STF-fkj3WaJ7gn', '1:03:07 pm', '1:41:41 pm', '2023-10-17'),
(80, 'STF-Lg9VtDTzFK', '1:12:46 pm', '1:20:48 pm', '2023-10-17'),
(81, 'STF-fkj3WaJ7gn', '1:21:11 pm', '1:41:41 pm', '2023-10-17'),
(82, 'STF-L2RaBSLbUB', '1:40:09 pm', '1:40:25 pm', '2023-10-17'),
(83, 'STF-fkj3WaJ7gn', '1:40:32 pm', '1:41:41 pm', '2023-10-17'),
(84, 'STF-fkj3WaJ7gn', '1:41:37 pm', '1:41:41 pm', '2023-10-17'),
(85, 'STF-L2RaBSLbUB', '1:41:45 pm', NULL, '2023-10-17'),
(86, 'STF-L2RaBSLbUB', '5:56:03 am', '5:56:07 am', '2023-10-18'),
(87, '[value-1]', '5:59:58 am', NULL, '2023-10-18');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
CREATE TABLE IF NOT EXISTS `orders` (
  `serial` int(100) NOT NULL AUTO_INCREMENT,
  `order_id` varchar(50) NOT NULL,
  `invent_id` varchar(50) NOT NULL,
  `supplier_id` varchar(50) NOT NULL,
  `quantity` int(3) NOT NULL,
  `total_cost` float NOT NULL,
  `date` datetime(6) NOT NULL,
  `state` varchar(50) NOT NULL DEFAULT 'Pending',
  PRIMARY KEY (`serial`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=hp8;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`serial`, `order_id`, `invent_id`, `supplier_id`, `quantity`, `total_cost`, `date`, `state`) VALUES
(1, 'ORDf8LuJRTClK', 'IVENT-HwufXWBBMK', 'SPLRnPI4SgH08z', 2, 20000, '2023-10-11 00:00:00.000000', 'Delivered'),
(2, 'ORDloHeNDYfYv', 'IVENT-cmvkt8zJSk', 'SPLRnPI4SgH08z', 2, 40000, '2023-10-12 00:00:00.000000', 'Delivered'),
(3, 'ORDtpA5mvtknK', 'IVENT-HwufXWBBMK', 'SPLRnPI4SgH08z', 4, 40000, '2023-10-12 00:00:00.000000', 'Pending'),
(4, 'ORDXXLo1hObD5', 'IVENT-HwufXWBBMK', 'SPLRxOn4XGXWNC', 1, 10000, '2023-10-17 00:00:00.000000', 'Pending'),
(5, 'ORD5LFu8H5LWS', 'IVENT-HwufXWBBMK', 'SPLRxOn4XGXWNC', 2, 20000, '2023-10-17 00:00:00.000000', 'Delivered'),
(6, 'ORD5LFu8H5LWS', 'IVENT-HwufXWBBMK', 'SPLRxOn4XGXWNC', 2, 20000, '2023-10-17 00:00:00.000000', 'Delivered');

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

DROP TABLE IF EXISTS `payments`;
CREATE TABLE IF NOT EXISTS `payments` (
  `payment_id` varchar(50) NOT NULL,
  `order_id` varchar(50) DEFAULT NULL,
  `name` varchar(128) DEFAULT NULL,
  `cheque_number` varchar(50) DEFAULT NULL,
  `amount` double NOT NULL,
  `purpose` varchar(128) DEFAULT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`payment_id`)
) ENGINE=MyISAM DEFAULT CHARSET=hp8;

--
-- Dumping data for table `payments`
--

INSERT INTO `payments` (`payment_id`, `order_id`, `name`, `cheque_number`, `amount`, `purpose`, `date`) VALUES
('PYMNT0X3xq1HzdM', 'ORDf8LuJRTClK', NULL, '', 20000, 'Medicine & Equipment', '2023-10-11'),
('PYMNTysJ7KI5oAj', 'ORDloHeNDYfYv', NULL, '03412', 40000, 'Medicine & Equipment', '2023-10-12'),
('PYMNTkw50QL2kdv', NULL, 'Escom', '', 10000, 'Utilities', '2023-10-12'),
('PYMNT93vzf5aDrw', NULL, 'Nico', '56478', 100000, 'Rent', '2023-10-12'),
('PYMNTsGVAhNYPIU', 'ORD5LFu8H5LWS', NULL, '', 40000, 'Medicine & Equipment', '2023-10-17'),
('PYMNTMOqiGRKRCn', NULL, 'Water Board', '', 30000, 'Utilities', '2023-10-17');

-- --------------------------------------------------------

--
-- Table structure for table `prescriptions`
--

DROP TABLE IF EXISTS `prescriptions`;
CREATE TABLE IF NOT EXISTS `prescriptions` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `pre_id` varchar(128) NOT NULL,
  `diagonosis_id` varchar(45) DEFAULT NULL,
  `invent_id` varchar(50) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `date` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=hp8;

--
-- Dumping data for table `prescriptions`
--

INSERT INTO `prescriptions` (`id`, `pre_id`, `diagonosis_id`, `invent_id`, `quantity`, `date`) VALUES
(1, 'PPES: 8mE6mgNXzF', 'DGNS:8mkbu9atdb', 'IVENT-HwufXWBBMK', 3, '2023-10-11'),
(2, 'PPES: 7dta6qdMuI', 'DGNS:EHljoz5M9G', 'IVENT-HwufXWBBMK', 2, '2023-10-12'),
(3, 'PPES: uINXP5su6p', 'DGNS:EHljoz5M9G', 'IVENT-cmvkt8zJSk', 1, '2023-10-12'),
(4, 'PPES: mFR5G06dg8', 'DGNS:8HHqK5K9bI', 'IVENT-cmvkt8zJSk', 1, '2023-10-12'),
(5, 'PPES: 48MqiVhsL2', 'DGNS:hB7NbqBRuT', 'IVENT-HwufXWBBMK', 4, '2023-10-12'),
(6, 'PPES: 48MqiVhsL2', 'DGNS:hB7NbqBRuT', 'IVENT-cmvkt8zJSk', 4, '2023-10-12'),
(7, 'PPES: xhHjnXYMiL', 'DGNS:rNwNRx1as9', 'IVENT-cmvkt8zJSk', 1, '2023-10-17'),
(8, 'PPES: xhHjnXYMiL', 'DGNS:rNwNRx1as9', 'IVENT-HwufXWBBMK', 1, '2023-10-17'),
(9, 'PPES: c2DBPVUrmA', 'DGNS:rNwNRx1as9', 'IVENT-cmvkt8zJSk', 2, '2023-10-17'),
(10, 'PPES: c2DBPVUrmA', 'DGNS:rNwNRx1as9', 'IVENT-HwufXWBBMK', 4, '2023-10-17'),
(11, 'PPES: DnpTq1M2jT', 'DGNS:sGiPBHVgEG', 'IVENT-HwufXWBBMK', 2, '2023-10-17');

-- --------------------------------------------------------

--
-- Table structure for table `prescriptions_temp`
--

DROP TABLE IF EXISTS `prescriptions_temp`;
CREATE TABLE IF NOT EXISTS `prescriptions_temp` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `pre_id` text,
  `diagonosis_id` varchar(60) DEFAULT NULL,
  `invent_id` varchar(50) DEFAULT 'INVENT',
  `quantity` int(11) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=hp8;

-- --------------------------------------------------------

--
-- Table structure for table `receipt_temp`
--

DROP TABLE IF EXISTS `receipt_temp`;
CREATE TABLE IF NOT EXISTS `receipt_temp` (
  `temp_id` int(11) NOT NULL AUTO_INCREMENT,
  `invent_id` varchar(45) DEFAULT 'INVENT',
  `service_id` varchar(60) DEFAULT NULL,
  `quantity` int(11) DEFAULT '1',
  `cost` float DEFAULT NULL,
  `date` date DEFAULT NULL,
  `pre_id` varchar(128) DEFAULT NULL,
  `trans_id` varchar(60) NOT NULL,
  PRIMARY KEY (`temp_id`)
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=hp8;

-- --------------------------------------------------------

--
-- Table structure for table `services`
--

DROP TABLE IF EXISTS `services`;
CREATE TABLE IF NOT EXISTS `services` (
  `service_id` varchar(50) NOT NULL,
  `s_name` varchar(128) NOT NULL,
  `cost` float NOT NULL,
  PRIMARY KEY (`service_id`)
) ENGINE=MyISAM DEFAULT CHARSET=hp8;

--
-- Dumping data for table `services`
--

INSERT INTO `services` (`service_id`, `s_name`, `cost`) VALUES
('SRVC-fuPFl7nWKo', 'Consultation', 9000),
('SRVC-SICLX7Eeml', 'HTC', 2000),
('SRVC-WH0AcWjNj5', 'MRI', 5000);

-- --------------------------------------------------------

--
-- Table structure for table `staffs`
--

DROP TABLE IF EXISTS `staffs`;
CREATE TABLE IF NOT EXISTS `staffs` (
  `staff_id` varchar(20) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `date_of_birth` date DEFAULT NULL,
  `age` int(3) NOT NULL,
  `address` varchar(70) NOT NULL,
  `phone_number` varchar(30) NOT NULL,
  `email` varchar(120) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(30) CHARACTER SET latin1 COLLATE latin1_general_cs NOT NULL DEFAULT 'undefined',
  `role` varchar(30) NOT NULL,
  PRIMARY KEY (`staff_id`)
) ENGINE=MyISAM DEFAULT CHARSET=hp8;

--
-- Dumping data for table `staffs`
--

INSERT INTO `staffs` (`staff_id`, `first_name`, `last_name`, `gender`, `date_of_birth`, `age`, `address`, `phone_number`, `email`, `username`, `password`, `role`) VALUES
('[value-1]', '[value-2]', '[value-3]', '', NULL, 0, '[value-4]', '[value-5]', '', 'caleb', '1234', 'Admin'),
('STF-L2RaBSLbUB', 'kelvin', 'simbi', 'Male', '2023-08-15', 0, 'Area 6', '15/08/2023 12:00:00 am', 'kelvins77@gmail.com', 'kenshi', '1234', 'Receiptionist'),
('STF-byvuwL38B6', 'caleb', 'namvula', 'Male', '1998-09-29', 25, 'Area 23.', '0992247334', 'namvulacaleb@gmail.com', 'kayleb', 'default', 'Doctor'),
('STF-fkj3WaJ7gn', 'Blessings', 'Banda', 'Male', '1999-08-15', 24, 'Male', '0992247334', 'namvulacaleb@gmail.com', 'buju', '1234', 'Doctor'),
('STF-Lg9VtDTzFK', 'caleb1', 'banda', '', '2023-08-15', 0, 'c1', '15/08/2023 12:00:00 am', 'clinichope77@gmail.com', 'wati', '1234', 'LabTech');

-- --------------------------------------------------------

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
CREATE TABLE IF NOT EXISTS `suppliers` (
  `supplier_id` varchar(20) NOT NULL,
  `name` varchar(128) NOT NULL,
  `address` varchar(50) NOT NULL,
  `phone_number` varchar(50) NOT NULL,
  `email` varchar(128) NOT NULL,
  `payment_terms` varchar(128) NOT NULL,
  `delivery_terms` varchar(128) NOT NULL,
  PRIMARY KEY (`supplier_id`)
) ENGINE=MyISAM DEFAULT CHARSET=hp8;

--
-- Dumping data for table `suppliers`
--

INSERT INTO `suppliers` (`supplier_id`, `name`, `address`, `phone_number`, `email`, `payment_terms`, `delivery_terms`) VALUES
('SPLRxOn4XGXWNC', 'Caleb', 'Area 13,', '0992247334', 'namvulacaleb@gmail.com', 'Due one week after delivery', 'withing 24 hours');

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

DROP TABLE IF EXISTS `transactions`;
CREATE TABLE IF NOT EXISTS `transactions` (
  `serial` int(11) NOT NULL AUTO_INCREMENT,
  `trans_id` varchar(60) NOT NULL,
  `pre_id` varchar(128) DEFAULT NULL,
  `service_id` varchar(60) DEFAULT NULL,
  `amount` float DEFAULT NULL,
  `date` date DEFAULT NULL,
  PRIMARY KEY (`serial`)
) ENGINE=MyISAM AUTO_INCREMENT=31 DEFAULT CHARSET=hp8;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`serial`, `trans_id`, `pre_id`, `service_id`, `amount`, `date`) VALUES
(1, 'TRANS:bdxRWUMrDG', 'PPES: 8mE6mgNXzF', NULL, 300, '2023-10-11'),
(2, 'TRANS:XabqBJgqnH', 'Customer Name', NULL, 400, '2023-10-11'),
(3, 'TRANS:I7PM21ee2z', 'PPES: 8mE6mgNXzF', NULL, 400, '2023-10-11'),
(4, 'TRANS:ysSHNydmJN', 'PPES: 8mE6mgNXzF', '', 400, '2023-10-11'),
(5, 'TRANS:ysSHNydmJN', '', 'SRVC-fuPFl7nWKo', 9000, '2023-10-11'),
(6, 'TRANS:PhMcfXiXmw', '', 'SRVC-fuPFl7nWKo', 9000, '2023-10-11'),
(7, 'TRANS:XGpDn5Atcf', 'PPES: 8mE6mgNXzF', '', 500, '2023-10-11'),
(8, 'TRANS:Hw85ip7xUR', 'Customer Name', '', 100, '2023-10-11'),
(9, 'TRANS:QCSVcM7q3p', 'PPES: 8mE6mgNXzF', '', 400, '2023-10-11'),
(10, 'TRANS:KW8vPE07H8', 'PPES: 8mE6mgNXzF', '', 400, '2023-10-11'),
(11, 'TRANS:KW8vPE07H8', 'PPES: 8mE6mgNXzF', '', 400, '2023-10-11'),
(12, 'TRANS:KW8vPE07H8', 'PPES: 8mE6mgNXzF', '', 400, '2023-10-11'),
(13, 'TRANS:lhYBfugGGk', 'Customer Name', '', 400, '2023-10-11'),
(14, 'TRANS:U6bknzASlm', '', 'SRVC-fuPFl7nWKo', 9000, '2023-10-11'),
(15, 'TRANS:U6bknzASlm', 'PPES: 8mE6mgNXzF', '', 400, '2023-10-11'),
(16, 'TRANS:3pMXexwxGV', '', 'SRVC-fuPFl7nWKo', 9000, '2023-10-11'),
(17, 'TRANS:vbBbGPXsIX', '', 'SRVC-fuPFl7nWKo', 500000, '2023-10-12'),
(18, 'TRANS:vbBbGPXsIX', 'PPES: 7dta6qdMuI', '', 200, '2023-10-12'),
(19, 'TRANS:lQ7HOcMk4a', '', 'SRVC-fuPFl7nWKo', 9000, '2023-10-12'),
(20, 'TRANS:lQ7HOcMk4a', 'PPES: 7dta6qdMuI', '', 4000, '2023-10-12'),
(21, 'TRANS:LzYXGtBsGg', 'PPES: uINXP5su6p', '', 4000, '2023-10-12'),
(22, 'TRANS:LzYXGtBsGg', '', 'SRVC-fuPFl7nWKo', 9000, '2023-10-12'),
(23, 'TRANS:TzhOoWwUNx', 'PPES: uINXP5su6p', '', 8000, '2023-10-12'),
(24, 'TRANS:TzhOoWwUNx', '', 'SRVC-fuPFl7nWKo', 9000, '2023-10-12'),
(25, 'TRANS:DyVa6UKulI', '', 'SRVC-fuPFl7nWKo', 9000, '2023-10-12'),
(26, 'TRANS:DyVa6UKulI', 'PPES: 48MqiVhsL2', '', 400, '2023-10-12'),
(27, 'TRANS:DyVa6UKulI', 'PPES: 48MqiVhsL2', '', 16000, '2023-10-12'),
(28, 'TRANS:IqBkVXkS8n', 'PPES: c2DBPVUrmA', '', 400, '2023-10-17'),
(29, 'TRANS:IqBkVXkS8n', 'PPES: c2DBPVUrmA', '', 8000, '2023-10-17'),
(30, 'TRANS:IqBkVXkS8n', '', 'SRVC-fuPFl7nWKo', 9000, '2023-10-17');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
