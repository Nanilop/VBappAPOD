Imports System.Runtime.Serialization
<Serializable>
Public Class DataSerie
    Private explanation_ As String
    Public Property explanation() As String
        Get
            Return explanation_
        End Get
        Set(ByVal value As String)
            explanation_ = value
        End Set
    End Property
    Private copyright_ As String
    Public Property copyright() As String
        Get
            Return copyright_
        End Get
        Set(ByVal value As String)
            copyright_ = value
        End Set
    End Property
    Private Dates_ As String
    Public Property Dates() As String
        Get
            Return Dates_
        End Get
        Set(ByVal value As String)
            Dates_ = value
        End Set
    End Property
    Private hdurl_ As String
    Public Property hdurl() As String
        Get
            Return hdurl_
        End Get
        Set(ByVal value As String)
            hdurl_ = value
        End Set
    End Property
    Private title_ As String
    Public Property title() As String
        Get
            Return title_
        End Get
        Set(ByVal value As String)
            title_ = value
        End Set
    End Property
    Private media_type_ As String
    Public Property media_type() As String
        Get
            Return media_type_
        End Get
        Set(ByVal value As String)
            media_type_ = value
        End Set
    End Property
    Private url_ As String
    Public Property url() As String
        Get
            Return url_
        End Get
        Set(ByVal value As String)
            url_ = value
        End Set
    End Property
    Private service_version_ As String
    Public Property service_version() As String
        Get
            Return service_version_
        End Get
        Set(ByVal value As String)
            service_version_ = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return title_
    End Function
    '<DataMember(Name:="explanation")> Public explanation As String
    '<DataMember(Name:="copyright")> Public copyright As String
    '<DataMember(Name:="Date")> Public fecha As String
    '<DataMember(Name:="hdurl")> Public hdurl As String
    '<DataMember(Name:="title")> Public title As String
    '<DataMember(Name:="media_type")> Public media_type As String
    '<DataMember(Name:="url")> Public url As String
    '<DataMember(Name:="service_version")> Public service_version As String

End Class
