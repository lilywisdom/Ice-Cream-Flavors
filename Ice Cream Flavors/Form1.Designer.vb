<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lbFlavors = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picIceCream = New System.Windows.Forms.PictureBox()
        CType(Me.picIceCream, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbFlavors
        '
        Me.lbFlavors.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFlavors.FormattingEnabled = True
        Me.lbFlavors.ItemHeight = 25
        Me.lbFlavors.Items.AddRange(New Object() {"Strawberry ", "Vanilla", "Chocolate ", "Coffee", "Pistachio"})
        Me.lbFlavors.Location = New System.Drawing.Point(339, 86)
        Me.lbFlavors.Name = "lbFlavors"
        Me.lbFlavors.Size = New System.Drawing.Size(103, 129)
        Me.lbFlavors.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(339, 236)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 47)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picIceCream
        '
        Me.picIceCream.Image = Global.Ice_Cream_Flavors.My.Resources.Resources.na
        Me.picIceCream.Location = New System.Drawing.Point(30, 45)
        Me.picIceCream.Name = "picIceCream"
        Me.picIceCream.Size = New System.Drawing.Size(289, 238)
        Me.picIceCream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIceCream.TabIndex = 1
        Me.picIceCream.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(472, 335)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picIceCream)
        Me.Controls.Add(Me.lbFlavors)
        Me.Name = "frmMain"
        Me.Text = "Ice Cream Flavors"
        CType(Me.picIceCream, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbFlavors As ListBox
    Friend WithEvents picIceCream As PictureBox
    Friend WithEvents btnExit As Button
End Class
