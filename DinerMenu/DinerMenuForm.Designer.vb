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
        Me.components = New System.ComponentModel.Container()
        Me.DinerNameLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DisplaySpecialLabel = New System.Windows.Forms.Label()
        Me.FoodPicture1 = New System.Windows.Forms.PictureBox()
        Me.FoodPicture2 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.FoodPicture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodPicture2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DinerNameLabel
        '
        Me.DinerNameLabel.AutoSize = True
        Me.DinerNameLabel.Font = New System.Drawing.Font("Niagara Solid", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinerNameLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.DinerNameLabel.Location = New System.Drawing.Point(413, 18)
        Me.DinerNameLabel.Name = "DinerNameLabel"
        Me.DinerNameLabel.Size = New System.Drawing.Size(672, 115)
        Me.DinerNameLabel.TabIndex = 0
        Me.DinerNameLabel.Text = "California Dinin' Specials"
        Me.DinerNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SoupButton)
        Me.GroupBox1.Controls.Add(Me.SaladButton)
        Me.GroupBox1.Controls.Add(Me.FishButton)
        Me.GroupBox1.Controls.Add(Me.ExitButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 741)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1468, 143)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'SoupButton
        '
        Me.SoupButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SoupButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SoupButton.Location = New System.Drawing.Point(24, 30)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(208, 93)
        Me.SoupButton.TabIndex = 0
        Me.SoupButton.Text = "Soup"
        Me.SoupButton.UseVisualStyleBackColor = False
        '
        'SaladButton
        '
        Me.SaladButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SaladButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SaladButton.Location = New System.Drawing.Point(253, 30)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(208, 93)
        Me.SaladButton.TabIndex = 1
        Me.SaladButton.Text = "Salad"
        Me.SaladButton.UseVisualStyleBackColor = False
        '
        'FishButton
        '
        Me.FishButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FishButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FishButton.Location = New System.Drawing.Point(482, 30)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(208, 93)
        Me.FishButton.TabIndex = 2
        Me.FishButton.Text = "Fish"
        Me.FishButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ExitButton.Location = New System.Drawing.Point(1237, 30)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(208, 93)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'DisplaySpecialLabel
        '
        Me.DisplaySpecialLabel.Font = New System.Drawing.Font("Niagara Solid", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplaySpecialLabel.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.DisplaySpecialLabel.Location = New System.Drawing.Point(12, 133)
        Me.DisplaySpecialLabel.Name = "DisplaySpecialLabel"
        Me.DisplaySpecialLabel.Size = New System.Drawing.Size(980, 605)
        Me.DisplaySpecialLabel.TabIndex = 2
        Me.DisplaySpecialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FoodPicture1
        '
        Me.FoodPicture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FoodPicture1.Location = New System.Drawing.Point(1006, 133)
        Me.FoodPicture1.Name = "FoodPicture1"
        Me.FoodPicture1.Size = New System.Drawing.Size(468, 292)
        Me.FoodPicture1.TabIndex = 3
        Me.FoodPicture1.TabStop = False
        '
        'FoodPicture2
        '
        Me.FoodPicture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FoodPicture2.Location = New System.Drawing.Point(1006, 443)
        Me.FoodPicture2.Name = "FoodPicture2"
        Me.FoodPicture2.Size = New System.Drawing.Size(468, 292)
        Me.FoodPicture2.TabIndex = 4
        Me.FoodPicture2.TabStop = False
        '
        'DinerMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1492, 896)
        Me.Controls.Add(Me.FoodPicture2)
        Me.Controls.Add(Me.FoodPicture1)
        Me.Controls.Add(Me.DisplaySpecialLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DinerNameLabel)
        Me.Name = "DinerMenuForm"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "California Dinin' Special Menu"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.FoodPicture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodPicture2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DinerNameLabel As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents SoupButton As Windows.Forms.Button
    Friend WithEvents SaladButton As Windows.Forms.Button
    Friend WithEvents FishButton As Windows.Forms.Button
    Friend WithEvents ExitButton As Windows.Forms.Button
    Friend WithEvents DisplaySpecialLabel As Windows.Forms.Label
    Friend WithEvents FoodPicture1 As Windows.Forms.PictureBox
    Friend WithEvents FoodPicture2 As Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
End Class
