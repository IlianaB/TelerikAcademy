/* Task Description */
/* 
 Create a function constructor for Person. Each Person must have:
 *	properties `firstname`, `lastname` and `age`
 *	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
 *	age must always be a number in the range 0 150
 *	the setter of age can receive a convertible-to-number value
 *	if any of the above is not met, throw Error
 *	property `fullname`
 *	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
 *	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
 *	it must parse it and set `firstname` and `lastname`
 *	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
 *	all methods and properties must be attached to the prototype of the Person
 *	all methods and property setters must return this, if they are not supposed to return other value
 *	enables method-chaining
 */
function solve() {
    var Person = (function () {
        var firstname, lastname, age, fullname;

        function isValidName(value) {
            var regex = /^[A-Za-z]{3,20}$/gi;

            return regex.test(value);
        }

        function isValidAge(value) {
            var age = parseInt(value, 10);

            return age >= 0 && age <= 150;
        }

        function Person(firstname, lastname, age) {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.fullname = firstname + ' ' + lastname;
        }

        Object.defineProperty(Person.prototype, 'firstname', {
            get: function () {
                return firstname;
            },
            set: function (value) {
                if (!isValidName(value)) {
                    throw Error('Invalid firstname! The firstname should be a string with only Latin letters between 3 and 20 characters')
                }

                firstname = value;

                return this;
            }
        });

        Object.defineProperty(Person.prototype, 'lastname', {
            get: function () {
                return lastname;
            },
            set: function (value) {
                if (!isValidName(value)) {
                    throw Error('Invalid lastname! The lastname should be a string with only Latin letters between 3 and 20 characters')
                }

                lastname = value;

                return this;
            }
        });

        Object.defineProperty(Person.prototype, 'age', {
            get: function () {
                return age;
            },
            set: function (value) {
                if (!isValidAge(value)) {
                    throw Error('Invalid age! The age should be a number between 0 and 150')
                }

                age = parseInt(value, 10);

                return this;
            }
        });

        Object.defineProperty(Person.prototype, 'fullname', {
            get: function () {
                return firstname + ' ' + lastname;
            },
            set: function (value) {
                var names = value.split(' ');

                this.firstname = names[0];
                this.lastname = names[1];

                return this;
            }
        });

        Person.prototype.introduce = function () {
            return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
        };

        return Person;
    }());
    return Person;
}
module.exports = solve;
