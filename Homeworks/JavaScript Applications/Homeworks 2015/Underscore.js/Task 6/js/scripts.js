/* 
 Create a function that:
 *   **Takes** a collection of books
 *   Each book has propeties `title` and `author`
 **  `author` is an object that has properties `firstName` and `lastName`
 *   **finds** the most popular author (the author with biggest number of books)
 *   **prints** the author to the console
 *	if there is more than one author print them all sorted in ascending order by fullname
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */

//function solve(){
    //return function (books) {
var books = [{
    title: 'Book1',
    author: {
        firstName: 'Sanjay',
        lastName: 'Wilfrith'
    }
}, {
    title: 'Book27',
    author: {
        firstName: 'Sanjay',
        lastName: 'Sec'
    }
}, {
    title: 'Book3',
    author: {
        firstName: 'Sanjay',
        lastName: 'Sec'
    }
}];
        var allBooks = _.chain(books)
            .map(function(book) {
            book.author.fullName = book.author.firstName + ' ' + book.author.lastName;

            return book;
        })
            .groupBy(function(book){
                return book.author.fullName;
            })
            .value();

        console.log(allBooks);
    //};
//}

//module.exports = solve;