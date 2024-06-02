var Actor = function (nconst, primaryname, birthyear, deathyear) {
    this.nconst = ko.observable(nconst);
    this.age = ko.observable(primaryname);
    this.birthyear = ko.observable(birthyear);
    this.deathyear = ko.observable(deathyear);

};

var Movie = function (tconst,titletype,primarytitle) {
    this.tconst = ko.observable(tconst);
    this.titletype = ko.observable(titletype);
    this.primarytitle = ko.observable(primarytitle);
};

var User = function (id, username, password, email) {
    this.userUserid = ko.observable(id);
    this.userUsername = ko.observable(username);
    this.userPassword = ko.observable(password);
    this.userEmail = ko.observable(email);
    this.createdAt = Date.now();
    this.lastLogin = Date.now();
};


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
