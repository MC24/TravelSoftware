<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequestListForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataListBox = New System.Windows.Forms.ListBox()
        Me.AddRequestButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DataListBox
        '
        Me.DataListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataListBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataListBox.FormattingEnabled = True
        Me.DataListBox.ItemHeight = 15
        Me.DataListBox.Location = New System.Drawing.Point(0, 0)
        Me.DataListBox.Name = "DataListBox"
        Me.DataListBox.Size = New System.Drawing.Size(901, 294)
        Me.DataListBox.TabIndex = 0
        '
        'AddRequestButton
        '
        Me.AddRequestButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AddRequestButton.Location = New System.Drawing.Point(0, 267)
        Me.AddRequestButton.Name = "AddRequestButton"
        Me.AddRequestButton.Size = New System.Drawing.Size(901, 27)
        Me.AddRequestButton.TabIndex = 1
        Me.AddRequestButton.Text = "Add Request"
        Me.AddRequestButton.UseVisualStyleBackColor = True
        '
        'RequestListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 294)
        Me.Controls.Add(Me.AddRequestButton)
        Me.Controls.Add(Me.DataListBox)
        Me.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "RequestListForm"
        Me.Text = "Request List"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataListBox As System.Windows.Forms.ListBox
    Friend WithEvents AddRequestButton As System.Windows.Forms.Button
End Class
