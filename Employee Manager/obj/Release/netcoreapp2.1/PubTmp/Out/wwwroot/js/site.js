// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



CreateEmployee = function () {
    
    var child = window.open('/Employee/Add', "Create Employee", 'width=780px,height=600px,top=125,left=250');
    var timer = setInterval(checkChild, 500);

    function checkChild() {
        if (child.closed) {
            window.location.reload(true);
            clearInterval(timer);
        }
    }
}

EditEmployee = function (EmployeeId) {
    
    var child = window.open('/Employee/Edit?id=' + EmployeeId, "Edit Employee", 'width=780px,height=600px,top=125,left=250');
    var timer = setInterval(checkChild, 500);

    function checkChild() {
        if (child.closed) {
            window.location.reload(true);
            clearInterval(timer);
        }
    }
}

CreateTask = function () {
    
    var child = window.open('/Task/Add', "Create Task", 'width=780px,height=480px,top=150,left=250');
    var timer = setInterval(checkChild, 500);

    function checkChild() {
        if (child.closed) {
            window.location.reload(true);
            clearInterval(timer);
        }
    }
}

CreateRole = function () {
    
    var child = window.open('/Role/Add', "Create Role", 'width=780px,height=380px,top=150,left=250');
    var timer = setInterval(checkChild, 500);

    function checkChild() {
        if (child.closed) {
            window.location.reload(true);
            clearInterval(timer);
        }
    }
}

CreateQueue = function () {
    
    var child = window.open('/Queue/Add', "Queue Task", 'width=780px,height=380px,top=150,left=250');
    var timer = setInterval(checkChild, 500);

    function checkChild() {
        if (child.closed) {
            window.location.reload(true);
            clearInterval(timer);
        }
    }
}

ShowReports = function () {

    var child = window.open('/Report/List', "Reports", 'width=780px,height=500px,top=150,left=250');
    var timer = setInterval(checkChild, 500);

    function checkChild() {
        if (child.closed) {
            window.location.reload(true);
            clearInterval(timer);
        }
    }
}


ListEmployees = function () {
    window.open('/Employee/List', "Manage Employees", 'width=780px,height=500px,top=150,left=250');
}

ListTasks = function () {
    window.open('/Task/List', "Manage Tasks", 'width=780px,height=500px,top=150,left=250');
}

ListQueues = function () {
    window.open('/Queue/List', "Manage Task Queue", 'width=780px,height=500px,top=150,left=250');
}

ListQueuesRoll = function () {
    window.open('/QueueRoll/List', "Active Tasks", 'width=780px,height=500px,top=150,left=250');
}

ListRoles = function () {
    window.open('/Role/List', "Manage Roles", 'width=780px,height=500px,top=150,left=250');
}

StartItem = function (QueueId) {
    $.post("Queue/StartQueue", { id: QueueId }, function (data) {
        $("#row_" + QueueId).hide();
        $("#btnsta_" + QueueId).hide();
    });
}

