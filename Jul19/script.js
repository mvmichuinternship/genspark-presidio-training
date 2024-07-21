document.addEventListener('DOMContentLoaded', () => {
    const lettersContainer = document.getElementById('letters-container');
    const wordInput = document.getElementById('word-input');
    const submitBtn = document.getElementById('submit-btn');
    const feedback = document.getElementById('feedback');
    
    const letters = ['a', 'b', 'c', 'd', 'e', 'f', 'g'];
    const mandatoryLetter = 'e';
    const validWords = new Set(['beef', 'cage', 'caged', 'cafe', 'fade', 'faced', 'face', 'deaf']);
    
    const attempts = [];
    const guessed = [];

    letters.forEach(letter => {
        const letterElement = document.createElement('span');
        letterElement.textContent = letter.toUpperCase();
        letterElement.style.padding='12px';
        letterElement.style.backgroundColor='orange';
        letterElement.style.color='white';
        letterElement.style.fontSize='24px';
        letterElement.style.fontStyle='semibold';
        letterElement.style.borderRadius='2px';
        letterElement.className = `letter ${letter === mandatoryLetter ? 'mandatory' : ''}`;
        letterElement.dataset.letter = letter;
        lettersContainer.appendChild(letterElement);
    });

    lettersContainer.addEventListener('click', event => {
        if (event.target.classList.contains('letter')) {
            const letter = event.target.dataset.letter;
            wordInput.value += letter.toUpperCase();
        }
    });

    submitBtn.addEventListener('click', () => {
        const userInput = wordInput.value.trim().toLowerCase();
        attempts.push(userInput)
        console.log(guessed)
        if (userInput.length >= 4 && userInput.includes(mandatoryLetter) && validWords.has(userInput)) {
            if (!guessed.includes(userInput)) {
                guessed.push(userInput);
            }
            feedback.innerHTML = `Congratulations! You spelled a valid word<br>Your attempts:<br>${attempts.join('<br>')}`;
            feedback.style.color = "orange";  
        } else {
            feedback.innerHTML = `Oops! That is not correct. Try again<br>Your attempts:<br>${attempts.join('<br>')}`;
            feedback.style.color = "red";  
        }

        
        if (guessed.length == 7) {
            feedback.innerHTML = `Congratulations! You spelled all valid words<br>Your guesses:<br>${guessed.join('<br>')}`;
            feedback.style.color = "green"; 
        }

       
        wordInput.value = '';
    });
});
