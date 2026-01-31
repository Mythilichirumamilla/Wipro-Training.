// Accept user name and marks
let userName = prompt("Enter user name:");
let marks = parseInt(prompt("Enter marks:"));

// Determine pass/fail using conditions
let result;
if (marks >= 40) {
    result = "Pass";
} else {
    result = "Fail";
}

// Store subjects in an array
let subjects = ["Maths", "Science", "English"];

// Display result using string methods
let message = "hello " + userName;
message = message.toUpperCase();

console.log(message);
console.log("Marks: " + marks);
console.log("Result: " + result);
console.log("Subjects: " + subjects.join(", "));