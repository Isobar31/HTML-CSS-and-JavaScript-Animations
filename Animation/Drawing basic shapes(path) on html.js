var canvas = document.getElementById('canvas');//Cache a reference to the html element.

//set the drawing surface diemension to match the canvas.
canvas.width = canvas.scrollWidth;
canvas.height = canvas.scrollHeight;

//set a reference to the 2d drawing context API.
var ctx = canvas.getContext('2d');

//draw a path which is outlined.
ctx.beginPath();
ctx.moveTo(100, 100);
ctx.lineTo(200, 100);
ctx.moveTo(100, 200);
ctx.lineTo(50, 100);

ctx.strokeStyle = 'green';
ctx.stroke();

//draw a path which is filled.
ctx.beginPath();
ctx.moveTo(400, 100);
ctx.lineTo(500, 100);
ctx.moveTo(400, 200);
ctx.lineTo(350, 100);

ctx.fillStyle = 'green';
ctx.fill();

//circle
ctx.beginPath();
ctx.arc(650, 150, 50, 0, Math.PI/2);
ctx.lineTo(650, 150);

ctx.fillStyle = 'red';
ctx.fill();
