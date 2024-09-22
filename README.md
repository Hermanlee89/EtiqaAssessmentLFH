# EtiqaAssessmentLFH

# cshtml:
## Index  - Home/Main page with data return from DB.
###  Edit link to Edit.cshtml.
###  Delete link to delete (UserCOntroller.cs).
###  Create link to Create.cshtml.
## Create - New user creation. (Razor component)
## Edit   - Edit user. (Razor component)

# UserController.cs:
## Index() - HttpGet to return DB result and display in table as (Username, Mail, PhoneNo, Skillsets, Hobby).
## Create() - Return view of table as input for create new user.
## Create(userModel user) - To insert input into DB. (Created/Update date fields as date time today.)
## Edit(int id) - Return view of table as input for update existing user.
## Edit(int id, userModel user) - To update data into DB. (Update date fields as date time today, Created date fields status quo.)
## Delete(int id) - To delete the selected data from DB.

# userModel.cs:
## Models for user fields.

# userContext.cs:
## DbContext

# Program.cs:
## Added DB connection string.

# appsettings.json
## Added DB ConnectionStrings

# Database: Microsoft SQL server
## Database = EtiqaAssessment, User Id = EtiqaDBuser1, Password = DBuser$1
### Table = Users