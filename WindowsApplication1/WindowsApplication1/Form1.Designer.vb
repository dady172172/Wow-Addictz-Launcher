<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.howtoconnect = New System.Windows.Forms.ToolStripButton()
        Me.Help = New System.Windows.Forms.ToolStripButton()
        Me.about = New System.Windows.Forms.ToolStripButton()
        Me.textwowdir = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.buttonbrowse = New System.Windows.Forms.Button()
        Me.buttonplay = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.howtoconnect, Me.Help, Me.about})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(478, 32)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'howtoconnect
        '
        Me.howtoconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.howtoconnect.Image = CType(resources.GetObject("howtoconnect.Image"), System.Drawing.Image)
        Me.howtoconnect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.howtoconnect.Name = "howtoconnect"
        Me.howtoconnect.Size = New System.Drawing.Size(146, 29)
        Me.howtoconnect.Text = "How To Connect"
        '
        'Help
        '
        Me.Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Help.Image = CType(resources.GetObject("Help.Image"), System.Drawing.Image)
        Me.Help.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(53, 29)
        Me.Help.Text = "Help"
        '
        'about
        '
        Me.about.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.about.Image = CType(resources.GetObject("about.Image"), System.Drawing.Image)
        Me.about.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.about.Name = "about"
        Me.about.Size = New System.Drawing.Size(66, 29)
        Me.about.Text = "About"
        '
        'textwowdir
        '
        Me.textwowdir.Location = New System.Drawing.Point(35, 96)
        Me.textwowdir.Name = "textwowdir"
        Me.textwowdir.Size = New System.Drawing.Size(255, 26)
        Me.textwowdir.TabIndex = 1
        Me.textwowdir.Text = "Path to wow folder"
        '
        'buttonbrowse
        '
        Me.buttonbrowse.Location = New System.Drawing.Point(336, 96)
        Me.buttonbrowse.Name = "buttonbrowse"
        Me.buttonbrowse.Size = New System.Drawing.Size(75, 33)
        Me.buttonbrowse.TabIndex = 2
        Me.buttonbrowse.Text = "Browse"
        Me.buttonbrowse.UseVisualStyleBackColor = True
        '
        'buttonplay
        '
        Me.buttonplay.Location = New System.Drawing.Point(202, 211)
        Me.buttonplay.Name = "buttonplay"
        Me.buttonplay.Size = New System.Drawing.Size(75, 37)
        Me.buttonplay.TabIndex = 3
        Me.buttonplay.Text = "play"
        Me.buttonplay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 444)
        Me.Controls.Add(Me.buttonplay)
        Me.Controls.Add(Me.buttonbrowse)
        Me.Controls.Add(Me.textwowdir)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "Form1"
        Me.Text = "Wow addictz Launcher"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents buttonplay As Button
End Class
