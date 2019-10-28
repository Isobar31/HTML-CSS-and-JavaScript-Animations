function Dictionary(val){
  let answer = "";
  var lookUp = {
  "name": "Name of person or thing",
  "legs": "Part of an animal that makes it stand",
  "Mother": "Someone who gives birth to another person",
  "friends": ["Poppy", "Jerry", "Tom", "Honphey"]   
    
};
answer = lookUp[val];
    return answer;
}

console.log(Dictionary("name"));
