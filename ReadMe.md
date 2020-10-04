# Applicant Tracking System

The company HappyTech is growing and advertises a significant number of positions. Therefore, the number of applications they have to deal with is increasing too. The company’s policy is to respond to both successful and unsuccessful applications by sending them feedback. As writing up letters for every applicant takes a lot of time, the company identified an ontology that could be used by a software application to generate the feedback. The feedback application will be used by anybody involved in reviewing the applications.

## Requirements

#### Create, edit, delete a template
A template has
* a header containing relevant information about the person the feedback is for, the person giving the feedback and what the feedback is for: CV, interview, technical interview, etc.
* a number of sections. Each section contains a title, a list of pairs of codes and the comments to be included in the feedback. The template can be used to review the applications for one or more positions advertised.

#### Generate feedback
Before the feedback writing process starts, the template to be used has to be selected. The feedback window contains the header, the sections with the codes that can be selected via checkboxes or radio buttons and a text box for free comment. The feedback is saved as a pdf file using the applicant’s code or name.

#### Email the applicants the feedback
The emails should be sent automatically, in bulk once all interviews for a position are completed.

## User Stories

#### As a recruiter of HappyTech, I want to
* be able to log in to the system in order to review applications.
* have an option to reset my password in case I forget it.
* create new feedback templates and edit or delete existing templates.
* search for applications by job position or applicant's name.
* select application for review and generate feedback for the applicant.
* email back feedback after all applicants have been interviewed.

#### As an administrator, I want to
* log in to the system in order to manage employees' accounts.
* add, edit or delete accounts and change their permissions.
* reset employee's password manually.

#### As an applicant, I want to
* apply by filling out the required form and attaching a CV.
* view the status of my application.
* ask a question about the job position or application process.
