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
        btEjecutar = New Button()
        lstMostrarPares = New ListBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btEjecutar
        ' 
        btEjecutar.Location = New Point(48, 42)
        btEjecutar.Name = "btEjecutar"
        btEjecutar.Size = New Size(155, 40)
        btEjecutar.TabIndex = 0
        btEjecutar.Text = "Ejecutar"
        btEjecutar.UseVisualStyleBackColor = True
        ' 
        ' lstMostrarPares
        ' 
        lstMostrarPares.FormattingEnabled = True
        lstMostrarPares.ItemHeight = 20
        lstMostrarPares.Location = New Point(297, 23)
        lstMostrarPares.Name = "lstMostrarPares"
        lstMostrarPares.Size = New Size(122, 424)
        lstMostrarPares.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(284, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 20)
        Label1.TabIndex = 2
        Label1.Text = "Los numeros pares son:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(lstMostrarPares)
        Controls.Add(btEjecutar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btEjecutar As Button
    Friend WithEvents lstMostrarPares As ListBox
    Friend WithEvents Label1 As Label
End Class
