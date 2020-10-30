--
-- Table data for table `user`
--


INSERT INTO `user` (`user_id`, `title`, `first_name`, `middle_names`, `last_name`, `email_address`, `mobile_number`, `work_number`) VALUES (NULL, 'Dr', 'Admin', NULL, 'Admin', 'admin@example.com', '00447777777777', NULL);
INSERT INTO `user` (`user_id`, `title`, `first_name`, `middle_names`, `last_name`, `email_address`, `mobile_number`, `work_number`) VALUES (NULL, 'Ms', 'Krista', NULL, 'Emmerich', 'allie15@example.com', '00447589229143', NULL);
INSERT INTO `user` (`user_id`, `title`, `first_name`, `middle_names`, `last_name`, `email_address`, `mobile_number`, `work_number`) VALUES (NULL, 'Mrs', 'Vance', NULL, 'Abbott', 'kautzer.selmer@example.com', '00447593726494', NULL);
INSERT INTO `user` (`user_id`, `title`, `first_name`, `middle_names`, `last_name`, `email_address`, `mobile_number`, `work_number`) VALUES (NULL, 'Dr', 'Jordon', NULL, 'Kuhn', 'jamie.rolfson@example.net', '00447938752124', NULL);
INSERT INTO `user` (`user_id`, `title`, `first_name`, `middle_names`, `last_name`, `email_address`, `mobile_number`, `work_number`) VALUES (NULL, 'Mrs', 'Diamond', NULL, 'Block', 'scottie71@example.net', '00447529120397', NULL);

-- --------------------------------------------------------

--
-- Table data for table `employee`
--
INSERT INTO `employee` (`employee_id`, `user_id`, `job_title`, `photo`, `password`, `administrator`) VALUES (NULL, '1', 'HappyTech Administrator', NULL, 'c1c224b03cd9bc7b6a86d77f5dace40191766c485cd55dc48caf9ac873335d6f', b'1');
INSERT INTO `employee` (`employee_id`, `user_id`, `job_title`, `photo`, `password`, `administrator`) VALUES (NULL, '2', 'HappyTech Line Manager', NULL, 'e7cf3ef4f17c3999a94f2c6f612e8a888e5b1026878e4e19398b23bd38ec221a', b'1');
INSERT INTO `employee` (`employee_id`, `user_id`, `job_title`, `photo`, `password`, `administrator`) VALUES (NULL, '3', 'Personnel Manager', NULL, 'e7cf3ef4f17c3999a94f2c6f612e8a888e5b1026878e4e19398b23bd38ec221a', b'0');

-- --------------------------------------------------------

--
-- Table data for table `applicant`
--

INSERT INTO `applicant` (`applicant_id`, `user_id`, `date_of_birth`, `national_insurance_number`) VALUES (NULL, '3', '1999-11-11', 'AB123456C');
INSERT INTO `applicant` (`applicant_id`, `user_id`, `date_of_birth`, `national_insurance_number`) VALUES (NULL, '4', '2000-10-16', 'DE123456F');

-- --------------------------------------------------------

--
-- Table data for table `application`
--

INSERT INTO `application` (`application_id`, `applicant_id`, `employee_id`, `date_submitted`, `interviewed`, `feedback_left`, `feedback_sent`) VALUES (NULL, '1', NULL, '2020-10-15', b'1', b'1', b'1');
INSERT INTO `application` (`application_id`, `applicant_id`, `employee_id`, `date_submitted`, `interviewed`, `feedback_left`, `feedback_sent`) VALUES (NULL, '2', NULL, '2020-10-16', b'1', b'0', b'0');

-- --------------------------------------------------------

--
-- Table data for table `job_position`
--

INSERT INTO `job_position` (`job_position_id`, `title`, `job_requirements`, `responsibilities`, `salary`) VALUES (NULL, 'Software Engineer', 'We are looking for talented individuals with:\na technical degree or equivalent experience with a strong STEM foundation,\nconsistent track record of personal and academic achievements,\nsoftware programming experience, and willingness to learn a new programming language if necessary,\nflexible and can quickly adapt to new challenges and requirements,\ncreative problem solving skills,\nmotivated by challenges and continuous learning.', 'The primary focus of your role will be the development of innovative mobile and web based technology solutions to meet the operationally focused needs of our clients.', '35000');

-- --------------------------------------------------------

--
-- Table data for table `application_for_job_position`
--

INSERT INTO `application_for_job_position` (`job_position_id`, `application_id`) VALUES ('1', '1');
INSERT INTO `application_for_job_position` (`job_position_id`, `application_id`) VALUES ('1', '2');

-- --------------------------------------------------------

--
-- Table data for table `section`
--

INSERT INTO `section` (`section_id`, `title`) VALUES (NULL, 'Resume');
INSERT INTO `section` (`section_id`, `title`) VALUES (NULL, 'Interview');
INSERT INTO `section` (`section_id`, `title`) VALUES (NULL, 'Technical Interview');

-- --------------------------------------------------------

--
-- Table data for table `template`
--

INSERT INTO `template` (`template_id`, `title`, `header`, `footer`) VALUES (NULL, 'Template Title', 'Dear [ApplicantName],', 'Kind Regards,\n[EmployeeName]\nHappy Tech');

-- --------------------------------------------------------

--
-- Table data for table `comment`
--

INSERT INTO `comment` (`comment_id`, `section_id`, `code`, `comment`) VALUES (NULL, '1', 'RE01', 'Resume file missing.');
INSERT INTO `comment` (`comment_id`, `section_id`, `code`, `comment`) VALUES (NULL, '1', 'RE02', 'No references available.');
INSERT INTO `comment` (`comment_id`, `section_id`, `code`, `comment`) VALUES (NULL, '2', 'IN01', 'Arrived late to the interview.');
INSERT INTO `comment` (`comment_id`, `section_id`, `code`, `comment`) VALUES (NULL, '3', 'TI01', 'Good logical thinking.');

-- --------------------------------------------------------

--
-- Table data for table `list_of_comments`
--

INSERT INTO `list_of_comments` (`comment_id`, `template_id`) VALUES ('1', '1');
INSERT INTO `list_of_comments` (`comment_id`, `template_id`) VALUES ('2', '1');
INSERT INTO `list_of_comments` (`comment_id`, `template_id`) VALUES ('3', '1');

-- --------------------------------------------------------

--
-- Table data for table `feedback`
--

INSERT INTO `feedback` (`feedback_id`, `application_id`, `template_id`, `date_created`) VALUES (NULL, '1', '1', '2020-10-22');
INSERT INTO `feedback` (`feedback_id`, `application_id`, `template_id`, `date_created`) VALUES (NULL, '2', '1', '2020-10-22');

-- --------------------------------------------------------