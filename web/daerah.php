<div class="container">
  <div class="row">
    <!DOCTYPE html>
<html>
<body>

<canvas id="myCanvas" width="800" height="300" style="border:1px solid #d3d3d3;">
Your browser does not support the HTML5 canvas tag.</canvas>

<script>

var c = document.getElementById("myCanvas");
var ctx = c.getContext("2d");

//Draw a red line at y=100
ctx.strokeStyle = "red";
var y=50;
y = 300-y;
var y1=150;
y1=300-y1;
var y2=100;
y2=300-y2;
ctx.moveTo(0, y);
ctx.lineTo(200, y1);
ctx.lineTo(400, y2);
ctx.stroke();

ctx.font = "12px Arial";

//Place each word at y=100 with different textBaseline values
ctx.fillText("1.000", 0, 300);
ctx.fillText("2.000", 0, 240);
ctx.fillText("3.000", 0, 180);
ctx.fillText("4.000", 0, 120);
ctx.fillText("5.000", 0, 60);
ctx.textBaseline="top";
ctx.fillText("6.000", 0, 0);

</script>

</body>
</html>

  </div>
</div>
