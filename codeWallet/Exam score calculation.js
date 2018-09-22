function onSubmit(){
  var score = 0;
  var numOfQuestion = 5;
  var ansArr = ['optionB1', 'optionE2', 'optionA3', 'optionE4', 'optionC5'];//Values of all the answers.

//Getting the questions through each question value.
  var q1 = document.forms['quiz']['option1'].value;
  var q2 = document.forms['quiz']['option2'].value;
  var q3 = document.forms['quiz']['option3'].value;
  var q4 = document.forms['quiz']['option4'].value;
  var q5 = document.forms['quiz']['option5'].value;

  for (var i = 1; i <= numOfQuestion; i++) {
    if (eval('option' + i) == '') {
      alert("You missed question number "+ i);
    }

  for (var i = 1; i <= numOfQuestion; i++) {
    if (eval('option' + i) == ansArr[i-1]) {
    score++;
    }
  }

  var result = document.getElementById('results');
  result.innerHTML = "<h2> You scored: " + score + " points out of " + numOfQuestion + " questions."</h2>;
  alert("You scored: " + score + " points out of " + numOfQuestion + " questions.");
  return false;
}
