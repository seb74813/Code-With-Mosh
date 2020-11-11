//Finds the highest value of two numbers
function max(x, y) {
    return (x > y) ? x : y;
}
console.log('Max of Two Number:');
console.log(max(1, 2));
console.log(max(5, 1));
console.log(max(7, 7));

//Checks if screen is landscape or portrait
function isLandscape(width, height) {
    return (width > height);
}
console.log('Landscape or Portrait:');
console.log(isLandscape(1, 2));
console.log(isLandscape(5, 1));
console.log(isLandscape(7, 7));

//Divisible by 3 => 'Fizz'
//Divisible by 5 => 'Buzz'
//Divisible by both 3 and 5 => 'FizzBuzz'
//Not divisible by 3 3 or 5 => input
//Not a number = 'Not a number'
function fizzBuzz(input) {
    if (typeof(input) !== "number") return NaN;
    if ((input % 3 === 0) && (input % 5 === 0))
    return 'FizzBuzz';
    if (input % 3 === 0) return 'Fizz';
    if (input % 5 === 0) return 'Buzz';
    return input;
}
console.log('FizzBuzz:');
console.log(fizzBuzz('Meep'));
console.log(fizzBuzz(15));
console.log(fizzBuzz(6));
console.log(fizzBuzz(10));
console.log(fizzBuzz(7));

//Gives demerit points if speed is over the limit and suspends licenses with over 12 points
function checkSpeed (speed) {
    const speedLimit = 70;
    const kmPerPoint = 5;

    if(speed < speedLimit + kmPerPoint) {
        console.log('Ok');
        return;
    }
    const points = Math.floor((speed - speedLimit) / kmPerPoint);
    if (points >= 12) 
        console.log('License suspended');
    else 
        console.log('Points:', points);
    
}
console.log('Demerit Points:');
console.log(checkSpeed(70));
console.log(checkSpeed(71));
console.log(checkSpeed(75));
console.log(checkSpeed(180));

//Checks if the numbers between 0 and limit are even or odd
function showNumbers(limit) {

}
console.log('Even and Odd Numbers:');