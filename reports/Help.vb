﻿Public Class Help
    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.AppendText(Chr(13))
        RichTextBox1.AppendText(Space(25) + "1.) " + My.Resources.Resource1.output_file + Chr(13))
        RichTextBox1.AppendText(Chr(13))
        RichTextBox1.AppendText(Space(25) + "2.) " + My.Resources.Resource1.startdate + Chr(13))
        RichTextBox1.AppendText(Chr(13))
        RichTextBox1.AppendText(Space(25) + "3.) " + My.Resources.Resource1.enddate + Chr(13))
        RichTextBox1.AppendText(Chr(13))
        RichTextBox1.AppendText(Space(25) + "4.) " + My.Resources.Resource1.output_TextBox + Chr(13))
        RichTextBox1.AppendText(Chr(13))
        RichTextBox1.AppendText(Space(25) + "5.) " + My.Resources.Resource1.filetype + Chr(13))
        RichTextBox1.AppendText(Chr(13))
        RichTextBox1.AppendText(Space(25) + "6.) " + My.Resources.Resource1.Generate + Chr(13))
        RichTextBox1.AppendText(Chr(13))
        RichTextBox1.AppendText(Space(25) + "7.) " + My.Resources.Resource1.Export + Chr(13))
    End Sub
End Class