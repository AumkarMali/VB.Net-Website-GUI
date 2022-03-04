<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntroScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIntroScreen))
        Me.btnOrderPageInit = New System.Windows.Forms.Button()
        Me.btnExtraInfoPageInit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblStartingInfo = New System.Windows.Forms.Label()
        Me.pcbLittleCaesersGif = New System.Windows.Forms.PictureBox()
        Me.pcbBanner = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbLittleCaesersGif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOrderPageInit
        '
        Me.btnOrderPageInit.Location = New System.Drawing.Point(374, 176)
        Me.btnOrderPageInit.Name = "btnOrderPageInit"
        Me.btnOrderPageInit.Size = New System.Drawing.Size(131, 49)
        Me.btnOrderPageInit.TabIndex = 0
        Me.btnOrderPageInit.Text = "Start Order"
        Me.btnOrderPageInit.UseVisualStyleBackColor = True
        '
        'btnExtraInfoPageInit
        '
        Me.btnExtraInfoPageInit.Location = New System.Drawing.Point(374, 253)
        Me.btnExtraInfoPageInit.Name = "btnExtraInfoPageInit"
        Me.btnExtraInfoPageInit.Size = New System.Drawing.Size(131, 49)
        Me.btnExtraInfoPageInit.TabIndex = 1
        Me.btnExtraInfoPageInit.Text = "Extra information"
        Me.btnExtraInfoPageInit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.IndianRed
        Me.PictureBox1.Location = New System.Drawing.Point(0, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(550, 132)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblStartingInfo
        '
        Me.lblStartingInfo.AutoSize = True
        Me.lblStartingInfo.Location = New System.Drawing.Point(211, 221)
        Me.lblStartingInfo.Name = "lblStartingInfo"
        Me.lblStartingInfo.Size = New System.Drawing.Size(83, 13)
        Me.lblStartingInfo.TabIndex = 3
        Me.lblStartingInfo.Text = "Lets get started!"
        '
        'pcbLittleCaesersGif
        '
        Me.pcbLittleCaesersGif.Image = CType(resources.GetObject("pcbLittleCaesersGif.Image"), System.Drawing.Image)
        Me.pcbLittleCaesersGif.Location = New System.Drawing.Point(0, 156)
        Me.pcbLittleCaesersGif.Name = "pcbLittleCaesersGif"
        Me.pcbLittleCaesersGif.Size = New System.Drawing.Size(179, 126)
        Me.pcbLittleCaesersGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbLittleCaesersGif.TabIndex = 4
        Me.pcbLittleCaesersGif.TabStop = False
        '
        'pcbBanner
        '
        Me.pcbBanner.Image = CType(resources.GetObject("pcbBanner.Image"), System.Drawing.Image)
        Me.pcbBanner.Location = New System.Drawing.Point(0, 0)
        Me.pcbBanner.Name = "pcbBanner"
        Me.pcbBanner.Size = New System.Drawing.Size(550, 124)
        Me.pcbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbBanner.TabIndex = 5
        Me.pcbBanner.TabStop = False
        '
        'frmIntroScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(549, 327)
        Me.Controls.Add(Me.pcbBanner)
        Me.Controls.Add(Me.pcbLittleCaesersGif)
        Me.Controls.Add(Me.lblStartingInfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExtraInfoPageInit)
        Me.Controls.Add(Me.btnOrderPageInit)
        Me.Name = "frmIntroScreen"
        Me.Text = "Welcome to Little Ceasers!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbLittleCaesersGif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOrderPageInit As System.Windows.Forms.Button
    Friend WithEvents btnExtraInfoPageInit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblStartingInfo As System.Windows.Forms.Label
    Friend WithEvents pcbLittleCaesersGif As System.Windows.Forms.PictureBox
    Friend WithEvents pcbBanner As System.Windows.Forms.PictureBox

End Class
