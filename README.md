# ADUsageDemo

## Introduction

This project demonstrates how to use an Active Directory account as the user for accessing the database.

## Preparation

The following must be met before you can run this project:

- You have a VPN client and account to connect to the organization's domain
- Your machine is joined in the organization's domain
- You have an Active Directory account to use as login

All of the above would require assistance from the network administrator of the organization.

### Database

This project uses a SQL Server Express edition database, so you can try it out first in the local installation in
your machine. This guide uses SSMS to do all the actions you would need to do with the database.

#### Creating a user in SQL Server

Create a user in your target SQL Server through the following steps:

1. Ensure that you are already connected to your organization's VPN.
2. Login through a user that has permissions to create a login on the SQL Server.
3. Expand the **Security** node, right-click **Logins** and then click **New Login...**
4. From the **General** page, search the AD account through the **Search...** button beside the **Login name** textbox.
5. Click the **Locations...** button and ensure that you see your organization's domain.
6. You shall see an **Entire Directory** node. Expand it, and you shall also see you organization's domain.
7. Select the domain you wish to search the AD account you're going to use and then click **OK**.
8. Enter the AD account you wish to use (i.e., `org.domain.com\ad_user`) and then click **OK**.
9. If that account exists in the domain, it will let you use it.
10. Select your desired **Default database** for that user, but the **master** database will do for now.
11. That's all for now, we'll go back to this later after the database migration has been executed.