Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Text

Public Class Form1
    'newsfeed and load saved dir background worker
    Private Sub BackgroundWorker1_DoWork() Handles BackgroundWorker1.DoWork
        Dim web As New WebClient
        Dim savehere As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        web.DownloadFile("https://docs.google.com/uc?authuser=0&id=0B2cXOThb6ZldWWpfeDdqY3ZVa2c&export=download", savehere)



    End Sub


    'on load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load news feed
        Try
            formnewsfeed_Enter()
        Catch ex As Exception
            newsfeed.Text = "Error loading Please make sure your connected to the internet."
        End Try
        Try
            wlk()
            cataclysm()
            mop()
        Catch ex As Exception
            Exit Try
        End Try
    End Sub


    'how to connect button
    Private Sub howtoconnect_Click(sender As Object, e As EventArgs) Handles howtoconnect.Click
        Process.Start("www.wowaddictz.net")
    End Sub
    'help button
    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
        MessageBox.Show("For assistance please visit website.", "Help")
    End Sub
    'about button
    Private Sub about_Click(sender As Object, e As EventArgs) Handles about.Click
        Dim ver As String = "24.1.16.13.35"
        MessageBox.Show("Wow-Addictz Launcher ver. " + ver)
    End Sub
    'vote/buy button
    Private Sub votebuy_Click(sender As Object, e As EventArgs) Handles votebuy.Click
        Process.Start("www.wowaddictz.net/voting")
    End Sub
    'refresh button
    Private Sub refreshall_Click(sender As Object, e As EventArgs) Handles refreshall.Click
        Try
            formnewsfeed_Enter()
        Catch ex As Exception
            newsfeed.Text = "Error loading Please make sure your connected to the internet."
        End Try
    End Sub
    'browse button wrath of the lich king
    Private Sub buttonbrowse_Click(sender As Object, e As EventArgs) Handles buttonbrowse.Click
        FolderBrowserDialog1.ShowDialog()
        textwowdir.Text = FolderBrowserDialog1.SelectedPath
        Dim wowexedir As String = textwowdir.Text + "\wow.exe"
        If File.Exists(wowexedir) Then
            My.Settings.wowdir = textwowdir.Text
            My.Settings.Save()
        Else
            MessageBox.Show("Error finding wow.exe. Please select the folder with wow.exe in it. If you don't have the client please see our website or How to connect above.", "ERROR")

        End If
    End Sub
    'play button wrath of the lichking
    Private Sub buttonplaywlk_Click(sender As Object, e As EventArgs) Handles buttonplaywlk.Click

        Try
            Dim wowexedir As String = My.Settings.wowdir + "\wow.exe"
            Dim wowcfg = My.Settings.wowdir + "\Data\enUS\realmlist.wtf"
            My.Computer.FileSystem.DeleteFile(wowcfg)
            File.Create(wowcfg).Dispose()
            My.Computer.FileSystem.WriteAllText(wowcfg, "set realmlist localhost", True)
            Process.Start(wowexedir)
        Catch ex As Exception
            MessageBox.Show("Error finding wow.exe. Please select the folder with wow.exe in it.", "Error")
            Exit Sub
        End Try

    End Sub


    'browse button for cataclysm
    Private Sub catabrowsebtn_Click(sender As Object, e As EventArgs) Handles catabrowsebtn.Click
        FolderBrowserDialog1.ShowDialog()
        catatxtbox.Text = FolderBrowserDialog1.SelectedPath
        Dim cataexedir As String = catatxtbox.Text + "\wow.exe"
        If File.Exists(cataexedir) Then
            My.Settings.catadir = catatxtbox.Text
            My.Settings.Save()
        Else
            MessageBox.Show("Error finding wow.exe. Please select the folder with wow.exe in it. If you don't have the client please see our website or How to connect above.", "Error")
        End If
    End Sub


    'cataclysm play button (delete and create relmslist)
    Private Sub cataplaybtn_Click(sender As Object, e As EventArgs) Handles cataplaybtn.Click
        If catatxtbox.Text = String.Empty Then
            MessageBox.Show("Error finding wow.exe. Please select the folder with wow.exe in it. If you don't have the client please see our website or How to connect above.", "Error")
        ElseIf Not File.Exists(catatxtbox.Text + "\wow.exe") Then
            MessageBox.Show("Error finding wow.exe. Please select the folder with wow.exe in it. If you don't have the client please see our website or How to connect above.", "Error")
        Else
            Dim cataexedir = catatxtbox.Text + "\wow.exe"
            Dim catacfg = catatxtbox.Text + "\Data\enUS\realmlist.wtf"
            My.Computer.FileSystem.DeleteFile(catacfg)
            File.Create(catacfg).Dispose()
            My.Computer.FileSystem.WriteAllText(catacfg, "set realmlist localhost", True)
            Process.Start(cataexedir)
        End If
    End Sub


    'mist of pandaria browse button
    Private Sub mopbrowsebtn_Click(sender As Object, e As EventArgs) Handles mopbrowsebtn.Click
        FolderBrowserDialog1.ShowDialog()
        moptxtbox.Text = FolderBrowserDialog1.SelectedPath
        Dim mopexedir As String = catatxtbox.Text + "\wow.exe"
        If File.Exists(mopexedir) Then
            My.Settings.mopdir = moptxtbox.Text
            My.Settings.Save()
        Else
            MessageBox.Show("Error finding wow.exe. Please select the folder with wow.exe in it. If you don't have the client please see our website or How to connect above.", "Error")
        End If
    End Sub


    'mist of pandaria play button
    Private Sub mopplaybtn_Click(sender As Object, e As EventArgs) Handles mopplaybtn.Click
        If moptxtbox.Text = String.Empty Then
            MessageBox.Show("Error finding wow.exe. Please select the folder with wow.exe in it. If you don't have the client please see our website or How to connect above.", "Error")
        ElseIf Not File.Exists(moptxtbox.Text + "\wow.exe") Then
            MessageBox.Show("Error finding wow.exe. Please select the folder with wow.exe in it. If you don't have the client please see our website or How to connect above.", "Error")
        Else
            Dim mopexedir = moptxtbox.Text + "\wow.exe"
            Dim mopcfg = moptxtbox.Text + "\WTF\config.wtf"
            My.Computer.FileSystem.DeleteFile(mopcfg)
            IO.File.Create(mopcfg).Close()
            Dim file = My.Computer.FileSystem.OpenTextFileWriter(mopcfg, True)
            Dim mopconfigtxt As String = "SET locale " + ControlChars.Quote + "enGB" + ControlChars.Quote & vbCrLf &
                "SET installLocale " + ControlChars.Quote + "enGB" + ControlChars.Quote & vbCrLf &
                "SET realmlist " + ControlChars.Quote + "mop.freakz.ro" + ControlChars.Quote






            My.Computer.FileSystem.WriteAllText(mopcfg, mopconfigtxt, True)
            file.Close()
            Process.Start(mopexedir)
        End If
    End Sub


    'top toolbar minimize
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        WindowState = FormWindowState.Minimized
    End Sub


    'top toolbar maximize
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub


    'form1 left click treated as move form1
    Dim loc As Point
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub


    ' other part to move form1
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub



    Private Sub ToolStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles ToolStrip1.MouseDown
        If e.Button = MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub

    Private Sub ToolStrip1_MouseMove(sender As Object, e As MouseEventArgs) Handles ToolStrip1.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub

    Private Sub formnewsfeed_Enter() Handles formnewsfeed.Enter
        'load newsfeed
        Dim web As New WebClient
        Dim news As String = web.DownloadString("https://docs.google.com/uc?authuser=0&id=0B2cXOThb6ZldRk1EQU15WDMwRW8&export=download")
        newsfeed.Text = news
    End Sub

    Private Sub wlk()
        Try
            textwowdir.Text = My.Settings.wowdir
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub cataclysm()
        Try
            catatxtbox.Text = My.Settings.catadir
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub mop()
        Try
            moptxtbox.Text = My.Settings.mopdir

        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub downloadwlk_Click(sender As Object, e As EventArgs) Handles downloadwlk.Click

        Try
            Process.Start("magnet:?xt=urn:btih:DD31C5CE1984B183E310196306CB958A4B08243F&dn=world+of+warcraft+3+3+5a&tr=udp%3A%2F%2Ftracker.openbittorrent.com%3A80%2Fannounce&tr=udp%3A%2F%2Fglotorrents.pw%3A6969%2Fannounce")
        Catch ex As Exception
            MessageBox.Show("Make sure you have a torrent downloader like Utorrent")
        End Try


    End Sub

    Private Sub btndownloadcata_Click(sender As Object, e As EventArgs) Handles btndownloadcata.Click
        Try
            Process.Start("magnet:?xt=urn:btih:D7D4A96313629D1EB20C58D996105AB80225C9B0&dn=world+of+warcraft+4+3+4+15595+phanto+edition+rar&tr=udp%3A%2F%2F12.rarbg.me%3A80%2Fannounce&tr=udp%3A%2F%2Fglotorrents.pw%3A6969%2Fannounce")
        Catch ex As Exception
            MessageBox.Show("Make sure you have a torrent downloader like Utorrent")
        End Try
    End Sub

    Private Sub btndownloadmop_Click(sender As Object, e As EventArgs) Handles btndownloadmop.Click
        Try
            Process.Start("http://heroes-wow.com/HeroesWoW-5.4.8-WoD-Models.rar.torrent")
        Catch ex As Exception
            MessageBox.Show("Make sure you have a torrent downloader like Utorrent")
        End Try
    End Sub
End Class
