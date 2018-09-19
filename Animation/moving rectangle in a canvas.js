function draw(xAxis, yAxis) /*They represent the x and y coordinate specified in the html function call*/
{
  var canvas = document.getElementById('canvas');
  var ctx = canvas.getContext('2d');
  ctx.save(); /*save the canvas state if required.*/
  ctx.clearRect(0, 0, 550, 400); /*Clear the canvas for redrawing.*/
  // The first two parameters are the x and y axes. The last two are the width and height
  ctx.fillStyle = "rgba(0, 200, 0, 1)";/*Fill the rectangle with this color.*/
  ctx.fillRect(xAxis, 20, 50, 50); //Draw the rectangle.
  ctx.restore();//Restores the saved rectangle.
  xAxis += 1;
  var loopTimer = setTimeout('draw('+ xAxis +', '+ yAxis +')', 20);
}
