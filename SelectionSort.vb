Module SelectionSort

    Sub Main()
        Dim numbers() As Integer = {76, 87, 21, 14, 3722, 82, 3, 95, 885}

        Console.WriteLine("Original Array:")
        PrintArray(numbers)

        SelectionSort(numbers)

        Console.WriteLine(vbCrLf & "Sorted Array (Ascending):")
        PrintArray(numbers)

        Console.ReadLine()
    End Sub

    'selection sort algorithm
    Sub SelectionSort(ByRef arr() As Integer)
        Dim n As Integer = arr.Length

        For i As Integer = 0 To n - 2
            Dim minIndex As Integer = i

            For j As Integer = i + 1 To n - 1
                If arr(j) < arr(minIndex) Then
                    minIndex = j
                End If
            Next

            ' swaps elements in array
            If minIndex <> i Then
                Dim temp As Integer = arr(i)
                arr(i) = arr(minIndex)
                arr(minIndex) = temp
            End If
        Next
    End Sub

    'helper method to print array
    Sub PrintArray(arr() As Integer)
        For Each item As Integer In arr
            Console.Write(item & " ")
        Next
        Console.WriteLine()
    End Sub

End Module