(function () {
    var numberToGuess,
        endFunction,
        name,
        score = 0;

    function init(playerName, endCallback) {
        numberToGuess = getRandomNumber(4);
        name = playerName;
        endFunction = endCallback;
    }

    function guess(number) {
        var guessNumber = number.toString(),
            sheepCount = 0,
            ramsCount = 0;

        score++;

        for (var i = 0; i < guessNumber.length; i++) {
            for (var j = 0; j < numberToGuess.length; j++) {
                if (guessNumber[i] == numberToGuess[j]) {
                    if (i != j) {
                        sheepCount++;
                    } else {
                        ramsCount++;
                    }
                }
            }
        }

        if (ramsCount === 4) {
            saveResult();
        }

        return {
            sheep: sheepCount,
            rams: ramsCount
        }
    }

    function getHighScore(count) {
        var results = JSON.parse(localStorage.getItem('results')),
            sortedResults = results.sort(compareFunction),
            topScores = sortedResults.slice(0, count);

        return topScores;
    }

    function getRandomNumber(length) {
        var allNumbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9],
            number = '',
            currDigit,
            position;

        for (var i = 0; i < length; i++) {
            position = 'taken';

            while (position === 'taken') {
                currDigit = getCurrentDigit(i);
                position = allNumbers[currDigit];
            }

            number += currDigit;
            allNumbers[currDigit] = 'taken';
        }

        function getCurrentDigit(index) {
            index = index === 0 ? 1 : 0;

            return Math.floor((Math.random() * 9) + index);
        }

        return number;
    }

    function saveResult() {
        var results = JSON.parse(localStorage.getItem('results')) || [];

        results.push({
            name: name,
            score: score
        });

        localStorage.setItem('results', JSON.stringify(results));

        endFunction();
    }

    function compareFunction(a, b) {
        if (a.score < b.score) {
            return -1;
        } else if (a.score > b.score) {
            return 1;
        } else {
            return 0;
        }
    }

    return {
        init: init,
        guess: guess,
        getHighScore: getHighScore
    }
}());
