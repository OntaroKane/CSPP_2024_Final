const start = Date.now();

function userViewModel() {
    this.userUserid = "001";
    this.userUsername = "something";
    this.userPassword = "sasd";
    this.userEmail = "this@that.com";
    this.createdAt = start;
    this.lastLogin = start;

}

ko.applyBindings(userViewModel);
