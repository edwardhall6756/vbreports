Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Office.Interop

Public Class ChangeClientNumber
	Dim Tmilli As Integer
	Dim Tsec As Integer
	Dim Tmin As Integer
	Dim Thour As Integer
	Private LoadThread As System.Threading.Thread
	Private QueryThread As System.Threading.Thread
	Dim dts As DataSet
	Dim excel As String
	Private fn As String
	Dim dt As DataTable
	Dim fi As FileInfo
	Dim count As Integer
	Dim col As Integer
	Dim fcol As Integer
	Dim ocol As Integer
	Dim lines() As String
	Dim cn As SqlConnection
	Private vsql = "--declare @c cursor
--set @c = cursor  for 
--query to identify accounts to move to new customer code---
--select  master.number, master.customer, [dbo].[ELH20200708AFF].[Move to Code] --Set this to the new customer code
--from master with (nolock) 
--join dbo.ELH20200708AFF on (dbo.ELH20200708AFF.[File Number] = master.number)
--where
--select * from [dbo].[mpn10142019cap]
--[dbo].[mpn10142019cap]
--22641
----

set nocount on

--declare @number integer
--declare @oldcode varchar(10)
--declare @newcode varchar(10)
declare @count integer

set @count = 0

--open @c

--fetch next from @c into @number, @oldcode, @newcode

--while @@fetch_status = 0

begin

	set @count += 1 -- @count + 1
	print cast(@number as varchar) + ' count: ' + cast(@count as varchar)
	PRINT ' Old #' +@oldcode
PRINT ' New #' +@NEWcode


	INSERT INTO notes
		(number, created, user0, [action], result, comment)
		VALUES
		(@number, getdate(), 'SYSTEM', 'CUST', 'CHNG', 'CUSTOMER CHANGED | ' + @oldcode + ' | ' + @newcode)


	update master
	set customer = @newcode
	from master with (rowlock)
	where number = @number


	update pdc
	set customer = @newcode
	from pdc with (rowlock) 
	where pdc.number = @number
	

	update promises
	set customer = @newcode
	from promises with (rowlock) 
	where promises.acctid = @number
	
	update payhistory 
	set payhistory.customer = @newcode
	from payhistory with (rowlock) 
	where payhistory.number = @number



	--fetch next from @c into @number, @oldcode, @newcode

end

print 'Total accts updated: ' + cast(@count as varchar)

--close @c
--deallocate @c
"
	Private Sub Stopwatch_Tick(sender As Object, e As EventArgs) Handles StopWatch.Tick
		Tmilli += 1
		If Tmilli = 100 Then
			Tsec += 1
			Tmilli = 0
		ElseIf Tsec = 60 Then
			Tmin += 1
			Tsec = 0
		ElseIf Tmin = 60 Then
			Thour += 1
			Tmin = 0
		End If
		WriteTime()
	End Sub
	Private Sub WriteTime()
		ElapseTextBox.Text = "Elapsed Time " + Strings.Right("0" + Thour.ToString, 2) + " : " + Strings.Right("0" + Tmin.ToString, 2) + " : " + Strings.Right("0" + Tsec.ToString, 2)
	End Sub

	Private Sub Inputxlsx(ByVal filename As String)
		Dim excel As New Excel.Application With {
			.DisplayAlerts = False
		}
		Dim workbook As Excel.Workbook = excel.Workbooks.Open(filename)
		Dim sheet As Excel.Worksheet = workbook.Sheets(1)

		filename = Path.ChangeExtension(filename, ".txt")
		sheet.SaveAs(filename, Microsoft.Office.Interop.Excel.XlFileFormat.xlCSVMSDOS)

		workbook.Close()
		workbook = Nothing

		excel.Quit()
		excel = Nothing
		CheckForIllegalCrossThreadCalls = False
		LoadThread = New System.Threading.Thread(AddressOf ReadFile)
		LoadThread.Start(filename)
		'ReadFile(filename)


	End Sub
	Private Sub ReadFile(ByVal fn As String)
		WriteTime()
		StopWatch.Enabled = True
		ActivityTextBox.Text = " Loading Excel file"
		Dim lines() As String = IO.File.ReadAllLines(fn)

		' add columns only if DGV has none
		col = 0
		If DataGridView1.Columns.Count = 0 Then
			For Each cnam In Split(lines(0), ",")
				DataGridView1.Columns.Add(cnam, cnam)
				ComboBox1.Items.Add(cnam)
				ComboBox2.Items.Add(cnam)
				col += 1
			Next

		End If
		count = 0
		For x As Integer = 1 To UBound(lines)
			DataGridView1.Rows.Add(Split(lines(x).Replace("""", ""), ","))
			count += 1
			WriteTime()

		Next
		Cursor = Cursors.Default
		ACount.Text = count
		'FileColumn.Maximum = col
		'OldColumn.Maximum = col
		StopWatch.Stop()
		StopWatch.Enabled = False
		WriteTime()
		Tmilli = 0
		Tsec = 0
		Tmin = 0
		Thour = 0
		ActivityTextBox.Text = "Seccussful excel load"
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
		OpenFileDialog1.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"

		OpenFileDialog1.ShowDialog()
	End Sub

	Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
		Me.Cursor = Cursors.WaitCursor
		fn = OpenFileDialog1.FileName
		fi = New FileInfo(fn)
		excel = fi.FullName
		Inputxlsx(fn)
	End Sub

	Private Sub MakeChange_Click(sender As Object, e As EventArgs) Handles MakeChange.Click
		CheckForIllegalCrossThreadCalls = False
		ActivityTextBox.Text = "Changing old# to " + TextBox1.Text

		WriteTime()
		StopWatch.Enabled = True
		QueryThread = New System.Threading.Thread(AddressOf RunQuery
)
		QueryThread.Start()
	End Sub
	Public Sub RunQuery()
		WriteTime()
		StopWatch.Enabled = True

		Try
			Cursor = Cursors.WaitCursor
			'Dim cmd As New SqlCommand(vsql)

			cn.Open()
			Dim cm1 As SqlCommand = New SqlCommand(vsql, cn)
			cm1.Parameters.AddWithValue("@number", "000000000")
			cm1.Parameters.AddWithValue("@oldcode", "0")
			cm1.Parameters.AddWithValue("@newcode", TextBox1.Text)
			For Each row As DataGridViewRow In DataGridView1.Rows
				row.Selected = True
				Dim obj(row.Cells.Count - 1) As Object
				For i = 0 To row.Cells.Count - 1
					cm1.Parameters("@number").Value = row.Cells(fcol).Value
					cm1.Parameters("@oldcode").Value = row.Cells(ocol).Value
					cm1.ExecuteNonQuery()

					WriteTime()
				Next
				row.Selected = False
			Next
			cn.Close()
			StopWatch.Stop()
			StopWatch.Enabled = False
			WriteTime()
			Tmilli = 0
			Tsec = 0
			Tmin = 0
			Thour = 0
			ActivityTextBox.Text = "Finished Changing customer numbers."

		Catch ex As System.Exception
			Cursor = Cursors.Default
			MessageBox.Show(ex.Message)
			ActivityTextBox.Text = "Error in Changing customer numbers."
		End Try
		Cursor = Cursors.Default

	End Sub
	Private Function Mkchgenable() As Boolean
		If fcol = ocol Then
			Return False

		ElseIf TextBox1.Text = "" Then
			Return False
		ElseIf DataGridView1.Rows.Count = 0 Then
			Return False
		ElseIf prod.Checked = testdb.checked Then
			Return False
		Else
			Return True
		End If
	End Function

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
		MakeChange.Enabled = Mkchgenable()
	End Sub

	Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
		fcol = ComboBox1.SelectedIndex
		MakeChange.Enabled = Mkchgenable()
	End Sub

	Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
		ocol = ComboBox2.SelectedIndex
		MakeChange.Enabled = Mkchgenable()
	End Sub

	Private Sub Prod_CheckedChanged(sender As Object, e As EventArgs) Handles prod.CheckedChanged
		If prod.Checked Then
			cn = New SqlConnection With {
				.ConnectionString = My.Settings.collect2000ConnectionString
			}
		ElseIf testdb.Checked Then
			cn = New SqlConnection With {
				.ConnectionString = My.Settings.Testdb
			}
		End If
		MakeChange.Enabled = Mkchgenable()
	End Sub

	Private Sub Testdb_CheckedChanged(sender As Object, e As EventArgs) Handles testdb.CheckedChanged
		If prod.Checked Then
			cn = New SqlConnection With {
				.ConnectionString = My.Settings.collect2000ConnectionString
			}
		ElseIf testdb.Checked Then
			cn = New SqlConnection With {
				.ConnectionString = My.Settings.Testdb
			}
		End If
		MakeChange.Enabled = Mkchgenable()
	End Sub
End Class