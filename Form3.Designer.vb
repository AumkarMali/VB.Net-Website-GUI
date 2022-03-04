<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfoPage))
        Me.pcbCountryImage = New System.Windows.Forms.PictureBox()
        Me.lblinfoPageTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGoToIntro = New System.Windows.Forms.Button()
        CType(Me.pcbCountryImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbCountryImage
        '
        Me.pcbCountryImage.Image = CType(resources.GetObject("pcbCountryImage.Image"), System.Drawing.Image)
        Me.pcbCountryImage.Location = New System.Drawing.Point(12, 114)
        Me.pcbCountryImage.Name = "pcbCountryImage"
        Me.pcbCountryImage.Size = New System.Drawing.Size(244, 157)
        Me.pcbCountryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbCountryImage.TabIndex = 0
        Me.pcbCountryImage.TabStop = False
        '
        'lblinfoPageTitle
        '
        Me.lblinfoPageTitle.AutoSize = True
        Me.lblinfoPageTitle.Font = New System.Drawing.Font("Myanmar Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinfoPageTitle.Location = New System.Drawing.Point(135, 28)
        Me.lblinfoPageTitle.Name = "lblinfoPageTitle"
        Me.lblinfoPageTitle.Size = New System.Drawing.Size(350, 37)
        Me.lblinfoPageTitle.TabIndex = 1
        Me.lblinfoPageTitle.Text = "Our importance towards good food."
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 224)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'btnGoToIntro
        '
        Me.btnGoToIntro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGoToIntro.Location = New System.Drawing.Point(12, 12)
        Me.btnGoToIntro.Name = "btnGoToIntro"
        Me.btnGoToIntro.Size = New System.Drawing.Size(99, 29)
        Me.btnGoToIntro.TabIndex = 3
        Me.btnGoToIntro.Text = "Go To Last Page"
        Me.btnGoToIntro.UseVisualStyleBackColor = False
        '
        'frmInfoPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(594, 347)
        Me.Controls.Add(Me.btnGoToIntro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblinfoPageTitle)
        Me.Controls.Add(Me.pcbCountryImage)
        Me.Name = "frmInfoPage"
        Me.Text = "Our importance to food and culture"
        CType(Me.pcbCountryImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pcbCountryImage As System.Windows.Forms.PictureBox
    Friend WithEvents lblinfoPageTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGoToIntro As System.Windows.Forms.Button
End Class
