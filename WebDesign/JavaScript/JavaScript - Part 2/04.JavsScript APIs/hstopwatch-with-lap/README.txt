READ ME:
*********

This software is developed and copyrighted by HIOX Softwares.
This is given under The GNU General Public License (GPL).
This version is hstopwatch-lap 1.0


Features:
----------
a) You can use this stopwatch timer with lap for any event to calculate the time.
b) You can reset the time using Reset button.
c) Just download and use it. 


Downloads:
-----------
Please visit our site http://www.hscripts.com and do the download


Installation:
--------------
Please take 5 minutes time and read installation instructions carefully and
completely! This will ensure a proper and easy installation 

Extracting files:
a) Unzip the file hstopwatch-lap.zip to extract the files to the folder
hstopwatch-lap\hstopwatch-lap.
b) You will get the files htimer/ stopwatch-lap.js, htimer/README

Embedding the code:
a) First copy the following Java Script within the “Head” tag.
<!-- Script by hscripts.com -->

<script src="hstopwatch/stopwatch-lap.js">
</script>
<body onload='stopwatch();'>
<div>
	<input type='text' id='disp' maxlength=12 readonly>
	<button type='button' onclick='ss()' id='butt'>Start/Stop</button>
	<button type='button' onclick='r()' id='butt2'>Reset</button>
</div>
<div id='lap'>
<table border=1>
	<tr><th width=65>Lap #</th><th width=110>Running Total</th><th
width=110>This Lap</th></tr>
</table>
</div>
</body>
<!-- Script by hscripts.com -->
b) Now copy the following CSS tag in the “Head” tag.
<style type='text/css'>
#disp
{
	background-color: black;
	font-size: 1.75em;
	font-weight: bold;
	color: white;
	width: 7.65em;
	font-family: "Courier New";
	padding: 0.15em;
	border-right-width:0;
}

#butt 
{
	font-size: 1em;
	width: 8em;
	font-family: "Courier New";
}

#butt2 
{
	font-size: 1em;
	width: 5em;
	font-family: "Courier New";
}

#lap
{
	margin-top: 0.5em;
}
</style>


Releases:
----------
Release Date hstopwatch-lap 1.0 : 23-12-2007

On any suggestions mail to us at support@hscripts.com

Visit us at http://www.hscripts.com
Visit us at http://www.hioxindia.com
