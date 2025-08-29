
This project demonstrates how to connect an **ASP.NET Web Forms application** with **SQL Server** using **ADO.NET**.  
It includes a simple form to insert student details (Roll No, Name, Class, Address) into a SQL Server database.
## 🚀 Features
- ASP.NET Web Forms frontend with TextBox, Buttons, and Label controls.
- ADO.NET connection to SQL Server.
- Insert records into the database using `SqlConnection` and `SqlCommand`.
- Displays success or error message after data insertion.
- Reset form fields automatically after successful entry.
## 🛠️ Technologies Used
- **ASP.NET Web Forms (C#)**
- **ADO.NET**
- **SQL Server**

---

## 📂 Project Structure
- `WebForm1.aspx` → UI design (Form with Roll No, Name, Class, Address, Save & Exit buttons, and Label).  
- `WebForm1.aspx.cs` → Code-behind with ADO.NET logic.  
- `userinfo` Database in SQL Server.  

---

## 🗄️ Database Setup

Run the following SQL commands in SQL Server:

```sql
-- Create Database
CREATE DATABASE userinfo;
USE userinfo;

-- Create Table
CREATE TABLE userinfo (
    roll INT PRIMARY KEY NOT NULL,
    name NVARCHAR(20),
    class NVARCHAR(20),
    addres NVARCHAR(50)
);

-- Check table data
SELECT * FROM userinfo;
screenshorts
<img width="1920" height="972" alt="2" src="https://github.com/user-attachments/assets/2d41a883-5804-4991-9ae1-8da156d50ac5" />
<img width="1915" height="964" alt="3" src="https://github.com/user-attachments/assets/34bed96c-c093-41f6-ae26-a9e2f5e3b489" />
<img width="999" height="726" alt="4" src="https://github.com/user-attachments/assets/5ef5ca6b-0c5d-42be-bac0-c88cb40f5e7e" />


