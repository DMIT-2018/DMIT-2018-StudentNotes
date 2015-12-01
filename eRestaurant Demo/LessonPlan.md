# Lesson Plans

The following are draft outlines for lesson plans.

## Security

* Intro
    * Run, Register User, Login/Logout + View Db tables
    * Move Identity classes to class library (`ApplicationUser`, `UserManager`, `ApplicationDbContext`)
* Admin: Users - `~/Admin/Default.aspx`
    * GridView of Users, populate from Code-Behind => view
    * `GridView.AutoGenerateColumns = false` + `BoundColumns` for UserName, E-Mail
    * Switch to ListView
    * ListView InsertItemTemplate + code-behind to create a user
    * ListView Delete User button + code-behind
* Global.asax:
    * Check for default users/roles, then add users/roles/
    * Default users/roles in `<appSettings>`
* Admin: Roles - `~/Admin/Default.aspx`
    * ListView to show roles (Insert/Delete) + number of users
* Admin: Users
    * Column to show users' roles
* Admin: `Request.IsAuthenticated` + `.IsInRole()`
    * `Response.Redirect` to Index page
    * ?? Log an error ??
* Admin: User Roles
    * Add User to Role
    * Remove User from Role

## eRestaurant

* Entities + DAL
    * `Item` + `Category` entities + `eRestaurantContext`
* Manage Menu Items form (ListView)
* `OurMenu.aspx`
    * LINQ
    * Nested Repeater
* **Practice:** Manage Staff
    * `Waiter` entity + DbContext
    * Manage Waiters (+ add as a User and add to the roles `Staff` + `Waiters`)
* Reservations - **Queries**
    * Show reservations (for a particular date)
    * Search reservations
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
* Front Desk
    * Apply User Control - Show current Date/time clock
    * LINQ - Get current table occupancy.
    * Command - Seat a walk-in customer
    * Show today's Reservations
    * Command - Seat a Reservation (multiple tables)
* Front Desk
    * Mock Date/Time with Admin visibility
* **Demos/Practice:** Waiter
    * Customer Orders query/command
* **Demos/Practice:** Kitchen
    * Current orders query/command

