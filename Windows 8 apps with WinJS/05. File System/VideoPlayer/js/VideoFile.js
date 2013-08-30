var VideoFile = new WinJS.Class.define(function (title, album) {
    this._id = Math.uuid();
    this.title = title;
    this.album = album;
});