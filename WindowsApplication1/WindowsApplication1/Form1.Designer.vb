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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.howtoconnect = New System.Windows.Forms.ToolStripButton()
        Me.votebuy = New System.Windows.Forms.ToolStripButton()
        Me.Help = New System.Windows.Forms.ToolStripButton()
        Me.about = New System.Windows.Forms.ToolStripButton()
        Me.refreshall = New System.Windows.Forms.ToolStripButton()
        Me.textwowdir = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.buttonbrowse = New System.Windows.Forms.Button()
        Me.buttonplaywlk = New System.Windows.Forms.Button()
        Me.info = New System.Windows.Forms.Label()
        Me.formnewsfeed = New System.Windows.Forms.GroupBox()
        Me.newsfeed = New System.Windows.Forms.RichTextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.downloadwlk = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelwlk = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cataplaybtn = New System.Windows.Forms.Button()
        Me.catabrowsebtn = New System.Windows.Forms.Button()
        Me.catatxtbox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.mopplaybtn = New System.Windows.Forms.Button()
        Me.mopbrowsebtn = New System.Windows.Forms.Button()
        Me.moptxtbox = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btndownloadcata = New System.Windows.Forms.Button()
        Me.btndownloadmop = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.formnewsfeed.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.LimeGreen
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.howtoconnect, Me.votebuy, Me.Help, Me.about, Me.refreshall})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.MaximumSize = New System.Drawing.Size(800, 31)
        Me.ToolStrip1.MinimumSize = New System.Drawing.Size(800, 31)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 31)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'howtoconnect
        '
        Me.howtoconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.howtoconnect.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.howtoconnect.Image = CType(resources.GetObject("howtoconnect.Image"), System.Drawing.Image)
        Me.howtoconnect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.howtoconnect.Name = "howtoconnect"
        Me.howtoconnect.Size = New System.Drawing.Size(115, 28)
        Me.howtoconnect.Text = "How To Connect"
        '
        'votebuy
        '
        Me.votebuy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.votebuy.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.votebuy.Image = CType(resources.GetObject("votebuy.Image"), System.Drawing.Image)
        Me.votebuy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.votebuy.Name = "votebuy"
        Me.votebuy.Size = New System.Drawing.Size(70, 28)
        Me.votebuy.Text = "Vote/buy"
        '
        'Help
        '
        Me.Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Help.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Help.Image = CType(resources.GetObject("Help.Image"), System.Drawing.Image)
        Me.Help.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(41, 28)
        Me.Help.Text = "Help"
        '
        'about
        '
        Me.about.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.about.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.about.Image = CType(resources.GetObject("about.Image"), System.Drawing.Image)
        Me.about.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.about.Name = "about"
        Me.about.Size = New System.Drawing.Size(51, 28)
        Me.about.Text = "About"
        '
        'refreshall
        '
        Me.refreshall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.refreshall.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.refreshall.Image = CType(resources.GetObject("refreshall.Image"), System.Drawing.Image)
        Me.refreshall.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.refreshall.Name = "refreshall"
        Me.refreshall.Size = New System.Drawing.Size(75, 28)
        Me.refreshall.Text = "Refresh all"
        '
        'textwowdir
        '
        Me.textwowdir.Location = New System.Drawing.Point(30, 413)
        Me.textwowdir.Margin = New System.Windows.Forms.Padding(2)
        Me.textwowdir.Name = "textwowdir"
        Me.textwowdir.Size = New System.Drawing.Size(200, 23)
        Me.textwowdir.TabIndex = 1
        Me.textwowdir.Text = "Path to wow folder"
        '
        'buttonbrowse
        '
        Me.buttonbrowse.Location = New System.Drawing.Point(262, 413)
        Me.buttonbrowse.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonbrowse.Name = "buttonbrowse"
        Me.buttonbrowse.Size = New System.Drawing.Size(100, 25)
        Me.buttonbrowse.TabIndex = 2
        Me.buttonbrowse.Text = "Browse"
        Me.buttonbrowse.UseVisualStyleBackColor = True
        '
        'buttonplaywlk
        '
        Me.buttonplaywlk.Location = New System.Drawing.Point(251, 527)
        Me.buttonplaywlk.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonplaywlk.Name = "buttonplaywlk"
        Me.buttonplaywlk.Size = New System.Drawing.Size(200, 50)
        Me.buttonplaywlk.TabIndex = 3
        Me.buttonplaywlk.Text = "play"
        Me.buttonplaywlk.UseVisualStyleBackColor = True
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Location = New System.Drawing.Point(72, 53)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(0, 13)
        Me.info.TabIndex = 4
        '
        'formnewsfeed
        '
        Me.formnewsfeed.BackColor = System.Drawing.Color.LightGreen
        Me.formnewsfeed.Controls.Add(Me.newsfeed)
        Me.formnewsfeed.Location = New System.Drawing.Point(0, 38)
        Me.formnewsfeed.Name = "formnewsfeed"
        Me.formnewsfeed.Size = New System.Drawing.Size(482, 611)
        Me.formnewsfeed.TabIndex = 5
        Me.formnewsfeed.TabStop = False
        Me.formnewsfeed.Text = "News"
        '
        'newsfeed
        '
        Me.newsfeed.BackColor = System.Drawing.Color.LightGreen
        Me.newsfeed.Cursor = System.Windows.Forms.Cursors.No
        Me.newsfeed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.newsfeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newsfeed.Location = New System.Drawing.Point(3, 16)
        Me.newsfeed.Name = "newsfeed"
        Me.newsfeed.ReadOnly = True
        Me.newsfeed.Size = New System.Drawing.Size(476, 592)
        Me.newsfeed.TabIndex = 0
        Me.newsfeed.Text = ""
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(485, 38)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(712, 611)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.downloadwlk)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.labelwlk)
        Me.TabPage1.Controls.Add(Me.buttonbrowse)
        Me.TabPage1.Controls.Add(Me.textwowdir)
        Me.TabPage1.Controls.Add(Me.buttonplaywlk)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(704, 582)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Wrath of the lich king 3.3.5a"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'downloadwlk
        '
        Me.downloadwlk.Location = New System.Drawing.Point(251, 153)
        Me.downloadwlk.Margin = New System.Windows.Forms.Padding(2)
        Me.downloadwlk.Name = "downloadwlk"
        Me.downloadwlk.Size = New System.Drawing.Size(100, 25)
        Me.downloadwlk.TabIndex = 7
        Me.downloadwlk.Text = "Download"
        Me.downloadwlk.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(34, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Download Torrent"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(24, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Wrath of the lich king 3.3.5a"
        '
        'labelwlk
        '
        Me.labelwlk.AutoSize = True
        Me.labelwlk.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelwlk.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.labelwlk.Location = New System.Drawing.Point(25, 374)
        Me.labelwlk.Name = "labelwlk"
        Me.labelwlk.Size = New System.Drawing.Size(212, 25)
        Me.labelwlk.TabIndex = 4
        Me.labelwlk.Text = "Path to WOTLK Folder"
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.btndownloadcata)
        Me.TabPage2.Controls.Add(Me.cataplaybtn)
        Me.TabPage2.Controls.Add(Me.catabrowsebtn)
        Me.TabPage2.Controls.Add(Me.catatxtbox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(704, 582)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cataclysm 4.3.4"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cataplaybtn
        '
        Me.cataplaybtn.Location = New System.Drawing.Point(251, 527)
        Me.cataplaybtn.Name = "cataplaybtn"
        Me.cataplaybtn.Size = New System.Drawing.Size(200, 50)
        Me.cataplaybtn.TabIndex = 2
        Me.cataplaybtn.Text = "Play"
        Me.cataplaybtn.UseVisualStyleBackColor = True
        '
        'catabrowsebtn
        '
        Me.catabrowsebtn.Location = New System.Drawing.Point(262, 413)
        Me.catabrowsebtn.Name = "catabrowsebtn"
        Me.catabrowsebtn.Size = New System.Drawing.Size(100, 25)
        Me.catabrowsebtn.TabIndex = 1
        Me.catabrowsebtn.Text = "Browse"
        Me.catabrowsebtn.UseVisualStyleBackColor = True
        '
        'catatxtbox
        '
        Me.catatxtbox.Location = New System.Drawing.Point(30, 413)
        Me.catatxtbox.Name = "catatxtbox"
        Me.catatxtbox.Size = New System.Drawing.Size(200, 23)
        Me.catatxtbox.TabIndex = 0
        Me.catatxtbox.Text = "Select Path to wow folder"
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.btndownloadmop)
        Me.TabPage3.Controls.Add(Me.mopplaybtn)
        Me.TabPage3.Controls.Add(Me.mopbrowsebtn)
        Me.TabPage3.Controls.Add(Me.moptxtbox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(704, 582)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Mists of Pandaria 5.4.8"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'mopplaybtn
        '
        Me.mopplaybtn.Location = New System.Drawing.Point(251, 527)
        Me.mopplaybtn.Name = "mopplaybtn"
        Me.mopplaybtn.Size = New System.Drawing.Size(200, 50)
        Me.mopplaybtn.TabIndex = 2
        Me.mopplaybtn.Text = "Play"
        Me.mopplaybtn.UseVisualStyleBackColor = True
        '
        'mopbrowsebtn
        '
        Me.mopbrowsebtn.Location = New System.Drawing.Point(262, 413)
        Me.mopbrowsebtn.Name = "mopbrowsebtn"
        Me.mopbrowsebtn.Size = New System.Drawing.Size(100, 25)
        Me.mopbrowsebtn.TabIndex = 1
        Me.mopbrowsebtn.Text = "Browse"
        Me.mopbrowsebtn.UseVisualStyleBackColor = True
        '
        'moptxtbox
        '
        Me.moptxtbox.Location = New System.Drawing.Point(30, 413)
        Me.moptxtbox.Name = "moptxtbox"
        Me.moptxtbox.Size = New System.Drawing.Size(200, 23)
        Me.moptxtbox.TabIndex = 0
        Me.moptxtbox.Text = "Path to wow folder"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1167, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1131, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'btndownloadcata
        '
        Me.btndownloadcata.Location = New System.Drawing.Point(251, 153)
        Me.btndownloadcata.Name = "btndownloadcata"
        Me.btndownloadcata.Size = New System.Drawing.Size(100, 25)
        Me.btndownloadcata.TabIndex = 3
        Me.btndownloadcata.Text = "Download"
        Me.btndownloadcata.UseVisualStyleBackColor = True
        '
        'btndownloadmop
        '
        Me.btndownloadmop.Location = New System.Drawing.Point(251, 153)
        Me.btndownloadmop.Name = "btndownloadmop"
        Me.btndownloadmop.Size = New System.Drawing.Size(100, 25)
        Me.btndownloadmop.TabIndex = 3
        Me.btndownloadmop.Text = "Download"
        Me.btndownloadmop.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(34, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Download Torrent"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(34, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Download Torrent"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(1200, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.formnewsfeed)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(1200, 650)
        Me.MinimumSize = New System.Drawing.Size(1200, 650)
        Me.Name = "Form1"
        Me.Text = "Wow addictz Launcher"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.formnewsfeed.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents howtoconnect As ToolStripButton
    Friend WithEvents Help As ToolStripButton
    Friend WithEvents about As ToolStripButton
    Friend WithEvents textwowdir As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents buttonbrowse As Button
    Friend WithEvents buttonplaywlk As Button
    Friend WithEvents votebuy As ToolStripButton
    Friend WithEvents info As Label
    Friend WithEvents formnewsfeed As GroupBox
    Friend WithEvents newsfeed As RichTextBox
    Friend WithEvents refreshall As ToolStripButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents cataplaybtn As Button
    Friend WithEvents catabrowsebtn As Button
    Friend WithEvents catatxtbox As TextBox
    Friend WithEvents mopplaybtn As Button
    Friend WithEvents mopbrowsebtn As Button
    Friend WithEvents moptxtbox As TextBox
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents labelwlk As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents downloadwlk As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btndownloadcata As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btndownloadmop As Button
End Class
