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
        Label3 = New Label()
        txtAdjacent = New TextBox()
        txtHypotenuse = New TextBox()
        txtOpposite = New TextBox()
        btnClose = New Button()
        btnCalculateOpposite = New Button()
        btnCalculateAdjacent = New Button()
        btnCalculateHypotenuse = New Button()
        lblHeading = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(239, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 20)
        Label1.TabIndex = 0
        Label1.Text = "Adjacent"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(239, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 0
        Label2.Text = "Opposite"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(239, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 20)
        Label3.TabIndex = 0
        Label3.Text = "Hypotenuse"
        ' 
        ' txtAdjacent
        ' 
        txtAdjacent.Location = New Point(396, 94)
        txtAdjacent.Name = "txtAdjacent"
        txtAdjacent.Size = New Size(125, 27)
        txtAdjacent.TabIndex = 1
        ' 
        ' txtHypotenuse
        ' 
        txtHypotenuse.Location = New Point(396, 187)
        txtHypotenuse.Name = "txtHypotenuse"
        txtHypotenuse.Size = New Size(125, 27)
        txtHypotenuse.TabIndex = 1
        ' 
        ' txtOpposite
        ' 
        txtOpposite.Location = New Point(396, 142)
        txtOpposite.Name = "txtOpposite"
        txtOpposite.Size = New Size(125, 27)
        txtOpposite.TabIndex = 1
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(348, 364)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnCalculateOpposite
        ' 
        btnCalculateOpposite.Location = New Point(304, 306)
        btnCalculateOpposite.Name = "btnCalculateOpposite"
        btnCalculateOpposite.Size = New Size(173, 29)
        btnCalculateOpposite.TabIndex = 2
        btnCalculateOpposite.Text = "Calculate Opposite"
        btnCalculateOpposite.UseVisualStyleBackColor = True
        ' 
        ' btnCalculateAdjacent
        ' 
        btnCalculateAdjacent.Location = New Point(107, 306)
        btnCalculateAdjacent.Name = "btnCalculateAdjacent"
        btnCalculateAdjacent.Size = New Size(173, 29)
        btnCalculateAdjacent.TabIndex = 2
        btnCalculateAdjacent.Text = "Calculate Adjacent"
        btnCalculateAdjacent.UseVisualStyleBackColor = True
        ' 
        ' btnCalculateHypotenuse
        ' 
        btnCalculateHypotenuse.Location = New Point(505, 306)
        btnCalculateHypotenuse.Name = "btnCalculateHypotenuse"
        btnCalculateHypotenuse.Size = New Size(173, 29)
        btnCalculateHypotenuse.TabIndex = 2
        btnCalculateHypotenuse.Text = "Calculate Hypotenuse"
        btnCalculateHypotenuse.UseVisualStyleBackColor = True
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Times New Roman", 24F, FontStyle.Italic, GraphicsUnit.Point)
        lblHeading.Location = New Point(21, 19)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(779, 47)
        lblHeading.TabIndex = 3
        lblHeading.Text = "Enter any Two sides of a Right Angled Triangle"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(lblHeading)
        Controls.Add(btnCalculateAdjacent)
        Controls.Add(btnCalculateHypotenuse)
        Controls.Add(btnCalculateOpposite)
        Controls.Add(btnClose)
        Controls.Add(txtOpposite)
        Controls.Add(txtHypotenuse)
        Controls.Add(txtAdjacent)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Pythagorus Theorem"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAdjacent As TextBox
    Friend WithEvents txtHypotenuse As TextBox
    Friend WithEvents txtOpposite As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnCalculateOpposite As Button
    Friend WithEvents btnCalculateAdjacent As Button
    Friend WithEvents btnCalculateHypotenuse As Button
    Friend WithEvents lblHeading As Label
End Class
