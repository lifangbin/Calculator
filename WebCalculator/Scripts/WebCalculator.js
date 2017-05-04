$(document).ready(function () {
    // Get all the keys from document
    var keys = document.querySelectorAll('#calculator span');
    
    // Add onclick event to all the keys and perform operations
    for (var i = 0; i < keys.length; i++) {
        keys[i].onclick = function (e) {
            // Get the input and button values
            var input = document.querySelector('.screen');
            var inputVal = input.value;
            var btnVal = this.innerHTML;
            

            // Now, just append the key values (btnValue) to the input string and finally use javascript's eval function to get the result
            // If clear key is pressed, erase everything
            if (btnVal == 'C') {
                input.value = '';
            }
            else {
                input.value += btnVal;
            }
            e.preventDefault();
        }
    }
});