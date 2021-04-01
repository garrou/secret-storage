# secret-storage

Hidden application in a functional calculator.  
If calculator user input the correct password (by default "123456") and click on "=", the application close calculator and open login form.  
On login form, you can create an account or login.  
When user is loged, he can store passwords, update his profile picture and profile.  
If user is loged as admin, he can see all users, add a user, delete users.   

Data are stored in **MySQL** database.  

![Alt text](assets/mysql.png?raw=true "MySQL")  

All users password are crypted with **SHA256**.  

• [Microsoft SHA256](https://docs.microsoft.com/fr-fr/dotnet/api/system.security.cryptography.sha256managed?view=net-5.0)  

![Alt text](assets/encrypted.PNG?raw=true "Encrypted")  

## Demo

• Calculator form (Home)  

![Alt text](assets/calculator.PNG?raw=true "Calculator")  

• Login form  

![Alt text](assets/login.PNG?raw=true "Login")  

• User form  

![Alt text](assets/user.PNG?raw=true "User")  

• Admin form  

![Alt text](assets/admin.PNG?raw=true "Admin")  

## Requirements

• [Visual Studio](https://visualstudio.microsoft.com/fr/)  

• [MySQL Server](https://dev.mysql.com/downloads/mysql/)  

• [MySQL Connector/NET](https://dev.mysql.com/downloads/connector/net/)  

## Launching requirements

• To pass the units tests 

**Execute SQL script :** SecretStorage\SecretStorage\src\sql\database.sql  
