// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args) {
    	var output = document.getElementById("output");
    	var submitBtn = document.getElementById("submit");

    	submitBtn.addEventListener("click", function () {
    		postPostData().then(function () {
    			refreshOutputContent();
    		});
    	});

    	setInterval(function () {
    		refreshOutputContent();
    	}, 5000);
	
    	function postPostData() {
    		var contentBox = document.getElementById("contentBox").value;
    		document.getElementById("contentBox").value = "";
    		var time = new Date();
    		time = "["+time.toLocaleTimeString()+"]";
    		var dataToSend = { Author: time, Content: contentBox };
    		dataToSend = JSON.stringify(dataToSend);
    		return WinJS.xhr({
    			url: "http://posted.apphb.com/api/posts",
    			type: "POST",
    			data: dataToSend,
    			headers: { "Content-type": "application/json" },
    		});
    	}

    	function refreshOutputContent() {
    		getPostData().then(function (request) {
    			var posts = JSON.parse(request.responseText);
    			renderData(posts);
    		})
    	}

    	function renderData(posts) {
    		var buffer = document.createElement("buffer");
    		for (var i = 0; i < posts.length; i++) {
    			var item = posts[i];
    			var post = document.createElement("div");
    			post.className = "post";
    			post.innerText = item.Author + ": " + item.Content;
    			buffer.appendChild(post);
    		}
    		output.innerHTML = buffer.innerHTML;
    		output.scrollTop = output.scrollHeight;
    	}

    	function getPostData() {
    		return WinJS.xhr({
    			url: "http://posted.apphb.com/api/posts",
    			type: "GET",
    		});
    	}
    };

    app.start();
})();
