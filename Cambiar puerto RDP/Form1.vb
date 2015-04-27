Imports Microsoft.Win32
Imports System

Public Class Form1
    Dim portv As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim value As String
        Dim key As RegistryKey
        key = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp")
        value = key.GetValue("PortNumber", 0)
        key.Close()
        Select Case value
            Case 0 Or 3389
                portv = 3389
                stds.Select()
                port.Enabled = False
            Case Else
                portv = value
                alts.Select()
                port.Text = value
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub alts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alts.CheckedChanged
        If alts.Checked Then
            port.Enabled = True
        Else
            port.Enabled = False
            portv = 3389
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim key As RegistryKey
        Dim errorf As Boolean


        If alts.Checked Then
            If Not IsNumeric(port.Text) Then
                errorf = True
                MsgBox("El puerto TCP debe ser un número comprendido entre 1 y 65535", MsgBoxStyle.Critical, "Error")
            ElseIf port.Text = "" Or port.Text < 1 Or port.Text > 65535 Then
                errorf = True
                MsgBox("El puerto TCP debe ser un número comprendido entre 1 y 65535", MsgBoxStyle.Critical, "Error")
            End If
        End If

        If Not errorf Then
            key = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp", True)
            key.SetValue("PortNumber", portv)
            key.Close()
            MsgBox("El puerto se ha cambiado correctamente a " & portv, MsgBoxStyle.Information, "Éxito")
            Me.Close()
        End If

    End Sub

    Private Sub port_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles port.TextChanged
        If Not IsNumeric(port.Text) Then
            MsgBox("El puerto TCP debe ser un número comprendido entre 1 y 65535", MsgBoxStyle.Critical, "Error")
        Else
            portv = port.Text
        End If

    End Sub
End Class
