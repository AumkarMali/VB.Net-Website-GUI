<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomize
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomize))
        Me.grbSize = New System.Windows.Forms.GroupBox()
        Me.rabXLarge = New System.Windows.Forms.RadioButton()
        Me.rabLarge = New System.Windows.Forms.RadioButton()
        Me.rabMedium = New System.Windows.Forms.RadioButton()
        Me.rabSmall = New System.Windows.Forms.RadioButton()
        Me.grbToppings = New System.Windows.Forms.GroupBox()
        Me.chkTomatoe = New System.Windows.Forms.CheckBox()
        Me.chkOnion = New System.Windows.Forms.CheckBox()
        Me.chkBacon = New System.Windows.Forms.CheckBox()
        Me.chkSausage = New System.Windows.Forms.CheckBox()
        Me.chkChicken = New System.Windows.Forms.CheckBox()
        Me.chkMushrooms = New System.Windows.Forms.CheckBox()
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.chkHam = New System.Windows.Forms.CheckBox()
        Me.grbSideItems = New System.Windows.Forms.GroupBox()
        Me.chkGarlicBread = New System.Windows.Forms.CheckBox()
        Me.chkWings = New System.Windows.Forms.CheckBox()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.chkSoda = New System.Windows.Forms.CheckBox()
        Me.grbOrderType = New System.Windows.Forms.GroupBox()
        Me.rabPickUp = New System.Windows.Forms.RadioButton()
        Me.rabDelivery = New System.Windows.Forms.RadioButton()
        Me.grbPaymentMethod = New System.Windows.Forms.GroupBox()
        Me.rabDebit = New System.Windows.Forms.RadioButton()
        Me.rabCredit = New System.Windows.Forms.RadioButton()
        Me.rabCash = New System.Windows.Forms.RadioButton()
        Me.txtCouponCode = New System.Windows.Forms.TextBox()
        Me.lblCouponInfo = New System.Windows.Forms.Label()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnBackPage = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.btnProceedCheckout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveReceipt = New System.Windows.Forms.Button()
        Me.btnPrintReceipt = New System.Windows.Forms.Button()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.txtReceipt = New System.Windows.Forms.TextBox()
        Me.grbSize.SuspendLayout()
        Me.grbToppings.SuspendLayout()
        Me.grbSideItems.SuspendLayout()
        Me.grbOrderType.SuspendLayout()
        Me.grbPaymentMethod.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbSize
        '
        Me.grbSize.BackColor = System.Drawing.Color.Gray
        Me.grbSize.Controls.Add(Me.rabXLarge)
        Me.grbSize.Controls.Add(Me.rabLarge)
        Me.grbSize.Controls.Add(Me.rabMedium)
        Me.grbSize.Controls.Add(Me.rabSmall)
        Me.grbSize.ForeColor = System.Drawing.Color.White
        Me.grbSize.Location = New System.Drawing.Point(21, 70)
        Me.grbSize.Name = "grbSize"
        Me.grbSize.Size = New System.Drawing.Size(116, 130)
        Me.grbSize.TabIndex = 0
        Me.grbSize.TabStop = False
        Me.grbSize.Text = "Pizza Size"
        '
        'rabXLarge
        '
        Me.rabXLarge.AutoSize = True
        Me.rabXLarge.Location = New System.Drawing.Point(6, 88)
        Me.rabXLarge.Name = "rabXLarge"
        Me.rabXLarge.Size = New System.Drawing.Size(62, 17)
        Me.rabXLarge.TabIndex = 3
        Me.rabXLarge.TabStop = True
        Me.rabXLarge.Text = "X-Large"
        Me.rabXLarge.UseVisualStyleBackColor = True
        '
        'rabLarge
        '
        Me.rabLarge.AutoSize = True
        Me.rabLarge.Location = New System.Drawing.Point(6, 65)
        Me.rabLarge.Name = "rabLarge"
        Me.rabLarge.Size = New System.Drawing.Size(52, 17)
        Me.rabLarge.TabIndex = 2
        Me.rabLarge.TabStop = True
        Me.rabLarge.Text = "Large"
        Me.rabLarge.UseVisualStyleBackColor = True
        '
        'rabMedium
        '
        Me.rabMedium.AutoSize = True
        Me.rabMedium.Location = New System.Drawing.Point(6, 42)
        Me.rabMedium.Name = "rabMedium"
        Me.rabMedium.Size = New System.Drawing.Size(62, 17)
        Me.rabMedium.TabIndex = 1
        Me.rabMedium.TabStop = True
        Me.rabMedium.Text = "Medium"
        Me.rabMedium.UseVisualStyleBackColor = True
        '
        'rabSmall
        '
        Me.rabSmall.AutoSize = True
        Me.rabSmall.Location = New System.Drawing.Point(6, 19)
        Me.rabSmall.Name = "rabSmall"
        Me.rabSmall.Size = New System.Drawing.Size(53, 17)
        Me.rabSmall.TabIndex = 0
        Me.rabSmall.TabStop = True
        Me.rabSmall.Text = "Small "
        Me.rabSmall.UseVisualStyleBackColor = True
        '
        'grbToppings
        '
        Me.grbToppings.BackColor = System.Drawing.Color.Gray
        Me.grbToppings.Controls.Add(Me.chkTomatoe)
        Me.grbToppings.Controls.Add(Me.chkOnion)
        Me.grbToppings.Controls.Add(Me.chkBacon)
        Me.grbToppings.Controls.Add(Me.chkSausage)
        Me.grbToppings.Controls.Add(Me.chkChicken)
        Me.grbToppings.Controls.Add(Me.chkMushrooms)
        Me.grbToppings.Controls.Add(Me.chkPepperoni)
        Me.grbToppings.Controls.Add(Me.chkHam)
        Me.grbToppings.ForeColor = System.Drawing.Color.White
        Me.grbToppings.Location = New System.Drawing.Point(143, 70)
        Me.grbToppings.Name = "grbToppings"
        Me.grbToppings.Size = New System.Drawing.Size(200, 130)
        Me.grbToppings.TabIndex = 4
        Me.grbToppings.TabStop = False
        Me.grbToppings.Text = "Toppings"
        '
        'chkTomatoe
        '
        Me.chkTomatoe.AutoSize = True
        Me.chkTomatoe.Location = New System.Drawing.Point(111, 89)
        Me.chkTomatoe.Name = "chkTomatoe"
        Me.chkTomatoe.Size = New System.Drawing.Size(68, 17)
        Me.chkTomatoe.TabIndex = 8
        Me.chkTomatoe.Text = "Tomatoe"
        Me.chkTomatoe.UseVisualStyleBackColor = True
        '
        'chkOnion
        '
        Me.chkOnion.AutoSize = True
        Me.chkOnion.Location = New System.Drawing.Point(111, 66)
        Me.chkOnion.Name = "chkOnion"
        Me.chkOnion.Size = New System.Drawing.Size(54, 17)
        Me.chkOnion.TabIndex = 7
        Me.chkOnion.Text = "Onion"
        Me.chkOnion.UseVisualStyleBackColor = True
        '
        'chkBacon
        '
        Me.chkBacon.AutoSize = True
        Me.chkBacon.Location = New System.Drawing.Point(111, 43)
        Me.chkBacon.Name = "chkBacon"
        Me.chkBacon.Size = New System.Drawing.Size(57, 17)
        Me.chkBacon.TabIndex = 6
        Me.chkBacon.Text = "Bacon"
        Me.chkBacon.UseVisualStyleBackColor = True
        '
        'chkSausage
        '
        Me.chkSausage.AutoSize = True
        Me.chkSausage.Location = New System.Drawing.Point(111, 20)
        Me.chkSausage.Name = "chkSausage"
        Me.chkSausage.Size = New System.Drawing.Size(68, 17)
        Me.chkSausage.TabIndex = 5
        Me.chkSausage.Text = "Sausage"
        Me.chkSausage.UseVisualStyleBackColor = True
        '
        'chkChicken
        '
        Me.chkChicken.AutoSize = True
        Me.chkChicken.Location = New System.Drawing.Point(6, 89)
        Me.chkChicken.Name = "chkChicken"
        Me.chkChicken.Size = New System.Drawing.Size(65, 17)
        Me.chkChicken.TabIndex = 3
        Me.chkChicken.Text = "Chicken"
        Me.chkChicken.UseVisualStyleBackColor = True
        '
        'chkMushrooms
        '
        Me.chkMushrooms.AutoSize = True
        Me.chkMushrooms.Location = New System.Drawing.Point(6, 66)
        Me.chkMushrooms.Name = "chkMushrooms"
        Me.chkMushrooms.Size = New System.Drawing.Size(80, 17)
        Me.chkMushrooms.TabIndex = 2
        Me.chkMushrooms.Text = "Mushrooms"
        Me.chkMushrooms.UseVisualStyleBackColor = True
        '
        'chkPepperoni
        '
        Me.chkPepperoni.AutoSize = True
        Me.chkPepperoni.Location = New System.Drawing.Point(6, 43)
        Me.chkPepperoni.Name = "chkPepperoni"
        Me.chkPepperoni.Size = New System.Drawing.Size(74, 17)
        Me.chkPepperoni.TabIndex = 1
        Me.chkPepperoni.Text = "Pepperoni"
        Me.chkPepperoni.UseVisualStyleBackColor = True
        '
        'chkHam
        '
        Me.chkHam.AutoSize = True
        Me.chkHam.Location = New System.Drawing.Point(6, 19)
        Me.chkHam.Name = "chkHam"
        Me.chkHam.Size = New System.Drawing.Size(48, 17)
        Me.chkHam.TabIndex = 0
        Me.chkHam.Text = "Ham"
        Me.chkHam.UseVisualStyleBackColor = True
        '
        'grbSideItems
        '
        Me.grbSideItems.BackColor = System.Drawing.Color.Gray
        Me.grbSideItems.Controls.Add(Me.chkGarlicBread)
        Me.grbSideItems.Controls.Add(Me.chkWings)
        Me.grbSideItems.Controls.Add(Me.chkFries)
        Me.grbSideItems.Controls.Add(Me.chkSoda)
        Me.grbSideItems.ForeColor = System.Drawing.Color.White
        Me.grbSideItems.Location = New System.Drawing.Point(349, 70)
        Me.grbSideItems.Name = "grbSideItems"
        Me.grbSideItems.Size = New System.Drawing.Size(148, 130)
        Me.grbSideItems.TabIndex = 9
        Me.grbSideItems.TabStop = False
        Me.grbSideItems.Text = "Side Items"
        '
        'chkGarlicBread
        '
        Me.chkGarlicBread.AutoSize = True
        Me.chkGarlicBread.Location = New System.Drawing.Point(6, 89)
        Me.chkGarlicBread.Name = "chkGarlicBread"
        Me.chkGarlicBread.Size = New System.Drawing.Size(84, 17)
        Me.chkGarlicBread.TabIndex = 3
        Me.chkGarlicBread.Text = "Garlic Bread"
        Me.chkGarlicBread.UseVisualStyleBackColor = True
        '
        'chkWings
        '
        Me.chkWings.AutoSize = True
        Me.chkWings.Location = New System.Drawing.Point(6, 66)
        Me.chkWings.Name = "chkWings"
        Me.chkWings.Size = New System.Drawing.Size(56, 17)
        Me.chkWings.TabIndex = 2
        Me.chkWings.Text = "Wings"
        Me.chkWings.UseVisualStyleBackColor = True
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.Location = New System.Drawing.Point(6, 43)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(48, 17)
        Me.chkFries.TabIndex = 1
        Me.chkFries.Text = "Fries"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'chkSoda
        '
        Me.chkSoda.AutoSize = True
        Me.chkSoda.Location = New System.Drawing.Point(6, 19)
        Me.chkSoda.Name = "chkSoda"
        Me.chkSoda.Size = New System.Drawing.Size(51, 17)
        Me.chkSoda.TabIndex = 0
        Me.chkSoda.Text = "Soda"
        Me.chkSoda.UseVisualStyleBackColor = True
        '
        'grbOrderType
        '
        Me.grbOrderType.BackColor = System.Drawing.Color.Gray
        Me.grbOrderType.Controls.Add(Me.rabPickUp)
        Me.grbOrderType.Controls.Add(Me.rabDelivery)
        Me.grbOrderType.ForeColor = System.Drawing.Color.White
        Me.grbOrderType.Location = New System.Drawing.Point(21, 219)
        Me.grbOrderType.Name = "grbOrderType"
        Me.grbOrderType.Size = New System.Drawing.Size(127, 92)
        Me.grbOrderType.TabIndex = 4
        Me.grbOrderType.TabStop = False
        Me.grbOrderType.Text = "Order Type"
        '
        'rabPickUp
        '
        Me.rabPickUp.AutoSize = True
        Me.rabPickUp.Location = New System.Drawing.Point(6, 42)
        Me.rabPickUp.Name = "rabPickUp"
        Me.rabPickUp.Size = New System.Drawing.Size(63, 17)
        Me.rabPickUp.TabIndex = 1
        Me.rabPickUp.TabStop = True
        Me.rabPickUp.Text = "Pick Up"
        Me.rabPickUp.UseVisualStyleBackColor = True
        '
        'rabDelivery
        '
        Me.rabDelivery.AutoSize = True
        Me.rabDelivery.Location = New System.Drawing.Point(6, 19)
        Me.rabDelivery.Name = "rabDelivery"
        Me.rabDelivery.Size = New System.Drawing.Size(63, 17)
        Me.rabDelivery.TabIndex = 0
        Me.rabDelivery.TabStop = True
        Me.rabDelivery.Text = "Delivery"
        Me.rabDelivery.UseVisualStyleBackColor = True
        '
        'grbPaymentMethod
        '
        Me.grbPaymentMethod.BackColor = System.Drawing.Color.Gray
        Me.grbPaymentMethod.Controls.Add(Me.rabDebit)
        Me.grbPaymentMethod.Controls.Add(Me.rabCredit)
        Me.grbPaymentMethod.Controls.Add(Me.rabCash)
        Me.grbPaymentMethod.ForeColor = System.Drawing.Color.White
        Me.grbPaymentMethod.Location = New System.Drawing.Point(170, 219)
        Me.grbPaymentMethod.Name = "grbPaymentMethod"
        Me.grbPaymentMethod.Size = New System.Drawing.Size(103, 92)
        Me.grbPaymentMethod.TabIndex = 5
        Me.grbPaymentMethod.TabStop = False
        Me.grbPaymentMethod.Text = "PaymentMethod"
        '
        'rabDebit
        '
        Me.rabDebit.AutoSize = True
        Me.rabDebit.Location = New System.Drawing.Point(6, 65)
        Me.rabDebit.Name = "rabDebit"
        Me.rabDebit.Size = New System.Drawing.Size(75, 17)
        Me.rabDebit.TabIndex = 2
        Me.rabDebit.TabStop = True
        Me.rabDebit.Text = "Debit Card"
        Me.rabDebit.UseVisualStyleBackColor = True
        '
        'rabCredit
        '
        Me.rabCredit.AutoSize = True
        Me.rabCredit.Location = New System.Drawing.Point(6, 42)
        Me.rabCredit.Name = "rabCredit"
        Me.rabCredit.Size = New System.Drawing.Size(77, 17)
        Me.rabCredit.TabIndex = 1
        Me.rabCredit.TabStop = True
        Me.rabCredit.Text = "Credit Card"
        Me.rabCredit.UseVisualStyleBackColor = True
        '
        'rabCash
        '
        Me.rabCash.AutoSize = True
        Me.rabCash.Location = New System.Drawing.Point(6, 19)
        Me.rabCash.Name = "rabCash"
        Me.rabCash.Size = New System.Drawing.Size(49, 17)
        Me.rabCash.TabIndex = 0
        Me.rabCash.TabStop = True
        Me.rabCash.Text = "Cash"
        Me.rabCash.UseVisualStyleBackColor = True
        '
        'txtCouponCode
        '
        Me.txtCouponCode.Location = New System.Drawing.Point(294, 238)
        Me.txtCouponCode.Name = "txtCouponCode"
        Me.txtCouponCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCouponCode.TabIndex = 10
        '
        'lblCouponInfo
        '
        Me.lblCouponInfo.Location = New System.Drawing.Point(294, 219)
        Me.lblCouponInfo.Name = "lblCouponInfo"
        Me.lblCouponInfo.Size = New System.Drawing.Size(100, 16)
        Me.lblCouponInfo.TabIndex = 11
        Me.lblCouponInfo.Text = "COUPON CODE"
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnTotal.Location = New System.Drawing.Point(294, 268)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(94, 59)
        Me.btnTotal.TabIndex = 12
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'btnBackPage
        '
        Me.btnBackPage.Location = New System.Drawing.Point(12, 12)
        Me.btnBackPage.Name = "btnBackPage"
        Me.btnBackPage.Size = New System.Drawing.Size(75, 23)
        Me.btnBackPage.TabIndex = 13
        Me.btnBackPage.Text = "Go back"
        Me.btnBackPage.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Peru
        Me.btnClear.Location = New System.Drawing.Point(422, 41)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Peru
        Me.btnExit.Location = New System.Drawing.Point(422, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtConfirm
        '
        Me.txtConfirm.Location = New System.Drawing.Point(397, 268)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.ReadOnly = True
        Me.txtConfirm.Size = New System.Drawing.Size(100, 20)
        Me.txtConfirm.TabIndex = 16
        Me.txtConfirm.Text = "Confirm"
        '
        'btnProceedCheckout
        '
        Me.btnProceedCheckout.BackColor = System.Drawing.Color.Chocolate
        Me.btnProceedCheckout.Location = New System.Drawing.Point(410, 294)
        Me.btnProceedCheckout.Name = "btnProceedCheckout"
        Me.btnProceedCheckout.Size = New System.Drawing.Size(75, 23)
        Me.btnProceedCheckout.TabIndex = 17
        Me.btnProceedCheckout.Text = "Checkout"
        Me.btnProceedCheckout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(114, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 32)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Little Caesers Menu"
        '
        'btnSaveReceipt
        '
        Me.btnSaveReceipt.BackColor = System.Drawing.Color.SandyBrown
        Me.btnSaveReceipt.Location = New System.Drawing.Point(503, 238)
        Me.btnSaveReceipt.Name = "btnSaveReceipt"
        Me.btnSaveReceipt.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveReceipt.TabIndex = 20
        Me.btnSaveReceipt.Text = "Save"
        Me.btnSaveReceipt.UseVisualStyleBackColor = False
        '
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.BackColor = System.Drawing.Color.SandyBrown
        Me.btnPrintReceipt.Location = New System.Drawing.Point(584, 238)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintReceipt.TabIndex = 21
        Me.btnPrintReceipt.Text = "Print"
        Me.btnPrintReceipt.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'txtReceipt
        '
        Me.txtReceipt.AcceptsTab = True
        Me.txtReceipt.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.txtReceipt.Location = New System.Drawing.Point(504, 70)
        Me.txtReceipt.Multiline = True
        Me.txtReceipt.Name = "txtReceipt"
        Me.txtReceipt.ReadOnly = True
        Me.txtReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReceipt.Size = New System.Drawing.Size(232, 162)
        Me.txtReceipt.TabIndex = 23
        Me.txtReceipt.WordWrap = False
        '
        'frmCustomize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(748, 346)
        Me.Controls.Add(Me.txtReceipt)
        Me.Controls.Add(Me.btnPrintReceipt)
        Me.Controls.Add(Me.btnSaveReceipt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnProceedCheckout)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBackPage)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.lblCouponInfo)
        Me.Controls.Add(Me.txtCouponCode)
        Me.Controls.Add(Me.grbPaymentMethod)
        Me.Controls.Add(Me.grbOrderType)
        Me.Controls.Add(Me.grbSideItems)
        Me.Controls.Add(Me.grbToppings)
        Me.Controls.Add(Me.grbSize)
        Me.Name = "frmCustomize"
        Me.Text = "Customize your order"
        Me.grbSize.ResumeLayout(False)
        Me.grbSize.PerformLayout()
        Me.grbToppings.ResumeLayout(False)
        Me.grbToppings.PerformLayout()
        Me.grbSideItems.ResumeLayout(False)
        Me.grbSideItems.PerformLayout()
        Me.grbOrderType.ResumeLayout(False)
        Me.grbOrderType.PerformLayout()
        Me.grbPaymentMethod.ResumeLayout(False)
        Me.grbPaymentMethod.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbSize As System.Windows.Forms.GroupBox
    Friend WithEvents rabXLarge As System.Windows.Forms.RadioButton
    Friend WithEvents rabLarge As System.Windows.Forms.RadioButton
    Friend WithEvents rabMedium As System.Windows.Forms.RadioButton
    Friend WithEvents rabSmall As System.Windows.Forms.RadioButton
    Friend WithEvents grbToppings As System.Windows.Forms.GroupBox
    Friend WithEvents chkTomatoe As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnion As System.Windows.Forms.CheckBox
    Friend WithEvents chkBacon As System.Windows.Forms.CheckBox
    Friend WithEvents chkSausage As System.Windows.Forms.CheckBox
    Friend WithEvents chkChicken As System.Windows.Forms.CheckBox
    Friend WithEvents chkMushrooms As System.Windows.Forms.CheckBox
    Friend WithEvents chkPepperoni As System.Windows.Forms.CheckBox
    Friend WithEvents chkHam As System.Windows.Forms.CheckBox
    Friend WithEvents grbSideItems As System.Windows.Forms.GroupBox
    Friend WithEvents chkGarlicBread As System.Windows.Forms.CheckBox
    Friend WithEvents chkWings As System.Windows.Forms.CheckBox
    Friend WithEvents chkFries As System.Windows.Forms.CheckBox
    Friend WithEvents chkSoda As System.Windows.Forms.CheckBox
    Friend WithEvents grbOrderType As System.Windows.Forms.GroupBox
    Friend WithEvents rabPickUp As System.Windows.Forms.RadioButton
    Friend WithEvents rabDelivery As System.Windows.Forms.RadioButton
    Friend WithEvents grbPaymentMethod As System.Windows.Forms.GroupBox
    Friend WithEvents rabDebit As System.Windows.Forms.RadioButton
    Friend WithEvents rabCredit As System.Windows.Forms.RadioButton
    Friend WithEvents rabCash As System.Windows.Forms.RadioButton
    Friend WithEvents txtCouponCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCouponInfo As System.Windows.Forms.Label
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents btnBackPage As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents btnProceedCheckout As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSaveReceipt As System.Windows.Forms.Button
    Friend WithEvents btnPrintReceipt As System.Windows.Forms.Button
    Friend WithEvents PrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents txtReceipt As System.Windows.Forms.TextBox
End Class
