
function userViewModel() {
    this.userUserid = ko.observable("001");
    this.userUsername = ko.observable("something");
    this.userPassword = ko.observable("sasd");
    this.userEmail = ko.observable("this@that.com");
    this.createdAt = Date.now();
    this.lastLogin = Date.now();
 
    this.fullInfo = ko.computed(function () {
        return this.userUserid() + " " + this.userUsername() + " " + this.userPassword()
            + " " + this.userEmail() + " " + this.createdAt + " " + this.lastLogin;
    },this);

    this.changeUserId = function() {
        this.userUserid("NotMe");
    };
};

ko.applyBindings(new userViewModel());
