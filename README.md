# Test-Management-App User Guide

This is a small-scale test management application aimed to provide an efficient way for teams to manage their software testing processes. Key features include testcase organization, test script configuration, team management, test schedule planning, analytics. This software was made as part of a university thesis.

## Installation notes

The executable file for the project can be found in \Test Management App\bin\Debug.
The database script is included in the project as TestManagementApp_DatabaseScript.sql to rebuild the database .
Edit the connection string in \TestManagementApp\App.config file to connect to your data source.

## Instructions

### Creating new Testcase

1. On Test Library page, click on the "NEW" button.
2. Rewrite the test name.
3. Fill rest of input fields with the desired data.
4. Click on "SAVE" button

### Modifying a Testcase

1. On Test Library page, press left-click on a testcase.
2. In the appeared window, modify the desired values.
3. Press the "SAVE" button.

### Deleting a Testcase

1. On Test Library page, press left-click on a testcase.
2. In the appeared window, click on the "DELETE" button.

### Folder actions

1. On the Test Library page, right click a folder in the Hierarchy.
2. Select the desired action on the appeared context menu.
3. (opt) Select the folder with left click to display the content of that folder.

### Test Execution (manual)

1. On the Test Library page, click on a testcase to open it.
2. Press the "Execute" button on the top row.
3. In the Execution window, press the ▶ button to start the execution timer.
4. (opt) Press the ⏸ button to stop the timer temporarily.
5. Press the ⏹ button, to finsih the execution.
6. In the newly appeared window, select the result of the execution, and add a comment if necessary.
7. (opt) If the execution result is failed, select the step from the list, where the problem occured.
8. Click on the "Save" button to close the window.
9. Click on "Refresh" to display the newly saved execution in the list.

### Team Member actions

1. On the Team page, click on "Add" to add a new team member.
2. On the Team page, select a team member and click on "Edit" to modify the name or role of the team member.
3. On the Team page, click on "Remove" button to remove a team member.

### Add a Test Schedule instance

1. On the Schedule page, double click into a desired day column
2. In the newly opened windown, define the details of the schedule instance. 
3. Write the name or ID of the desired test into the input field to be able to select it from the list.
4. Select an action and optionally the team member for this task.
5. Click on "Save" button to save the schedule instance.

### Modify a Test Schedule instance

1. On the Schedule page, navigate to the desired schedule instance.
2. Left click on the schedule instance.
3. Click on the "Delete" button on the schedule details page.
