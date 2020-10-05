# Applicant Tracking System for HappyTech

The company HappyTech is growing and advertises a significant number of positions. Therefore, the number of applications they have to deal with is increasing too. The company’s policy is to respond to both successful and unsuccessful applications by sending them feedback. As writing up letters for every applicant takes a lot of time, the company identified an ontology that could be used by a software application to generate the feedback. The feedback application will be used by anybody involved in reviewing the applications.

## Requirements

#### Create, edit, delete templates
A template has
* a header containing relevant information about the person the feedback is for, the person giving the feedback and which part of the application (resume, interview, technical interview, etc.) the feedback is for.
* a number of sections. Each section contains a title, a list of pairs of codes and the comments to be included in the feedback. The template can be used to review the applications for one or more positions advertised.

#### Generate feedback
Before the feedback writing process starts, the template to be used has to be selected. The feedback window contains the header, the sections with the codes that can be selected via checkboxes or radio buttons and a text box for free comment. The feedback is saved as a pdf file using the applicant’s code or name.

#### Email the feedback to applicants
The emails should be sent automatically, in bulk once all interviews for a position are completed.

## User Stories

#### As an employee of HappyTech, I want to
* be able to access the system by logging in.
* have an option to reset my password in case I forget it.

#### As a recruiter, I want to
* create new feedback templates and edit or delete existing templates.
* filter applications by job position or search by applicant's name.
* select application for review and generate feedback for the applicant.
* email back feedback after all applicants have been interviewed.

#### As an administrator, I want to
* add, edit or delete employee accounts and change their permissions.
* reset employee's password manually.
