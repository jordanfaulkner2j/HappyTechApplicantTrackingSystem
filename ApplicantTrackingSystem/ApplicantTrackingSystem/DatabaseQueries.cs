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
        // table of employees (id, full name, email address, job title, administrator privileges)
        public const string EMPLOYEES = "SELECT employee.employee_id, users.first_name, users.middle_names, users.last_name, users.email_address, employee.job_title, employee.administrator FROM employee INNER JOIN users ON employee.user_id = users.user_id";

        // table of applicants (id, full name, email address, job position, date submitted, checkboxes for interviewed, feedback given and feedback sent)
        public const string APPLICANTS = "SELECT applicant.applicant_id, users.first_name, users.middle_names, users.last_name, users.email_address, job_position.title, applications.date_submitted, applications.interviewed, applications.feedback_left, applications.feedback_sent FROM((((applicant INNER JOIN users ON applicant.user_id = users.user_id) INNER JOIN applications ON applicant.applicant_id = applications.applicant_id) INNER JOIN application_for_job_position on applications.application_id = application_for_job_position.application_id) INNER JOIN job_position on application_for_job_position.job_position_id = job_position.job_position_id)";

        // table of templates (id, title, header, footer)
        public const string TEMPLATES = "SELECT * FROM template";

        // attribute called password
        public const string PASSWORD = "SELECT employee.password FROM employee INNER JOIN users ON employee.user_id = users.user_id";

        // attribute called administrator (checkbox whether employee has admin privileges)
        public const string IS_ADMIN = "SELECT employee.administrator FROM employee INNER JOIN users ON employee.user_id = users.user_id";

        /// <summary>
        /// insert queries
        /// </summary>
        // example insert query
        const string INSERT_EMPLOYEE = "INSERT INTO employee (employee_id, user_id, job_title, password, administrator) VALUES (NULL, '1', 'HappyTech Administrator', 'c1c224b03cd9bc7b6a86d77f5dace40191766c485cd55dc48caf9ac873335d6f', '1')";

        /// <summary>
        /// retrieve query for employee's password
        /// </summary>
        /// <param name="employeeEmail">query based on employee's email</param>
        /// <returns>sqlQuery, attributeName</returns>
        public static (string sqlQuery, string attributeName) GetEmployeePassword(string employeeEmail)
        {
            return (string.Format("{0} WHERE users.email_address = '{1}'", DatabaseQueries.PASSWORD, employeeEmail), "password");
        }

        /// <summary>
        /// retrieve query to check if employee has administrator privileges
        /// </summary>
        /// <param name="employeeEmail">query based on employee's email</param>
        /// <returns>sqlQuery, attributeName</returns>
        public static (string sqlQuery, string attributeName) IsEmployeeAdmin(string employeeEmail)
        {
            return (string.Format("{0} WHERE users.email_address = '{1}'", DatabaseQueries.IS_ADMIN, employeeEmail), "administrator");
        }
    }
}
