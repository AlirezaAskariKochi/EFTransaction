
using EFTransaction.App;

using (var dbContext = new ApplicationDbContext())
    {
        using (var transaction = dbContext.Database.BeginTransaction())
        {
            try
            {
            var rnd=new Random();
            int i = rnd.Next();
            // Create a new Book
            var newBook1 = new Book { Title = $"Book {i}" };
            dbContext.Books.Add(newBook1);
            dbContext.SaveChanges();


            // Create a new student
            var newStudent = new Student { Name = $"Student {i}", BookIds = new List<int> { newBook1.Id } };
                dbContext.Students.Add(newStudent);
                dbContext.SaveChanges();

                // Savepoint
                transaction.CreateSavepoint("Savepoint");

            // Create a new Book2
            var newBook2 = new Book { Title = $"Book {i+1}" };
            dbContext.Books.Add(newBook2);
            dbContext.SaveChanges();

            //
            throw new NullReferenceException("Test Exception");

            // If everything succeeds, commit the transaction
            transaction.Commit();
            }
            catch (NullReferenceException ex)
            {
            // If an NullReferenceException occurs, roll back to the savepoint
            transaction.RollbackToSavepoint("Savepoint");
            // If everything succeeds, commit the transaction till the savepoint so save an student i with book i but book (i+1) dose not create
            transaction.Commit();

        }
        catch (Exception ex)
        {
            // Handle exceptions or rollback the transaction
            transaction.Rollback();
        }
        }
    
}
