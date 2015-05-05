<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TravelRequestForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FirstNameBox = New System.Windows.Forms.TextBox()
        Me.LastNameBox = New System.Windows.Forms.TextBox()
        Me.PurposeBox = New System.Windows.Forms.TextBox()
        Me.EndDateBox = New System.Windows.Forms.TextBox()
        Me.StartDateBox = New System.Windows.Forms.TextBox()
        Me.AmountBox = New System.Windows.Forms.TextBox()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.DisplayListButton = New System.Windows.Forms.Button()
        Me.SaveRequestButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "LastName:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 41)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Purpose:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 73)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Start Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(172, 73)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "End Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 108)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Requested Amount:"
        '
        'FirstNameBox
        '
        Me.FirstNameBox.Location = New System.Drawing.Point(74, 5)
        Me.FirstNameBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FirstNameBox.Name = "FirstNameBox"
        Me.FirstNameBox.Size = New System.Drawing.Size(95, 20)
        Me.FirstNameBox.TabIndex = 1
        '
        'LastNameBox
        '
        Me.LastNameBox.Location = New System.Drawing.Point(233, 5)
        Me.LastNameBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LastNameBox.Name = "LastNameBox"
        Me.LastNameBox.Size = New System.Drawing.Size(95, 20)
        Me.LastNameBox.TabIndex = 3
        '
        'PurposeBox
        '
        Me.PurposeBox.Location = New System.Drawing.Point(74, 38)
        Me.PurposeBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PurposeBox.Name = "PurposeBox"
        Me.PurposeBox.Size = New System.Drawing.Size(254, 20)
        Me.PurposeBox.TabIndex = 5
        '
        'EndDateBox
        '
        Me.EndDateBox.Location = New System.Drawing.Point(230, 71)
        Me.EndDateBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EndDateBox.Name = "EndDateBox"
        Me.EndDateBox.Size = New System.Drawing.Size(95, 20)
        Me.EndDateBox.TabIndex = 9
        '
        'StartDateBox
        '
        Me.StartDateBox.Location = New System.Drawing.Point(74, 71)
        Me.StartDateBox.Margin = New System.Windows.Forms.Padding(2)
        Me.StartDateBox.Name = "StartDateBox"
        Me.StartDateBox.Size = New System.Drawing.Size(95, 20)
        Me.StartDateBox.TabIndex = 7
        '
        'AmountBox
        '
        Me.AmountBox.Location = New System.Drawing.Point(113, 106)
        Me.AmountBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AmountBox.Name = "AmountBox"
        Me.AmountBox.Size = New System.Drawing.Size(76, 20)
        Me.AmountBox.TabIndex = 11
        '
        'MessageLabel
        '
        Me.MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MessageLabel.Location = New System.Drawing.Point(10, 179)
        Me.MessageLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(315, 46)
        Me.MessageLabel.TabIndex = 14
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(116, 141)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(64, 23)
        Me.ClearButton.TabIndex = 15
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(186, 141)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(53, 23)
        Me.CloseButton.TabIndex = 16
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'DisplayListButton
        '
        Me.DisplayListButton.Location = New System.Drawing.Point(250, 141)
        Me.DisplayListButton.Name = "DisplayListButton"
        Me.DisplayListButton.Size = New System.Drawing.Size(75, 23)
        Me.DisplayListButton.TabIndex = 17
        Me.DisplayListButton.Text = "Display List"
        Me.DisplayListButton.UseVisualStyleBackColor = True
        '
        'SaveRequestButton
        '
        Me.SaveRequestButton.Location = New System.Drawing.Point(12, 141)
        Me.SaveRequestButton.Name = "SaveRequestButton"
        Me.SaveRequestButton.Size = New System.Drawing.Size(98, 23)
        Me.SaveRequestButton.TabIndex = 18
        Me.SaveRequestButton.Text = "Save Request"
        Me.SaveRequestButton.UseVisualStyleBackColor = True
        '
        'TravelRequestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 244)
        Me.Controls.Add(Me.SaveRequestButton)
        Me.Controls.Add(Me.DisplayListButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.AmountBox)
        Me.Controls.Add(Me.StartDateBox)
        Me.Controls.Add(Me.EndDateBox)
        Me.Controls.Add(Me.PurposeBox)
        Me.Controls.Add(Me.LastNameBox)
        Me.Controls.Add(Me.FirstNameBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TravelRequestForm"
        Me.Text = "Travel Request"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FirstNameBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameBox As System.Windows.Forms.TextBox
    Friend WithEvents PurposeBox As System.Windows.Forms.TextBox
    Friend WithEvents EndDateBox As System.Windows.Forms.TextBox
    Friend WithEvents StartDateBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountBox As System.Windows.Forms.TextBox
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents DisplayListButton As System.Windows.Forms.Button
    Friend WithEvents SaveRequestButton As System.Windows.Forms.Button

End Class
