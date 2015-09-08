var validator = (function () {
    function isEmpty(text) {
        if (text === undefined || text === null) {
            return true;
        }

        return false;
    }

    function isValidLength(text, min, max) {
        if (text.length < min || text.length > max) {
            return false;
        }

        return true;
    }

    return {
        isEmpty: isEmpty,
        isValidLength: isValidLength
    }
}());
