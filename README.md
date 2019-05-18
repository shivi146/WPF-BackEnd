# WPF-BackEnd
WPF-BackEnd
In this project there are two set of API's
a) Get form data 
b) Save user details

I have created two layers 
1. Controller(This layer is just for Routing.)
2. Component(This layer is for all the Business logic.)

URL for Get Form Data:We need to send Form Id to fetch the Form Data.
http://localhost:54515/api/FormDetails/GetFormData?FormId=registrationinfo

Response::
{
    "TextBoxes": [
        {
            "Label": "First name",
            "Enabled": true
        },
        {
            "Label": "Last name",
            "Enabled": true
        },
        {
            "Label": "Age",
            "Enabled": false
        }
    ]
}

URL for Save user detail: We need to pass data in body as JSON
http://localhost:54515/api/User/SaveUserDetails

{
	"First Name":"Shivangi",
	"Last Name":"Garg",
	"Age":25	
}

when this data is received in Component/Business Layer it gets printed in Log file as:
2019-05-18 12:43:50,500 [8] INFO  POCDynamicUI.Component.UserComponent - ### Inside Save User Details: FirstName: Shivangi, LastName: Garg , Age: 25 

# How to run the project:
To make this project work you need to create a Json File named as form-registrationinfo.json which must be placed in location C:\Temp.

# Logging:
The Log file will also be generated in the C:\Temp folder.

Note:- THis project is build on .NET framewrok 4.6.1 as after upgrading the projet to 4.7 or 4.7.1
 Unity framework warnings were coming when I updated Unity.WebAPI dependency the Dependency injection stopped working.
 So most of the blogs suggested to move back to previous version.
