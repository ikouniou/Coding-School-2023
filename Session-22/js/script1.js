function reverseString() {

    var str = document.getElementById("string").value;
    let newString = "";
    for (let i = str.length - 1; i >= 0; i--) {
        newString += str[i];
    }
    document.getElementById("reversed").value = newString;
}