let animal = {
    eats: true
  };
//   let rabbit = {
//     jumps: true
//   };
  
//   rabbit.__proto__ = animal; 
let rabbit = {
    jumps: true,
    __proto__: animal
  };
  
  // we can find both properties in rabbit now:
  console.log( rabbit.eats ); // true 
  console.log( rabbit.jumps ); // true