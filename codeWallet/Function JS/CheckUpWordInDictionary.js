var lookUp = {
  "name": "Name of person or thing",
  "legs": "Part of an animal that makes it stand",
  "Mother": "Someone who gives birth to another person",
  "friends": ["Poppy", "Jerry", "Tom", "Honphey"]   
    
};

function CheckObject(val){
 
  if(lookUp.hasOwnProperty(val))
    {
      return lookUp[val];
    }
  else
  {
    return "Not found"
  }
}

console.log(CheckObject("friends"));
