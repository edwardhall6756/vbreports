<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AFFfix
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
        Me.jsonfile = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.jsoninput = New System.Windows.Forms.Button()
        Me.openjson = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'jsonfile
        '
        Me.jsonfile.Location = New System.Drawing.Point(155, 59)
        Me.jsonfile.Name = "jsonfile"
        Me.jsonfile.Size = New System.Drawing.Size(298, 20)
        Me.jsonfile.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'jsoninput
        '
        Me.jsoninput.Location = New System.Drawing.Point(68, 59)
        Me.jsoninput.Name = "jsoninput"
        Me.jsoninput.Size = New System.Drawing.Size(75, 23)
        Me.jsoninput.TabIndex = 1
        Me.jsoninput.Text = "input"
        Me.jsoninput.UseVisualStyleBackColor = True
        '
        'openjson
        '
        Me.openjson.Location = New System.Drawing.Point(68, 89)
        Me.openjson.Name = "openjson"
        Me.openjson.Size = New System.Drawing.Size(75, 23)
        Me.openjson.TabIndex = 2
        Me.openjson.Text = "Open"
        Me.openjson.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(68, 130)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(980, 244)
        Me.DataGridView1.TabIndex = 3
        '
        'AFFfix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 569)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.openjson)
        Me.Controls.Add(Me.jsoninput)
        Me.Controls.Add(Me.jsonfile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AFFfix"
        Me.Text = "AFFfix"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents jsonfile As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents jsoninput As Button
    Friend WithEvents openjson As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
