Public Class Articulo
    'DEFINIMOS LAS PROPIEDADES PARA EL ARTICULO !
    Private _CodigoArticulo As String
    Public Property CodigoArticulo() As String
        Get
            Return _CodigoArticulo
        End Get
        Set(ByVal value As String)
            _CodigoArticulo = value
        End Set
    End Property

    Private _DescripcionArticulo As String
    Public Property DescripcionArticulo() As String
        Get
            Return _DescripcionArticulo
        End Get
        Set(ByVal value As String)
            _DescripcionArticulo = value
        End Set
    End Property
End Class
