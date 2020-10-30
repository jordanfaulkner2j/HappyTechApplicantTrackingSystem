-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 27, 2020 at 09:14 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `applicant_tracking_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `applicant`
--

CREATE TABLE `applicant` (
  `applicant_id` int(4) NOT NULL COMMENT '1 to 9,999',
  `user_id` int(5) NOT NULL,
  `date_of_birth` date NOT NULL COMMENT 'yyyy-mm-dd',
  `national_insurance_number` varchar(9) NOT NULL COMMENT '9 characters without spaces'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `application`
--

CREATE TABLE `application` (
  `application_id` int(4) NOT NULL COMMENT '1 to 9,999',
  `applicant_id` int(4) NOT NULL,
  `employee_id` int(4) DEFAULT NULL,
  `date_submitted` date NOT NULL COMMENT 'current date',
  `resume` blob NOT NULL COMMENT 'file',
  `interviewed` bit(1) NOT NULL COMMENT 'set to 1 for true',
  `feedback_left` bit(1) NOT NULL COMMENT 'set to 1 for true',
  `feedback_sent` bit(1) NOT NULL COMMENT 'set to 1 for true'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `application_for_job_position`
--

CREATE TABLE `application_for_job_position` (
  `job_position_id` int(2) NOT NULL,
  `application_id` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `comment`
--

CREATE TABLE `comment` (
  `comment_id` int(3) NOT NULL COMMENT '1 to 999',
  `section_id` int(2) NOT NULL,
  `code` VARCHAR(4) NOT NULL COMMENT '2 letters for identifying section and 2 digits for comment',
  `comment` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `employee_id` int(4) NOT NULL COMMENT '1 to 9,999',
  `user_id` int(5) NOT NULL,
  `job_title` varchar(25) NOT NULL,
  `photo` blob DEFAULT NULL COMMENT 'file',
  `password` varchar(256) NOT NULL COMMENT 'hash size for the SHA256 algorithm is 256 bits',
  `administrator` bit(1) NOT NULL COMMENT 'set to 1 for admin rights'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `feedback`
--

CREATE TABLE `feedback` (
  `feedback_id` int(4) NOT NULL COMMENT '1 to 9,999',
  `application_id` int(4) NOT NULL,
  `template_id` int(2) NOT NULL,
  `date_created` date NOT NULL COMMENT 'current date',
  `feedback_file` blob NOT NULL COMMENT 'file'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `job_position`
--

CREATE TABLE `job_position` (
  `job_position_id` int(2) NOT NULL COMMENT '1 to 99',
  `title` varchar(25) NOT NULL,
  `job_requirements` text NOT NULL,
  `responsibilities` text NOT NULL,
  `salary` decimal(10,2) NOT NULL COMMENT '2 decimal places'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `list_of_comments`
--

CREATE TABLE `list_of_comments` (
  `comment_id` int(3) NOT NULL,
  `template_id` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `section`
--

CREATE TABLE `section` (
  `section_id` int(2) NOT NULL COMMENT '1 to 99',
  `title` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `template`
--

CREATE TABLE `template` (
  `template_id` int(2) NOT NULL COMMENT '1 to 99',
  `title` varchar(25) NOT NULL,
  `header` text NOT NULL,
  `footer` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_id` int(5) NOT NULL COMMENT '1 to 99,999',
  `title` enum('Mr','Mrs','Miss','Ms','Dr') DEFAULT NULL COMMENT 'Mr, Mrs, Miss, Ms, Dr',
  `first_name` varchar(25) NOT NULL,
  `middle_names` varchar(50) DEFAULT NULL,
  `last_name` varchar(25) NOT NULL,
  `email_address` varchar(100) NOT NULL,
  `mobile_number` varchar(15) NOT NULL COMMENT 'personal phone number',
  `work_number` varchar(15) DEFAULT NULL COMMENT 'work or home phone number'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for table `applicant`
--
ALTER TABLE `applicant`
  ADD PRIMARY KEY (`applicant_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `application`
--
ALTER TABLE `application`
  ADD PRIMARY KEY (`application_id`),
  ADD KEY `applicant_id` (`applicant_id`),
  ADD KEY `employee_id` (`employee_id`);

--
-- Indexes for table `application_for_job_position`
--
ALTER TABLE `application_for_job_position`
  ADD PRIMARY KEY (`job_position_id`,`application_id`),
  ADD KEY `application_id` (`application_id`);

--
-- Indexes for table `comment`
--
ALTER TABLE `comment`
  ADD PRIMARY KEY (`comment_id`),
  ADD KEY `section_id` (`section_id`),
  ADD UNIQUE KEY `code` (`code`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`employee_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `feedback`
--
ALTER TABLE `feedback`
  ADD PRIMARY KEY (`feedback_id`),
  ADD KEY `application_id` (`application_id`),
  ADD KEY `template_id` (`template_id`);

--
-- Indexes for table `job_position`
--
ALTER TABLE `job_position`
  ADD PRIMARY KEY (`job_position_id`);

--
-- Indexes for table `list_of_comments`
--
ALTER TABLE `list_of_comments`
  ADD PRIMARY KEY (`comment_id`,`template_id`),
  ADD KEY `template_id` (`template_id`);

--
-- Indexes for table `section`
--
ALTER TABLE `section`
  ADD PRIMARY KEY (`section_id`);

--
-- Indexes for table `template`
--
ALTER TABLE `template`
  ADD PRIMARY KEY (`template_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for table `applicant`
--
ALTER TABLE `applicant`
  MODIFY `applicant_id` int(4) NOT NULL AUTO_INCREMENT COMMENT '1 to 9,999';

--
-- AUTO_INCREMENT for table `application`
--
ALTER TABLE `application`
  MODIFY `application_id` int(4) NOT NULL AUTO_INCREMENT COMMENT '1 to 9,999';

--
-- AUTO_INCREMENT for table `comment`
--
ALTER TABLE `comment`
  MODIFY `comment_id` int(3) NOT NULL AUTO_INCREMENT COMMENT '1 to 999';

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `employee_id` int(4) NOT NULL AUTO_INCREMENT COMMENT '1 to 9,999';

--
-- AUTO_INCREMENT for table `feedback`
--
ALTER TABLE `feedback`
  MODIFY `feedback_id` int(4) NOT NULL AUTO_INCREMENT COMMENT '1 to 9,999';

--
-- AUTO_INCREMENT for table `job_position`
--
ALTER TABLE `job_position`
  MODIFY `job_position_id` int(2) NOT NULL AUTO_INCREMENT COMMENT '1 to 99';

--
-- AUTO_INCREMENT for table `section`
--
ALTER TABLE `section`
  MODIFY `section_id` int(2) NOT NULL AUTO_INCREMENT COMMENT '1 to 99';

--
-- AUTO_INCREMENT for table `template`
--
ALTER TABLE `template`
  MODIFY `template_id` int(2) NOT NULL AUTO_INCREMENT COMMENT '1 to 99';

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(5) NOT NULL AUTO_INCREMENT COMMENT '1 to 99,999';

--
-- Constraints for table `applicant`
--
ALTER TABLE `applicant`
  ADD CONSTRAINT `applicant_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `application`
--
ALTER TABLE `application`
  ADD CONSTRAINT `application_ibfk_1` FOREIGN KEY (`applicant_id`) REFERENCES `applicant` (`applicant_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `application_ibfk_2` FOREIGN KEY (`employee_id`) REFERENCES `employee` (`employee_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `application_for_job_position`
--
ALTER TABLE `application_for_job_position`
  ADD CONSTRAINT `application_for_job_position_ibfk_1` FOREIGN KEY (`application_id`) REFERENCES `application` (`application_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `application_for_job_position_ibfk_2` FOREIGN KEY (`job_position_id`) REFERENCES `job_position`(`job_position_id`) ON DELETE RESTRICT ON UPDATE CASCADE;

--
-- Constraints for table `comment`
--
ALTER TABLE `comment`
  ADD CONSTRAINT `comment_ibfk_1` FOREIGN KEY (`section_id`) REFERENCES `section` (`section_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `employee`
--
ALTER TABLE `employee`
  ADD CONSTRAINT `employee_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `feedback`
--
ALTER TABLE `feedback`
  ADD CONSTRAINT `feedback_ibfk_1` FOREIGN KEY (`application_id`) REFERENCES `application` (`application_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `feedback_ibfk_2` FOREIGN KEY (`template_id`) REFERENCES `template` (`template_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `list_of_comments`
--
ALTER TABLE `list_of_comments`
  ADD CONSTRAINT `list_of_comments_ibfk_1` FOREIGN KEY (`comment_id`) REFERENCES `comment` (`comment_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `list_of_comments_ibfk_2` FOREIGN KEY (`template_id`) REFERENCES `template` (`template_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
