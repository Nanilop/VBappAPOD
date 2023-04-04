Imports System.Net
Imports System.Security.Policy
Imports System.Text.Json

Public Class Form1
    Private a As Integer = 1

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Function ReadSerie(url As String) As Image

        Try

            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Accept = "application/json"
            '//request.
            '//request.Credentials = New NetworkCredential("api_key", "sOhsjgchCQ2BhyCnUZ7r61qkNw3m0S91SU3fEmXZ");
            '//request.Headers.Add("api_key","sOhsjgchCQ2BhyCnUZ7r61qkNw3m0S91SU3fEmXZ");
            '//request.Headers.Add("api_key", "sOhsjgchCQ2BhyCnUZ7r61qkNw3m0S91SU3fEmXZ");
            '//
            '//request.Headers["api_key"] = "sOhsjgchCQ2BhyCnUZ7r61qkNw3m0S91SU3fEmXZ";
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            If (response.StatusCode <> HttpStatusCode.OK) Then
                Throw New Exception(String.Format(
                                "Server error (HTTP {0}: {1}).",
                                response.StatusCode,
                                response.StatusDescription))
            End If
            '//DataContractJsonSerializer jsonSerializer = New DataContractJsonSerializer(TypeOf(Response));
            '//object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
            '//Response jsonResponse = objResponse as Response;
            '//Image datos = JsonSerializer.Deserialize<Image>(response.GetResponseStream());
            '//return datos;
            Dim stream = response.GetResponseStream()

            Return Bitmap.FromStream(stream)


        Catch e As Exception

            MessageBox.Show(e.Message.ToString())
            Return Nothing
        End Try
    End Function
    Public Function Meses(mes As Integer) As String
        Dim s() As String = {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"}
        Return s(mes - 1)
    End Function
    Public Function Dia(dias As Integer) As String

        Dim s() As String = {"01", "02", "03", "04", "05", "06", "07", "08", "09",
                "10", "11", "12", "13", "14", "15", "16", "17", "18", "19",
            "20", "21", "22", "23", "24", "25", "26", "27", "28", "29",
            "30", "31"}
        Return s(dias - 1)
    End Function
    Public Function ReadSerie(Inicio As DateTime, Final As DateTime) As List(Of DataSerie)
        Try
            Dim filtro As String = "start_date=" + Inicio.Year.ToString() + "-" + Meses(Inicio.Month) +
                        "-" + Dia(Inicio.Day) + "&end_date=" + Final.Year.ToString() + "-" + Meses(Final.Month) +
                        "-" + Dia(Final.Day) + "&"
            Dim url As String = "https://api.nasa.gov/planetary/apod?" + filtro + "api_key=sOhsjgchCQ2BhyCnUZ7r61qkNw3m0S91SU3fEmXZ"
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Accept = "application/json"
            '//request.
            '//request.Credentials = New NetworkCredential("api_key", "sOhsjgchCQ2BhyCnUZ7r61qkNw3m0S91SU3fEmXZ");
            '//request.Headers.Add("api_key","sOhsjgchCQ2BhyCnUZ7r61qkNw3m0S91SU3fEmXZ");
            '//request.Headers.Add("api_key", "sOhsjgchCQ2BhyCnUZ7r61qkNw3m0S91SU3fEmXZ");
            '//
            '//request.Headers["api_key"] = "sOhsjgchCQ2BhyCnUZ7r61qkNw3m0S91SU3fEmXZ";
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            If (response.StatusCode <> HttpStatusCode.OK) Then
                Throw New Exception(String.Format(
                    "Server error (HTTP {0}: {1}).",
                    response.StatusCode,
                    response.StatusDescription))
            End If
            Try
                If IsNothing(response.Headers("X-RateLimit-Remaining")) Then
                    a = CType(response.Headers("X-RateLimit-Remaining"), Integer)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
                Return Nothing
            End Try
            Dim datos As List(Of DataSerie) = JsonSerializer.Deserialize(Of List(Of DataSerie))(response.GetResponseStream())

            '//DataContractJsonSerializer jsonSerializer = New DataContractJsonSerializer(TypeOf(Response));
            '//object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
            '//Response jsonResponse = objResponse as Response;
            '//return jsonResponse;
            Return datos

        Catch e As Exception
            MessageBox.Show(e.Message.ToString())
            Return Nothing
        End Try
    End Function

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        listFotos.Enabled = False
        button1.Enabled = False
        listFotos.Text = ""
        picFoto.Image = Nothing
        If (a > 0) Then
            Dim response As List(Of DataSerie) = ReadSerie(dtpInicial.Value, dtpFinal.Value)
            listFotos.Items.Clear()
            For Each b In response
                listFotos.Items.Add(b)
            Next
            listFotos.Enabled = True
            button1.Enabled = True
        Else
            MessageBox.Show("No quedan intentos. Trate mañana")
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        button1.Enabled = False
        listFotos.Enabled = False
        btnFiltrar.Enabled = False
        If IsNothing(listFotos.SelectedItem) Then
            MessageBox.Show("Seleccione una imagen")

        Else
            Dim filt As DataSerie = CType(listFotos.SelectedItem, DataSerie)
            Dim response As Image

            If (btnHD.Checked) Then

                    response = ReadSerie(filt.hdurl)

                Else

                    response = ReadSerie(filt.url)
                End If

                picFoto.SizeMode = PictureBoxSizeMode.Zoom
                picFoto.Image = response


        End If
        button1.Enabled = True
        listFotos.Enabled = True
        btnFiltrar.Enabled = True
    End Sub
End Class