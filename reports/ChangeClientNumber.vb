Imports System.IO
Imports Microsoft.Office.Interop

Public Class ChangeClientNumber
    Private vsql = "declare @c cursor
set @c = cursor  for 
--query to identify accounts to move to new customer code---
select  master.number, master.customer, [dbo].[ELH20200708AFF].[Move to Code] --Set this to the new customer code
from master with (nolock) 
join dbo.ELH20200708AFF on (dbo.ELH20200708AFF.[File Number] = master.number)
--where
--select * from [dbo].[mpn10142019cap]
--[dbo].[mpn10142019cap]
--22641
----

set nocount on

declare @number integer
declare @oldcode varchar(10)
declare @newcode varchar(10)
declare @count integer

set @count = 0

open @c

fetch next from @c into @number, @oldcode, @newcode

while @@fetch_status = 0

begin

	set @count += 1 -- @count + 1
	print cast(@number as varchar) + ' count: ' + cast(@count as varchar)
	PRINT ' oLD #' +@oldcode
PRINT ' nEW #' +@NEWcode


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



	fetch next from @c into @number, @oldcode, @newcode

end

print 'Total accts updated: ' + cast(@count as varchar)

close @c
deallocate @c
"
    Private Sub ChangeClientNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Inputxlsx(ByVal filename As String)
        Dim excel As New Excel.Application With {
            .DisplayAlerts = False
        }
        Dim workbook As Excel.Workbook = excel.Workbooks.Open(filename)
        Dim sheet As Excel.Worksheet = workbook.Sheets(1)

        filename = Path.ChangeExtension(filename, ".txt")
        sheet.SaveAs(filename, Microsoft.Office.Interop.Excel.XlFileFormat.xlCSVMSDOS)
        'excel.Application.XlFileFormat.xlTextMSDOS)
        'interop.microsoft.Office()
        ' Microsoft.Office.Interop.Excel.XlFileFormat.xlTextMSDOS)
        workbook.Close()
        workbook = Nothing

        excel.Quit()
        excel = Nothing

        ReadFile(filename)


    End Sub
    Private Sub ReadFile(ByVal fn As String)

    End Sub
End Class