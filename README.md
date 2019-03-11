** AllYear-
Initially no user option to select all payperiods in the current year up to the current date.
Upon creation also added function to populate the begin and end dates with current year pay period
start start and most recent pay period end date.

* EmployerDefault-
The Employer had no default page and they had their pathing updated to default to the employee index.

** ErorrStyling-
On Work Time Events page when there were no dates entered the styling of border and message text was not
properly rendering as the requested red. Changed styling sheet to target the classes associated with those fields.

** LoginPageLogic-
Login page logic did not know when a user was loggwed in and did not require current user logging off to allow
a new user to log in. Logic input to check if someone is logged in and if so the login button changes name and
operation to first log off the user before allowing someone else to log in.

** TimeOffNotes-
Time off request notes were displayed inline and were made to appear underneath the request when the details button
was pressed. Removed details button pathing that redirected to a new page to view notes.

** ValidateMessages-
When invalid information was put into required fields the error messages would not automatically update based on
if valid information was then input without resubmitting the webform. ValidateMessageFor for data revalidation.