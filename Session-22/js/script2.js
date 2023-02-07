function checkPalindrome() {

    var string = document.getElementById("string2").value;
    const len = string.length;

    // loop through half of the string
    for (let i = 0; i < len / 2; i++) {

        // check if first and last string are same
        if (string[i] !== string[len - 1 - i]) {
            document.getElementById("palindrome").value = "No"
            return;
        }
    }
    document.getElementById("palindrome").value = "Yes"
}