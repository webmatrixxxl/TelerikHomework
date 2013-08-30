// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args)
    {
        var reset = function ()
        {
            WinJS.Application.sessionState["statusLines"] = null;
            var rhymeSelector = document.getElementById("rhymeSelect");
            rhymeSelector.selectedIndex = 0;
            WinJS.Application.sessionState["statusRhymes"] = null;
            var linesSelector = document.getElementById("linesSelector");
            linesSelector.selectedIndex = 0;
            WinJS.Application.local.remove("backup.txt");
            var editor = document.getElementById("editor");
            editor.textContent = "";

        }

        if (args.detail.kind === activation.ActivationKind.launch)
        {
            if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated)
            {
                reset();

            }
            else
            {
                if (WinJS.Application.local.exists("backup.txt"))
                {
                    WinJS.Application.local.readText("backup.txt").then(function (text)
                    {
                        var editor = document.getElementById("editor");
                        editor.textContent = text;
                    });
                }

                var statusRhymes = WinJS.Application.sessionState["statusRhymes"];
                if (statusRhymes)
                {
                    var rhymeSelector = document.getElementById("rhymeSelect");
                    rhymeSelector.selectedIndex = statusRhymes;
                }
                var statusLines = WinJS.Application.sessionState["statusLines"];
                if (statusLines)
                {
                    var linesSelector = document.getElementById("linesSelector");
                    linesSelector.selectedIndex = statusLines;
                }
            }
            args.setPromise(WinJS.UI.processAll());



            var showResutl = function ()
            {
                var rawPoem = document.getElementById("editor").textContent;
                var linesSoFar = 0;
                var poemContainer = document.getElementById("poemContainer");
                var linesInVerse = document.getElementById("linesSelector").value;
                poemContainer.innerHTML = "<p>";
                for (var i = 0; i < rawPoem.length; i++)
                {
                    if (linesSoFar == linesInVerse)
                    {
                        poemContainer.innerHTML += "</p><p>";
                        linesSoFar = 0;
                    }
                    if (rawPoem[i]=='\n')
                    {
                        linesSoFar++;
                        poemContainer.innerHTML += "<br/>"
                        continue;
                    }
                    poemContainer.innerHTML += rawPoem[i];
                }
                poemContainer.innerHTML += "</p>";
            }

            setInterval(function ()
            {
                var localFolder = Windows.Storage.ApplicationData.current.localFolder;
                var fileName = "backup.txt";
                localFolder.
                createFileAsync(fileName,
                Windows.Storage.CreationCollisionOption.replaceExisting).then(
                function (file)
                {
                    file.openTransactedWriteAsync().then(function (transaction)
                    {
                        var writer = Windows.Storage.Streams.DataWriter(transaction.stream);
                        var editor = document.getElementById("editor");
                        writer.writeString(editor.textContent);
                        writer.storeAsync().done(function ()
                        {
                            transaction.commitAsync().done(function ()
                            {
                                transaction.close();
                            });
                        });
                    })
                });
                showResutl();
            }, 2000);


            WinJS.Utilities.id("appbar-new-button").listen("click", function ()
            {
                var msg = new Windows.UI.Popups.MessageDialog("Starting a new peome will discard your current one. Would You like to continue?");
                msg.commands.append(new Windows.UI.Popups.UICommand("OK",
                function (command)
                {
                    reset();
                }));
                msg.commands.append(new Windows.UI.Popups.UICommand("Cancel",
                   function (command) {
                   }));

                msg.showAsync();
            })


            WinJS.Utilities.id("appbar-save-button").listen("click", function ()
            {
                var savePicker = new Windows.Storage.Pickers.FileSavePicker();
                savePicker.defaultFileExtension = ".txt"
                savePicker.fileTypeChoices.insert("Plain Text", [".txt"])
                savePicker.suggestedFileName = "New Text Document";

                savePicker.pickSaveFileAsync().then(function (file)
                {
                    Windows.Storage.FileIO.writeTextAsync(file, document.getElementById("editor").textContent);
                });

            })

            WinJS.Utilities.id("appbar-open-button").listen("click", function ()
            {
                var openPicker = new Windows.Storage.Pickers.FileOpenPicker();

                openPicker.fileTypeFilter.append("*");
                openPicker.pickSingleFileAsync().then(function (file)
                {
                    Windows.Storage.FileIO.readTextAsync(file).then(function (text)
                    {
                        document.getElementById("editor").textContent = text;
                    });
                });

            })
            
        }
    };

    app.oncheckpoint = function (args)
    {
        var rhymeSelector = document.getElementById("rhymeSelect");
        WinJS.Application.sessionState["statusRhymes"] = rhymeSelector.selectedIndex;
        var linesSelector = document.getElementById("linesSelector");
        WinJS.Application.sessionState["statusLines"] = linesSelector.selectedIndex;
    };

    app.start();
})();
