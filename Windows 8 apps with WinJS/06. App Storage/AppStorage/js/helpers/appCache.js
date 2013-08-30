/// <reference path="../../Scripts/linq.js" />

var AppCache = WinJS.Class.define(function (fileName) {
    this._fileName = fileName;
    this._data = {};
    this.load();
}, {
    pushSafe: function(key, workerData) {
        var result = this.get(key, workerData);
        
        if (result === null || result === undefined) {
            result = workerData;
            this._data[key].push(result);
            this.save();
        }

        return result;
    },
    get: function(key, workerData) {
        var worker = this._data[key];
        if (worker === undefined) {
            this._data[key] = [];
        }

        var result = Enumerable.From(this._data[key]).Where(function(x) {
            return x.firstValue == workerData.firstValue && x.secondValue == workerData.secondValue && x.workerType == workerData.workerType;
        }).FirstOrDefault();

        return result;
    },
    save: function () {
        var self = this;
        Windows.Storage.ApplicationData.current.localFolder.createFileAsync(this._fileName, Windows.Storage.CreationCollisionOption.replaceExisting).done(function (file) {
            var json = JSON.stringify(self._data);
            Windows.Storage.FileIO.writeTextAsync(file, json);
        });
    },
    load: function () {
        var self = this;
        Windows.Storage.ApplicationData.current.localFolder.getFileAsync(this._fileName).then(function (file) {
            Windows.Storage.FileIO.readTextAsync(file).done(function (content) {
                var obj = JSON.parse(content);
                self._data = obj;
            });
        });
    }
});