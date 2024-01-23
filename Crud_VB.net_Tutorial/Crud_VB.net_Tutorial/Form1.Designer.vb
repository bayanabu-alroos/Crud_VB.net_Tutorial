<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TextItemName = New TextBox()
        TextDesign = New TextBox()
        ComboColor = New ComboBox()
        DateTimeInsert = New DateTimePicker()
        RadioAllowed = New RadioButton()
        RadioNotAllowed = New RadioButton()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(232, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(357, 35)
        Label1.TabIndex = 0
        Label1.Text = "Crud Tutorial  Forms"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(47, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 30)
        Label4.TabIndex = 3
        Label4.Text = "Item Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(47, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 30)
        Label3.TabIndex = 4
        Label3.Text = "Design"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(47, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 30)
        Label5.TabIndex = 5
        Label5.Text = "Color"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(47, 285)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 30)
        Label6.TabIndex = 6
        Label6.Text = "Item Date"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(47, 342)
        Label7.Name = "Label7"
        Label7.Size = New Size(166, 30)
        Label7.TabIndex = 7
        Label7.Text = "Warranty Type"
        ' 
        ' TextItemName
        ' 
        TextItemName.Location = New Point(250, 121)
        TextItemName.Multiline = True
        TextItemName.Name = "TextItemName"
        TextItemName.Size = New Size(439, 40)
        TextItemName.TabIndex = 14
        ' 
        ' TextDesign
        ' 
        TextDesign.Location = New Point(250, 175)
        TextDesign.Multiline = True
        TextDesign.Name = "TextDesign"
        TextDesign.Size = New Size(439, 40)
        TextDesign.TabIndex = 15
        ' 
        ' ComboColor
        ' 
        ComboColor.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        ComboColor.FormattingEnabled = True
        ComboColor.Items.AddRange(New Object() {"Black", "Blue", "Golden", "Gray", "White"})
        ComboColor.Location = New Point(250, 227)
        ComboColor.Name = "ComboColor"
        ComboColor.Size = New Size(439, 38)
        ComboColor.Sorted = True
        ComboColor.TabIndex = 18
        ComboColor.TabStop = False
        ' 
        ' DateTimeInsert
        ' 
        DateTimeInsert.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimeInsert.Format = DateTimePickerFormat.Short
        DateTimeInsert.Location = New Point(250, 281)
        DateTimeInsert.Name = "DateTimeInsert"
        DateTimeInsert.Size = New Size(439, 36)
        DateTimeInsert.TabIndex = 19
        ' 
        ' RadioAllowed
        ' 
        RadioAllowed.AutoSize = True
        RadioAllowed.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        RadioAllowed.ForeColor = SystemColors.ButtonFace
        RadioAllowed.Location = New Point(250, 342)
        RadioAllowed.Name = "RadioAllowed"
        RadioAllowed.Size = New Size(118, 34)
        RadioAllowed.TabIndex = 20
        RadioAllowed.TabStop = True
        RadioAllowed.Text = "Allowed"
        RadioAllowed.UseVisualStyleBackColor = True
        ' 
        ' RadioNotAllowed
        ' 
        RadioNotAllowed.AutoSize = True
        RadioNotAllowed.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        RadioNotAllowed.ForeColor = SystemColors.ButtonFace
        RadioNotAllowed.Location = New Point(424, 338)
        RadioNotAllowed.Name = "RadioNotAllowed"
        RadioNotAllowed.Size = New Size(163, 34)
        RadioNotAllowed.TabIndex = 21
        RadioNotAllowed.TabStop = True
        RadioNotAllowed.Text = "Not Allowed"
        RadioNotAllowed.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Teal
        Button1.Font = New Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(250, 418)
        Button1.Name = "Button1"
        Button1.Size = New Size(134, 44)
        Button1.TabIndex = 22
        Button1.Text = "Insert"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkMagenta
        ClientSize = New Size(800, 657)
        Controls.Add(Button1)
        Controls.Add(RadioNotAllowed)
        Controls.Add(RadioAllowed)
        Controls.Add(DateTimeInsert)
        Controls.Add(ComboColor)
        Controls.Add(TextDesign)
        Controls.Add(TextItemName)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextItemName As TextBox
    Friend WithEvents TextDesign As TextBox
    Friend WithEvents ComboColor As ComboBox
    Friend WithEvents DateTimeInsert As DateTimePicker
    Friend WithEvents RadioAllowed As RadioButton
    Friend WithEvents RadioNotAllowed As RadioButton
    Friend WithEvents Button1 As Button

End Class
