/// <reference path="//Microsoft.WinJS.1.0/js/base.js" />
/// <reference path="Social.v1.js" />
(function () {
    //var benchArray = [];
    //var userArray = [];
    var benchArray = [{
        Id: 69,
        Name: "Шано пейщата",
        UsersCount: 3,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-09-01 12:31:52.957",
        EndTime: "2013-09-01 12:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 51,
        Name: "Постата",
        UsersCount: 1,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-10-01 2:31:52.957",
        EndTime: "2013-10-01 2:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 69,
        Name: "Шано пейщата",
        UsersCount: 3,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-09-01 12:31:52.957",
        EndTime: "2013-09-01 12:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 51,
        Name: "Постата",
        UsersCount: 1,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-10-01 2:31:52.957",
        EndTime: "2013-10-01 2:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    },
    {
        Id: 69,
        Name: "Шано пейщата",
        UsersCount: 3,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-09-01 12:31:52.957",
        EndTime: "2013-09-01 12:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 51,
        Name: "Постата",
        UsersCount: 1,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-10-01 2:31:52.957",
        EndTime: "2013-10-01 2:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 69,
        Name: "Шано пейщата",
        UsersCount: 3,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-09-01 12:31:52.957",
        EndTime: "2013-09-01 12:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 51,
        Name: "Постата",
        UsersCount: 1,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-10-01 2:31:52.957",
        EndTime: "2013-10-01 2:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }
    , {
        Id: 69,
        Name: "Шано пейщата",
        UsersCount: 3,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-09-01 12:31:52.957",
        EndTime: "2013-09-01 12:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 51,
        Name: "Постата",
        UsersCount: 1,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-10-01 2:31:52.957",
        EndTime: "2013-10-01 2:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 69,
        Name: "Шано пейщата",
        UsersCount: 3,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-09-01 12:31:52.957",
        EndTime: "2013-09-01 12:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 51,
        Name: "Постата",
        UsersCount: 1,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-10-01 2:31:52.957",
        EndTime: "2013-10-01 2:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 69,
        Name: "Шано пейщата",
        UsersCount: 3,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-09-01 12:31:52.957",
        EndTime: "2013-09-01 12:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 51,
        Name: "Постата",
        UsersCount: 1,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-10-01 2:31:52.957",
        EndTime: "2013-10-01 2:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }];

    var userArray = [{
        Id: 4,
        Nickname: "daniel.filipov",
        Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
        StartTime: "2013-09-01 15:25:13.037",
        EndTime: "2013-09-01 15:25:13.037"
    }, {
        Id: 5,
        Nickname: "webmatrix",
        Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
        StartTime: "2013-09-01 15:25:13.037",
        EndTime: "2013-09-01 15:25:13.037"
    }, {
        Id: 69,
        Name: "Шано пейщата",
        UsersCount: 3,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-09-01 12:31:52.957",
        EndTime: "2013-09-01 12:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 51,
        Name: "Постата",
        UsersCount: 1,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-10-01 2:31:52.957",
        EndTime: "2013-10-01 2:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 69,
        Name: "Шано пейщата",
        UsersCount: 3,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-09-01 12:31:52.957",
        EndTime: "2013-09-01 12:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 51,
        Name: "Постата",
        UsersCount: 1,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-10-01 2:31:52.957",
        EndTime: "2013-10-01 2:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 69,
        Name: "Шано пейщата",
        UsersCount: 3,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-09-01 12:31:52.957",
        EndTime: "2013-09-01 12:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 51,
        Name: "Постата",
        UsersCount: 1,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-10-01 2:31:52.957",
        EndTime: "2013-10-01 2:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    },
    {
        Id: 69,
        Name: "Шано пейщата",
        UsersCount: 3,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-09-01 12:31:52.957",
        EndTime: "2013-09-01 12:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 51,
        Name: "Постата",
        UsersCount: 1,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-10-01 2:31:52.957",
        EndTime: "2013-10-01 2:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 69,
        Name: "Шано пейщата",
        UsersCount: 3,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-09-01 12:31:52.957",
        EndTime: "2013-09-01 12:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 51,
        Name: "Постата",
        UsersCount: 1,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-10-01 2:31:52.957",
        EndTime: "2013-10-01 2:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }
    , {
        Id: 69,
        Name: "Шано пейщата",
        UsersCount: 3,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-09-01 12:31:52.957",
        EndTime: "2013-09-01 12:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 51,
        Name: "Постата",
        UsersCount: 1,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-10-01 2:31:52.957",
        EndTime: "2013-10-01 2:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 69,
        Name: "Шано пейщата",
        UsersCount: 3,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-09-01 12:31:52.957",
        EndTime: "2013-09-01 12:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 51,
        Name: "Постата",
        UsersCount: 1,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-10-01 2:31:52.957",
        EndTime: "2013-10-01 2:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 69,
        Name: "Шано пейщата",
        UsersCount: 3,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-09-01 12:31:52.957",
        EndTime: "2013-09-01 12:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 51,
        Name: "Постата",
        UsersCount: 1,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-10-01 2:31:52.957",
        EndTime: "2013-10-01 2:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }];

    var userArray = [{
        Id: 4,
        Nickname: "daniel.filipov",
        Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
        StartTime: "2013-09-01 15:25:13.037",
        EndTime: "2013-09-01 15:25:13.037"
    }, {
        Id: 5,
        Nickname: "webmatrix",
        Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
        StartTime: "2013-09-01 15:25:13.037",
        EndTime: "2013-09-01 15:25:13.037"
    }, {
        Id: 69,
        Name: "Шано пейщата",
        UsersCount: 3,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-09-01 12:31:52.957",
        EndTime: "2013-09-01 12:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 51,
        Name: "Постата",
        UsersCount: 1,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-10-01 2:31:52.957",
        EndTime: "2013-10-01 2:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 69,
        Name: "Шано пейщата",
        UsersCount: 3,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-09-01 12:31:52.957",
        EndTime: "2013-09-01 12:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }, {
        Id: 51,
        Name: "Постата",
        UsersCount: 1,
        Latitude: 4.0,
        Longitude: 5.0,
        StartTime: "2013-10-01 2:31:52.957",
        EndTime: "2013-10-01 2:31:52.957",
        Users: [{
            Id: 4,
            Nickname: "daniel.filipov",
            Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }, {
            Id: 5,
            Nickname: "webmatrix",
            Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
            StartTime: "2013-09-01 15:25:13.037",
            EndTime: "2013-09-01 15:25:13.037"
        }]
    }];

    //var userArray = [{
    //    Id: 4,
    //    Nickname: "daniel.filipov",
    //    Avatar: "https://graph.facebook.com/1789178471/picture?type=large",
    //    StartTime: "2013-09-01 15:25:13.037",
    //    EndTime: "2013-09-01 15:25:13.037"
    //}, {
    //    Id: 5,
    //    Nickname: "webmatrix",
    //    Avatar: "http://profile.ak.fbcdn.net/hprofile-ak-prn2/1076219_1485517583_849518829_q.jpg",
    //    StartTime: "2013-09-01 15:25:13.037",
    //    EndTime: "2013-09-01 15:25:13.037"
    //}];

    function getAllUsers() {
        return userArray;
    }

    function getUserById(Id) {
        var userToReturn = null;

        userArray.forEach(function (user) {
            if (user.Id === Id) {
                userToReturn = user;
            }
        });

        return userToReturn;
    }


    function getAllBenches() {
        return benchArray;
    }

    function getBenchById(Id) {
        var benchToReturn = null;

        benchArray.forEach(function (bench) {
            if (bench.Id === Id) {
                benchToReturn = bench;
            }
        });

        return benchToReturn;
    }

    //function getBenchUsers(Id) {
    //    var bench = getBenchById(Id);
    //    return bench.Users;
    //}

    var addBench = function (benchDTO) {
        return new WinJS.Promise(function (success, error, progrss) {
            // ReWrite AJAX
            benchArray.push(benchDTO);
            success();
        });
    }


    var addUser = function (userDTO) {
        return new WinJS.Promise(function (success, error, progrss) {
            // ReWrite AJAX
            userArray.push(userDTO);
            success();
        });
    }


    WinJS.Namespace.define("Data", {
        getAllBenches: getAllBenches,
        getBenchById: getBenchById,
        //getBenchUsers: getBenchUsers,

        addBench: addBench,
        addUser: addUser,


        getAllUsers: getAllUsers,
        getUserById: getUserById
    });

})();