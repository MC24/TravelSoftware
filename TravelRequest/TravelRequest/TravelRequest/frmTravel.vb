Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text

Public Class TravelRequestForm

    Dim fileStream As FileStream
    Private Sub ClearInputControls()
        FirstNameBox.Clear()
        LastNameBox.Clear()
        PurposeBox.Clear()
        StartDateBox.Clear()
        EndDateBox.Clear()
        AmountBox.Clear()
    End Sub

    Private Function ValidateNotBlank(input As TextBox) As Boolean
        If input.Text.Trim = String.Empty Then
            Throw New InputBlankException(input.Name & " cannot be blank.")
            Return False
        End If
        Return True
    End Function

    Private Function ValidateStartDate(input As TextBox) As Boolean
        Dim startDate As Date
        Dim currentDate As Date = Today()
        Try
            startDate = Date.Parse(input.Text.Trim)
            If startDate < currentDate Then
                Throw New StartsInPastException
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Private Function ValidateEndDate(input As TextBox, startDate As Date) As Boolean
        Dim endDate As Date
        Try
            endDate = Date.Parse(input.Text.Trim)
            If endDate < startDate Then
                Throw New EndsBeforeStartException
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Private Function ValidateAmount(input As TextBox) As Boolean
        Dim amt As Double
        Try
            amt = Double.Parse(input.Text.Trim)
        Catch ex As Exception
            Throw ex
            Return False
        End Try
        If amt <= 0 Then
            Throw New NonPositiveAmountException
            Return False
        Else
            Return True
        End If
    End Function

    Public Class InputBlankException
        Inherits Exception
        ' default constructor
        Public Sub New()
            MyBase.New("Input cannot be blank.")
        End Sub

        ' constructor for customizing error message
        Public Sub New(messageValue As String)
            MyBase.New(messageValue)
        End Sub

        ' constructor for customizing the exception's error
        ' message and specifying the InnerException object
        Public Sub New(messageValue As String, inner As Exception)
            MyBase.New(messageValue, inner)
        End Sub
    End Class 'InputBlankException

    Public Class StartsInPastException
        Inherits Exception
        ' default constructor
        Public Sub New()
            MyBase.New("Start date is in the past.")
        End Sub

        ' constructor for customizing error message
        Public Sub New(messageValue As String)
            MyBase.New(messageValue)
        End Sub

        ' constructor for customizing the exception's error
        ' message and specifying the InnerException object
        Public Sub New(messageValue As String, inner As Exception)
            MyBase.New(messageValue, inner)
        End Sub
    End Class 'StartsInPastException

    Public Class EndsBeforeStartException
        Inherits Exception
        ' default constructor
        Public Sub New()
            MyBase.New("End date is before start date.")
        End Sub

        ' constructor for customizing error message
        Public Sub New(messageValue As String)
            MyBase.New(messageValue)
        End Sub

        ' constructor for customizing the exception's error
        ' message and specifying the InnerException object
        Public Sub New(messageValue As String, inner As Exception)
            MyBase.New(messageValue, inner)
        End Sub
    End Class 'EndsBeforeStartException

    Public Class NonPositiveAmountException
        Inherits Exception
        ' default constructor
        Public Sub New()
            MyBase.New("Requested amount must be greater than zero.")
        End Sub

        ' constructor for customizing error message
        Public Sub New(messageValue As String)
            MyBase.New(messageValue)
        End Sub

        ' constructor for customizing the exception's error
        ' message and specifying the InnerException object
        Public Sub New(messageValue As String, inner As Exception)
            MyBase.New(messageValue, inner)
        End Sub
    End Class 'NonPositiveAmountException

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ClearInputControls()
    End Sub

    Private Sub DisplayListButton_Click(sender As Object, e As EventArgs) Handles DisplayListButton.Click
        Dim frmRequestList As New RequestListForm
        fileStream.Close()
        MessageLabel.Text = ""
        frmRequestList.ShowDialog()
    End Sub

    Private Sub TravelRequestForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        Dim streamWriter As StreamWriter

        Try
            If (File.Exists("travel.ser")) Then
                fileStream = New FileStream("travel.ser", FileMode.Append)
            Else
                fileStream = New FileStream("travel.ser", FileMode.OpenOrCreate)
                streamWriter = New StreamWriter(fileStream)
            End If
        Catch ex As IOException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function RecordSaved() As Boolean
        Dim travelRecord As New TravelRecord()
        Dim successful As Boolean = True
        Dim formatter As New BinaryFormatter()
        Dim fileName As String = "travel.ser"

        Try

            travelRecord.FirstName = FirstNameBox.Text
            travelRecord.LastName = LastNameBox.Text
            travelRecord.Purpose = PurposeBox.Text
            travelRecord.StartDate = Date.Parse(StartDateBox.Text)
            travelRecord.EndDate = Date.Parse(EndDateBox.Text)
            travelRecord.Amount = Double.Parse(AmountBox.Text)
            travelRecord.ID = Guid.NewGuid()
            formatter.Serialize(fileStream, travelRecord)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            successful = False
        End Try

        Return successful
    End Function

    Private Sub SaveRequestButton_Click(sender As Object, e As EventArgs) Handles SaveRequestButton.Click

            If (RecordSaved()) Then
                MessageLabel.Text = "Record saved successfully"
            Else
                MessageLabel.Text = "Record was not saved successfully"
            End If

    End Sub

    Private Sub TravelRequestForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        fileStream.Close()
    End Sub

End Class
