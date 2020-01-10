Public Class Hours
    Private _Id As String
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property
    Private _Hora As String
    Public Property Hora() As String
        Get
            Return _Hora
        End Get
        Set(ByVal value As String)
            _Hora = value
        End Set
    End Property
    Private _CustomerID As String
    Public Property CustomerID() As String
        Get
            Return _CustomerID
        End Get
        Set(ByVal value As String)
            _CustomerID = value
        End Set
    End Property

    Public Property Lista() As IEnumerable(Of Customer)
End Class
