﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantTrackingSystem
{
    class DatabaseQueries
    {
        /// <summary>
        /// search queries
        /// </summary
        // table of users and their details from the table of users (first name, middle names, last name, mobile number, work number, email address)
        public const string USER_DETAILS = "SELECT users.title, users.first_name, users.middle_names, users.last_name, users.mobile_number, users.work_number, users.email_address FROM users";

        // table of employees (full name, email address, job title, administrator privileges)
        public const string EMPLOYEES = "SELECT CONCAT(users.first_name, ' ', CASE WHEN users.middle_names IS NOT NULL THEN CONCAT(users.middle_names, ' ') END, users.last_name) AS 'Full Name', users.email_address AS 'Email Address', employee.job_title AS 'Job Title', CASE WHEN employee.administrator = 1 THEN 'Administrator' ELSE 'User' END AS 'Privileges' FROM employee INNER JOIN users ON employee.user_id = users.user_id";

        // attribute which merges employee's first, middle and last name
        public const string EMPLOYEE_NAME = "SELECT CONCAT(users.first_name, ' ', CASE WHEN users.middle_names IS NOT NULL THEN CONCAT(users.middle_names, ' ') END, users.last_name) AS full_name FROM users INNER JOIN employee ON users.user_id = employee.user_id";

        // attribute called password
        public const string EMPLOYEE_PASSWORD = "SELECT employee.password FROM employee INNER JOIN users ON employee.user_id = users.user_id";

        // attribute called administrator (checkbox whether employee has admin privileges)
        public const string EMPLOYEE_IS_ADMIN = "SELECT employee.administrator FROM employee INNER JOIN users ON employee.user_id = users.user_id";

        // attribute called job position
        public const string EMPLOYEE_JOB_POSITION = "SELECT employee.job_title FROM employee INNER JOIN users ON employee.user_id = users.user_id";

        // attribute called mobile number
        public const string EMPLOYEE_PHONE_NUMBER = "SELECT users.mobile_number FROM users INNER JOIN employee ON users.user_id = employee.user_id";

        // query for selecting specific employee based on their email address
        public const string EMPLOYEE_WHERE_EMAIL = "WHERE users.email_address = '{0}'";

        // table of applicants (id, full name, email address, job position, date submitted, checkboxes for interviewed, feedback given and feedback sent)
        public const string APPLICANTS = "SELECT applicant.applicant_id, users.first_name, users.middle_names, users.last_name, users.email_address, job_position.title, applications.date_submitted, applications.interviewed, applications.feedback_left, applications.feedback_sent FROM ((((applicant INNER JOIN users ON applicant.user_id = users.user_id) INNER JOIN applications ON applicant.applicant_id = applications.applicant_id) INNER JOIN application_for_job_position on applications.application_id = application_for_job_position.application_id) INNER JOIN job_position on application_for_job_position.job_position_id = job_position.job_position_id)";

        // attribute which merges applicant's first, middle and last name
        public const string APPLICANT_NAME = "SELECT CONCAT(users.first_name, ' ', CASE WHEN users.middle_names IS NOT NULL THEN CONCAT(users.middle_names, ' ') END, users.last_name) AS full_name FROM users INNER JOIN applicant ON users.user_id = applicant.user_id";

        // attribute called job position
        public const string APPLICANT_JOB_POSITION = "SELECT job_position.title FROM (((job_position INNER JOIN application_for_job_position ON job_position.job_position_id = application_for_job_position.job_position_id) INNER JOIN applications ON application_for_job_position.application_id = applications.application_id) INNER JOIN applicant ON applications.applicant_id = applicant.applicant_id)";

        // query for selecting specific applicant based on their id
        public const string APPLICANT_WHERE_ID = "WHERE applicant.applicant_id = '{0}'";

        // table of templates (id, title, header, footer)
        public const string TEMPLATES = "SELECT * FROM template";

        // get template_id
        public const string GET_TEMPLATE_ID = "SELECT template_id FROM template WHERE title = '{0}'";

        // get template header
        public const string GET_TEMPLATE_HEADER = "SELECT header FROM template WHERE title ='{0}'";

        // get template footer
        public const string GET_TEMPLATE_FOOTER = "SELECT footer FROM template WHERE title ='{0}'";

        // get template title
        public const string GET_TEMPLATE_TITLE = "SELECT title FROM template WHERE {0} ='{1}'";

        // count number of records in template table
        public const string COUNT_TEMPLATES = "SELECT COUNT(*) FROM template";

        // attribute called comment_id
        public const string GET_COMMENT_ID_LIST = "SELECT comment_id FROM list_of_comments WHERE {0} = '{1}' AND {2} = '{3}'";

        // attribute called comment_id
        public const string GET_COMMENT_ID = "SELECT comment_id FROM comment WHERE {0} = '{1}'";

        // attribute called comment
        public const string GET_COMMENT = "SELECT comment FROM comment WHERE {0} = '{1}'";

        // attribute called code with WHERE condition
        public const string GET_CODE = "SELECT code FROM comment WHERE {0} = '{1}'";

        // get highest comment_id from comment table
        public const string MAX_COMMENT_ID = "SELECT MAX(comment_id) FROM comment";

        // attribute called section_title
        public const string GET_SECTION = "SELECT title FROM section WHERE section_id = '{0}'";

        // attribute called section_id
        public const string GET_SECTION_ID = "SELECT section_id FROM section WHERE title = '{0}'";

        // attribute called section_id, retrieved from comment table
        public const string GET_SECTION_ID_COMMENT = "SELECT section_id FROM comment WHERE {0} = '{1}'";

        // count sections
        public const string COUNT_SECTIONS = "SELECT COUNT(*) FROM section";

        /// <summary>
        /// get complete query for retrieving specified record
        /// </summary>
        /// <param name="baseQuery">basic query listing the attributes to output</param>
        /// <param name="whereQuery">search for record based on specified attribute</param>
        /// <param name="whereAttribute">specified attribute</param>
        /// <returns>fully joined search query</returns>
        public static string GetRecord(string baseQuery, string whereQuery, string whereAttribute)
        {
            return string.Join(" ", baseQuery, string.Format(whereQuery, whereAttribute));
        }

        /// <summary>
        /// update queries
        /// </summary>
        // update (title, first, middle and last names, phone number, work number, email address) for employee with specified email address
        public const string UPDATE_EMPLOYEE_DETAILS = "UPDATE users SET users.title = CASE WHEN '{0}' = '' THEN NULL ELSE '{0}' END, users.first_name = '{1}', users.middle_names = CASE WHEN '{2}' = '' THEN NULL ELSE '{2}' END, users.last_name = '{3}', users.mobile_number = '{4}', users.work_number = CASE WHEN '{5}' = '' THEN NULL ELSE '{5}' END, users.email_address = '{6}'";

        // update (job title and administrator privillages) for employee with specified email address
        public const string UPDATE_EMPLOYEE_ROLE = "UPDATE employee SET employee.job_title = '{0}', employee.administrator = '{1}' FROM employee INNER JOIN users ON employee.user_id = users.user_id";

        // update password for employee with specified email address
        public const string UPDATE_EMPLOYEE_PASSWORD = "UPDATE employee SET employee.password = '{0}' FROM employee INNER JOIN users ON employee.user_id = users.user_id";

        // update comment (code, comment)
        public const string UPDATE_COMMENT = "UPDATE comment SET comment = '{0}' WHERE code = '{1}'";

        // update template (template_id, title, header, footer)
        public const string UPDATE_TEMPLATE = "UPDATE template SET title = '{0}', header = '{1}', footer = '{2}' WHERE template_id = '{3}'";

        // update list_of_comments (comment_id, template_id)
        public const string UPDATE_LIST_OF_COMMENTS = "UPDATE list_of_comments SET comment_id = '{0}', template_id = '{1}' WHERE comment_id = '{2}' AND template_id = '{3}'";

        /// <summary>
        /// retrieve complete query for updating record
        /// </summary>
        /// <param name="baseQuery">basic query with the list of attributes to update</param>
        /// <param name="listOfAttributes">attributes to merge with the query</param>
        /// <param name="whereQuere">where condition</param>
        /// <param name="whereAttribute">where specified value</param>
        /// <returns>full update query</returns>
        public static string UpdateRecord(string baseQuery, string[] listOfAttributes, string whereQuere, string whereAttribute)
        {
            return string.Join(" ", string.Format(baseQuery, listOfAttributes), string.Format(whereQuere, whereAttribute));
        }

        /// <summary>
        /// overload method for retrieving complete query for updating single attribute
        /// </summary>
        /// <param name="baseQuery">basic query with the list of attributes to update</param>
        /// <param name="attribute">single attribute</param>
        /// <param name="whereQuere">where condition</param>
        /// <param name="whereAttribute">where specified value</param>
        /// <returns>full update query for single attribute</returns>
        public static string UpdateRecord(string baseQuery, string attribute, string whereQuere, string whereAttribute)
        {
            return string.Join(" ", string.Format(baseQuery, attribute), string.Format(whereQuere, whereAttribute));
        }

        /// <summary>
        /// insert queries
        /// </summary>
        // insert (title, first, middle and last names, mobile number, work number and email address) into table of users
        public const string INSERT_EMPLOYEE = "INSERT INTO users (title, first_name, middle_names, last_name, mobile_number, work_number, email_address) VALUES (CASE WHEN '{0}' = '' THEN NULL ELSE '{0}' END, '{1}', CASE WHEN '{2}' = '' THEN NULL ELSE '{2}' END, '{3}', '{4}', CASE WHEN '{5}' = '' THEN NULL ELSE '{5}' END, '{6}')";

        // insert (user id, job title, password hash and administrator privillages) into employee using employee's email address to get their user id
        public const string INSERT_EMPLOYEE_ROLE = "INSERT INTO employee (user_id, job_title, password, administrator) VALUES ((SELECT user_id FROM users WHERE users.email_address = '{0}'), '{1}', '{2}', '{3}')";

        // insert into template
        public const string INSERT_TEMPLATE = "INSERT INTO template (title, header, footer) VALUES ('{0}', '{1}', '{2}')";

        // insert into comment
        public const string INSERT_COMMENT = "INSERT INTO comment (section_id, code, comment) VALUES ('{0}', '{1}', '{2}')";

        // insert into list_of_comments
        public const string INSERT_LIST_OF_COMMENTS = "INSERT INTO list_of_comments (comment_id, template_id) VALUES ('{0}', '{1}')";

        /// <summary>
        /// delete queries
        /// </summary>
        // delete employee's account from the users table (cascade relationship deletes linked record from employee table)
        public const string DELETE_EMPLOYEE = "DELETE FROM users WHERE users.email_address = '{0}'";
        
        // delete record from template 
        public const string DELETE_TEMPLATE = "DELETE FROM template WHERE template_id = '{0}'";

        // delete record from comment table
        public const string DELETE_COMMENT = "DELETE FROM comment WHERE comment_id = '{0}'";

        // delete record from list_of_comments table
        public const string DELETE_LIST_OF_COMMENTS = "DELETE FROM list_of_comments WHERE {0} = '{1}' AND {2} = '{3}'";
    }
}
