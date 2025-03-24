<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerMenuForm
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
        Me.DinnerName = New System.Windows.Forms.Label()
        Me.DisplaySpecialLabel = New System.Windows.Forms.Label()
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupMenu = New System.Windows.Forms.GroupBox()
        Me.GroupMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'DinnerName
        '
        Me.DinnerName.AutoSize = True
        Me.DinnerName.Font = New System.Drawing.Font("Brush Script MT", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinnerName.Location = New System.Drawing.Point(235, 9)
        Me.DinnerName.Name = "DinnerName"
        Me.DinnerName.Size = New System.Drawing.Size(265, 28)
        Me.DinnerName.TabIndex = 0
        Me.DinnerName.Text = "Diner At The Edge Of Space"
        '
        'DisplaySpecialLabel
        '
        Me.DisplaySpecialLabel.AutoSize = True
        Me.DisplaySpecialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplaySpecialLabel.Location = New System.Drawing.Point(83, 65)
        Me.DisplaySpecialLabel.Name = "DisplaySpecialLabel"
        Me.DisplaySpecialLabel.Size = New System.Drawing.Size(67, 29)
        Me.DisplaySpecialLabel.TabIndex = 1
        Me.DisplaySpecialLabel.Text = "         "
        '
        'SoupButton
        '
        Me.SoupButton.Location = New System.Drawing.Point(39, 337)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(195, 54)
        Me.SoupButton.TabIndex = 2
        Me.SoupButton.Text = "Soup of the Day"
        Me.SoupButton.UseVisualStyleBackColor = True
        '
        'SaladButton
        '
        Me.SaladButton.Location = New System.Drawing.Point(272, 337)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(195, 54)
        Me.SaladButton.TabIndex = 3
        Me.SaladButton.Text = "Chef's Special"
        Me.SaladButton.UseVisualStyleBackColor = True
        '
        'FishButton
        '
        Me.FishButton.Location = New System.Drawing.Point(509, 337)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(195, 54)
        Me.FishButton.TabIndex = 4
        Me.FishButton.Text = "Daily Fish"
        Me.FishButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(39, 420)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(665, 54)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GroupMenu
        '
        Me.GroupMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupMenu.Controls.Add(Me.DisplaySpecialLabel)
        Me.GroupMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupMenu.Location = New System.Drawing.Point(39, 50)
        Me.GroupMenu.Name = "GroupMenu"
        Me.GroupMenu.Size = New System.Drawing.Size(652, 261)
        Me.GroupMenu.TabIndex = 6
        Me.GroupMenu.TabStop = False
        Me.GroupMenu.Text = "Specials"
        '
        'DinerMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 486)
        Me.Controls.Add(Me.GroupMenu)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Controls.Add(Me.DinnerName)
        Me.Name = "DinerMenuForm"
        Me.Text = "Menu"
        Me.GroupMenu.ResumeLayout(False)
        Me.GroupMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DinnerName As Label
    Friend WithEvents DisplaySpecialLabel As Label
    Friend WithEvents SoupButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents GroupMenu As GroupBox
End Class
