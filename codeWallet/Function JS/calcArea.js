//The HTML page where the JS file will take input from the form and calculate the area of the given values
<form >
        Width: 
        <input type="number" id="width"> 
        <br/><br/>

        Height: 
        <input type="number" id="height">
        <br/> <br/>
       
        <input type="button" onclick="calcArea()" value="Get Area">
        <input type="text" id="answer" size="6px">
    </form> 
    
    

//The JS code for calculating area in a function
function calcArea()
{
    var wit = document.getElementById("width").value;
    var hgt = document.getElementById("height").value;

    var area = wit * hgt;

    document.getElementById("answer").value = area;
}
