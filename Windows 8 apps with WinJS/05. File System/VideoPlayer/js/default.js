// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {
            if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
                // TODO: This application has been newly launched. Initialize
                // your application here.
            } else {
                // TODO: This application has been reactivated from suspension.
                // Restore application state here.
            }
            args.setPromise(WinJS.UI.processAll());

            var storagePermissions = Windows.Storage.AccessCache.StorageApplicationPermissions;
            
            var fileList = new WinJS.Binding.List();
            var grdFiles = document.getElementById("grdFiles").winControl;
            grdFiles.itemDataSource = fileList.dataSource;
            grdFiles.addEventListener("iteminvoked", function(e) {
                e.detail.itemPromise.then(function (item) {
                    loadFile(item.data._id, item.index);
                });
            });
            
            var pnlVideoPlayer = document.getElementById("pnlVideoPlayer");
            pnlVideoPlayer.addEventListener("ended", function (e) {
                var fileIndex = parseInt(e.target.getAttribute("tag")) + 1;
                var file;
                if (fileList.length > fileIndex) {
                    file = fileList.slice(0)[fileIndex];
                } else {
                    fileIndex = 0;
                    file = fileList.slice(0)[0];
                }
                loadFile(file._id, fileIndex);
            });
            var btnAddFile = document.getElementById("btnAddFile");
            btnAddFile.addEventListener("click", function(e) {
                var openFile = Windows.Storage.Pickers.FileOpenPicker();
                openFile.fileTypeFilter.replaceAll([".avi", ".wmv", ".mp3", ".mp4"]);
                openFile.pickSingleFileAsync().then(function (result) {
                    if (result != null) {
                        result.properties.getMusicPropertiesAsync().then(function (properties) {
                            var file = new VideoFile(properties.title, properties.album);
                            fileList.push(file);

                            storagePermissions.futureAccessList.addOrReplace(file._id, result);
                            
                            var fileUrl = URL.createObjectURL(result);
                            startVideoPlayer(fileUrl);
                        });
                    }
                });
            });

            var btnRemoveFile = document.getElementById("btnRemoveFile");
            btnRemoveFile.addEventListener("click", function (e) {
                var indicesList = grdFiles.selection.getIndices().sort(function (a, b) {
                    return a - b;
                });
                for (var j = indicesList.length - 1; j >= 0; j--) {
                    fileList.splice(indicesList[j], 1);
                }
            });

            var btnSavePlaylist = document.getElementById("btnSavePlaylist");
            btnSavePlaylist.addEventListener("click", function(e) {
                var saveDialog = Windows.Storage.Pickers.FileSavePicker();
                saveDialog.defaultFileExtension = ".pl";
                saveDialog.fileTypeChoices.insert("Playlist", [".pl"]);
                saveDialog.suggestedFileName = "Playlist.pl";
                saveDialog.pickSaveFileAsync().then(function (file) {
                    if (fileList != null) {
                        var jsonString = JSON.stringify(fileList.slice(0));
                        Windows.Storage.FileIO.writeTextAsync(file, jsonString);
                    }
                });
            });

            var btnLoadPlaylist = document.getElementById("btnLoadPlaylist");
            btnLoadPlaylist.addEventListener("click", function(e) {
                var openFile = Windows.Storage.Pickers.FileOpenPicker();
                openFile.fileTypeFilter.replaceAll([".pl"]);
                openFile.pickSingleFileAsync().then(function (result) {
                    if (result != null) {
                        Windows.Storage.FileIO.readTextAsync(result).then(function(file) {
                            var jsonObject = JSON.parse(file);
                            fileList = new WinJS.Binding.List(jsonObject);
                            grdFiles.itemDataSource = fileList.dataSource;
                            loadFile(fileList.slice(0)[0]._id, 0);
                        });
                    }
                });
            });

            var startVideoPlayer = function (fileUrl) {
                pnlVideoPlayer.setAttribute("src", fileUrl);
                pnlVideoPlayer.load();
                pnlVideoPlayer.play();
            };

            var loadFile = function(fileId, fileIndex) {
                storagePermissions.futureAccessList.getFileAsync(fileId).then(function(fileData) {
                    var fileUrl = URL.createObjectURL(fileData);
                    pnlVideoPlayer.setAttribute("tag", fileIndex);
                    startVideoPlayer(fileUrl);
                    grdFiles.selection.set(fileIndex);
                }, function(error) {
                    console.log(error);
                });
            };
        }
    };

    
    
    app.oncheckpoint = function (args) {
        // TODO: This application is about to be suspended. Save any state
        // that needs to persist across suspensions here. You might use the
        // WinJS.Application.sessionState object, which is automatically
        // saved and restored across suspension. If you need to complete an
        // asynchronous operation before your application is suspended, call
        // args.setPromise().
    };

    app.start();
})();
