<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reporting
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub


	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reporting))
		Me.StatusStrip = New System.Windows.Forms.StatusStrip()
		Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.PPACreditAuditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PPACreditAuditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.SettlementsToBe2ndReviewedToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExeterSifPifToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OperationalExecptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.InventoryWorkGapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.First30DaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Inventory3160DaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Inventory6190DaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TimezonesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DialerContactedInLessThan8DaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DebtSettlementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LetterLinkExceptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProcessedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PDCDeletedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AFFFileCleanUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LastARCStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GenericQueryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AccountQueryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AFFInputFixToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.IinstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.stopwatch = New System.Windows.Forms.Timer(Me.components)
		Me.DateMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.StatusStrip.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'StatusStrip
		'
		Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
		Me.StatusStrip.Location = New System.Drawing.Point(0, 501)
		Me.StatusStrip.Name = "StatusStrip"
		Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
		Me.StatusStrip.Size = New System.Drawing.Size(737, 22)
		Me.StatusStrip.TabIndex = 7
		Me.StatusStrip.Text = "StatusStrip"
		'
		'ToolStripStatusLabel
		'
		Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
		Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
		Me.ToolStripStatusLabel.Text = "Status"
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PPACreditAuditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.CloseToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem1})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
		Me.MenuStrip1.Size = New System.Drawing.Size(737, 24)
		Me.MenuStrip1.TabIndex = 9
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'PPACreditAuditToolStripMenuItem
		'
		Me.PPACreditAuditToolStripMenuItem.AutoToolTip = True
		Me.PPACreditAuditToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.PPACreditAuditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PPACreditAuditToolStripMenuItem1, Me.SettlementsToBe2ndReviewedToolStripMenuItem1, Me.ExeterSifPifToolStripMenuItem, Me.OperationalExecptionsToolStripMenuItem, Me.DebtSettlementToolStripMenuItem, Me.LetterLinkExceptionToolStripMenuItem, Me.PDCDeletedToolStripMenuItem, Me.AFFFileCleanUpToolStripMenuItem})
		Me.PPACreditAuditToolStripMenuItem.Name = "PPACreditAuditToolStripMenuItem"
		Me.PPACreditAuditToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
		Me.PPACreditAuditToolStripMenuItem.Text = "&Reports"
		Me.PPACreditAuditToolStripMenuItem.ToolTipText = "Select Reports"
		'
		'PPACreditAuditToolStripMenuItem1
		'
		Me.PPACreditAuditToolStripMenuItem1.Name = "PPACreditAuditToolStripMenuItem1"
		Me.PPACreditAuditToolStripMenuItem1.Size = New System.Drawing.Size(239, 22)
		Me.PPACreditAuditToolStripMenuItem1.Text = "&PPA Credit Audit"
		'
		'SettlementsToBe2ndReviewedToolStripMenuItem1
		'
		Me.SettlementsToBe2ndReviewedToolStripMenuItem1.Name = "SettlementsToBe2ndReviewedToolStripMenuItem1"
		Me.SettlementsToBe2ndReviewedToolStripMenuItem1.Size = New System.Drawing.Size(239, 22)
		Me.SettlementsToBe2ndReviewedToolStripMenuItem1.Text = "&Settlements to be 2nd reviewed"
		'
		'ExeterSifPifToolStripMenuItem
		'
		Me.ExeterSifPifToolStripMenuItem.Name = "ExeterSifPifToolStripMenuItem"
		Me.ExeterSifPifToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
		Me.ExeterSifPifToolStripMenuItem.Text = "&Exeter Sif/Pif"
		'
		'OperationalExecptionsToolStripMenuItem
		'
		Me.OperationalExecptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.InventoryWorkGapToolStripMenuItem, Me.First30DaysToolStripMenuItem, Me.Inventory3160DaysToolStripMenuItem, Me.Inventory6190DaysToolStripMenuItem, Me.ContactsToolStripMenuItem, Me.TimezonesToolStripMenuItem, Me.DialerContactedInLessThan8DaysToolStripMenuItem})
		Me.OperationalExecptionsToolStripMenuItem.Name = "OperationalExecptionsToolStripMenuItem"
		Me.OperationalExecptionsToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
		Me.OperationalExecptionsToolStripMenuItem.Text = "&Operational Execptions"
		'
		'ToolStripMenuItem2
		'
		Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
		Me.ToolStripMenuItem2.Size = New System.Drawing.Size(277, 22)
		Me.ToolStripMenuItem2.Text = "&2 - Manager Desk Work Gap"
		'
		'InventoryWorkGapToolStripMenuItem
		'
		Me.InventoryWorkGapToolStripMenuItem.Name = "InventoryWorkGapToolStripMenuItem"
		Me.InventoryWorkGapToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
		Me.InventoryWorkGapToolStripMenuItem.Text = "&3 - Inventory Work Gap"
		'
		'First30DaysToolStripMenuItem
		'
		Me.First30DaysToolStripMenuItem.Name = "First30DaysToolStripMenuItem"
		Me.First30DaysToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
		Me.First30DaysToolStripMenuItem.Text = "&4 - First 30 Days"
		'
		'Inventory3160DaysToolStripMenuItem
		'
		Me.Inventory3160DaysToolStripMenuItem.Name = "Inventory3160DaysToolStripMenuItem"
		Me.Inventory3160DaysToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
		Me.Inventory3160DaysToolStripMenuItem.Text = "&5 - Inventory 31 - 60 Days"
		'
		'Inventory6190DaysToolStripMenuItem
		'
		Me.Inventory6190DaysToolStripMenuItem.Name = "Inventory6190DaysToolStripMenuItem"
		Me.Inventory6190DaysToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
		Me.Inventory6190DaysToolStripMenuItem.Text = "&6 - Inventory 61 - 90 Days"
		'
		'ContactsToolStripMenuItem
		'
		Me.ContactsToolStripMenuItem.Name = "ContactsToolStripMenuItem"
		Me.ContactsToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
		Me.ContactsToolStripMenuItem.Text = "&7 - Contacts"
		'
		'TimezonesToolStripMenuItem
		'
		Me.TimezonesToolStripMenuItem.Name = "TimezonesToolStripMenuItem"
		Me.TimezonesToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
		Me.TimezonesToolStripMenuItem.Text = "&8 - Timezones"
		'
		'DialerContactedInLessThan8DaysToolStripMenuItem
		'
		Me.DialerContactedInLessThan8DaysToolStripMenuItem.Name = "DialerContactedInLessThan8DaysToolStripMenuItem"
		Me.DialerContactedInLessThan8DaysToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
		Me.DialerContactedInLessThan8DaysToolStripMenuItem.Text = "&9 - Dialer Contacted in less than 8 days"
		'
		'DebtSettlementToolStripMenuItem
		'
		Me.DebtSettlementToolStripMenuItem.Name = "DebtSettlementToolStripMenuItem"
		Me.DebtSettlementToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
		Me.DebtSettlementToolStripMenuItem.Text = "Debt Settlement"
		'
		'LetterLinkExceptionToolStripMenuItem
		'
		Me.LetterLinkExceptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PendingToolStripMenuItem, Me.ProcessedToolStripMenuItem})
		Me.LetterLinkExceptionToolStripMenuItem.Name = "LetterLinkExceptionToolStripMenuItem"
		Me.LetterLinkExceptionToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
		Me.LetterLinkExceptionToolStripMenuItem.Text = "Letter Link Exception"
		'
		'PendingToolStripMenuItem
		'
		Me.PendingToolStripMenuItem.Name = "PendingToolStripMenuItem"
		Me.PendingToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
		Me.PendingToolStripMenuItem.Text = "Pending"
		'
		'ProcessedToolStripMenuItem
		'
		Me.ProcessedToolStripMenuItem.Name = "ProcessedToolStripMenuItem"
		Me.ProcessedToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
		Me.ProcessedToolStripMenuItem.Text = "Processed"
		'
		'PDCDeletedToolStripMenuItem
		'
		Me.PDCDeletedToolStripMenuItem.Name = "PDCDeletedToolStripMenuItem"
		Me.PDCDeletedToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
		Me.PDCDeletedToolStripMenuItem.Text = "PDC Deleted"
		'
		'AFFFileCleanUpToolStripMenuItem
		'
		Me.AFFFileCleanUpToolStripMenuItem.Name = "AFFFileCleanUpToolStripMenuItem"
		Me.AFFFileCleanUpToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
		Me.AFFFileCleanUpToolStripMenuItem.Text = "AFF File Clean UP"
		'
		'ToolsToolStripMenuItem
		'
		Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LastARCStatusToolStripMenuItem, Me.GenericQueryToolStripMenuItem, Me.AccountQueryToolStripMenuItem, Me.AFFInputFixToolStripMenuItem, Me.DateMaintenanceToolStripMenuItem})
		Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
		Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
		Me.ToolsToolStripMenuItem.Text = "Tools"
		Me.ToolsToolStripMenuItem.Visible = False
		'
		'LastARCStatusToolStripMenuItem
		'
		Me.LastARCStatusToolStripMenuItem.Name = "LastARCStatusToolStripMenuItem"
		Me.LastARCStatusToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.LastARCStatusToolStripMenuItem.Text = "&Last ARC Status"
		'
		'GenericQueryToolStripMenuItem
		'
		Me.GenericQueryToolStripMenuItem.Name = "GenericQueryToolStripMenuItem"
		Me.GenericQueryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.GenericQueryToolStripMenuItem.Text = "Generic Query"
		'
		'AccountQueryToolStripMenuItem
		'
		Me.AccountQueryToolStripMenuItem.Name = "AccountQueryToolStripMenuItem"
		Me.AccountQueryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.AccountQueryToolStripMenuItem.Text = "Account Query"
		'
		'AFFInputFixToolStripMenuItem
		'
		Me.AFFInputFixToolStripMenuItem.Name = "AFFInputFixToolStripMenuItem"
		Me.AFFInputFixToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.AFFInputFixToolStripMenuItem.Text = "AFF Input Fix"
		'
		'CloseToolStripMenuItem
		'
		Me.CloseToolStripMenuItem.AutoToolTip = True
		Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
		Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
		Me.CloseToolStripMenuItem.Text = "&Close"
		Me.CloseToolStripMenuItem.ToolTipText = "Close open form"
		'
		'HelpToolStripMenuItem
		'
		Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.IinstructionsToolStripMenuItem})
		Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
		Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
		Me.HelpToolStripMenuItem.Text = "&About"
		'
		'AboutToolStripMenuItem
		'
		Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.AboutToolStripMenuItem.Text = "About this application"
		'
		'IinstructionsToolStripMenuItem
		'
		Me.IinstructionsToolStripMenuItem.Name = "IinstructionsToolStripMenuItem"
		Me.IinstructionsToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.IinstructionsToolStripMenuItem.Text = "instructions"
		'
		'ExitToolStripMenuItem1
		'
		Me.ExitToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
		Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(38, 20)
		Me.ExitToolStripMenuItem1.Text = "Exit"
		'
		'stopwatch
		'
		Me.stopwatch.Enabled = True
		Me.stopwatch.Interval = 1
		'
		'DateMaintenanceToolStripMenuItem
		'
		Me.DateMaintenanceToolStripMenuItem.Name = "DateMaintenanceToolStripMenuItem"
		Me.DateMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
		Me.DateMaintenanceToolStripMenuItem.Text = "Date Maintenance"
		'
		'Reporting
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(737, 523)
		Me.Controls.Add(Me.StatusStrip)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.HelpButton = True
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.IsMdiContainer = True
		Me.Name = "Reporting"
		Me.Text = "Reporting"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.StatusStrip.ResumeLayout(False)
		Me.StatusStrip.PerformLayout()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
	Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents PPACreditAuditToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PPACreditAuditToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents SettlementsToBe2ndReviewedToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
	Public WithEvents stopwatch As Timer
	Friend WithEvents ExeterSifPifToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OperationalExecptionsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TimezonesToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
	Friend WithEvents Inventory3160DaysToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Inventory6190DaysToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents First30DaysToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents InventoryWorkGapToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DialerContactedInLessThan8DaysToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ContactsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents IinstructionsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DebtSettlementToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LastARCStatusToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GenericQueryToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents AccountQueryToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LetterLinkExceptionToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PendingToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ProcessedToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PDCDeletedToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AFFInputFixToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AFFFileCleanUpToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DateMaintenanceToolStripMenuItem As ToolStripMenuItem
End Class
