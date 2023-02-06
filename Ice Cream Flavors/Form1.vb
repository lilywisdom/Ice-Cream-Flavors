'Name We All Scream For Ice Cream
'Purpose Pick your favorite ice cream flavor
'Programmer Alison

Option Strict On
Option Infer Off
Option Explicit On

Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class frmMain

    Private Sub lbFlavors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbFlavors.SelectedIndexChanged
        If lbFlavors.SelectedIndex = 0 Then
            picIceCream.Image = My.Resources.strawberry
        ElseIf lbFlavors.SelectedIndex = 1 Then
            picIceCream.Image = My.Resources.vanil
        ElseIf lbFlavors.SelectedIndex = 2 Then
            picIceCream.Image = My.Resources.choco
        ElseIf lbFlavors.SelectedIndex = 3 Then
            picIceCream.Image = My.Resources.coffee
        ElseIf lbFlavors.SelectedIndex = 4 Then
            picIceCream.Image = My.Resources.pistacho
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
