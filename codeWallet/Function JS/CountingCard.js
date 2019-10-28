function CountingCard(card) {
  // Only change code below this line
  let count = 0;
if(card < 7){
count++;
}else if(card >= 7 && card <=9){
      count = 0;
   }
  else if(card == 10 || card =='J' || card == 'K' || card =='A'){
    count--;
  }
  else{
   count = "Undefined";
  }
  
  let holdbet;
  if( count < 0)
     {
      holdbet = "Hold";
     }else if(count == 0){
    holdbet = "Undefined";
  }
  else if(count == 1){
    holdbet = "bet";
  }
  else{
    holdbet  = "Undefined";
  }
  return count + " " + holdbet;
}

