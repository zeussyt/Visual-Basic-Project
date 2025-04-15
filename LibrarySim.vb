Module LibrarySim

    Class Book
        Public Property Title As String
        Public Property Author As String
        Public Property ISBN As Long

        Public Sub Display()
            Console.WriteLine($"Book Title: {Title} | Author: {Author} | ISBN: {ISBN}")
        End Sub
    End Class

    Sub Main()
        Dim books As New List(Of Book)()
        Dim continueInput As String = "Y"

        Do While continueInput.ToUpper() = "Y"
            Dim p As New Book

            Console.WriteLine()
            Console.WriteLine("=== Enter a New Book ===")

            Console.Write("Title: ")
            p.Title = Console.ReadLine()

            Console.Write("Author: ")
            p.Author = Console.ReadLine()

            Console.Write("ISBN (10-13 digits): ")
            Dim isbnInput As String = Console.ReadLine()
            Long.TryParse(isbnInput, p.ISBN)

            books.Add(p)

            Console.Write("Do you want to add another book? (Y/N): ")
            continueInput = Console.ReadLine()
        Loop

        Console.WriteLine()
        Console.WriteLine("=== The books you entered were ===")
        For Each p In books
            p.Display()
        Next

        Console.ReadLine()
    End Sub

End Module
