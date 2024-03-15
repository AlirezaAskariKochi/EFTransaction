# EF Core Transactions with Savepoints Example

This repository demonstrates the use of Entity Framework (EF) Core transactions with savepoints in an ASP.NET 8 application. The code illustrates how to manage database operations transactionally, with the ability to roll back to specific points in the transaction if an error occurs.
This C# code snippet demonstrates the use of Entity Framework transactions with savepoints in an ASP.NET application. It showcases a scenario where a Book and a Student are added to a database within a transaction. A savepoint is created after the initial operations, and a second Book is added. An intentional NullReferenceException is thrown to simulate an error, triggering a rollback to the savepoint. This ensures that the first Book and Student remain saved, while the second Book addition is discarded. The transaction is then committed up to the savepoint, preserving partial changes despite the exception.

## Key Features

•  [**Transactional Operations**](https://www.bing.com/search?form=SKPBOT&q=Transactional%20Operations): Ensures that database operations such as adding entities are executed within a transaction scope.

•  [**Savepoints**](https://www.bing.com/search?form=SKPBOT&q=Savepoints): Allows setting a point within a transaction to which you can roll back without discarding the entire transaction.

•  [**Exception Handling**](https://www.bing.com/search?form=SKPBOT&q=Exception%20Handling): Demonstrates how to handle exceptions and roll back to a savepoint when an error is encountered.


## Code Explanation

The core functionality is encapsulated within a `using` block that ensures the disposal of the `dbContext` and `transaction` objects. Here's a breakdown of the critical sections:

•  [**Initialization**](https://www.bing.com/search?form=SKPBOT&q=Initialization): A new `ApplicationDbContext` instance is created, and a transaction is begun.

•  [**Entity Creation**](https://www.bing.com/search?form=SKPBOT&q=Entity%20Creation): New `Book` and `Student` entities are added to the context and saved to the database.

•  [**Savepoint Creation**](https://www.bing.com/search?form=SKPBOT&q=Savepoint%20Creation): After the initial save, a savepoint is created using `transaction.CreateSavepoint("SavepointName")`.

•  [**Error Simulation**](https://www.bing.com/search?form=SKPBOT&q=Error%20Simulation): An exception is intentionally thrown to simulate an error condition.

•  [**Rollback to Savepoint**](https://www.bing.com/search?form=SKPBOT&q=Rollback%20to%20Savepoint): The transaction is rolled back to the previously created savepoint using `transaction.RollbackToSavepoint("SavepointName")`.

•  [**Commit up to Savepoint**](https://www.bing.com/search?form=SKPBOT&q=Commit%20up%20to%20Savepoint): The transaction is committed up to the savepoint, preserving the changes made before the error occurred.



Contributions make the open-source community an amazing place to learn, inspire, and create. Any contributions you make are greatly appreciated.

Contact
ALi Reza Askari Kochi - ALireza_Askari_Kochi@outlook.com - https://www.linkedin.com/in/alireza-askari-kochi-2274475a/

Project Link: https://github.com/AlirezaAskariKochi/EFTransaction.git
