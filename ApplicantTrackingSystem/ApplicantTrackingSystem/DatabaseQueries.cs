using System;
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
        /// </summary>
        // table of employees (full name, email address, job title, administrator privileges)
        public const string EMPLOYEES = "SELECT CONCAT(users.first_name, ' ', CASE WHEN users.middle_names IS NOT NULL THEN CONCAT(users.middle_names, ' ') END, users.last_name) AS 'Full Name', users.email_address AS 'Email Address', employee.job_title AS 'Job Title', CASE WHEN employee.administrator = 1 THEN 'Administrator' ELSE 'User' END AS 'Privileges' FROM employee INNER JOIN users ON employee.user_id = users.user_id";

        // table of applicants (id, full name, email address, job position, date submitted, checkboxes for interviewed, feedback given and feedback sent)
        public const string APPLICANTS = "SELECT applicant.applicant_id, users.first_name, users.middle_names, users.last_name, users.email_address, job_position.title, applications.date_submitted, applications.interviewed, applications.feedback_left, applications.feedback_sent FROM((((applicant INNER JOIN users ON applicant.user_id = users.user_id) INNER JOIN applications ON applicant.applicant_id = applications.applicant_id) INNER JOIN application_for_job_position on applications.application_id = application_for_job_position.application_id) INNER JOIN job_position on application_for_job_position.job_position_id = job_position.job_position_id)";

        // table of templates (id, title, header, footer)
        public const string TEMPLATES = "SELECT * FROM template";

        // table of applicants and their details from the table of users (id, first name, middle names, last name, email address, mobile number, work number)
        public const string APPLICANT_DETAILS = "SELECT * FROM users applicant INNER JOIN users ON applicant.user_id = users.user_id";

        // table of employees and their details from the table of users (id, first name, middle names, last name, email address, mobile number, work number)
        public const string EMPLOYEE_DETAILS = "SELECT * FROM users employee INNER JOIN users ON employee.user_id = users.user_id";

        // attribute which merges first, middle and last name
        public const string EMPLOYEE_NAME = "SELECT CONCAT(users.first_name, ' ', CASE WHEN users.middle_names IS NOT NULL THEN CONCAT(users.middle_names, ' ') END, users.last_name) AS full_name FROM users INNER JOIN employee ON users.user_id = employee.user_id";

        // attribute called password
        public const string EMPLOYEE_PASSWORD = "SELECT employee.password FROM employee INNER JOIN users ON employee.user_id = users.user_id";

        // attribute called administrator (checkbox whether employee has admin privileges)
        public const string EMPLOYEE_IS_ADMIN = "SELECT employee.administrator FROM employee INNER JOIN users ON employee.user_id = users.user_id";

        // attribute called administrator (checkbox whether employee has admin privileges)
        public const string EMPLOYEE_WHERE_EMAIL = "WHERE users.email_address = '{0}'";

        /// <summary>
        /// retrieve complete query for retrieving employee details with specified email address
        /// </summary>
        /// <param name="sqlQuery">basic query listing the attributes to search for</param>
        /// <param name="employeeEmail">search by specified employee's email</param>
        /// <returns>fully joined query</returns>
        public static string GetRecord(string baseQuery, string whereQuery, string whereAttribute)
        {
            return string.Join(" ", baseQuery, string.Format(whereQuery, whereAttribute));
        }

        /// <summary>
        /// update queries
        /// </summary>
        // attributes (first, middle and last names, email address, phone number, work number) for employee with specified email address
        public const string UPDATE_EMPLOYEE_DETAILS = "UPDATE users SET users.first_name = '{0}', users.middle_names = '{1}', users.last_name = '{2}', users.email_address = '{3}', users.mobile_number = '{4}', users.work_number = '{5}'";

        /// <summary>
        /// retrieve complete query for updating employee details with specified email address
        /// </summary>
        /// <param name="sqlQuery">basic query with the list of attributes to update</param>
        /// <param name="listOfAttributes">attributes to merge with the query</param>
        /// <param name="employeeEmail">update employee details with specified email address</param>
        /// <returns></returns>
        public static string UpdateRecord(string baseQuery, string[] listOfAttributes, string whereQuere, string whereAttribute)
        {
            return string.Join(" ", string.Format(baseQuery, listOfAttributes), string.Format(whereQuere, whereAttribute));
        }

        /// <summary>
        /// insert queries
        /// </summary>
        // example insert query
        //const string INSERT_EMPLOYEE = "INSERT INTO employee (employee_id, user_id, job_title, password, administrator) VALUES (NULL, '1', 'HappyTech Administrator', 'c1c224b03cd9bc7b6a86d77f5dace40191766c485cd55dc48caf9ac873335d6f', '1')";
    }
}
