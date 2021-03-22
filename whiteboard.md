User Stories___
1. As a librarian, I want to create, read, update, delete, and list books in the catalog, so that we can keep track of our inventory.

2. As a librarian, I want to search for a book by author or title, so that I can find a book when there are a lot of books in the library.

3. As a librarian, I want to enter multiple authors for a book, so that I can include accurate information in my catalog. (Hint: make an authors table and a books table with a many-to-many relationship.)

4. As a patron, I want to check a book out, so that I can take it home with me.

5. As a patron, I want to know how many copies of a book are on the shelf, so that I can see if any are available. (Hint: make a copies table; a book should have many copies.)

6. As a patron, I want to see a history of all the books I checked out, so that I can look up the name of that awesome sci-fi novel I read three years ago. (Hint: make a checkouts table that is a join table between patrons and copies.)

6. As a patron, I want to know when a book I checked out is due, so that I know when to return it.

7. As a librarian, I want to see a list of overdue books, so that I can call up the patron who checked them out and tell them to bring them back - OR ELSE!

Functionality___
1. Book class
  - Full CRUD + Index
  - Properties
    - Author joinentity
    - Title
2. Search functionality
3. Author class
  - Properties
    - Name
    - Book Joinentity
4. AuthorBook class
  - join book and author
  - Many to many
5. Patron Class
  - Properties
    - Name
    - Book Joinentity
6. BookCustomer class
  - join customer and book classes
  - many to many
7. Copies Class
  - CopyCode 
  - DueDate
  - BookCopies join entity
8. BookCopies Class
  - Joins book and copies
  - Many to many
9. Sign features
  - Librarian Login
    - Have access to Books CRUD, Author CRUD
  - Patrons Login
    - See list of books they checked out only.