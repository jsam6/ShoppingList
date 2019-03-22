<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.checkListBox = New System.Windows.Forms.CheckedListBox()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.remBtn = New System.Windows.Forms.Button()
        Me.clrBtn = New System.Windows.Forms.Button()
        Me.itemInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'checkListBox
        '
        Me.checkListBox.FormattingEnabled = True
        Me.checkListBox.Location = New System.Drawing.Point(12, 12)
        Me.checkListBox.Name = "checkListBox"
        Me.checkListBox.Size = New System.Drawing.Size(152, 174)
        Me.checkListBox.TabIndex = 0
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(184, 209)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(75, 32)
        Me.addBtn.TabIndex = 1
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'remBtn
        '
        Me.remBtn.Location = New System.Drawing.Point(184, 31)
        Me.remBtn.Name = "remBtn"
        Me.remBtn.Size = New System.Drawing.Size(75, 31)
        Me.remBtn.TabIndex = 2
        Me.remBtn.Text = "Remove"
        Me.remBtn.UseVisualStyleBackColor = True
        '
        'clrBtn
        '
        Me.clrBtn.Location = New System.Drawing.Point(184, 87)
        Me.clrBtn.Name = "clrBtn"
        Me.clrBtn.Size = New System.Drawing.Size(75, 33)
        Me.clrBtn.TabIndex = 3
        Me.clrBtn.Text = "Clear"
        Me.clrBtn.UseVisualStyleBackColor = True
        '
        'itemInput
        '
        Me.itemInput.Location = New System.Drawing.Point(12, 209)
        Me.itemInput.Name = "itemInput"
        Me.itemInput.Size = New System.Drawing.Size(152, 22)
        Me.itemInput.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.itemInput)
        Me.Controls.Add(Me.clrBtn)
        Me.Controls.Add(Me.remBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.checkListBox)
        Me.Name = "Form1"
        Me.Text = "Shopping List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents checkListBox As CheckedListBox
    Friend WithEvents addBtn As Button
    Friend WithEvents remBtn As Button
    Friend WithEvents clrBtn As Button
    Friend WithEvents itemInput As TextBox
End Class
