const randomNumber = Math.floor(Math.random() * 10) + 1;

document.getElementById("guessButton").addEventListener("click", function() {
    const userGuess = Number(document.getElementById("guessInput").value);
    const resultText = document.getElementById("resultText");

    if (!userGuess || userGuess < 1 || userGuess > 10) {
        resultText.textContent = "Please enter a valid number between 1 and 10.";
        resultText.style.color = "red";
        return;
    }

    if (userGuess === randomNumber) {
        resultText.textContent = "congratulations! you guessing it!";
        resultText.style.color = "green";
    }else if (userGuess < randomNumber) {
        resultText.textContent = "try a higher number!";
        resultText.style.color = "#333";
    }else {
        resultText.textContent = "try a lower number!";
        resultText.style.color = "#333";
    }

})