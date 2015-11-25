﻿Imports System.IO

Public Class Form1
    Private Sub howtoconnect_Click(sender As Object, e As EventArgs) Handles howtoconnect.Click
        Process.Start("www.wowaddictz.net")
    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
        MessageBox.Show("For assistance please visit website.", "Help")
    End Sub

    Private Sub about_Click(sender As Object, e As EventArgs) Handles about.Click
        MessageBox.Show("Wow-Addictz Launching ver. 0.1")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Settings.wowdir = String.Empty Then
            My.Settings.wowdir = textwowdir.Text
        End If

    End Sub

    Private Sub textwowdir_TextChanged(sender As Object, e As EventArgs) Handles textwowdir.TextChanged

    End Sub

    Private Sub buttonbrowse_Click(sender As Object, e As EventArgs) Handles buttonbrowse.Click
        FolderBrowserDialog1.ShowDialog()
        Dim selectedwowdir As String = FolderBrowserDialog1.SelectedPath
        If File.Exists(selectedwowdir + "\wow.exe") Then
            My.Settings.wowdir = selectedwowdir
            My.Settings.Save()
            selectedwowdir = textwowdir.Text
        Else
            MessageBox.Show("Error finding wow.exe. Please select the folder with wow.exe in it. If you don't have the client please see our website or How to connect above.", "Error")

        End If
    End Sub

    Private Sub buttonplay_Click(sender As Object, e As EventArgs) Handles buttonplay.Click
        If textwowdir.Text = String.Empty Then
            MessageBox.Show("Error finding wow.exe. Please select the folder with wow.exe in it. If you don't have the client please see our website or How to connect above.", "Error")
        ElseIf Not File.Exists(textwowdir.Text + "\wow.exe") Then
            MessageBox.Show("Error finding wow.exe. Please select the folder with wow.exe in it. If you don't have the client please see our website or How to connect above.", "Error")
        Else
            Process.Start(textwowdir.Text + "\wow.exe")
        End If


    End Sub
End Class
