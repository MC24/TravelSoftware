Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class RequestListForm

    Dim fileStream As FileStream

    Private Sub RequestListForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        Try
            fileStream = New FileStream("travel.ser", FileMode.Open, FileAccess.Read)
        Catch ex As IOException
            MessageBox.Show("Error in creating filestream")
        End Try

        LoadList()

    End Sub

    Public Sub LoadList()

        Dim formatter As New BinaryFormatter()

        Dim recordList As New List(Of TravelRecord)

        Do While (fileStream.Position <> fileStream.Length)
            Dim record As TravelRecord = formatter.Deserialize(fileStream)
            recordList.Add(record)
        Loop

        If (fileStream.Length > 0) Then
            Try
                For i As Integer = 0 To recordList.Count - 1 Step 1
                    DataListBox.Items.Add(recordList(i).ToString())
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub RequestListForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        fileStream.Close()
    End Sub
End Class