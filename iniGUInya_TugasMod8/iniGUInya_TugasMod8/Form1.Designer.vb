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
        Label2 = New Label()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        ComboBox2 = New ComboBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(252, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 32)
        Label1.TabIndex = 0
        Label1.Text = "Temperature Converter"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(335, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 23)
        Label2.TabIndex = 1
        Label2.Text = "Kelompok 6"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(222, 140)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 27)
        TextBox1.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(428, 140)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(348, 283)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 7
        Button1.Text = "Convert"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(318, 347)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(131, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 20)
        Label3.TabIndex = 9
        Label3.Text = "From"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(131, 224)
        Label4.Name = "Label4"
        Label4.Size = New Size(25, 20)
        Label4.TabIndex = 10
        Label4.Text = "To"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(222, 221)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 28)
        ComboBox2.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(192, 349)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 20)
        Label5.TabIndex = 11
        Label5.Text = "Result"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 451)
        Controls.Add(ComboBox2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "TempConv_Kel6"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label5 As Label
End Class
