/*
    Example of a multi-line comment just like in C#/Java
*/

// Single line comment

/*****************************************************************************
 * We test the JavaScript code using Inspect in the browser
 ****************************************************************************/

/**
 * Functions start with the word function.
 * They don't have a return type and the naming convention is camel-case.
 */
function variables() {
  // Declares a variable where the value cannot be changed
  const aVariable = 42;
  
  // console.log() - display data on the console (Console.WriteLine() or System.out.println()) 
  // JavaScript support interpolation to construct strings similar to C#
  //
  // Interpolation:  `words ${variable}`  C#: $(words {aVariable})
  console.log(`The value in aVariable is: ${aVariable}`)

  // Declares a variable those value can be changed

  let itBe = 87.4;
  console.log(`The value in itBe is: ${itBe}`)

  itBe = 1776;
  console.log(`The value in itBe is: ${itBe}`)

  // Declares a variable that will always be an array
  let stuff = ["things", 'Kevin', "Hello", 774.6]
  console.log(`The value in stuff is: ${stuff}`) // Display teh array as a variable - elements separated by ,
  console.log(stuff)    // display the array name is shows the array and it's elements in a dropdown
  console.table(stuff)

}
function varTest() {
  let num = 10;
  var someVariable = num
}

/**
 * Functions can also accept parameters.
 * Notice the parameters do not have types.
 * @param {Number} param1 The first number to display
 * @param {Number} param2 The second number to display
 */
function printParameters(param1, param2) {
  console.log(`The value of param1 is ${param1}`);
  console.log(`The value of param2 is ${param2}`);
}

/**
 * Compares two values x and y.
 * == is loose equality -  values are the same, but types don't matter
 * === is strict equality - values and type must be the same 
 * @param {Object} x
 * @param {Object} y
 */
function equality(x, y) {
  console.log(`x is ${typeof x}`); // typeof will return the data type of the variable 
  console.log(`y is ${typeof y}`);

  console.log(`x == y : ${x == y}`);
  console.log(`x === y : ${x === y}`); 
}

/**
 * Each value is inherently truthy or falsy.
 * false, 0, '', null, undefined, and NaN are always falsy
 * everything else is always truthy
 * @param {Object} x The object to check for truthy or falsy,
 */
function falsy(x) {
  if (x) {
    console.log(`${x} is truthy`);
  } else {
    console.log(`${x} is falsy`);
  }
}

/**
 * JavaScript Objects are NOT the same Object-Oriented Objects 
 * 
 *  Objects are simple key-value pairs
    - values can be primitive data types
    - values can be arrays
    - or they can be functions
    JSON - JavaScript Object Notation - How we share data between devices 
*/
function objects() {
  const person = {           // JavaScript objects are enclosed in {}
    firstName: "James T.",   // attributes in are specified with name : value
    lastName: "Kirk",        // multiple values are seperated by commas
    age: 42,                 ,,
    employees: [
      "Spock",
      "McCoy",
      "Uhura",
      "Scotty"
    ]
  };

  // Log the object
  console.log(person)
  console.log(`person contains: ${person}`);
  console.log(person);

  // Log the first and last name

  console.log(`Person's first name:${person.firstName}`)
  console.log(`          last name: ${person.lastName}`)

  // Log each employee

  for( let i=0; i < person.employees.length; i++) {
    console.log(`Employee #${i+1}: ${person.employees[i]}`)
  }
}

/*
########################
Function Overloading
########################

in C# and Java Function Overloading is when functions have the same name, but different parameters
and the compiler determines which function to call based on the data types of the parameters

In C#/Java functions overloads are used for multiple constructors of a class

Function Overloading is not available in Javascript. If you declare a
function with the same name, more than one time in a script file, the
earlier ones are overridden and the most recent one will be used.
*/

function Add(num1, num2) {
  return num1 + num2;
}

function Add(num1, num2, num3) {
  return num1 + num2 + num3;
}

/*
########################
Math Library
########################

A built-in `Math` object has properties and methods for mathematical constants and functions.
*/

function mathFunctions() {
  console.log("Math.PI : " + Math.PI);
  console.log("Math.LOG10E : " + Math.LOG10E);
  console.log("Math.abs(-10) : " + Math.abs(-10));
  console.log("Math.floor(1.99) : " + Math.floor(1.99));
  console.log("Math.ceil(1.01) : " + Math.ceil(1.01));
  console.log("Math.random() : " + Math.random());
}

/*
########################
String Methods
########################

The string data type has a lot of properties and methods similar to strings in Java/C#
*/

function stringFunctions(value) {
  console.log(`.length -  ${value.length}`);
  console.log(`.endsWith('World') - ${value.endsWith("World")}`);
  console.log(`.startsWith('Hello') - ${value.startsWith("Hello")}`);
  console.log(`.indexOf('Hello') - ${value.indexOf("Hello")}`);

  /*
    Other Methods
        - split(string)
        - substr(number, number)
        - substring(number, number)
        - toLowerCase()
        - trim()
        - https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String
    */
}
