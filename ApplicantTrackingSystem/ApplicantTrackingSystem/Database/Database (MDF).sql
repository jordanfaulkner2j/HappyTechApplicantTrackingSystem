
CREATE TABLE applicant (
  applicant_id int NOT NULL IDENTITY PRIMARY KEY,
  user_id int NOT NULL,
  date_of_birth date NOT NULL,
  national_insurance_number varchar(9) NOT NULL
)

CREATE TABLE applications (
  application_id int NOT NULL IDENTITY PRIMARY KEY,
  applicant_id int NOT NULL,
  employee_id int DEFAULT NULL,
  date_submitted date NOT NULL,
  interviewed bit NOT NULL,
  feedback_left bit NOT NULL,
  feedback_sent bit NOT NULL
)

CREATE TABLE application_for_job_position (
  job_position_id int NOT NULL IDENTITY PRIMARY KEY,
  application_id int NOT NULL
)

CREATE TABLE comment (
  comment_id int NOT NULL IDENTITY PRIMARY KEY,
  section_id int NOT NULL,
  code VARCHAR NOT NULL,
  comment text NOT NULL
)

CREATE TABLE employee (
  employee_id int NOT NULL IDENTITY PRIMARY KEY,
  user_id int NOT NULL,
  job_title varchar(25) NOT NULL,
  password varchar(256) NOT NULL,
  administrator bit NOT NULL
)

CREATE TABLE feedback (
  feedback_id int NOT NULL IDENTITY PRIMARY KEY,
  application_id int NOT NULL,
  template_id int NOT NULL,
  date_created date NOT NULL,
) 

CREATE TABLE job_position (
  job_position_id int NOT NULL IDENTITY PRIMARY KEY,
  title varchar(25) NOT NULL,
  job_requirements text NOT NULL,
  responsibilities text NOT NULL,
  salary decimal(10,2) NOT NULL
)

CREATE TABLE list_of_comments (
  comment_id int NOT NULL IDENTITY PRIMARY KEY,
  template_id int NOT NULL
) 

CREATE TABLE section (
  section_id int NOT NULL IDENTITY PRIMARY KEY,
  title varchar NOT NULL
)

CREATE TABLE template (
  template_id int NOT NULL IDENTITY PRIMARY KEY,
  title varchar(25) NOT NULL,
  header text NOT NULL,
  footer text NOT NULL
)

CREATE TABLE users (
  user_id int NOT NULL IDENTITY PRIMARY KEY,
  first_name varchar(25) NOT NULL,
  middle_names varchar(50) DEFAULT NULL,
  last_name varchar(25) NOT NULL,
  email_address varchar(100) NOT NULL,
  mobile_number varchar(15) NOT NULL,
  work_number varchar(15) DEFAULT NULL
)
ALTER TABLE applicant
  ADD CONSTRAINT applicant_ibfk_1 FOREIGN KEY (user_id) REFERENCES users (user_id) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE applications
  ADD CONSTRAINT application_ibfk_1 FOREIGN KEY (applicant_id) REFERENCES applicant (applicant_id) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE applications
  ADD CONSTRAINT application_ibfk_2 FOREIGN KEY (employee_id) REFERENCES employee (employee_id) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE application_for_job_position
  ADD CONSTRAINT application_for_job_position_ibfk_1 FOREIGN KEY (application_id) REFERENCES applications (application_id) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE application_for_job_position
  ADD CONSTRAINT application_for_job_position_ibfk_2 FOREIGN KEY (job_position_id) REFERENCES job_position(job_position_id) ON DELETE SET DEFAULT ON UPDATE SET DEFAULT;

ALTER TABLE comment
  ADD CONSTRAINT comment_ibfk_1 FOREIGN KEY (section_id) REFERENCES section (section_id) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE employee
  ADD CONSTRAINT employee_ibfk_1 FOREIGN KEY (user_id) REFERENCES users (user_id) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE feedback
  ADD CONSTRAINT feedback_ibfk_1 FOREIGN KEY (application_id) REFERENCES applications (application_id) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE feedback
  ADD CONSTRAINT feedback_ibfk_2 FOREIGN KEY (template_id) REFERENCES template (template_id) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE list_of_comments
  ADD CONSTRAINT list_of_comments_ibfk_1 FOREIGN KEY (comment_id) REFERENCES comment (comment_id) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE list_of_comments
  ADD CONSTRAINT list_of_comments_ibfk_2 FOREIGN KEY (template_id) REFERENCES template (template_id) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;
