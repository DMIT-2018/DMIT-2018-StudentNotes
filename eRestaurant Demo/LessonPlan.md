# Lesson Plans

The following are draft outlines for lesson plans.

* Review Layered Architecture
   * PL/BLL/DAL/CBOs
* Version Control
   * Background (CVCS vs DVCS)
   * git and GitHub
   * Basic git Commands
* ASP.NET Web Forms Website
   * Project and Repository Setup
* Databound Controls Overview
   * Types of Databound Controls
   * GridView Overview
   * DetailsView Overview
   * Repeater Overview
   * ListView Overview
   * DataSource Controls
   * ObjectDataSource
* Customizing Databound Controls
   * Understanding Databound Templates
   * Eval and Bind - Old School
   * ItemType - New School
   * FindControl
* eRestaurant Overview
   * The background story
* Site Navigation
   * Hard-code Links
   * asp:HyperLink
* Website Error Handling
   * Try/Catch Review
   * Site-Wide
   * Custom 404
   * Logging Options (NuGet)
* Website Security
   * Authentication vs Authorization
   * History of ASP.NET Security
* Intro to ASP.Net Identity
    * Run, Register User, Login/Logout + View Db tables
    * Move Identity classes to class library (`ApplicationUser`, `UserManager`, `ApplicationDbContext`)
    * Add `RoleManager` class (?and? `ApplicationRole` ?)
* ASP.NET Identity in Web Forms Website
   * ApplicationDbContext, ApplicationUser, and UserManager
   * Migrating Identity classes to a class library
   * The purpose of OWIN
* Admin: Users - `~/Admin/Default.aspx`
    * GridView of Users, populate from Code-Behind => view
    * `GridView.AutoGenerateColumns = false` + `BoundColumns` for UserName, E-Mail and E-Mail Confirmed
    * Switch to ListView
    * ListView InsertItemTemplate + code-behind to create a user
    * ListView Delete User button + code-behind
* Global.asax:
    * Check for default users/roles, then programmatically add users/roles/
    * Default users/roles in `<appSettings>`
    * Alternate - Using Migrations (quick demo, **separate branch**)
        * Migrations' main purpose: modifying Db structure as application changes in a code-first environment + database seeding
        * Full syntax for Migrations (for when you have multiple DbContext classes)
* Admin: Roles - `~/Admin/Default.aspx`
    * ListView to show roles (Insert/Delete) + number of users
* Admin: Users Revisited
    * Column to show users' roles
* Authentication and Authorization
   * Admin: `Request.IsAuthenticated` + `.IsInRole()`
   * `Response.Redirect` to Index page
   * Log unauthorized access attempt
* Admin: User Roles
    * Add User to Role
    * Remove User from Role
* Entity Framework
   * Code-First with Entity Framework
   * Understanding Entity Framework in a Layered Architecture
* Entities and the DbContext
    * `Item` + `Category` entities + `eRestaurantContext`
    * Navigation Properties
    * Entity Attributes
    * NotMapped Properties and Rich Entities
    * Mapping the Whole Database
* Per-Entity CRUD
   * Basic CRUD in the DbContext
* Manage Menu Items
    * BLL - CRUD approach (same object model for data regardless of create/read/update/delete)
    * `[DataObject]` attributes + `ObjectDataSource` and DataBound controls
    * ListView for CRUD
* LINQ Basics
   * LINQ Overview
   * LinqPad
   * LINQ Query Syntax
   * LINQ Method Syntax
* LINQ to Entities
   * Querying the Database in LinqPad
   * Translating LinqPad queries to Entity Framework
* Display the Menu
    * LINQ
    * `OurMenu.aspx`
    * Nested Repeater
* Report on Menu Items
   * Microsoft Reports (and Crystal Reports)
   * Menu Report (Popularity)
   * Creating Flat POCOs in LINQ
   * Creating Reports (.rdlc)
   * ReportViewer Controls
   * Customizing Reports
* **Practice:** Manage Waiters
    * `Waiter` entity + DbContext
    * Manage Waiters (+ add as a User and add to the roles `Staff` + `Waiters`)
* CQRS Principles
   * What is CQRS
   * How CQRS relates to Application Design
* Reservations - **Queries**
    * Show reservations (for a particular date)
    * Search reservations (by name, by contact number, by date, by date-range)
* Reservations - **Commands**
    * Place reservations
    * Change Reservation Status (cancelled, time change, etc.)
* User Controls
    * Emit Javascript to show a clock with the current date/time.
        * http://www.sitepoint.com/10-cool-jquery-clock-tutorials-analog-digital/
        * http://flipclockjs.com/
        * http://lexxus.github.io/jq-timeTo/
        * http://www.pageresource.com/jscript/jclock.htm
        * https://www.washington.edu/accesscomputing/webd2/student/unit5/module2/lesson3.html
        * http://www.webestools.com/scripts_tutorials-code-source-7-display-date-and-time-in-javascript-real-time-clock-javascript-date-time.html
        * http://www.ricocheting.com/code/javascript/html-generator/date-time-clock
        * http://www.javascriptkit.com/javatutors/time1.shtml
        * http://time.is/widgets
        * http://www.cssscript.com/animated-digital-led-clock-with-javascript-and-css/
        * http://talkerscode.com/webtricks/digital-clock-with-complete-time-and-date-using-css-and-javascript.php
        * https://googlecreativelab.github.io/coder-projects/projects/digital_clock/
    * Get a Date/Time (for Mocking)
    * Test page for using User Controls
* Front Desk Use Cases
    * Apply User Control - Show current Date/time clock
    * LINQ - Get current table occupancy.
    * Command - Seat a walk-in customer
    * Show today's Reservations
    * Command - Seat a Reservation (multiple tables)
* **Demos:** Waiter Use Cases
    * Query/Command Planning
    * Take Customer Orders
    * Serve Order
    * Split Bill - *Code-behind moving items between GridViews or ListViews*
    * Combine Bills
* **Practice:** Kitchen Use Cases
    * Query/Command Planning
    * List current orders (by Bill/Table)
    * Mark orders ready to serve
* Payment Use Cases
    * Table/Order Status (Front Desk)
    * Modal Dialog - Pay Bill
    * Real-World Payment Gateways
* Revisiting the Front Desk
    * Mock Date/Time with Admin visibility
    * See the Restaurant at a Point In Time
* Database Deployment
* Website Deployment
* Infinity and Beyond!
   * Continuous Integration
