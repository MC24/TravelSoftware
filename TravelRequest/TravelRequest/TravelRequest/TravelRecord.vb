<Serializable()>
Public Class TravelRecord

    Public ID As Guid
    Public FirstName As String
    Public LastName As String
    Public Purpose As String
    Public StartDate As Date
    Public EndDate As Date
    Public Amount As Double

    Public Sub TravelRecord()
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("{0,-40}{1,-10}{2,-10}{3,-15}{4,12:d}{5,12:d}{6,12:C}", ID, FirstName, LastName, Purpose, StartDate, EndDate, Amount)
    End Function

End Class
