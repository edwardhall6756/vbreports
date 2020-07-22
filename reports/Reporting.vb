Imports System.Windows.Forms

Public Class Reporting
    Public Tmilli As Integer
    Public Tsec As Integer
    Public Tmin As Integer
    Public Thour As Integer
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True
		If Environment.UserName = "edward.hall" Then ToolsToolStripMenuItem.Visible = True
		If Environment.UserName = "mary.albert" Then ToolsToolStripMenuItem.Visible = True
	End Sub

    Private Sub PPACreditAuditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PPACreditAuditToolStripMenuItem1.Click

        OpenChild(My.Forms.PPACreditAudit)
    End Sub

    Private Sub SettlementsToBe2ndReviewedToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SettlementsToBe2ndReviewedToolStripMenuItem1.Click

        OpenChild(My.Forms.settlement)
    End Sub
    Private Sub OpenChild(cf As Form)
        CloseChildren()
        cf.MdiParent = Me
        cf.Dock = DockStyle.Fill
		cf.WindowState = FormWindowState.Maximized
		cf.ControlBox = False
		cf.ShowIcon = False
        cf.Show()
    End Sub

    Private Sub CloseChildren()
        For Each cf As Form In Me.MdiChildren
            cf.Close()
        Next
    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        CloseChildren()
    End Sub

    Private Sub ExeterSifPifToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExeterSifPifToolStripMenuItem.Click
        OpenChild(My.Forms.ExeterSifPif)
    End Sub

    Private Sub TimezonesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimezonesToolStripMenuItem.Click
        OpenChild(My.Forms.Exception8)
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        OpenChild(My.Forms.Exception2)
    End Sub

    Private Sub Inventory3160DaysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Inventory3160DaysToolStripMenuItem.Click
        OpenChild(My.Forms.Exception5)
    End Sub

    Private Sub Inventory6190DaysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Inventory6190DaysToolStripMenuItem.Click
        OpenChild(My.Forms.Exception6)
    End Sub

    Private Sub First30DaysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles First30DaysToolStripMenuItem.Click
        OpenChild(My.Forms.Exception4)
    End Sub

    Private Sub InventoryWorkGapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryWorkGapToolStripMenuItem.Click
        OpenChild(My.Forms.Exception3)
    End Sub

    Private Sub ContactsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactsToolStripMenuItem.Click
        OpenChild(My.Forms.Exception7)
    End Sub

    Private Sub DialerContactedInLessThan8DaysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DialerContactedInLessThan8DaysToolStripMenuItem.Click
        OpenChild(My.Forms.Exception9)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        OpenChild(My.Forms.AboutBox1)
    End Sub

    Private Sub IinstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IinstructionsToolStripMenuItem.Click
        OpenChild(My.Forms.Help)
    End Sub



    Private Sub LastARCStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LastARCStatusToolStripMenuItem.Click
        OpenChild(My.Forms.LastARCStatus)
    End Sub

    Private Sub DebtSettlementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebtSettlementToolStripMenuItem.Click
        OpenChild(My.Forms.DebtSettlement)
    End Sub

    Private Sub GenericQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenericQueryToolStripMenuItem.Click
        OpenChild(My.Forms.SQLExport)
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub AccountQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountQueryToolStripMenuItem.Click
        OpenChild(My.Forms.AccountQuery)
    End Sub

    Private Sub PendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PendingToolStripMenuItem.Click
        OpenChild(My.Forms.PendingLetterLinkExp)
    End Sub

    Private Sub ProcessedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcessedToolStripMenuItem.Click
        OpenChild(My.Forms.ProcessedLetterLinkExp)
    End Sub

    Private Sub PDCDeletedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PDCDeletedToolStripMenuItem.Click
        OpenChild(My.Forms.PCDDeletedReport)
    End Sub

    Private Sub AFFInputFixToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AFFInputFixToolStripMenuItem.Click
        OpenChild(My.Forms.AFFfix)
    End Sub

	Private Sub TSISMERestrictionRemovalToolStripMenuItem_Click(sender As Object, e As EventArgs) 
		OpenChild(My.Forms.TSISMERestrictionRemoval)
	End Sub

	Private Sub AFFFileCleanUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AFFFileCleanUpToolStripMenuItem.Click
		OpenChild(My.Forms.AFFfix)
	End Sub

	Private Sub DateMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateMaintenanceToolStripMenuItem.Click
		OpenChild(My.Forms.DateMaintenance)
	End Sub
End Class
