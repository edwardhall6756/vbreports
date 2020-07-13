Imports System.IO
Public Class AFFfix
    Private kpe(4) As String
    Private delim As String
    Dim dt1 As New DataTable

    Private Sub AFFfix_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kpe(0) = Chr(34) + "event" + Chr(34) + ":{" + Chr(34) + "tagadded" + Chr(34)
        kpe(1) = Chr(34) + "event" + Chr(34) + ":{" + Chr(34) + "recalled" + Chr(34)
        kpe(2) = Chr(34) + "event" + Chr(34) + ":{" + Chr(34) + "appliedFinancialTransaction" + Chr(34)
        kpe(3) = Chr(34) + "event" + Chr(34) + ":{" + Chr(34) + "ceaseAndDesistFiled" + Chr(34)
        delim = "{" + Chr(34) + "outSourcerAccountId" + Chr(34)
        DataGridView1.DataSource = dt1
    End Sub

    Private Sub Jsoninput_Click(sender As Object, e As EventArgs) Handles jsoninput.Click
        With OpenFileDialog1
            .FileName = jsonfile.Text
            .DefaultExt = "json"
            .InitialDirectory = "\\fbpa1fs1\DataEntry\New Business\AFF"
            .Filter = "json files (*.json)|*.json|json Files (*.json)|*.json"
            .ShowDialog()
        End With
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        jsonfile.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub Openjson_Click(sender As Object, e As EventArgs) Handles openjson.Click
        Dim fs As FileStream
        Dim reader As StreamReader
        Dim Line As String = ""
        Dim newline As String = ""
        Dim jsonline As String()
        fs = New FileStream(jsonfile.Text, FileMode.Open)
        reader = New StreamReader(fs)
        ' Dim json As String = "{""name"":""Rap God"",""statistics"":{""likeCount"":""122255"",""dislikeCount"":""4472""}}"

        'TextBox1.Text = read.Item("name").ToString
        'TextBox2.Text = read.Item("statistics")("likeCount").ToString + " " + " times"
        'Line.
        Do

        ' Dim Columns As String()

        Line = reader.ReadLine

            If Line Is Nothing Then Exit Do
            newline = Line.Replace(delim, Environment.NewLine + delim)
            jsonline = newline.Split(Environment.NewLine)
            dt1.Columns.Add("json")
            For x As Integer = 0 To UBound(jsonline)
                dt1.Rows.Add(jsonline(x).ToString)
            Next


        Loop

        reader.Dispose()
        fs.Dispose()

        'Dim jsonline As String = ""
        'jsonline.Replace(delim, Environment.NewLine + delim)
    End Sub
End Class