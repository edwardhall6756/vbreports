Imports System.Data.SqlClient

Public Class DateMaintenance
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		GetFileData()
	End Sub
	Private Sub GetFileData()
		Dim dt1 As New DataTable
		Dim vsql As String
		vsql = "select m.number,m.closed,m.Returned "
		vsql += "From master m with(nolock) "
		vsql += "where m.number = '" + filenumber.Text.Trim + "'"
		Cursor = Cursors.WaitCursor
		Dim cmd As New SqlCommand(vsql)
		Dim cn As New SqlConnection With {
			.ConnectionString = My.Settings.collect2000ConnectionString
		}
		Dim da1 As SqlDataAdapter = New SqlDataAdapter(vsql, cn.ConnectionString)
		da1.SelectCommand.CommandTimeout = 1800
		dt1.Clear()
		cn.Open()
		da1.Fill(dt1)
		da1.Dispose()
		cn.Close()
		If dt1.Rows.Count = 1 Then
			closedbox.Text = dt1.Rows(0).Item(1)
			returnedbox.Text = dt1.Rows(0).Item(2)
		ElseIf dt1.rows.count > 1 Then

		Else

		End If

		Cursor = Cursors.Default
	End Sub

	Private Sub DateMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub


	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
		Dim msg = "You are about to change the Closed date for this File Number. 
Do you want to continue?"
		Dim title = "Data Changing Request"
		Dim response = MsgBox(msg, style, title)
		If response = MsgBoxResult.Yes Then
			msg = "This will change the closed date to: " + ClosedDate.Value.ToShortDateString + " 
Are you certain this is what you want to do?"
			response = MsgBox(msg, style, title)
			If response = MsgBoxResult.Yes Then SaveClosed()
		End If
	End Sub
	Private Sub SaveClosed()
		Dim vsql As String
		vsql = "update master "
		vsql += "set closed = '" + ClosedDate.Value.ToShortDateString.ToString + "'"
		vsql += "where number = '" + filenumber.Text.Trim + "'"
		Cursor = Cursors.WaitCursor

		Dim cn As New SqlConnection With {
			.ConnectionString = My.Settings.collect2000ConnectionString
		}
		cn.Open()
		Dim cmd As New SqlCommand(vsql, cn)
		cmd.ExecuteNonQuery()
		cn.Close()
		GetFileData()
	End Sub
	Private Sub SaveReturned()
		Dim vsql As String
		vsql = "update master "
		vsql += "set returned = '" + ReturnedDate.Value.ToShortDateString.ToString + "'"
		vsql += "where number = '" + filenumber.Text.Trim + "'"
		Cursor = Cursors.WaitCursor

		Dim cn As New SqlConnection With {
			.ConnectionString = My.Settings.collect2000ConnectionString
		}
		cn.Open()
		Dim cmd As New SqlCommand(vsql, cn)
		cmd.ExecuteNonQuery()
		cn.Close()
		GetFileData()
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

		Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
		Dim msg = "You are about to change the Returned date for this File Number. 
Do you want to continue?"
		Dim title = "Data Changing Request"
		Dim response = MsgBox(msg, style, title)
		If response = MsgBoxResult.Yes Then
			msg = "This will change the Returned date to: " + ReturnedDate.Value.ToShortDateString + " 
Are you certain this is what you want to do?"
			response = MsgBox(msg, style, title)
			If response = MsgBoxResult.Yes Then SaveReturned()
		End If
	End Sub
End Class