document.onmousemove = animateCircles;

var colors = ['#ccc', '#6cf', '#eba13a'];

function animateCircles(event){
  let circle = document.createElement("div");
  circle.setAttribute("class","circle");
  document.body.appendChild(circle);

  circle.style.left = event.clientX + 'px';
  circle.style.top = event.clientY + 'px';

  var color = colors[Math.floor(Math.random() * colors.length)];


  circle.style.transition = "all 0.5s linear 0s";

  circle.style.left = circle.offsetleft - 20 + 'px';
  circle.style.left = circle.offsettop - 20 + 'px';

  circle.style.width = "20px";
  circle.style.height = "20px";
  circle.style.borderWidth = "5px";
  circle.style.opacity = "0px";

  setTimeout(function() {
    circle.style.color = color;
 circle.remove();
}, 100);
}
